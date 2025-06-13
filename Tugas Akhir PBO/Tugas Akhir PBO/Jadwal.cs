using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Tugas_Akhir_PBO
{
    public partial class Jadwal : Form
    {
        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {
        }

        


        public void TambahData(string waktu, string obat, string namaPasien, string noKamar, string diagnosa)
        {
            dataGridView1.Rows.Add(waktu, obat, namaPasien, noKamar, diagnosa);
        }


        private void Jadwal_Load_InitialSetup(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Waktu", "Waktu");
            dataGridView1.Columns.Add("Obat", "Obat");
            dataGridView1.Columns.Add("NamaPasien", "Nama Pasien");
            dataGridView1.Columns.Add("NoKamar", "No. Kamar");
            dataGridView1.Columns.Add("Diagnosa", "Diagnosa");
        }

        private void Jadwal_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("JamKonsumsi", "Jam Konsumsi");
            dataGridView1.Columns.Add("Obat", "Obat");

            timer1.Interval = 1000;
            timer1.Start();

            

        }
        


        private void timer1_Tick(object sender, EventArgs e)
        {
            string sekarang = DateTime.Now.ToString("HH:mm");

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["JamKonsumsi"].Value != null)
                {
                    string jamKonsumsi = row.Cells["JamKonsumsi"].Value.ToString();

                    if (sekarang == jamKonsumsi)
                    {
                        MessageBox.Show("Waktunya minum obat: " + row.Cells["Obat"].Value.ToString(),
                            "Pengingat Obat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }


        }
    }

}
