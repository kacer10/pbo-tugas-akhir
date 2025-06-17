namespace Tugas_Akhir_PBO
{
    partial class Riwayat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Riwayat));
            dataGridView1 = new DataGridView();
            refrsh = new Button();
            Kembali2 = new Button();
            RiwayatKesehatan = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 50);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(693, 281);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // refrsh
            // 
            refrsh.ForeColor = SystemColors.HotTrack;
            refrsh.Location = new Point(573, 358);
            refrsh.Margin = new Padding(2);
            refrsh.Name = "refrsh";
            refrsh.Size = new Size(121, 27);
            refrsh.TabIndex = 1;
            refrsh.Text = "Ubah Status";
            refrsh.UseVisualStyleBackColor = true;
            refrsh.Click += refrsh_Click;
            // 
            // Kembali2
            // 
            Kembali2.ForeColor = SystemColors.HotTrack;
            Kembali2.Location = new Point(469, 358);
            Kembali2.Margin = new Padding(2);
            Kembali2.Name = "Kembali2";
            Kembali2.Size = new Size(90, 27);
            Kembali2.TabIndex = 2;
            Kembali2.Text = "Back";
            Kembali2.UseVisualStyleBackColor = true;
            Kembali2.Click += button1_Click;
            // 
            // RiwayatKesehatan
            // 
            RiwayatKesehatan.AutoSize = true;
            RiwayatKesehatan.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RiwayatKesehatan.ForeColor = Color.FromArgb(0, 64, 64);
            RiwayatKesehatan.Location = new Point(239, 8);
            RiwayatKesehatan.Margin = new Padding(2, 0, 2, 0);
            RiwayatKesehatan.Name = "RiwayatKesehatan";
            RiwayatKesehatan.Size = new Size(128, 38);
            RiwayatKesehatan.TabIndex = 3;
            RiwayatKesehatan.Text = "Riwayat";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -4);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Riwayat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(716, 396);
            Controls.Add(pictureBox1);
            Controls.Add(RiwayatKesehatan);
            Controls.Add(Kembali2);
            Controls.Add(refrsh);
            Controls.Add(dataGridView1);
            Margin = new Padding(2);
            Name = "Riwayat";
            Load += Riwayat_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button refrsh;
        private Button Kembali2;
        private Label RiwayatKesehatan;
        private PictureBox pictureBox1;
    }
}