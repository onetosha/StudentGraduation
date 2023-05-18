namespace StudentGraduation
{
    partial class MainForm
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
            panel3 = new Panel();
            btnChange = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            lblMenu = new Label();
            panel1 = new Panel();
            pbSearch = new PictureBox();
            tbSearch = new TextBox();
            lblGraduations = new Label();
            pbRefresh = new PictureBox();
            pbClear = new PictureBox();
            dgvGraduations = new DataGridView();
            pictureBox1 = new PictureBox();
            lblSettings = new Label();
            panel2 = new Panel();
            llblDeleteSubject = new LinkLabel();
            llblDeleteGroup = new LinkLabel();
            llblDeleteFaculty = new LinkLabel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnRefresh = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            combSubject = new ComboBox();
            combGroup = new ComboBox();
            combFaculty = new ComboBox();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbClear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGraduations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(btnChange);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(lblMenu);
            panel3.Location = new Point(689, 345);
            panel3.Name = "panel3";
            panel3.Size = new Size(257, 211);
            panel3.TabIndex = 7;
            // 
            // btnChange
            // 
            btnChange.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnChange.Location = new Point(15, 148);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(223, 36);
            btnChange.TabIndex = 12;
            btnChange.Text = "Изменить оценку";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(15, 106);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(223, 36);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Удалить оценку";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(15, 64);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(223, 36);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Добавить оценку";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMenu.Location = new Point(15, 20);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(206, 23);
            lblMenu.TabIndex = 9;
            lblMenu.Text = "Управление записями:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(pbSearch);
            panel1.Controls.Add(tbSearch);
            panel1.Controls.Add(lblGraduations);
            panel1.Controls.Add(pbRefresh);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(944, 43);
            panel1.TabIndex = 5;
            // 
            // pbSearch
            // 
            pbSearch.Image = Properties.Resources.cdab85a392e92623afa27de32443379f;
            pbSearch.Location = new Point(673, 2);
            pbSearch.Margin = new Padding(3, 2, 3, 2);
            pbSearch.Name = "pbSearch";
            pbSearch.Size = new Size(40, 36);
            pbSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSearch.TabIndex = 7;
            pbSearch.TabStop = false;
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbSearch.Location = new Point(719, 9);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(215, 29);
            tbSearch.TabIndex = 6;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // lblGraduations
            // 
            lblGraduations.AutoSize = true;
            lblGraduations.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblGraduations.Location = new Point(3, 2);
            lblGraduations.Name = "lblGraduations";
            lblGraduations.Size = new Size(126, 36);
            lblGraduations.TabIndex = 3;
            lblGraduations.Text = "Оценки";
            // 
            // pbRefresh
            // 
            pbRefresh.Image = Properties.Resources.d79003346dca381291856eb89462eac8;
            pbRefresh.Location = new Point(629, 2);
            pbRefresh.Margin = new Padding(3, 2, 3, 2);
            pbRefresh.Name = "pbRefresh";
            pbRefresh.Size = new Size(38, 36);
            pbRefresh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRefresh.TabIndex = 5;
            pbRefresh.TabStop = false;
            pbRefresh.Click += pbRefresh_Click;
            // 
            // pbClear
            // 
            pbClear.Image = Properties.Resources._271_2712168_eraser_comments_clipart;
            pbClear.Location = new Point(635, 7);
            pbClear.Margin = new Padding(3, 2, 3, 2);
            pbClear.Name = "pbClear";
            pbClear.Size = new Size(43, 36);
            pbClear.SizeMode = PictureBoxSizeMode.StretchImage;
            pbClear.TabIndex = 4;
            pbClear.TabStop = false;
            pbClear.Click += pbClear_Click;
            // 
            // dgvGraduations
            // 
            dgvGraduations.AllowUserToAddRows = false;
            dgvGraduations.AllowUserToDeleteRows = false;
            dgvGraduations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvGraduations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGraduations.Location = new Point(2, 58);
            dgvGraduations.Name = "dgvGraduations";
            dgvGraduations.ReadOnly = true;
            dgvGraduations.RowHeadersWidth = 51;
            dgvGraduations.RowTemplate.Height = 25;
            dgvGraduations.Size = new Size(944, 281);
            dgvGraduations.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._64_641871_chiropract1;
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblSettings
            // 
            lblSettings.AutoSize = true;
            lblSettings.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblSettings.Location = new Point(66, 4);
            lblSettings.Name = "lblSettings";
            lblSettings.Size = new Size(265, 27);
            lblSettings.TabIndex = 8;
            lblSettings.Text = "Настроить отображение:";
            // 
            // panel2
            // 
            panel2.Controls.Add(llblDeleteSubject);
            panel2.Controls.Add(llblDeleteGroup);
            panel2.Controls.Add(llblDeleteFaculty);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pbClear);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(combSubject);
            panel2.Controls.Add(combGroup);
            panel2.Controls.Add(combFaculty);
            panel2.Controls.Add(lblSettings);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(5, 345);
            panel2.Name = "panel2";
            panel2.Size = new Size(681, 211);
            panel2.TabIndex = 6;
            // 
            // llblDeleteSubject
            // 
            llblDeleteSubject.AutoSize = true;
            llblDeleteSubject.Location = new Point(456, 120);
            llblDeleteSubject.Name = "llblDeleteSubject";
            llblDeleteSubject.Size = new Size(109, 15);
            llblDeleteSubject.TabIndex = 32;
            llblDeleteSubject.TabStop = true;
            llblDeleteSubject.Text = "Удалить предмет...";
            llblDeleteSubject.LinkClicked += llblDeleteSubject_LinkClicked;
            // 
            // llblDeleteGroup
            // 
            llblDeleteGroup.AutoSize = true;
            llblDeleteGroup.Location = new Point(264, 120);
            llblDeleteGroup.Name = "llblDeleteGroup";
            llblDeleteGroup.Size = new Size(101, 15);
            llblDeleteGroup.TabIndex = 31;
            llblDeleteGroup.TabStop = true;
            llblDeleteGroup.Text = "Удалить группу...";
            llblDeleteGroup.LinkClicked += llblDeleteGroup_LinkClicked;
            // 
            // llblDeleteFaculty
            // 
            llblDeleteFaculty.AutoSize = true;
            llblDeleteFaculty.Location = new Point(75, 120);
            llblDeleteFaculty.Name = "llblDeleteFaculty";
            llblDeleteFaculty.Size = new Size(119, 15);
            llblDeleteFaculty.TabIndex = 30;
            llblDeleteFaculty.TabStop = true;
            llblDeleteFaculty.Text = "Удалить факультет...";
            llblDeleteFaculty.LinkClicked += llblDeleteFaculty_LinkClicked;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._9cf535ed38c148f961f79288225e8442;
            pictureBox4.Location = new Point(601, 88);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(33, 29);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._9cf535ed38c148f961f79288225e8442;
            pictureBox3.Location = new Point(391, 88);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._9cf535ed38c148f961f79288225e8442;
            pictureBox2.Location = new Point(202, 88);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.Location = new Point(233, 150);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(218, 34);
            btnRefresh.TabIndex = 14;
            btnRefresh.Text = "Отобразить";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(456, 64);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 26;
            label3.Text = "Предмет";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(264, 64);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 25;
            label2.Text = "Группа";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(75, 64);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 24;
            label1.Text = "Факультет";
            // 
            // combSubject
            // 
            combSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            combSubject.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            combSubject.FormattingEnabled = true;
            combSubject.Location = new Point(456, 88);
            combSubject.Name = "combSubject";
            combSubject.Size = new Size(139, 29);
            combSubject.TabIndex = 23;
            // 
            // combGroup
            // 
            combGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            combGroup.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            combGroup.FormattingEnabled = true;
            combGroup.Location = new Point(264, 88);
            combGroup.Name = "combGroup";
            combGroup.Size = new Size(121, 29);
            combGroup.TabIndex = 22;
            // 
            // combFaculty
            // 
            combFaculty.DropDownStyle = ComboBoxStyle.DropDownList;
            combFaculty.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            combFaculty.FormattingEnabled = true;
            combFaculty.Location = new Point(75, 88);
            combFaculty.Name = "combFaculty";
            combFaculty.Size = new Size(121, 29);
            combFaculty.TabIndex = 21;
            combFaculty.SelectedIndexChanged += combFaculty_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 560);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvGraduations);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRefresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbClear).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGraduations).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button btnChange;
        private Button btnDelete;
        private Button btnAdd;
        private Label lblMenu;
        private Panel panel1;
        private PictureBox pbSearch;
        private TextBox tbSearch;
        private PictureBox pbRefresh;
        private PictureBox pbClear;
        private Label lblGraduations;
        private DataGridView dgvGraduations;
        private PictureBox pictureBox1;
        private Label lblSettings;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox combSubject;
        private ComboBox combGroup;
        private ComboBox combFaculty;
        private Button btnRefresh;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private LinkLabel llblDeleteSubject;
        private LinkLabel llblDeleteGroup;
        private LinkLabel llblDeleteFaculty;
    }
}