using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using Tugas_Akhir_PBO.Database;


namespace Tugas_Akhir_PBO
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void tombolLogin_Click_1(object sender, EventArgs e)
        {
            string password = isiPassword.Text.Trim();

            if (string.IsNullOrEmpty(isiID.Text.Trim()) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("ID dan Password tidak boleh kosong.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Konversi isiID.Text ke integer
                int id = int.Parse(isiID.Text.Trim());

                string query = "SELECT * FROM admin WHERE id_admin = @id AND password = @password";
                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
            new NpgsqlParameter("@id", id),
            new NpgsqlParameter("@password", password)
                };

                DataTable result = Tugas_Akhir_PBO.Database.Database.queryExecutor(query, parameters);

                if (result.Rows.Count > 0)
                {
                    MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Laporan laporan = new Laporan();
                    laporan.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("ID atau Password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("ID harus berupa angka.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}

