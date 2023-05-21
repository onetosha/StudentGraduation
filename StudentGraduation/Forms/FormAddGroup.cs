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
    public partial class FormAddGroup : Form
    {
        DataService dataService = new DataService();
        public FormAddGroup()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dataService.GetFacultiesCollection(сombFaculty);
        }

        private void pbClear_Click(object sender, EventArgs e)
        {
            tbGroup.Clear();
            сombFaculty.SelectedIndex = -1;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var groupName = tbGroup.Text;
            var facultyName = сombFaculty.SelectedItem.ToString();
            bool result = dataService.AddGroup(facultyName, groupName);
            if (result)
            {
                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Запись не создана!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
