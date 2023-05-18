namespace StudentGraduation
{
    partial class FormAddFaculty
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
            panel1 = new Panel();
            lblAddFaculty = new Label();
            pictureBox1 = new PictureBox();
            pbClear = new PictureBox();
            lblFaculty = new Label();
            tbFaculty = new TextBox();
            btnSubmit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbClear).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(lblAddFaculty);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(506, 83);
            panel1.TabIndex = 16;
            // 
            // lblAddFaculty
            // 
            lblAddFaculty.AutoSize = true;
            lblAddFaculty.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblAddFaculty.Location = new Point(83, 33);
            lblAddFaculty.Name = "lblAddFaculty";
            lblAddFaculty.Size = new Size(358, 25);
            lblAddFaculty.TabIndex = 1;
            lblAddFaculty.Text = "Добавление записи о факультете";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.png_clipart_computer_icons_gear_encapsulated_postscript_others_set_line;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pbClear
            // 
            pbClear.Image = Properties.Resources._271_2712168_eraser_comments_clipart;
            pbClear.Location = new Point(415, 115);
            pbClear.Name = "pbClear";
            pbClear.Size = new Size(63, 63);
            pbClear.SizeMode = PictureBoxSizeMode.StretchImage;
            pbClear.TabIndex = 2;
            pbClear.TabStop = false;
            pbClear.Click += pbClear_Click;
            // 
            // lblFaculty
            // 
            lblFaculty.AutoSize = true;
            lblFaculty.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFaculty.Location = new Point(14, 107);
            lblFaculty.Name = "lblFaculty";
            lblFaculty.Size = new Size(234, 27);
            lblFaculty.TabIndex = 18;
            lblFaculty.Text = "Название факультета:";
            // 
            // tbFaculty
            // 
            tbFaculty.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbFaculty.Location = new Point(14, 139);
            tbFaculty.Margin = new Padding(3, 4, 3, 4);
            tbFaculty.Name = "tbFaculty";
            tbFaculty.Size = new Size(367, 35);
            tbFaculty.TabIndex = 17;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmit.Location = new Point(178, 201);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(136, 43);
            btnSubmit.TabIndex = 19;
            btnSubmit.Text = "Добавить";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // FormAddFaculty
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 260);
            Controls.Add(btnSubmit);
            Controls.Add(pbClear);
            Controls.Add(lblFaculty);
            Controls.Add(tbFaculty);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAddFaculty";
            Text = "AddFaculty";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbClear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pbClear;
        private Label lblAddFaculty;
        private PictureBox pictureBox1;
        private Label lblFaculty;
        private TextBox tbFaculty;
        private Button btnSubmit;
    }
}