namespace Tugas_Akhir_PBO
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            isiID = new TextBox();
            isiPassword = new TextBox();
            btntombolsignIn = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            putihbox = new GroupBox();
            login = new Label();
            medipop = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            putihbox.SuspendLayout();
            SuspendLayout();
            // 
            // isiID
            // 
            isiID.BackColor = SystemColors.InactiveBorder;
            isiID.ForeColor = SystemColors.WindowFrame;
            isiID.Location = new Point(30, 121);
            isiID.Margin = new Padding(2, 2, 2, 2);
            isiID.Multiline = true;
            isiID.Name = "isiID";
            isiID.Size = new Size(241, 33);
            isiID.TabIndex = 0;
            isiID.Text = "ID";
            // 
            // isiPassword
            // 
            isiPassword.BackColor = SystemColors.InactiveBorder;
            isiPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            isiPassword.ForeColor = SystemColors.WindowFrame;
            isiPassword.Location = new Point(30, 178);
            isiPassword.Margin = new Padding(2, 2, 2, 2);
            isiPassword.Multiline = true;
            isiPassword.Name = "isiPassword";
            isiPassword.Size = new Size(241, 33);
            isiPassword.TabIndex = 1;
            isiPassword.Text = "Password";
            // 
            // btntombolsignIn
            // 
            btntombolsignIn.BackColor = SystemColors.Highlight;
            btntombolsignIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntombolsignIn.ForeColor = Color.White;
            btntombolsignIn.ImageAlign = ContentAlignment.MiddleRight;
            btntombolsignIn.Location = new Point(108, 276);
            btntombolsignIn.Margin = new Padding(2, 2, 2, 2);
            btntombolsignIn.Name = "btntombolsignIn";
            btntombolsignIn.Size = new Size(78, 32);
            btntombolsignIn.TabIndex = 3;
            btntombolsignIn.Text = "Log In";
            btntombolsignIn.UseVisualStyleBackColor = false;
            btntombolsignIn.Click += tombolLogin_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(448, 314);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 27);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 272);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // putihbox
            // 
            putihbox.BackColor = SystemColors.ButtonHighlight;
            putihbox.Controls.Add(isiID);
            putihbox.Controls.Add(isiPassword);
            putihbox.Controls.Add(btntombolsignIn);
            putihbox.Controls.Add(login);
            putihbox.Location = new Point(331, 10);
            putihbox.Margin = new Padding(2, 2, 2, 2);
            putihbox.Name = "putihbox";
            putihbox.Padding = new Padding(2, 2, 2, 2);
            putihbox.Size = new Size(299, 341);
            putihbox.TabIndex = 6;
            putihbox.TabStop = false;
            // 
            // login
            // 
            login.AutoSize = true;
            login.BackColor = SystemColors.ButtonHighlight;
            login.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login.ForeColor = SystemColors.ActiveCaption;
            login.Location = new Point(90, 22);
            login.Margin = new Padding(2, 0, 2, 0);
            login.Name = "login";
            login.Size = new Size(127, 32);
            login.TabIndex = 2;
            login.Text = "Welcome!";
            // 
            // medipop
            // 
            medipop.AutoSize = true;
            medipop.Font = new Font("Showcard Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            medipop.ForeColor = Color.FromArgb(47, 84, 104);
            medipop.Location = new Point(66, 278);
            medipop.Margin = new Padding(2, 0, 2, 0);
            medipop.Name = "medipop";
            medipop.Size = new Size(181, 43);
            medipop.TabIndex = 7;
            medipop.Text = "MEDIPOP";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(640, 360);
            Controls.Add(medipop);
            Controls.Add(putihbox);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            putihbox.ResumeLayout(false);
            putihbox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox isiID;
        private TextBox isiPassword;
        private Button btntombolsignIn;
        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox putihbox;
        public Label login;
        private Label medipop;
    }
}
