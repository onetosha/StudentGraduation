using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace StudentGraduation
{
    public class DBService
    {
        DataBase dataBase = new DataBase();
        public DBService()
        {
            
        }
        private List<string> Getter(string query)
        {
            List<string> result = new List<string>();
            dataBase.OpenConnection();
            SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(reader.GetString(0));
            }
            reader.Close();
            dataBase.CloseConnection();
            return result;
        }
        private void Deleter(string query)
        {
            dataBase.OpenConnection();
            SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
            command.ExecuteNonQuery();
            dataBase.CloseConnection();
        }
        public List<string> GetStudents()
        {
            var query = $"select s.fio from students s";
            return Getter(query);
        }
        public List<string> GetStudentsWhithGroup(string groupName)
        {
            var query = $"select s.fio from students s left join groups g on g.id=s.groupid where groupname = '{groupName}'";
            return Getter(query);
        }
        public List<string> GetFaculties()
        {
            var query = $"select facultyname from faculties";
            return Getter(query);
        }

        public List<string> GetGroups()
        {
            var query = $"select groupname from groups";
            return Getter(query);
        }
        public List<string> GetGroupsWithFaculty(string facultyName)
        {
            var query = $"select g.groupname from dbo.groups g left join faculties f on f.id = g.facultyid where f.facultyname='{facultyName}'";
            return Getter(query);
        }
        public List<string> GetSubjects()
        {
            var query = $"select subjectname from subjects";
            return Getter(query);
        }

        public bool AddFaculty(string facultyName)
        {
            dataBase.OpenConnection();
            if (facultyName != "")
            {
                var query = $"insert into faculties (facultyname) values ('{facultyName}')";
                SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
                command.ExecuteNonQuery();
                dataBase.CloseConnection();
                return true;
            }
            else
            {
                dataBase.CloseConnection();
                return false;
            }
        }
        public bool AddGroup(string facultyName, string groupName)
        {
            dataBase.OpenConnection();
            string query = $"select id from faculties where facultyname = '{facultyName}'";
            SqlCommand tempcommand = new SqlCommand(query, dataBase.GetConnection());
            SqlDataReader reader = tempcommand.ExecuteReader();
            int facultyid = 0;
            while (reader.Read())
            {
                facultyid = reader.GetInt32(0);
            }
            dataBase.CloseConnection();
            dataBase.OpenConnection();
            if (groupName != "" && facultyid != 0)
            {
                query = $"insert into groups (groupname, facultyid) values ('{groupName}', '{facultyid}')";
                SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
                command.ExecuteNonQuery();
                dataBase.CloseConnection();
                return true;
            }
            else
            {
                dataBase.CloseConnection();
                return false;
            }
        }
        public bool AddSubject(string subjectName)
        {
            dataBase.OpenConnection();
            if (subjectName != "")
            {
                var query = $"insert into subjects (subjectname) values ('{subjectName}')";
                SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
                command.ExecuteNonQuery();
                dataBase.CloseConnection();
                return true;
            }
            else
            {
                dataBase.CloseConnection();
                return false;
            }
        }
        public bool AddStudent(string fio, string birthday, string groupname, int ndyear, int numberOfCredit)
        {
            dataBase.OpenConnection();
            string tempquery = $"select id from groups where groupname='{groupname}'";
            SqlCommand tempcommand = new SqlCommand(tempquery, dataBase.GetConnection());
            SqlDataReader reader = tempcommand.ExecuteReader();

            int groupid = -1;
            while (reader.Read())
            {
                groupid = reader.GetInt32(0);
            }
            dataBase.CloseConnection();
            dataBase.OpenConnection();
            if (fio != "" && birthday != "" && groupid > 0)
            {
                var query = $"insert into students (fio, birthday, groupid, ndyear, numberofcredit) values ('{fio}', '{birthday}', '{groupid}', '{ndyear}', '{numberOfCredit}')";
                SqlCommand command = new SqlCommand(query, dataBase.GetConnection());

                command.ExecuteNonQuery();

                dataBase.CloseConnection();
                return true;
            }
            else
            {
                dataBase.CloseConnection();
                return false;
            }
        }
        public bool AddGraduation(string fio, string subjectName, int graduation)
        {
            dataBase.OpenConnection();
            string query = $"select id from students where fio = '{fio}'";
            SqlCommand tempcommand = new SqlCommand(query, dataBase.GetConnection());
            int studentid = 0;
            SqlDataReader reader = tempcommand.ExecuteReader();
            while (reader.Read())
            {
                studentid = reader.GetInt32(0);
            }
            int subjectid = 0;
            dataBase.CloseConnection();
            dataBase.OpenConnection();
            query = $"select id from subjects where subjectname = '{subjectName}'";
            tempcommand = new SqlCommand(query, dataBase.GetConnection());
            reader = tempcommand.ExecuteReader();
            while (reader.Read())
            {
                subjectid = reader.GetInt32(0);
            }

            dataBase.CloseConnection();
            dataBase.OpenConnection();
            if (studentid != 0 && subjectid != 0 && graduation != 0)
            {
                query = $"insert into graduations (studentid, subjectid, graduation) values ('{studentid}', '{subjectid}', '{graduation}')";
                SqlCommand command = new SqlCommand(query, dataBase.GetConnection());

                command.ExecuteNonQuery();

                dataBase.CloseConnection();
                return true;
            }
            else
            {
                dataBase.CloseConnection();
                return false;
            }
        }
        public void ChangeGraduation(int graduation, int id)
        {
            dataBase.OpenConnection();
            var query = $"update graduations set graduation = '{Convert.ToInt32(graduation)}' where id = '{id}'";
            var command = new SqlCommand(query, dataBase.GetConnection());
            command.ExecuteNonQuery();
            dataBase.CloseConnection();
        }
        public void DeleteFaculty(string faculty)
        {
            var query = $"delete from faculties where facultyname = '{faculty}'";
            Deleter(query);
        }
        public void DeleteGroup(string group)
        {
            var query = $"delete from groups where groupname = '{group}'";
            Deleter(query);
        }
        public void DeleteSubject(string subject)
        {
            var query = $"delete from faculties where facultyname = '{subject}'";
            Deleter(query);
        }
        public void DeleteRow(int id)
        {
            var query = $"delete from graduations where id = '{id}'";
            Deleter(query);
        }
        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetInt32(6));
        }
        public void RefreshDataGrid(DataGridView dgv, ComboBox combFaculty, ComboBox combGroup, ComboBox combSubject)
        {
            dgv.Rows.Clear();
            string query = $"select \r\n\tg.id,\r\n\tf.facultyname,\r\n\ts.ndyear,\r\n\tgr.groupname,\r\n\ts.fio,\r\n\tsub.subjectname,\r\n\tg.graduation\r\nfrom \r\n\tdbo.graduations g\r\n\tleft join dbo.students s on s.id = g.studentid\r\n\tleft join dbo.subjects sub on sub.id = g.subjectid\r\n\tleft join dbo.groups gr on gr.id = s.groupid\r\n\tleft join dbo.faculties f on f.id = gr.facultyid";
            if (combFaculty.SelectedIndex != -1 || combGroup.SelectedIndex != -1 || combSubject.SelectedIndex != -1)
            {
                bool flagwhere = true;
                query += " where";
                if (combFaculty.SelectedIndex != -1)
                {
                    flagwhere = false;
                    query += $" f.facultyname='{combFaculty.SelectedItem}'";
                }
                if (combGroup.SelectedIndex != -1)
                {
                    if (flagwhere)
                    {
                        query += $" gr.groupname='{combGroup.SelectedItem}'";
                    }
                    else
                    {
                        query += $" and gr.groupname='{combGroup.SelectedItem}'";
                    }
                }
                if (combSubject.SelectedIndex != -1)
                {
                    if (flagwhere)
                    {
                        query += $" sub.subjectname='{combSubject.SelectedItem}'";
                    }
                    else
                        query += $" and sub.subjectname='{combSubject.SelectedItem}'";
                }
            }

            SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
            dataBase.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();

            dataBase.CloseConnection();
        }
        public void Search(DataGridView dgvGraduations, string searchstr)
        {
            string query = $"select \r\n\tg.id,\r\n\tf.facultyname,\r\n\ts.ndyear,\r\n\tgr.groupname,\r\n\ts.fio,\r\n\tsub.subjectname,\r\n\tg.graduation\r\nfrom \r\n\tdbo.graduations g\r\n\tleft join dbo.students s on s.id = g.studentid\r\n\tleft join dbo.subjects sub on sub.id = g.subjectid\r\n\tleft join dbo.groups gr on gr.id = s.groupid\r\n\tleft join dbo.faculties f on f.id = gr.facultyid\r\nwhere\r\n\tconcat (g.id, f.facultyname, s.ndyear, gr.groupname, s.fio, sub.subjectname, g.graduation) like '%" + searchstr + "%'";

            SqlCommand command = new SqlCommand(query, dataBase.GetConnection());

            dataBase.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgvGraduations, reader);
            }
            reader.Close();
        }
        public bool LogIn(string login, string password)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user from register where login_user = '{login}' and password_user = '{password}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckUser(string login, string password)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select login_user, password_user from register where login_user = '{login}' and password_user = '{password}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool SignUp(string login, string password)
        {
            string querystring = $"insert into register (login_user, password_user) values ('{login}', '{password}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());

            dataBase.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                dataBase.CloseConnection();
                return true;
            }
            else
            {
                dataBase.CloseConnection();
                return false;
            }
        }
    }
}
