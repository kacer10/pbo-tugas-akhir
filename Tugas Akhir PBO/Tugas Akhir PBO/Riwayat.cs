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
    public partial class Riwayat : Form
    {
        private int selectedIdJadwal = -1;

        public Riwayat()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Laporan laporan = new Laporan();
            laporan.Show();

            Hide();
        }

        private void LoadDataJadwal()
        {
            string query = @"
                SELECT 
                    po.id_jadwal,
                    p.nama_pasien,
                    o.nama_obat,
                    po.waktu_pemberian,
                    po.status
                FROM 
                    Penjadwalan_Obat po
                JOIN 
                    Pasien p ON po.id_pasien = p.id_pasien
                JOIN 
                    Obat o ON po.id_obat = o.id_obat
                ";
            DataTable dt = Tugas_Akhir_PBO.Database.Database.queryExecutor(query);
            dataGridView1.DataSource = dt;

        }
        private void Riwayat_Load(object sender, EventArgs e)
        {
            LoadDataJadwal();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                if (selectedRow.Cells["id_jadwal"].Value != DBNull.Value)
                {
                    selectedIdJadwal = Convert.ToInt32(selectedRow.Cells["id_jadwal"].Value);
                }
            }
        }


        private void refrsh_Click(object sender, EventArgs e)
        {
            if (selectedIdJadwal == -1)
            {
                MessageBox.Show("Silakan pilih salah satu jadwal terlebih dahulu dari tabel.");
                return;
            }

            Dashboard konfirmasi = new Dashboard(selectedIdJadwal);
            konfirmasi.ShowDialog();

            // Refresh tabel jika ada perubahan setelah kembali
            LoadDataJadwal();
        }
    }
}
