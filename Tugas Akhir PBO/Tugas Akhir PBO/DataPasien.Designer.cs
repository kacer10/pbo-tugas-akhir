namespace Tugas_Akhir_PBO
{
    partial class DataPasien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataPasien));
            nama = new Label();
            nohp = new Label();
            identitas = new Label();
            umurnya = new Label();
            kamar = new Label();
            label6 = new Label();
            tanggal_lahir = new TextBox();
            jenis_kelamin = new ComboBox();
            jenis_kelamin.Items.AddRange(new object[] { "L", "P" });
            jenis_kelamin.DropDownStyle = ComboBoxStyle.DropDownList;
            alamat = new TextBox();
            nama_pasien = new TextBox();
            data = new Label();
            pictureBox1 = new PictureBox();
            Done2 = new Button();
            Kembali5 = new Button();
            pasienID = new Label();
            nomor_ruang = new TextBox();
            label_telepon = new Label();
            telepon = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // nama
            // 
            nama.AutoSize = true;
            nama.Location = new Point(37, 134);
            nama.Margin = new Padding(2, 0, 2, 0);
            nama.Name = "nama";
            nama.Size = new Size(94, 20);
            nama.TabIndex = 0;
            nama.Text = "Nama Pasien";
            // 
            // nohp
            // 
            nohp.AutoSize = true;
            nohp.Location = new Point(37, 196);
            nohp.Margin = new Padding(2, 0, 2, 0);
            nohp.Name = "nohp";
            nohp.Size = new Size(98, 20);
            nohp.TabIndex = 1;
            nohp.Text = "Jenis Kelamin";
            // 
            // identitas
            // 
            identitas.AutoSize = true;
            identitas.Location = new Point(38, 227);
            identitas.Margin = new Padding(2, 0, 2, 0);
            identitas.Name = "identitas";
            identitas.Size = new Size(57, 20);
            identitas.TabIndex = 2;
            identitas.Text = "Alamat";
            // 
            // umurnya
            // 
            umurnya.AutoSize = true;
            umurnya.Location = new Point(38, 165);
            umurnya.Margin = new Padding(2, 0, 2, 0);
            umurnya.Name = "umurnya";
            umurnya.Size = new Size(97, 20);
            umurnya.TabIndex = 3;
            umurnya.Text = "Tanggal Lahir";
            // 
            // kamar
            // 
            kamar.AutoSize = true;
            kamar.Location = new Point(37, 251);
            kamar.Margin = new Padding(2, 0, 2, 0);
            kamar.Name = "kamar";
            kamar.Size = new Size(0, 20);
            kamar.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(471, 340);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 5;
            // 
            // tanggal_lahir
            // 
            tanggal_lahir.Location = new Point(154, 162);
            tanggal_lahir.Margin = new Padding(2);
            tanggal_lahir.Name = "tanggal_lahir";
            tanggal_lahir.Size = new Size(254, 27);
            tanggal_lahir.TabIndex = 6;
            // 
            // jenis_kelamin
            // 
            jenis_kelamin.Location = new Point(154, 193);
            jenis_kelamin.Margin = new Padding(2);
            jenis_kelamin.Name = "jenis_kelamin";
            jenis_kelamin.Size = new Size(254, 27);
            jenis_kelamin.TabIndex = 7;
            // 
            // alamat
            // 
            alamat.Location = new Point(154, 224);
            alamat.Margin = new Padding(2);
            alamat.Name = "alamat";
            alamat.Size = new Size(254, 27);
            alamat.TabIndex = 10;
            // 
            // nama_pasien
            // 
            nama_pasien.Location = new Point(154, 131);
            nama_pasien.Margin = new Padding(2);
            nama_pasien.Name = "nama_pasien";
            nama_pasien.Size = new Size(254, 27);
            nama_pasien.TabIndex = 11;
            // 
            // data
            // 
            data.AutoSize = true;
            data.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            data.ForeColor = Color.FromArgb(0, 64, 64);
            data.Location = new Point(100, 58);
            data.Margin = new Padding(2, 0, 2, 0);
            data.Name = "data";
            data.Size = new Size(179, 38);
            data.TabIndex = 12;
            data.Text = "Data Pasien";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(452, 58);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 272);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Done2
            // 
            Done2.Location = new Point(561, 354);
            Done2.Margin = new Padding(2);
            Done2.Name = "Done2";
            Done2.Size = new Size(108, 34);
            Done2.TabIndex = 14;
            Done2.Text = "Done";
            Done2.UseVisualStyleBackColor = true;
            Done2.Click += Done2_Click;
            // 
            // Kembali5
            // 
            Kembali5.Location = new Point(438, 354);
            Kembali5.Margin = new Padding(2);
            Kembali5.Name = "Kembali5";
            Kembali5.Size = new Size(108, 34);
            Kembali5.TabIndex = 15;
            Kembali5.Text = "Back";
            Kembali5.UseVisualStyleBackColor = true;
            Kembali5.Click += Kembali5_Click;
            // 
            // pasienID
            // 
            pasienID.AutoSize = true;
            pasienID.Location = new Point(37, 258);
            pasienID.Margin = new Padding(2, 0, 2, 0);
            pasienID.Name = "pasienID";
            pasienID.Size = new Size(102, 20);
            pasienID.TabIndex = 16;
            pasienID.Text = "Nomor Ruang";
            pasienID.Click += label1_Click;
            // 
            // nomor_ruang
            // 
            nomor_ruang.Location = new Point(154, 255);
            nomor_ruang.Margin = new Padding(2);
            nomor_ruang.Name = "nomor_ruang";
            nomor_ruang.Size = new Size(254, 27);
            nomor_ruang.TabIndex = 17;
            // 
            // label_telepon
            // 
            label_telepon.AutoSize = true;
            label_telepon.Location = new Point(37, 288);
            label_telepon.Margin = new Padding(2, 0, 2, 0);
            label_telepon.Name = "label_telepon";
            label_telepon.Size = new Size(62, 20);
            label_telepon.TabIndex = 18;
            label_telepon.Text = "Telepon";
            // 
            // telepon
            // 
            telepon.Location = new Point(154, 286);
            telepon.Margin = new Padding(2);
            telepon.Name = "telepon";
            telepon.Size = new Size(254, 27);
            telepon.TabIndex = 19;
            // 
            // DataPasien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(717, 425);
            Controls.Add(telepon);
            Controls.Add(label_telepon);
            Controls.Add(nomor_ruang);
            Controls.Add(pasienID);
            Controls.Add(Kembali5);
            Controls.Add(Done2);
            Controls.Add(pictureBox1);
            Controls.Add(data);
            Controls.Add(nama_pasien);
            Controls.Add(alamat);
            Controls.Add(jenis_kelamin);
            Controls.Add(tanggal_lahir);
            Controls.Add(label6);
            Controls.Add(kamar);
            Controls.Add(umurnya);
            Controls.Add(identitas);
            Controls.Add(nohp);
            Controls.Add(nama);
            Margin = new Padding(2);
            Name = "DataPasien";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nama;
        private Label nohp;
        private Label identitas;
        private Label umurnya;
        private Label kamar;
        private Label label6;
        private TextBox tanggal_lahir;
        private ComboBox jenis_kelamin;
        private TextBox alamat;
        private TextBox nama_pasien;
        private Label data;
        private PictureBox pictureBox1;
        private Button Done2;
        private Button Kembali5;
        private Label pasienID;
        private TextBox nomor_ruang;
        private Label label_telepon;
        private TextBox telepon;
    }
}