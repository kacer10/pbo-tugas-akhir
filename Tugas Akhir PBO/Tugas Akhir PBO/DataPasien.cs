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
    public partial class DataPasien : Form
    {
        public DataPasien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data Pasien Berhasil Disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void Kembali5_Click(object sender, EventArgs e)
        {
            Laporan laporan = new Laporan();
            laporan.Show();

            this.Hide();
        }

        private void Done2_Click(object sender, EventArgs e)
        {
            string namaPasien = nama_pasien.Text.Trim();
            string tanggalLahir = tanggal_lahir.Text.Trim();
            string jenisKelamin = jenis_kelamin.SelectedItem?.ToString();
            string alamatPasien = alamat.Text.Trim();
            string noTelepon = telepon.Text.Trim();

            // Konversi nomor ruang ke integer
            int ruangRawat;
            bool isRuangValid = int.TryParse(nomor_ruang.Text.Trim(), out ruangRawat);

            // Validasi
            if (string.IsNullOrWhiteSpace(namaPasien) || string.IsNullOrWhiteSpace(tanggalLahir) ||
                string.IsNullOrWhiteSpace(jenisKelamin) || !isRuangValid)
            {
                MessageBox.Show("Mohon isi data dengan benar dan lengkap.");
                return;
            }

            try
            {
                string query = @"INSERT INTO Pasien (nama_pasien, tanggal_lahir, jenis_kelamin, alamat, nomor_ruang, no_telepon)
                         VALUES (@nama, @tgl, @jk, @alamat, @ruang, @telepon)";

                var parameters = new Npgsql.NpgsqlParameter[]
                {
                    new Npgsql.NpgsqlParameter("@nama", namaPasien),
                    new Npgsql.NpgsqlParameter("@tgl", tanggalLahir),
                    new Npgsql.NpgsqlParameter("@jk", jenisKelamin),
                    new Npgsql.NpgsqlParameter("@alamat", alamatPasien),
                    new Npgsql.NpgsqlParameter("@ruang", ruangRawat),
                    new Npgsql.NpgsqlParameter("@telepon", noTelepon),
                };

                Tugas_Akhir_PBO.Database.Database.queryExecutor(query, parameters);

                MessageBox.Show("Data pasien berhasil ditambahkan.");

                // Buka form laporan dan tutup form saat ini
                Laporan laporan = new Laporan();
                laporan.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

    }
}
