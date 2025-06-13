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
    public partial class Laporan : Form
    {
        public Laporan()
        {
            InitializeComponent();
        }

        private void tambahPasien_Click(object sender, EventArgs e)
        {
            DataPasien dataPasien = new DataPasien();
            dataPasien.Show();

            Hide();
        }

        private void jadwal_Click(object sender, EventArgs e)
        {
            Penjadwalan penjadwalan = new Penjadwalan();
            penjadwalan.Show();

            Hide();
        }

        private void obatRiwayat_Click(object sender, EventArgs e)
        {
            Riwayat riwayat = new Riwayat();
            riwayat.Show();

            Hide();
        }


        private void keluar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Application.Exit();

                LoginForm loginForm = new LoginForm();
                loginForm.Show();

                Hide();
            }


        }

        private void KondisiPasien_Click(object sender, EventArgs e)
        {
            Kondisi kondisi = new Kondisi();
            kondisi.Show();
            Hide();


        }
        private void LoadDataKondisi()
        {
            string query = "SELECT * FROM Kondisi";
            DataTable dt = Tugas_Akhir_PBO.Database.Database.queryExecutor(query);
            dataGridView1.DataSource = dt;
        }

        private void Laporan_Load(object sender, EventArgs e)
        {
            LoadDataKondisi();
        }
    }
}
