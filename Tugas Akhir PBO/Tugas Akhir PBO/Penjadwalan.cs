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

namespace Tugas_Akhir_PBO
{
    public partial class Penjadwalan : Form
    {
        public Penjadwalan()
        {
            InitializeComponent();
            LoadNamaPasien();
        }
        private void LoadNamaPasien()
        {
            string query = "SELECT nama_pasien FROM Pasien";
            DataTable dt = Tugas_Akhir_PBO.Database.Database.queryExecutor(query);

            foreach (DataRow row in dt.Rows)
            {
                comboBoxPasien.Items.Add(row["nama_pasien"].ToString());
            }
        }

        private void Kembali_Click(object sender, EventArgs e)
        {
            Laporan laporan = new Laporan();
            laporan.Show();
            this.Hide();


        }
        private void Done_Click(object sender, EventArgs e)
        {
            string namaPasien = comboBoxPasien.SelectedItem?.ToString();
            string obat = ObatIsi.Text;
            string dosis = DosisIsi.Text;
            string catatan = CatatanIsi.Text;
            string waktu = dateTimePicker2.Value.ToString("HH:mm");
            string jenis = jenis_obat.Text;

            if (string.IsNullOrEmpty(namaPasien) || string.IsNullOrEmpty(obat) || string.IsNullOrEmpty(dosis) || string.IsNullOrEmpty(catatan) || string.IsNullOrEmpty(jenis))
            {
                MessageBox.Show("Mohon lengkapi semua data.");
                return;
            }

            // Ambil id_pasien
            string queryPasien = "SELECT id_pasien FROM Pasien WHERE nama_pasien = @nama";
            var paramPasien = new Npgsql.NpgsqlParameter[]
            {
                new Npgsql.NpgsqlParameter("@nama", namaPasien)
            };
            DataTable dtPasien = Database.Database.queryExecutor(queryPasien, paramPasien);

            if (dtPasien.Rows.Count == 0)
            {
                MessageBox.Show("Pasien tidak ditemukan.");
                return;
            }

            int idPasien = Convert.ToInt32(dtPasien.Rows[0]["id_pasien"]);

            // Cek apakah obat sudah ada
            string queryObat = "SELECT id_obat FROM Obat WHERE nama_obat = @nama";
            var paramObat = new Npgsql.NpgsqlParameter[]
            {
                new Npgsql.NpgsqlParameter("@nama", obat)
            };
            DataTable dtObat = Database.Database.queryExecutor(queryObat, paramObat);

            int idObat;

            if (dtObat.Rows.Count > 0)
            {
                idObat = Convert.ToInt32(dtObat.Rows[0]["id_obat"]);
            }
            else
            {
                // Insert obat baru
                string insertObat = "INSERT INTO Obat (nama_obat, dosis, jenis_obat) VALUES (@nama, @dosis,@jenis) RETURNING id_obat";
                var paramInsertObat = new Npgsql.NpgsqlParameter[]
                {
                    new Npgsql.NpgsqlParameter("@nama", obat),
                    new Npgsql.NpgsqlParameter("@dosis", dosis),
                    new Npgsql.NpgsqlParameter("@jenis", jenis)

                };
                DataTable result = Database.Database.queryExecutor(insertObat, paramInsertObat);
                idObat = Convert.ToInt32(result.Rows[0]["id_obat"]);
            }

            // Insert ke Penjadwalan_Obat
            string insertJadwal = "INSERT INTO Penjadwalan_Obat (id_pasien, id_obat, waktu_pemberian, status, catatan) VALUES (@id_pasien, @id_obat, @waktu, @status, @catatan)";
            var paramJadwal = new Npgsql.NpgsqlParameter[]
            {
                new Npgsql.NpgsqlParameter("@id_pasien", idPasien),
                new Npgsql.NpgsqlParameter("@id_obat", idObat),
                new NpgsqlParameter("@waktu", dateTimePicker2.Value), // -> DateTime (otomatis cocok dengan timestamp PostgreSQL)
                new Npgsql.NpgsqlParameter("@status", "belum"),
                new Npgsql.NpgsqlParameter("@catatan", catatan)
            };


            Database.Database.commandExecutor(insertJadwal, paramJadwal);

            MessageBox.Show("Jadwal berhasil disimpan.");

            Riwayat jadwal = new Riwayat();
            jadwal.Show();
            this.Hide();
        }
    }
}
