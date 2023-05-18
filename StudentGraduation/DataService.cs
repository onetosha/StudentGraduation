using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGraduation
{
    public class DataService : DBService
    {
        DBService dBService = new DBService();
        public DataService()
        {

        }

        private void GetItems(ComboBox comboBox, List<string> list)
        {
            foreach (var i in list)
            {
                comboBox.Items.Add(i);
            }
        }
        public void GetStudentCollection(ComboBox combStudent)
        {
            GetItems(combStudent, dBService.GetStudents());
        }
        public void GetStudentsCollectionWithGroup(ComboBox combStudent, string groupName)
        {
            GetItems(combStudent, dBService.GetStudentsWhithGroup(groupName));
        }
        public void GetFacultiesCollection(ComboBox combFaculties)
        {
            GetItems(combFaculties, dBService.GetFaculties());
        }
        public void GetGroupsCollection(ComboBox combGroups)
        {
            GetItems(combGroups, dBService.GetGroups());
        }
        public void GetGroupsCollectionWithFaculty(ComboBox combGroups, string facultyName)
        {
            GetItems(combGroups, dBService.GetGroupsWithFaculty(facultyName));
        }
        public void GetSubjectsCollection(ComboBox combSubjects)
        {
            GetItems(combSubjects, dBService.GetSubjects());
        }
        public void GetAllData(ComboBox combFaculties, ComboBox combGroups, ComboBox combSubjects)
        {
            GetFacultiesCollection(combFaculties);
            GetGroupsCollection(combGroups);
            GetSubjectsCollection(combSubjects);
        }
        public void GetAllDataWithStudents(ComboBox combFaculties, ComboBox combGroups, ComboBox combSubjects, ComboBox combStudents)
        {
            GetFacultiesCollection(combFaculties);
            GetGroupsCollection(combGroups);
            GetSubjectsCollection(combSubjects);
            GetStudentCollection(combStudents);
        }
    }
}
