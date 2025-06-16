namespace Tugas_Akhir_PBO
{
    partial class Penjadwalan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Penjadwalan));
            Done = new Button();
            Kembali = new Button();
            dateTimePicker2 = new DateTimePicker();
            comboBoxPasien = new ComboBox();
            ObatIsi = new TextBox();
            DosisIsi = new TextBox();
            nama_pasien = new Label();
            isiObat = new Label();
            isiDosis = new Label();
            isiDiagnosis = new Label();
            CatatanIsi = new TextBox();
            jadwalinput = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            jenis_obat = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Done
            // 
            Done.Location = new Point(541, 323);
            Done.Margin = new Padding(2);
            Done.Name = "Done";
            Done.Size = new Size(90, 27);
            Done.TabIndex = 0;
            Done.Text = "Done";
            Done.UseVisualStyleBackColor = true;
            Done.Click += Done_Click;
            // 
            // Kembali
            // 
            Kembali.Location = new Point(446, 323);
            Kembali.Margin = new Padding(2);
            Kembali.Name = "Kembali";
            Kembali.Size = new Size(90, 27);
            Kembali.TabIndex = 1;
            Kembali.Text = "Back";
            Kembali.UseVisualStyleBackColor = true;
            Kembali.Click += Kembali_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(203, 82);
            dateTimePicker2.Margin = new Padding(2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(241, 27);
            dateTimePicker2.TabIndex = 2;
            dateTimePicker2.Value = new DateTime(2025, 6, 13, 19, 4, 29, 0);
            // 
            // comboBoxPasien
            // 
            comboBoxPasien.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPasien.Location = new Point(241, 127);
            comboBoxPasien.Margin = new Padding(2);
            comboBoxPasien.Name = "comboBoxPasien";
            comboBoxPasien.Size = new Size(252, 28);
            comboBoxPasien.TabIndex = 4;
            // 
            // ObatIsi
            // 
            ObatIsi.Location = new Point(190, 168);
            ObatIsi.Margin = new Padding(2);
            ObatIsi.Name = "ObatIsi";
            ObatIsi.Size = new Size(304, 27);
            ObatIsi.TabIndex = 5;
            // 
            // DosisIsi
            // 
            DosisIsi.Location = new Point(190, 205);
            DosisIsi.Margin = new Padding(2);
            DosisIsi.Name = "DosisIsi";
            DosisIsi.Size = new Size(304, 27);
            DosisIsi.TabIndex = 6;
            // 
            // nama_pasien
            // 
            nama_pasien.AutoSize = true;
            nama_pasien.Location = new Point(143, 130);
            nama_pasien.Margin = new Padding(2, 0, 2, 0);
            nama_pasien.Name = "nama_pasien";
            nama_pasien.Size = new Size(94, 20);
            nama_pasien.TabIndex = 8;
            nama_pasien.Text = "Nama Pasien";
            // 
            // isiObat
            // 
            isiObat.AutoSize = true;
            isiObat.Location = new Point(143, 170);
            isiObat.Margin = new Padding(2, 0, 2, 0);
            isiObat.Name = "isiObat";
            isiObat.Size = new Size(42, 20);
            isiObat.TabIndex = 9;
            isiObat.Text = "Obat";
            // 
            // isiDosis
            // 
            isiDosis.AutoSize = true;
            isiDosis.Location = new Point(143, 207);
            isiDosis.Margin = new Padding(2, 0, 2, 0);
            isiDosis.Name = "isiDosis";
            isiDosis.Size = new Size(45, 20);
            isiDosis.TabIndex = 10;
            isiDosis.Text = "Dosis";
            // 
            // isiDiagnosis
            // 
            isiDiagnosis.AutoSize = true;
            isiDiagnosis.Location = new Point(143, 244);
            isiDiagnosis.Margin = new Padding(2, 0, 2, 0);
            isiDiagnosis.Name = "isiDiagnosis";
            isiDiagnosis.Size = new Size(60, 20);
            isiDiagnosis.TabIndex = 11;
            isiDiagnosis.Text = "Catatan";
            // 
            // CatatanIsi
            // 
            CatatanIsi.Location = new Point(207, 242);
            CatatanIsi.Margin = new Padding(2);
            CatatanIsi.Name = "CatatanIsi";
            CatatanIsi.Size = new Size(286, 27);
            CatatanIsi.TabIndex = 12;
            // 
            // jadwalinput
            // 
            jadwalinput.AutoSize = true;
            jadwalinput.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            jadwalinput.ForeColor = SystemColors.HotTrack;
            jadwalinput.Location = new Point(126, 24);
            jadwalinput.Margin = new Padding(2, 0, 2, 0);
            jadwalinput.Name = "jadwalinput";
            jadwalinput.Size = new Size(413, 38);
            jadwalinput.TabIndex = 13;
            jadwalinput.Text = "Penjadwalan Konsumsi Obat";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 278);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 16;
            label1.Text = "Jenis";
            // 
            // jenis_obat
            // 
            jenis_obat.Location = new Point(190, 275);
            jenis_obat.Margin = new Padding(2);
            jenis_obat.Name = "jenis_obat";
            jenis_obat.Size = new Size(304, 27);
            jenis_obat.TabIndex = 15;
            // 
            // Penjadwalan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(640, 360);
            Controls.Add(label1);
            Controls.Add(jenis_obat);
            Controls.Add(pictureBox1);
            Controls.Add(jadwalinput);
            Controls.Add(CatatanIsi);
            Controls.Add(isiDiagnosis);
            Controls.Add(isiDosis);
            Controls.Add(isiObat);
            Controls.Add(nama_pasien);
            Controls.Add(DosisIsi);
            Controls.Add(ObatIsi);
            Controls.Add(comboBoxPasien);
            Controls.Add(dateTimePicker2);
            Controls.Add(Kembali);
            Controls.Add(Done);
            Margin = new Padding(2);
            Name = "Penjadwalan";
            Text = "Jadwal Konsumsi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Done;
        private Button Kembali;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBoxPasien;
        private TextBox ObatIsi;
        private TextBox DosisIsi;
        private Label nama_pasien;
        private Label isiObat;
        private Label isiDosis;
        private Label isiDiagnosis;
        private TextBox CatatanIsi;
        private Label jadwalinput;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox jenis_obat;
    }
}