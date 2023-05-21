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
    public partial class FormAddStudent : Form
    {
        DataService dataService = new DataService();
        public FormAddStudent()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dataService.GetFacultiesCollection(combFaculty);
            dataService.GetGroupsCollection(combGroup);
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var fio = tbFIO.Text;
            var birthday = tbBirthday.Text;
            int ndyear = Convert.ToInt32(numericNDyear.Value);
            var groupname = combGroup.SelectedItem.ToString();
            if (int.TryParse(tbNumberofcredit.Text, out int numberOfCredit))
            {
                bool result = dataService.AddStudent(fio, birthday, groupname, ndyear, numberOfCredit);
                if (result)
                {
                    MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Запись не создана!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Указаны неправильные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tbBirthday.Text = "";
            tbFIO.Text = "";
            tbNumberofcredit.Text = "";
            numericNDyear.Value = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormAddFaculty formAddFaculty = new FormAddFaculty();
            formAddFaculty.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormAddGroup formAddGroup = new FormAddGroup();
            formAddGroup.Show();
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            combFaculty.Items.Clear();
            combGroup.Items.Clear();
            dataService.GetFacultiesCollection(combFaculty);
            dataService.GetGroupsCollection(combGroup);
        }

        private void combFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            combGroup.Items.Clear();
            if (combFaculty.SelectedIndex != -1)
            {
                dataService.GetGroupsCollection(combGroup);
            }
        }
    }
}
