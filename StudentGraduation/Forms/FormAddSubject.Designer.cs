namespace StudentGraduation
{
    partial class FormAddSubject
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
            btnSubmit = new Button();
            pbClear = new PictureBox();
            lblSubject = new Label();
            tbSubject = new TextBox();
            panel1 = new Panel();
            lblAddSubject = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbClear).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmit.Location = new Point(156, 151);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(119, 32);
            btnSubmit.TabIndex = 24;
            btnSubmit.Text = "Добавить";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // pbClear
            // 
            pbClear.Image = Properties.Resources._271_2712168_eraser_comments_clipart;
            pbClear.Location = new Point(363, 86);
            pbClear.Margin = new Padding(3, 2, 3, 2);
            pbClear.Name = "pbClear";
            pbClear.Size = new Size(55, 47);
            pbClear.SizeMode = PictureBoxSizeMode.StretchImage;
            pbClear.TabIndex = 20;
            pbClear.TabStop = false;
            pbClear.Click += pbClear_Click;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubject.Location = new Point(12, 80);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(167, 21);
            lblSubject.TabIndex = 23;
            lblSubject.Text = "Название предмета:";
            // 
            // tbSubject
            // 
            tbSubject.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbSubject.Location = new Point(12, 104);
            tbSubject.Name = "tbSubject";
            tbSubject.Size = new Size(322, 29);
            tbSubject.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(lblAddSubject);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 62);
            panel1.TabIndex = 21;
            // 
            // lblAddSubject
            // 
            lblAddSubject.AutoSize = true;
            lblAddSubject.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblAddSubject.Location = new Point(73, 19);
            lblAddSubject.Name = "lblAddSubject";
            lblAddSubject.Size = new Size(345, 26);
            lblAddSubject.TabIndex = 1;
            lblAddSubject.Text = "Добавление записи о предмете";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.png_clipart_computer_icons_gear_encapsulated_postscript_others_set_line;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormAddSubject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 192);
            Controls.Add(btnSubmit);
            Controls.Add(pbClear);
            Controls.Add(lblSubject);
            Controls.Add(tbSubject);
            Controls.Add(panel1);
            Name = "FormAddSubject";
            Text = "FormAddSubject";
            ((System.ComponentModel.ISupportInitialize)pbClear).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private PictureBox pbClear;
        private Label lblSubject;
        private TextBox tbSubject;
        private Panel panel1;
        private Label lblAddSubject;
        private PictureBox pictureBox1;
    }
}