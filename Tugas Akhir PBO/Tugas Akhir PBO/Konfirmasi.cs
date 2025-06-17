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
    public partial class Dashboard : Form
    {
        private int idJadwal;
        public Dashboard(int idJadwal)
        {
            InitializeComponent();
            this.idJadwal = idJadwal;
            LoadStatus();
        }
        private void LoadStatus()
        {
            try
            {
                string query = "SELECT status FROM Penjadwalan_Obat WHERE id_jadwal = @idJadwal";
                var parameters = new Npgsql.NpgsqlParameter[]
                {
            new Npgsql.NpgsqlParameter("@idJadwal", idJadwal)
                };

                DataTable dt = Tugas_Akhir_PBO.Database.Database.queryExecutor(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    status_box.Text = dt.Rows[0]["status"].ToString();
                }
                else
                {
                    status_box.Text = "Data tidak ditemukan";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat status: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"
                UPDATE Penjadwalan_Obat
                SET status = 'sudah',
                    waktu_minum = @waktuMinum
                WHERE id_jadwal = @idJadwal;
            ";

                var parameters = new Npgsql.NpgsqlParameter[]
                {
                new Npgsql.NpgsqlParameter("@waktuMinum", DateTime.Now),
                new Npgsql.NpgsqlParameter("@idJadwal", idJadwal)
                };

                Tugas_Akhir_PBO.Database.Database.commandExecutor(query, parameters);

                MessageBox.Show("Status berhasil dikonfirmasi!");
                this.Close(); // atau kembali ke form Riwayat
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal konfirmasi: " + ex.Message);
            }
        }

        private void kembali4_Click(object sender, EventArgs e)
        {
            Riwayat riwayat = new Riwayat();
            riwayat.Show();
            Hide();
        }
    }
}
