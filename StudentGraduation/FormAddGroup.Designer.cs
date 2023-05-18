namespace StudentGraduation
{
    partial class FormAddGroup
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
            lblGroup = new Label();
            tbGroup = new TextBox();
            panel1 = new Panel();
            lblAddGroup = new Label();
            pictureBox1 = new PictureBox();
            сombFaculty = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbClear).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmit.Location = new Point(149, 219);
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
            pbClear.Location = new Point(365, 86);
            pbClear.Margin = new Padding(3, 2, 3, 2);
            pbClear.Name = "pbClear";
            pbClear.Size = new Size(55, 47);
            pbClear.SizeMode = PictureBoxSizeMode.StretchImage;
            pbClear.TabIndex = 20;
            pbClear.TabStop = false;
            pbClear.Click += pbClear_Click;
            // 
            // lblGroup
            // 
            lblGroup.AutoSize = true;
            lblGroup.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblGroup.Location = new Point(14, 80);
            lblGroup.Name = "lblGroup";
            lblGroup.Size = new Size(153, 21);
            lblGroup.TabIndex = 23;
            lblGroup.Text = "Название группы:";
            // 
            // tbGroup
            // 
            tbGroup.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbGroup.Location = new Point(14, 104);
            tbGroup.Name = "tbGroup";
            tbGroup.Size = new Size(322, 29);
            tbGroup.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(lblAddGroup);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 62);
            panel1.TabIndex = 21;
            // 
            // lblAddGroup
            // 
            lblAddGroup.AutoSize = true;
            lblAddGroup.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblAddGroup.Location = new Point(73, 19);
            lblAddGroup.Name = "lblAddGroup";
            lblAddGroup.Size = new Size(321, 26);
            lblAddGroup.TabIndex = 1;
            lblAddGroup.Text = "Добавление записи о группе";
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
            // сombFaculty
            // 
            сombFaculty.DropDownStyle = ComboBoxStyle.DropDownList;
            сombFaculty.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            сombFaculty.FormattingEnabled = true;
            сombFaculty.Location = new Point(14, 169);
            сombFaculty.Name = "сombFaculty";
            сombFaculty.Size = new Size(121, 29);
            сombFaculty.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 145);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 26;
            label1.Text = "Факультет:";
            // 
            // FormAddGroup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 263);
            Controls.Add(label1);
            Controls.Add(сombFaculty);
            Controls.Add(btnSubmit);
            Controls.Add(pbClear);
            Controls.Add(lblGroup);
            Controls.Add(tbGroup);
            Controls.Add(panel1);
            Name = "FormAddGroup";
            Text = "AddGroup";
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
        private Label lblGroup;
        private TextBox tbGroup;
        private Panel panel1;
        private Label lblAddGroup;
        private PictureBox pictureBox1;
        private ComboBox сombFaculty;
        private Label label1;
    }
}