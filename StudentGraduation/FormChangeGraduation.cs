using Microsoft.Data.SqlClient;
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
    public partial class FormChangeGraduation : Form
    {
        DataService dataService = new DataService();
        int id;
        public FormChangeGraduation(int id, string faculty, string group, string student, string subject, int graduation)
        {
            this.id = id;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            label2.Text = faculty;
            label3.Text = group;
            label4.Text = student;
            label5.Text = subject;
            numericGraduation.Value = graduation;
        }

        private void btnAddGraduation_Click(object sender, EventArgs e)
        {
            dataService.ChangeGraduation(Convert.ToInt32(numericGraduation.Value), id);
            MessageBox.Show("Запись успешно изменена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
