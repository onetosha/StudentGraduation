using Microsoft.Data.SqlClient;
using System.Data;
using System.Security.Policy;

namespace StudentGraduation
{
    public partial class MainForm : Form
    {
        DataService dataService = new DataService();
        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dgvGraduations.Columns.Add("id", "id");
            dgvGraduations.Columns.Add("faluctyname", "Факультет");
            dgvGraduations.Columns.Add("ndyear", "Курс");
            dgvGraduations.Columns.Add("groupname", "Группа");
            dgvGraduations.Columns.Add("fio", "ФИО");
            dgvGraduations.Columns.Add("subjectname", "Предмет");
            dgvGraduations.Columns.Add("graduation", "Оценка");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            dataService.GetAllData(combFaculty, combGroup, combSubject);
            dataService.RefreshDataGrid(dgvGraduations, combFaculty, combGroup, combSubject);
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            dgvGraduations.Rows.Clear();
            dataService.Search(dgvGraduations, tbSearch.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранную запись?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int index = dgvGraduations.CurrentCell.RowIndex;
                dgvGraduations.Rows[index].Visible = false;
                var id = Convert.ToInt32(dgvGraduations.Rows[index].Cells[0].Value);

                dataService.DeleteRow(id);

                MessageBox.Show("Запись удалена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            var index = dgvGraduations.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvGraduations.Rows[index].Cells[0].Value);
            string faculty = dgvGraduations.Rows[index].Cells[1].Value.ToString();
            string group = dgvGraduations.Rows[index].Cells[3].Value.ToString();
            string fio = dgvGraduations.Rows[index].Cells[4].Value.ToString();
            string subject = dgvGraduations.Rows[index].Cells[5].Value.ToString();
            int graduation = Convert.ToInt32(dgvGraduations.Rows[index].Cells[6].Value);
            FormChangeGraduation formChangeGraduation = new FormChangeGraduation(id, faculty, group, fio, subject, graduation);
            formChangeGraduation.Show();
        }
        private void pbClear_Click(object sender, EventArgs e)
        {
            combFaculty.SelectedIndex = -1;
            combGroup.SelectedIndex = -1;
            combSubject.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddGraduation formAddGraduation = new FormAddGraduation();
            formAddGraduation.Show();
        }

        private void combFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            combGroup.SelectedIndex = -1;
            combGroup.Items.Clear();
            dataService.GetGroupsCollectionWithFaculty(combGroup, combFaculty.SelectedItem.ToString());
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            combFaculty.Items.Clear();
            combGroup.Items.Clear();
            combSubject.Items.Clear();
            dataService.GetAllData(combFaculty, combGroup, combSubject);
            dataService.RefreshDataGrid(dgvGraduations, combFaculty, combGroup, combSubject);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataService.RefreshDataGrid(dgvGraduations, combFaculty, combGroup, combSubject);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormAddSubject formAddSubject = new FormAddSubject();
            formAddSubject.Show();
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

        private void llblDeleteFaculty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDeleteFaculty formDeleteFaculty = new FormDeleteFaculty();
            formDeleteFaculty.Show();
        }

        private void llblDeleteGroup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDeleteGroup formDeleteGroup = new FormDeleteGroup();
            formDeleteGroup.Show();
        }

        private void llblDeleteSubject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDeleteSubject formDeleteSubject = new FormDeleteSubject();
            formDeleteSubject.Show();
        }
    }
}