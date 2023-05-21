namespace StudentGraduation
{
    partial class FormAddStudent
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
            btnAddStudent = new Button();
            panel1 = new Panel();
            pbRefresh = new PictureBox();
            pictureBox4 = new PictureBox();
            lblAddStudent = new Label();
            numericNDyear = new NumericUpDown();
            lblNumberofcredit = new Label();
            lblNdyear = new Label();
            lblFaculty = new Label();
            tbNumberofcredit = new TextBox();
            tbBirthday = new TextBox();
            tbFIO = new TextBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblGroup = new Label();
            combGroup = new ComboBox();
            combFaculty = new ComboBox();
            lblBirthday = new Label();
            lblFio = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericNDyear).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.png_transparent_computer_icons_user_user_miscellaneous_logo_smiley;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddStudent.Location = new Point(263, 295);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(217, 51);
            btnAddStudent.TabIndex = 16;
            btnAddStudent.Text = "Сохранить";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
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
            panel1.TabIndex = 15;
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
            lblAddStudent.Size = new Size(478, 38);
            lblAddStudent.TabIndex = 1;
            lblAddStudent.Text = "Добавление записи о студенте";
            // 
            // numericNDyear
            // 
            numericNDyear.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            numericNDyear.Location = new Point(297, 203);
            numericNDyear.Margin = new Padding(3, 4, 3, 4);
            numericNDyear.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericNDyear.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericNDyear.Name = "numericNDyear";
            numericNDyear.Size = new Size(38, 35);
            numericNDyear.TabIndex = 21;
            numericNDyear.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // lblNumberofcredit
            // 
            lblNumberofcredit.AutoSize = true;
            lblNumberofcredit.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumberofcredit.Location = new Point(18, 252);
            lblNumberofcredit.Name = "lblNumberofcredit";
            lblNumberofcredit.Size = new Size(267, 27);
            lblNumberofcredit.TabIndex = 20;
            lblNumberofcredit.Text = "Номер зачётной книжки:";
            // 
            // lblNdyear
            // 
            lblNdyear.AutoSize = true;
            lblNdyear.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNdyear.Location = new Point(218, 205);
            lblNdyear.Name = "lblNdyear";
            lblNdyear.Size = new Size(67, 27);
            lblNdyear.TabIndex = 19;
            lblNdyear.Text = "Курс:";
            // 
            // lblFaculty
            // 
            lblFaculty.AutoSize = true;
            lblFaculty.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFaculty.Location = new Point(170, 113);
            lblFaculty.Name = "lblFaculty";
            lblFaculty.Size = new Size(123, 27);
            lblFaculty.TabIndex = 18;
            lblFaculty.Text = "Факультет:";
            // 
            // tbNumberofcredit
            // 
            tbNumberofcredit.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbNumberofcredit.Location = new Point(297, 249);
            tbNumberofcredit.Margin = new Padding(3, 4, 3, 4);
            tbNumberofcredit.Name = "tbNumberofcredit";
            tbNumberofcredit.Size = new Size(367, 35);
            tbNumberofcredit.TabIndex = 14;
            // 
            // tbBirthday
            // 
            tbBirthday.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbBirthday.Location = new Point(297, 63);
            tbBirthday.Margin = new Padding(3, 4, 3, 4);
            tbBirthday.Name = "tbBirthday";
            tbBirthday.Size = new Size(367, 35);
            tbBirthday.TabIndex = 11;
            // 
            // tbFIO
            // 
            tbFIO.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbFIO.Location = new Point(297, 16);
            tbFIO.Margin = new Padding(3, 4, 3, 4);
            tbFIO.Name = "tbFIO";
            tbFIO.Size = new Size(367, 35);
            tbFIO.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(lblGroup);
            panel2.Controls.Add(combGroup);
            panel2.Controls.Add(combFaculty);
            panel2.Controls.Add(numericNDyear);
            panel2.Controls.Add(btnAddStudent);
            panel2.Controls.Add(lblNumberofcredit);
            panel2.Controls.Add(lblNdyear);
            panel2.Controls.Add(lblFaculty);
            panel2.Controls.Add(lblBirthday);
            panel2.Controls.Add(lblFio);
            panel2.Controls.Add(tbNumberofcredit);
            panel2.Controls.Add(tbBirthday);
            panel2.Controls.Add(tbFIO);
            panel2.Location = new Point(2, 123);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(760, 357);
            panel2.TabIndex = 17;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._9cf535ed38c148f961f79288225e8442;
            pictureBox3.Location = new Point(442, 156);
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
            pictureBox2.Location = new Point(442, 109);
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
            lblGroup.Location = new Point(194, 159);
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
            combGroup.Location = new Point(297, 156);
            combGroup.Margin = new Padding(3, 4, 3, 4);
            combGroup.Name = "combGroup";
            combGroup.Size = new Size(138, 35);
            combGroup.TabIndex = 23;
            // 
            // combFaculty
            // 
            combFaculty.DropDownStyle = ComboBoxStyle.DropDownList;
            combFaculty.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            combFaculty.FormattingEnabled = true;
            combFaculty.Location = new Point(297, 109);
            combFaculty.Margin = new Padding(3, 4, 3, 4);
            combFaculty.Name = "combFaculty";
            combFaculty.Size = new Size(138, 35);
            combFaculty.TabIndex = 22;
            combFaculty.SelectedIndexChanged += combFaculty_SelectedIndexChanged;
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblBirthday.Location = new Point(122, 67);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(171, 27);
            lblBirthday.TabIndex = 17;
            lblBirthday.Text = "Дата рождения:";
            // 
            // lblFio
            // 
            lblFio.AutoSize = true;
            lblFio.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFio.Location = new Point(215, 20);
            lblFio.Name = "lblFio";
            lblFio.Size = new Size(70, 27);
            lblFio.TabIndex = 16;
            lblFio.Text = "ФИО:";
            // 
            // FormAddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 483);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAddStudent";
            Text = "Add_form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericNDyear).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnAddStudent;
        private Panel panel1;
        private PictureBox pictureBox4;
        private Label lblAddStudent;
        private NumericUpDown numericNDyear;
        private Label lblNumberofcredit;
        private Label lblNdyear;
        private Label lblFaculty;
        private TextBox tbNumberofcredit;
        private TextBox tbBirthday;
        private TextBox tbFIO;
        private Panel panel2;
        private Label lblBirthday;
        private Label lblFio;
        private ComboBox combGroup;
        private ComboBox combFaculty;
        private Label lblGroup;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pbRefresh;
    }
}