namespace Tugas_Akhir_PBO
{
    partial class Laporan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laporan));
            dataGridView1 = new DataGridView();
            tambahPasien = new Button();
            obatRiwayat = new Button();
            jadwal = new Button();
            keluar = new Button();
            KondisiPasien = new Button();
            pictureBox1 = new PictureBox();
            laporanKesehatan = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-3, 67);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(758, 296);
            dataGridView1.TabIndex = 0;
            // 
            // tambahPasien
            // 
            tambahPasien.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tambahPasien.Location = new Point(-3, 35);
            tambahPasien.Margin = new Padding(2);
            tambahPasien.Name = "tambahPasien";
            tambahPasien.Size = new Size(104, 27);
            tambahPasien.TabIndex = 1;
            tambahPasien.Text = "Data Pasien";
            tambahPasien.UseVisualStyleBackColor = true;
            tambahPasien.Click += tambahPasien_Click;
            // 
            // obatRiwayat
            // 
            obatRiwayat.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            obatRiwayat.Location = new Point(105, 36);
            obatRiwayat.Margin = new Padding(2);
            obatRiwayat.Name = "obatRiwayat";
            obatRiwayat.Size = new Size(75, 27);
            obatRiwayat.TabIndex = 2;
            obatRiwayat.Text = "Riwayat";
            obatRiwayat.UseVisualStyleBackColor = true;
            obatRiwayat.Click += obatRiwayat_Click;
            // 
            // jadwal
            // 
            jadwal.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jadwal.Location = new Point(184, 35);
            jadwal.Margin = new Padding(2);
            jadwal.Name = "jadwal";
            jadwal.Size = new Size(128, 27);
            jadwal.TabIndex = 3;
            jadwal.Text = "Obat dan Jadwal";
            jadwal.UseVisualStyleBackColor = true;
            jadwal.Click += jadwal_Click;
            // 
            // keluar
            // 
            keluar.Location = new Point(688, 384);
            keluar.Margin = new Padding(2);
            keluar.Name = "keluar";
            keluar.Size = new Size(90, 27);
            keluar.TabIndex = 4;
            keluar.Text = "Keluar";
            keluar.UseVisualStyleBackColor = true;
            keluar.Click += keluar_Click;
            // 
            // KondisiPasien
            // 
            KondisiPasien.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KondisiPasien.Location = new Point(316, 35);
            KondisiPasien.Margin = new Padding(2);
            KondisiPasien.Name = "KondisiPasien";
            KondisiPasien.Size = new Size(128, 27);
            KondisiPasien.TabIndex = 5;
            KondisiPasien.Text = "Catat Kondisi";
            KondisiPasien.UseVisualStyleBackColor = true;
            KondisiPasien.Click += KondisiPasien_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(746, 11);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // laporanKesehatan
            // 
            laporanKesehatan.AutoSize = true;
            laporanKesehatan.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            laporanKesehatan.ForeColor = Color.FromArgb(0, 64, 64);
            laporanKesehatan.Location = new Point(472, 17);
            laporanKesehatan.Margin = new Padding(2, 0, 2, 0);
            laporanKesehatan.Name = "laporanKesehatan";
            laporanKesehatan.Size = new Size(256, 35);
            laporanKesehatan.TabIndex = 16;
            laporanKesehatan.Text = "Laporan Kesehatan";
            // 
            // Laporan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(789, 422);
            Controls.Add(laporanKesehatan);
            Controls.Add(pictureBox1);
            Controls.Add(KondisiPasien);
            Controls.Add(keluar);
            Controls.Add(jadwal);
            Controls.Add(obatRiwayat);
            Controls.Add(tambahPasien);
            Controls.Add(dataGridView1);
            Margin = new Padding(2);
            Name = "Laporan";
            Text = "Form1";
            Load += Laporan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button tambahPasien;
        private Button obatRiwayat;
        private Button jadwal;
        private Button keluar;
        private Button KondisiPasien;
        private PictureBox pictureBox1;
        private Label laporanKesehatan;
    }
}