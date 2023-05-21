namespace StudentGraduation
{
    partial class FormDeleteSubject
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
            lblDeleteSubject = new Label();
            pictureBox1 = new PictureBox();
            btnSubmit = new Button();
            lblSubject = new Label();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(lblDeleteSubject);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 62);
            panel1.TabIndex = 25;
            // 
            // lblDeleteSubject
            // 
            lblDeleteSubject.AutoSize = true;
            lblDeleteSubject.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblDeleteSubject.Location = new Point(73, 19);
            lblDeleteSubject.Name = "lblDeleteSubject";
            lblDeleteSubject.Size = new Size(319, 26);
            lblDeleteSubject.TabIndex = 1;
            lblDeleteSubject.Text = "Удаление записи о предмете";
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
            btnSubmit.Location = new Point(157, 135);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(119, 32);
            btnSubmit.TabIndex = 28;
            btnSubmit.Text = "Удалить";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubject.Location = new Point(109, 76);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(167, 21);
            lblSubject.TabIndex = 27;
            lblSubject.Text = "Название предмета:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(109, 100);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(220, 29);
            comboBox1.TabIndex = 29;
            // 
            // FormDeleteSubject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 176);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Controls.Add(btnSubmit);
            Controls.Add(lblSubject);
            Name = "FormDeleteSubject";
            Text = "FormDeleteSubject";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblDeleteSubject;
        private PictureBox pictureBox1;
        private Button btnSubmit;
        private Label lblSubject;
        private ComboBox comboBox1;
    }
}