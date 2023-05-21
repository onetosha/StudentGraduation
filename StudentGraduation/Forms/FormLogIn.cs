using Microsoft.Data.SqlClient;
using StudentGraduation.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGraduation
{
    public partial class FormLogIn : Form
    {
        DataService dataService = new DataService();
        public FormLogIn()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void log_in_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            textBox1.MaxLength = 50;
            textBox2.MaxLength = 50;
        }

        private void btnLog_in_Click(object sender, EventArgs e)
        {
            var loginUser = textBox1.Text;
            var passwordUser = textBox2.Text;

            bool result = dataService.LogIn(loginUser, passwordUser);

            if (result)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm form_main = new MainForm();
                this.Hide();
                form_main.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void llblGotoRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSignUp form_sign_up = new FormSignUp();
            this.Hide();
            form_sign_up.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
            pictureBox3.Visible = false;
            pictureBox2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            pictureBox3.Visible = true;
            pictureBox2.Visible = false;
        }
    }
}
