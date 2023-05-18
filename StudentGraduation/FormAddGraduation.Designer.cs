namespace StudentGraduation
{
    partial class FormAddGraduation
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
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblGroup = new Label();
            combGroup = new ComboBox();
            combFaculty = new ComboBox();
            btnAddGraduation = new Button();
            panel1 = new Panel();
            pbRefresh = new PictureBox();
            pictureBox4 = new PictureBox();
            lblAddStudent = new Label();
            pictureBox1 = new PictureBox();
            lblFaculty = new Label();
            panel2 = new Panel();
            combStudent = new ComboBox();
            numericGraduation = new NumericUpDown();
            label1 = new Label();
            pictureBox6 = new PictureBox();
            lblSubject = new Label();
            combSubject = new ComboBox();
            pictureBox5 = new PictureBox();
            lblStudent = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericGraduation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._9cf535ed38c148f961f79288225e8442;
            pictureBox3.Location = new Point(466, 64);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._9cf535ed38c148f961f79288225e8442;
            pictureBox2.Location = new Point(466, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // lblGroup
            // 
            lblGroup.AutoSize = true;
            lblGroup.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblGroup.Location = new Point(173, 68);
            lblGroup.Name = "lblGroup";
            lblGroup.Size = new Size(91, 27);
            lblGroup.TabIndex = 24;
            lblGroup.Text = "Группа:";
            // 
            // combGroup
            // 
            combGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            combGroup.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            combGroup.FormattingEnabled = true;
            combGroup.Location = new Point(273, 64);
            combGroup.Margin = new Padding(3, 4, 3, 4);
            combGroup.Name = "combGroup";
            combGroup.Size = new Size(183, 35);
            combGroup.TabIndex = 23;
            combGroup.SelectedIndexChanged += combGroup_SelectedIndexChanged;
            // 
            // combFaculty
            // 
            combFaculty.DropDownStyle = ComboBoxStyle.DropDownList;
            combFaculty.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            combFaculty.FormattingEnabled = true;
            combFaculty.Location = new Point(273, 17);
            combFaculty.Margin = new Padding(3, 4, 3, 4);
            combFaculty.Name = "combFaculty";
            combFaculty.Size = new Size(183, 35);
            combFaculty.TabIndex = 22;
            combFaculty.SelectedIndexChanged += combFaculty_SelectedIndexChanged;
            // 
            // btnAddGraduation
            // 
            btnAddGraduation.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddGraduation.Location = new Point(239, 249);
            btnAddGraduation.Name = "btnAddGraduation";
            btnAddGraduation.Size = new Size(217, 51);
            btnAddGraduation.TabIndex = 16;
            btnAddGraduation.Text = "Сохранить";
            btnAddGraduation.UseVisualStyleBackColor = true;
            btnAddGraduation.Click += btnAddGraduation_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(pbRefresh);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(lblAddStudent);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 116);
            panel1.TabIndex = 18;
            // 
            // pbRefresh
            // 
            pbRefresh.Image = Properties.Resources.d79003346dca381291856eb89462eac8;
            pbRefresh.Location = new Point(638, 31);
            pbRefresh.Name = "pbRefresh";
            pbRefresh.Size = new Size(50, 56);
            pbRefresh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRefresh.TabIndex = 6;
            pbRefresh.TabStop = false;
            pbRefresh.Click += pbRefresh_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._271_2712168_eraser_comments_clipart;
            pictureBox4.Location = new Point(695, 31);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(53, 56);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // lblAddStudent
            // 
            lblAddStudent.AutoSize = true;
            lblAddStudent.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblAddStudent.Location = new Point(114, 39);
            lblAddStudent.Name = "lblAddStudent";
            lblAddStudent.Size = new Size(471, 38);
            lblAddStudent.TabIndex = 1;
            lblAddStudent.Text = "Добавление записи об оценке";
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
            // lblFaculty
            // 
            lblFaculty.AutoSize = true;
            lblFaculty.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFaculty.Location = new Point(146, 21);
            lblFaculty.Name = "lblFaculty";
            lblFaculty.Size = new Size(123, 27);
            lblFaculty.TabIndex = 18;
            lblFaculty.Text = "Факультет:";
            // 
            // panel2
            // 
            panel2.Controls.Add(combStudent);
            panel2.Controls.Add(numericGraduation);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(lblSubject);
            panel2.Controls.Add(combSubject);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(lblStudent);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(lblGroup);
            panel2.Controls.Add(combGroup);
            panel2.Controls.Add(combFaculty);
            panel2.Controls.Add(btnAddGraduation);
            panel2.Controls.Add(lblFaculty);
            panel2.Location = new Point(2, 123);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(760, 315);
            panel2.TabIndex = 19;
            // 
            // combStudent
            // 
            combStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            combStudent.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            combStudent.FormattingEnabled = true;
            combStudent.Location = new Point(273, 111);
            combStudent.Margin = new Padding(3, 4, 3, 4);
            combStudent.Name = "combStudent";
            combStudent.Size = new Size(402, 35);
            combStudent.TabIndex = 26;
            // 
            // numericGraduation
            // 
            numericGraduation.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            numericGraduation.Location = new Point(273, 204);
            numericGraduation.Margin = new Padding(3, 4, 3, 4);
            numericGraduation.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericGraduation.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericGraduation.Name = "numericGraduation";
            numericGraduation.Size = new Size(39, 35);
            numericGraduation.TabIndex = 33;
            numericGraduation.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(170, 207);
            label1.Name = "label1";
            label1.Size = new Size(95, 27);
            label1.TabIndex = 32;
            label1.Text = "Оценка:";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources._9cf535ed38c148f961f79288225e8442;
            pictureBox6.Location = new Point(466, 157);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(38, 39);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 31;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubject.Location = new Point(159, 161);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(106, 27);
            lblSubject.TabIndex = 30;
            lblSubject.Text = "Предмет:";
            // 
            // combSubject
            // 
            combSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            combSubject.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            combSubject.FormattingEnabled = true;
            combSubject.Location = new Point(273, 157);
            combSubject.Margin = new Padding(3, 4, 3, 4);
            combSubject.Name = "combSubject";
            combSubject.Size = new Size(183, 35);
            combSubject.TabIndex = 29;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources._9cf535ed38c148f961f79288225e8442;
            pictureBox5.Location = new Point(686, 111);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(38, 39);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 28;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStudent.Location = new Point(163, 115);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(100, 27);
            lblStudent.TabIndex = 27;
            lblStudent.Text = "Студент:";
            // 
            // FormAddGraduation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 439);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAddGraduation";
            Text = "FormAddGraduation";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericGraduation).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label lblGroup;
        private ComboBox combGroup;
        private ComboBox combFaculty;
        private Button btnAddGraduation;
        private Panel panel1;
        private PictureBox pictureBox4;
        private Label lblAddStudent;
        private PictureBox pictureBox1;
        private Label lblFaculty;
        private Panel panel2;
        private PictureBox pictureBox5;
        private Label lblStudent;
        private ComboBox combStudent;
        private NumericUpDown numericGraduation;
        private Label label1;
        private PictureBox pictureBox6;
        private Label lblSubject;
        private ComboBox combSubject;
        private PictureBox pbRefresh;
    }
}