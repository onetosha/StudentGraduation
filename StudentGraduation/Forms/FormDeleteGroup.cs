using Microsoft.Data.SqlClient;
using StudentGraduation.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGraduation
{
    public partial class FormDeleteGroup : Form
    {
        DataService dataService = new DataService();
        public FormDeleteGroup()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dataService.GetGroupsCollection(comboBox1);
        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранную запись?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                dataService.DeleteGroup(comboBox1.SelectedItem.ToString());
                MessageBox.Show("Запись удалена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.Items.Clear();
                dataService.GetGroupsCollection(comboBox1);
            }
        }
    }
}
