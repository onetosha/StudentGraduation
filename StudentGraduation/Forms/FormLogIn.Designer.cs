namespace StudentGraduation
{
    partial class FormLogIn
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
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lblLogin = new Label();
            lblPassword = new Label();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            lblAuthorize = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            llblGotoRegister = new LinkLabel();
            btnLog_in = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.img_458466;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(204, 163);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 39);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(204, 220);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(217, 39);
            textBox2.TabIndex = 2;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.Location = new Point(96, 166);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(102, 32);
            lblLogin.TabIndex = 3;
            lblLogin.Text = "Логин:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(78, 223);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(120, 32);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Пароль:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(lblAuthorize);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(562, 125);
            panel1.TabIndex = 5;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._271_2712168_eraser_comments_clipart;
            pictureBox4.Location = new Point(472, 28);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(72, 61);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // lblAuthorize
            // 
            lblAuthorize.AutoSize = true;
            lblAuthorize.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblAuthorize.Location = new Point(148, 36);
            lblAuthorize.Name = "lblAuthorize";
            lblAuthorize.Size = new Size(302, 53);
            lblAuthorize.TabIndex = 1;
            lblAuthorize.Text = "Авторизация";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.img_374056__1_;
            pictureBox2.Location = new Point(427, 220);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.img_313549;
            pictureBox3.Location = new Point(427, 220);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // llblGotoRegister
            // 
            llblGotoRegister.AutoSize = true;
            llblGotoRegister.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            llblGotoRegister.LinkColor = Color.Red;
            llblGotoRegister.Location = new Point(222, 318);
            llblGotoRegister.Name = "llblGotoRegister";
            llblGotoRegister.Size = new Size(180, 22);
            llblGotoRegister.TabIndex = 9;
            llblGotoRegister.TabStop = true;
            llblGotoRegister.Text = "Ещё нет аккаунта?";
            llblGotoRegister.LinkClicked += llblGotoRegister_LinkClicked;
            // 
            // btnLog_in
            // 
            btnLog_in.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLog_in.Location = new Point(204, 276);
            btnLog_in.Name = "btnLog_in";
            btnLog_in.Size = new Size(217, 39);
            btnLog_in.TabIndex = 10;
            btnLog_in.Text = "Войти";
            btnLog_in.UseVisualStyleBackColor = true;
            btnLog_in.Click += btnLog_in_Click;
            // 
            // log_in
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 356);
            Controls.Add(btnLog_in);
            Controls.Add(llblGotoRegister);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(lblPassword);
            Controls.Add(lblLogin);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "log_in";
            Text = "log_in";
            Load += log_in_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblLogin;
        private Label lblPassword;
        private Panel panel1;
        private Label lblAuthorize;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private LinkLabel llblGotoRegister;
        private Button btnLog_in;
    }
}