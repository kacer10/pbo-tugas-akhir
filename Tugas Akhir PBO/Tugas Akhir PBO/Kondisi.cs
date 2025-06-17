using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Akhir_PBO.Database;

namespace Tugas_Akhir_PBO
{
    public partial class Kondisi : Form
    {
        public Kondisi()
        {
            InitializeComponent();
            this.Load += Kondisi_Load;
        }

        private void Kembali3_Click(object sender, EventArgs e)
        {
            Laporan laporan = new Laporan();
            laporan.Show();

            this.Hide();
        }

        private void sudah_Click(object sender, EventArgs e)
        {
            try
            {
                string namaPasien = nama_pasien.Text.Trim();
                int suhuTubuh = int.Parse(suhu_tubuh.Text.Trim());
                int tekananDarah = int.Parse(tekanan_darah.Text.Trim());
                int noKamar = int.Parse(no_kamar.Text.Trim());
                int detakJantung = int.Parse(detak_jantung.Text.Trim());

                if (string.IsNullOrEmpty(namaPasien))
                {
                    MessageBox.Show("Nama pasien tidak boleh kosong.");
                    return;
                }

                // Ambil ID pasien berdasarkan nama
                string getIdQuery = "SELECT id_pasien FROM pasien WHERE nama_pasien = @nama";
                NpgsqlParameter[] paramNama = { new NpgsqlParameter("@nama", namaPasien) };
                DataTable idTable = Tugas_Akhir_PBO.Database.Database.queryExecutor(getIdQuery, paramNama);

                if (idTable.Rows.Count == 0)
                {
                    MessageBox.Show("Pasien tidak ditemukan.");
                    return;
                }

                int idPasien = Convert.ToInt32(idTable.Rows[0]["id_pasien"]);

                // Simpan ke tabel kondisi
                string insertQuery = "INSERT INTO kondisi (id_pasien, suhu_tubuh, tekanan_darah, nomor_kamar, detak_jantung) " +
                                     "VALUES (@id, @suhu, @tekanan, @kamar, @jantung)";

                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@id", idPasien),
                    new NpgsqlParameter("@suhu", suhuTubuh),
                    new NpgsqlParameter("@tekanan", tekananDarah),
                    new NpgsqlParameter("@kamar", noKamar),
                    new NpgsqlParameter("@jantung", detakJantung)
                };

                DataTable result = Tugas_Akhir_PBO.Database.Database.queryExecutor(insertQuery, parameters);
                MessageBox.Show("Data berhasil disimpan.");

                Laporan laporan = new Laporan();
                laporan.Show();
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Pastikan semua nilai numerik (suhu, tekanan, kamar, detak) diisi dengan angka yang valid.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }


        private void Kondisi_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT nama_pasien FROM pasien";
                DataTable dt = Tugas_Akhir_PBO.Database.Database.queryExecutor(query, null);
                foreach (DataRow row in dt.Rows)
                {
                    nama_pasien.Items.Add(row["nama_pasien"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat nama pasien: " + ex.Message);
            }
        }
    }
}
