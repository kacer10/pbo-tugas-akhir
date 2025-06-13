namespace Tugas_Akhir_PBO
{
    partial class Form1
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
            btnCatatKondisi = new Button();
            btnjadwalobat = new Button();
            btnpengaturan = new Button();
            groupBox1 = new GroupBox();
            btnDataPasien = new Button();
            btnKeluar = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCatatKondisi
            // 
            btnCatatKondisi.BackColor = Color.White;
            btnCatatKondisi.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCatatKondisi.ForeColor = Color.Black;
            btnCatatKondisi.Location = new Point(20, 119);
            btnCatatKondisi.Name = "btnCatatKondisi";
            btnCatatKondisi.Size = new Size(179, 30);
            btnCatatKondisi.TabIndex = 1;
            btnCatatKondisi.Text = "Catat Kondisi";
            btnCatatKondisi.TextAlign = ContentAlignment.MiddleLeft;
            btnCatatKondisi.UseVisualStyleBackColor = false;
            btnCatatKondisi.Click += btninputpasien_Click;
            // 
            // btnjadwalobat
            // 
            btnjadwalobat.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnjadwalobat.Location = new Point(20, 155);
            btnjadwalobat.Name = "btnjadwalobat";
            btnjadwalobat.Size = new Size(179, 30);
            btnjadwalobat.TabIndex = 2;
            btnjadwalobat.Text = "Jadwal Obat";
            btnjadwalobat.TextAlign = ContentAlignment.MiddleLeft;
            btnjadwalobat.UseVisualStyleBackColor = true;
            // 
            // btnpengaturan
            // 
            btnpengaturan.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnpengaturan.Location = new Point(20, 437);
            btnpengaturan.Name = "btnpengaturan";
            btnpengaturan.Size = new Size(97, 30);
            btnpengaturan.TabIndex = 4;
            btnpengaturan.Text = "Pengaturan";
            btnpengaturan.TextAlign = ContentAlignment.MiddleLeft;
            btnpengaturan.UseVisualStyleBackColor = true;
            btnpengaturan.Click += btnlaporan_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(btnKeluar);
            groupBox1.Controls.Add(btnDataPasien);
            groupBox1.Controls.Add(btnCatatKondisi);
            groupBox1.Controls.Add(btnpengaturan);
            groupBox1.Controls.Add(btnjadwalobat);
            groupBox1.Location = new Point(-14, -29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(199, 492);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // btnDataPasien
            // 
            btnDataPasien.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDataPasien.ImageAlign = ContentAlignment.MiddleLeft;
            btnDataPasien.Location = new Point(20, 83);
            btnDataPasien.Name = "btnDataPasien";
            btnDataPasien.Size = new Size(179, 30);
            btnDataPasien.TabIndex = 5;
            btnDataPasien.Text = "Data Pasien";
            btnDataPasien.TextAlign = ContentAlignment.MiddleLeft;
            btnDataPasien.UseVisualStyleBackColor = true;
            // 
            // btnKeluar
            // 
            btnKeluar.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKeluar.Location = new Point(128, 437);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(65, 30);
            btnKeluar.TabIndex = 6;
            btnKeluar.Text = "Keluar";
            btnKeluar.TextAlign = ContentAlignment.MiddleLeft;
            btnKeluar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(185, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(616, 369);
            dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Dashboard";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCatatKondisi;
        private Button btnjadwalobat;
        private Button btnpengaturan;
        private GroupBox groupBox1;
        private Button btnKeluar;
        private Button btnDataPasien;
        private DataGridView dataGridView1;
    }
}