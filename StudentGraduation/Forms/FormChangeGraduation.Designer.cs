namespace StudentGraduation
{
    partial class FormChangeGraduation
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
            lblAddStudent = new Label();
            pictureBox1 = new PictureBox();
            numericGraduation = new NumericUpDown();
            label1 = new Label();
            lblSubject = new Label();
            lblStudent = new Label();
            lblGroup = new Label();
            btnAddGraduation = new Button();
            lblFaculty = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericGraduation).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(lblAddStudent);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(613, 116);
            panel1.TabIndex = 35;
            // 
            // lblAddStudent
            // 
            lblAddStudent.AutoSize = true;
            lblAddStudent.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblAddStudent.Location = new Point(114, 39);
            lblAddStudent.Name = "lblAddStudent";
            lblAddStudent.Size = new Size(458, 38);
            lblAddStudent.TabIndex = 1;
            lblAddStudent.Text = "Изменение записи об оценке";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.png_clipart_computer_icons_gear_encapsulated_postscript_others_set_line;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // numericGraduation
            // 
            numericGraduation.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            numericGraduation.Location = new Point(183, 319);
            numericGraduation.Margin = new Padding(3, 4, 3, 4);
            numericGraduation.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericGraduation.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericGraduation.Name = "numericGraduation";
            numericGraduation.Size = new Size(39, 35);
            numericGraduation.TabIndex = 41;
            numericGraduation.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(80, 321);
            label1.Name = "label1";
            label1.Size = new Size(95, 27);
            label1.TabIndex = 40;
            label1.Text = "Оценка:";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubject.Location = new Point(69, 276);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(106, 27);
            lblSubject.TabIndex = 39;
            lblSubject.Text = "Предмет:";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStudent.Location = new Point(73, 229);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(100, 27);
            lblStudent.TabIndex = 38;
            lblStudent.Text = "Студент:";
            // 
            // lblGroup
            // 
            lblGroup.AutoSize = true;
            lblGroup.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblGroup.Location = new Point(82, 183);
            lblGroup.Name = "lblGroup";
            lblGroup.Size = new Size(91, 27);
            lblGroup.TabIndex = 37;
            lblGroup.Text = "Группа:";
            // 
            // btnAddGraduation
            // 
            btnAddGraduation.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddGraduation.Location = new Point(200, 369);
            btnAddGraduation.Name = "btnAddGraduation";
            btnAddGraduation.Size = new Size(217, 51);
            btnAddGraduation.TabIndex = 34;
            btnAddGraduation.Text = "Сохранить";
            btnAddGraduation.UseVisualStyleBackColor = true;
            btnAddGraduation.Click += btnAddGraduation_Click;
            // 
            // lblFaculty
            // 
            lblFaculty.AutoSize = true;
            lblFaculty.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFaculty.Location = new Point(56, 136);
            lblFaculty.Name = "lblFaculty";
            lblFaculty.Size = new Size(123, 27);
            lblFaculty.TabIndex = 36;
            lblFaculty.Text = "Факультет:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(183, 136);
            label2.Name = "label2";
            label2.Size = new Size(70, 27);
            label2.TabIndex = 42;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(183, 183);
            label3.Name = "label3";
            label3.Size = new Size(70, 27);
            label3.TabIndex = 43;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(183, 229);
            label4.Name = "label4";
            label4.Size = new Size(70, 27);
            label4.TabIndex = 44;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(183, 276);
            label5.Name = "label5";
            label5.Size = new Size(70, 27);
            label5.TabIndex = 45;
            label5.Text = "label5";
            // 
            // FormChangeGraduation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 435);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(numericGraduation);
            Controls.Add(label1);
            Controls.Add(lblSubject);
            Controls.Add(lblStudent);
            Controls.Add(lblGroup);
            Controls.Add(btnAddGraduation);
            Controls.Add(lblFaculty);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormChangeGraduation";
            Text = "FormChangeGraduation";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericGraduation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblAddStudent;
        private PictureBox pictureBox1;
        private NumericUpDown numericGraduation;
        private Label label1;
        private Label lblSubject;
        private Label lblStudent;
        private Label lblGroup;
        private Button btnAddGraduation;
        private Label lblFaculty;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}