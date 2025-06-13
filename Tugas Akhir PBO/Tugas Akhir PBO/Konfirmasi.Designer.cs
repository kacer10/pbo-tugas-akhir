using System.ComponentModel;

namespace Tugas_Akhir_PBO
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Dashboard));
            konfirmasinya = new Label();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            status_box = new TextBox();
            pictureBox1 = new PictureBox();
            kembali4 = new Button();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // konfirmasinya
            // 
            konfirmasinya.AutoSize = true;
            konfirmasinya.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            konfirmasinya.ForeColor = Color.FromArgb(0, 64, 64);
            konfirmasinya.Location = new Point(254, 108);
            konfirmasinya.Name = "konfirmasinya";
            konfirmasinya.Size = new Size(245, 38);
            konfirmasinya.TabIndex = 0;
            konfirmasinya.Text = "Status Konsumsi";
            // 
            // button1
            // 
            button1.Location = new Point(340, 262);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Done";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(244, 216);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // status_box
            // 
            status_box.ForeColor = SystemColors.WindowFrame;
            status_box.Location = new Point(320, 170);
            status_box.Name = "status_box";
            status_box.Size = new Size(150, 27);
            status_box.TabIndex = 3;
            status_box.Text = "ID Pasien";
            status_box.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // kembali4
            // 
            kembali4.Location = new Point(687, 414);
            kembali4.Name = "kembali4";
            kembali4.Size = new Size(112, 34);
            kembali4.TabIndex = 6;
            kembali4.Text = "Back";
            kembali4.UseVisualStyleBackColor = true;
            kembali4.Click += kembali4_Click;
            // 
            // Dashboard
            // 
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(kembali4);
            Controls.Add(pictureBox1);
            Controls.Add(status_box);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(konfirmasinya);
            Name = "Dashboard";
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label konfirmasinya;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private TextBox status_box;
        private PictureBox pictureBox1;
        private Button kembali4;
    }
}