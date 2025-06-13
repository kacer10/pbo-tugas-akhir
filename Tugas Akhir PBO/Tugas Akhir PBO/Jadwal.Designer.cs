namespace Tugas_Akhir_PBO
{
    partial class Jadwal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        //private System.Windows.Forms.DataGridView dataGridView1;
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jadwal));
            dataGridView1 = new DataGridView();
            jadwalnya = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            Kembali5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(799, 384);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // jadwalnya
            // 
            jadwalnya.AutoSize = true;
            jadwalnya.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            jadwalnya.ForeColor = Color.FromArgb(0, 64, 64);
            jadwalnya.Location = new Point(136, 9);
            jadwalnya.Name = "jadwalnya";
            jadwalnya.Size = new Size(493, 39);
            jadwalnya.TabIndex = 1;
            jadwalnya.Text = "Jadwal Konsumsi Obat Pasien";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Kembali5
            // 
            Kembali5.Location = new Point(733, 8);
            Kembali5.Name = "Kembali5";
            Kembali5.Size = new Size(65, 33);
            Kembali5.TabIndex = 6;
            Kembali5.Text = "Back";
            Kembali5.UseVisualStyleBackColor = true;
            // 
            // Jadwal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Kembali5);
            Controls.Add(pictureBox1);
            Controls.Add(jadwalnya);
            Controls.Add(dataGridView1);
            Name = "Jadwal";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Waktu", "Waktu");
            dataGridView1.Columns.Add("Obat", "Obat");
            dataGridView1.Columns.Add("NamaPasien", "Nama Pasien");
            dataGridView1.Columns.Add("NoKamar", "No. Kamar");
            dataGridView1.Columns.Add("Diagnosa", "Diagnosa");
        }

        #endregion





        private System.Windows.Forms.DataGridView dataGridView1;
        //private DataGridView dataGridView1;
        private Label jadwalnya;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private Button Kembali5;
    }
}