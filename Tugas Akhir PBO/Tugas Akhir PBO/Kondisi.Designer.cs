namespace Tugas_Akhir_PBO
{
    partial class Kondisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kondisi));
            suhu_tubuh = new TextBox();
            suhu = new Label();
            Jantung = new Label();
            detak_jantung = new TextBox();
            Darah = new Label();
            tekanan_darah = new TextBox();
            NamePasien = new Label();
            nama_pasien = new ComboBox();
            noKamar = new Label();
            no_kamar = new TextBox();
            kondisiKesehatan = new Label();
            pictureBox1 = new PictureBox();
            sudah = new Button();
            Kembali3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // suhu_tubuh
            // 
            suhu_tubuh.Location = new Point(135, 159);
            suhu_tubuh.Margin = new Padding(2);
            suhu_tubuh.Name = "suhu_tubuh";
            suhu_tubuh.Size = new Size(152, 27);
            suhu_tubuh.TabIndex = 0;
            // 
            // suhu
            // 
            suhu.AutoSize = true;
            suhu.Location = new Point(47, 162);
            suhu.Margin = new Padding(2, 0, 2, 0);
            suhu.Name = "suhu";
            suhu.Size = new Size(83, 20);
            suhu.TabIndex = 1;
            suhu.Text = "Suhu tubuh";
            // 
            // Jantung
            // 
            Jantung.AutoSize = true;
            Jantung.Location = new Point(327, 159);
            Jantung.Margin = new Padding(2, 0, 2, 0);
            Jantung.Name = "Jantung";
            Jantung.Size = new Size(103, 20);
            Jantung.TabIndex = 2;
            Jantung.Text = "Detak Jantung";
            // 
            // detak_jantung
            // 
            detak_jantung.Location = new Point(432, 159);
            detak_jantung.Margin = new Padding(2);
            detak_jantung.Name = "detak_jantung";
            detak_jantung.Size = new Size(135, 27);
            detak_jantung.TabIndex = 3;
            // 
            // Darah
            // 
            Darah.AutoSize = true;
            Darah.Location = new Point(47, 206);
            Darah.Margin = new Padding(2, 0, 2, 0);
            Darah.Name = "Darah";
            Darah.Size = new Size(107, 20);
            Darah.TabIndex = 4;
            Darah.Text = "Tekanan Darah";
            // 
            // tekanan_darah
            // 
            tekanan_darah.Location = new Point(152, 201);
            tekanan_darah.Margin = new Padding(2);
            tekanan_darah.Name = "tekanan_darah";
            tekanan_darah.Size = new Size(135, 27);
            tekanan_darah.TabIndex = 5;
            // 
            // NamePasien
            // 
            NamePasien.AutoSize = true;
            NamePasien.Location = new Point(47, 122);
            NamePasien.Margin = new Padding(2, 0, 2, 0);
            NamePasien.Name = "NamePasien";
            NamePasien.Size = new Size(94, 20);
            NamePasien.TabIndex = 6;
            NamePasien.Text = "Nama Pasien";
            // 
            // nama_pasien
            // 
            nama_pasien.Location = new Point(142, 120);
            nama_pasien.Margin = new Padding(2);
            nama_pasien.Name = "nama_pasien";
            nama_pasien.Size = new Size(145, 28);
            nama_pasien.TabIndex = 7;
            // 
            // noKamar
            // 
            noKamar.AutoSize = true;
            noKamar.Location = new Point(327, 122);
            noKamar.Margin = new Padding(2, 0, 2, 0);
            noKamar.Name = "noKamar";
            noKamar.Size = new Size(79, 20);
            noKamar.TabIndex = 8;
            noKamar.Text = "No. Kamar";
            // 
            // no_kamar
            // 
            no_kamar.Location = new Point(408, 120);
            no_kamar.Margin = new Padding(2);
            no_kamar.Name = "no_kamar";
            no_kamar.Size = new Size(159, 27);
            no_kamar.TabIndex = 9;
            // 
            // kondisiKesehatan
            // 
            kondisiKesehatan.AutoSize = true;
            kondisiKesehatan.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kondisiKesehatan.ForeColor = SystemColors.HotTrack;
            kondisiKesehatan.Location = new Point(178, 46);
            kondisiKesehatan.Margin = new Padding(2, 0, 2, 0);
            kondisiKesehatan.Name = "kondisiKesehatan";
            kondisiKesehatan.Size = new Size(274, 38);
            kondisiKesehatan.TabIndex = 10;
            kondisiKesehatan.Text = "Kondisi Kesehatan";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // sudah
            // 
            sudah.Location = new Point(550, 332);
            sudah.Margin = new Padding(2);
            sudah.Name = "sudah";
            sudah.Size = new Size(90, 27);
            sudah.TabIndex = 17;
            sudah.Text = "Done";
            sudah.UseVisualStyleBackColor = true;
            sudah.Click += sudah_Click;
            // 
            // Kembali3
            // 
            Kembali3.Location = new Point(455, 332);
            Kembali3.Margin = new Padding(2);
            Kembali3.Name = "Kembali3";
            Kembali3.Size = new Size(90, 27);
            Kembali3.TabIndex = 18;
            Kembali3.Text = "Back";
            Kembali3.UseVisualStyleBackColor = true;
            Kembali3.Click += Kembali3_Click;
            // 
            // Kondisi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(640, 360);
            Controls.Add(Kembali3);
            Controls.Add(sudah);
            Controls.Add(pictureBox1);
            Controls.Add(kondisiKesehatan);
            Controls.Add(no_kamar);
            Controls.Add(noKamar);
            Controls.Add(nama_pasien);
            Controls.Add(NamePasien);
            Controls.Add(tekanan_darah);
            Controls.Add(Darah);
            Controls.Add(detak_jantung);
            Controls.Add(Jantung);
            Controls.Add(suhu);
            Controls.Add(suhu_tubuh);
            Margin = new Padding(2);
            Name = "Kondisi";
            Load += Kondisi_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox suhu_tubuh;
        private Label suhu;
        private Label Jantung;
        private TextBox detak_jantung;
        private Label Darah;
        private TextBox tekanan_darah;
        private Label NamePasien;
        private ComboBox nama_pasien;
        private Label noKamar;
        private TextBox no_kamar;
        private Label kondisiKesehatan;
        private PictureBox pictureBox1;
        private Button sudah;
        private Button Kembali3;
    }
}