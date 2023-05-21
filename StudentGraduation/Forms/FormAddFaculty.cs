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
    public partial class FormAddFaculty : Form
    {
        DataService dataService = new DataService();
        public FormAddFaculty()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var facultyName = tbFaculty.Text;
            bool result = dataService.AddFaculty(facultyName);
            if (result)
            {
                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Запись не создана!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pbClear_Click(object sender, EventArgs e)
        {
            tbFaculty.Clear();
        }
    }
}
