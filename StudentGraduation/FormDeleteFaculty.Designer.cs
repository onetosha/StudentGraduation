namespace StudentGraduation
{
    partial class FormDeleteFaculty
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
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            lblDeleteFaculty = new Label();
            pictureBox1 = new PictureBox();
            btnSubmit = new Button();
            lblFaculty = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(110, 102);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(220, 29);
            comboBox1.TabIndex = 33;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(lblDeleteFaculty);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 62);
            panel1.TabIndex = 30;
            // 
            // lblDeleteFaculty
            // 
            lblDeleteFaculty.AutoSize = true;
            lblDeleteFaculty.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblDeleteFaculty.Location = new Point(73, 19);
            lblDeleteFaculty.Name = "lblDeleteFaculty";
            lblDeleteFaculty.Size = new Size(342, 26);
            lblDeleteFaculty.TabIndex = 1;
            lblDeleteFaculty.Text = "Удаление записи о факультете";
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
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmit.Location = new Point(158, 137);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(119, 32);
            btnSubmit.TabIndex = 32;
            btnSubmit.Text = "Удалить";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblFaculty
            // 
            lblFaculty.AutoSize = true;
            lblFaculty.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFaculty.Location = new Point(110, 78);
            lblFaculty.Name = "lblFaculty";
            lblFaculty.Size = new Size(179, 21);
            lblFaculty.TabIndex = 31;
            lblFaculty.Text = "Название факультета:";
            // 
            // FormDeleteFaculty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 174);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Controls.Add(btnSubmit);
            Controls.Add(lblFaculty);
            Name = "FormDeleteFaculty";
            Text = "FormDeleteFaculty";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Panel panel1;
        private Label lblDeleteFaculty;
        private PictureBox pictureBox1;
        private Button btnSubmit;
        private Label lblFaculty;
    }
}