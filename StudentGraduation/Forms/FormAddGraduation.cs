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
    public partial class FormAddGraduation : Form
    {
        DataService dataService = new DataService();
        public FormAddGraduation()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dataService.GetAllDataWithStudents(combFaculty, combGroup, combSubject, combStudent);
        }
        private void btnAddGraduation_Click(object sender, EventArgs e)
        {
            var fio = combStudent.SelectedItem.ToString();
            var subjectName = combSubject.SelectedItem.ToString();
            int graduation = Convert.ToInt32(numericGraduation.Value);
            bool result = dataService.AddGraduation(fio, subjectName, graduation);
            if (result)
            {
                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Запись не создана!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            combFaculty.Items.Clear();
            combGroup.Items.Clear();
            combStudent.Items.Clear();
            combSubject.Items.Clear();
            dataService.GetAllDataWithStudents(combFaculty, combGroup, combSubject, combStudent);
        }

        private void combFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {

            combGroup.Items.Clear();
            combStudent.Items.Clear();
            combGroup.SelectedIndex = -1;
            combGroup.Items.Clear();
            if (combFaculty.SelectedIndex != -1)
            {
                dataService.GetGroupsCollectionWithFaculty(combGroup, combFaculty.SelectedItem.ToString());
            }
            dataService.GetStudentCollection(combStudent);
        }

        private void combGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            combStudent.Items.Clear();
            if (combGroup.SelectedIndex != -1)
            {
                dataService.GetStudentsCollectionWithGroup(combStudent, combGroup.SelectedItem.ToString());
            }
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FormAddStudent formAddStudent = new FormAddStudent();
            formAddStudent.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FormAddSubject formAddSubject = new FormAddSubject();
            formAddSubject.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            combFaculty.SelectedIndex = -1;
            combGroup.SelectedIndex = -1;
            combStudent.SelectedIndex = -1;
            combSubject.SelectedIndex = -1;
        }
    }
}
