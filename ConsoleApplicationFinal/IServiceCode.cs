using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFinal

{
    interface IServiceCode
    {
        public List<Group> Groups { get; }
        public List<Student> Students { get; }
        public string CreateGroup(int online, int offline, Category categories, string no);
        public string ShowGroups();
        public string EditGroupName(string no,string newNo);
        public string GetGroupStudents(string no);
        public string GetAllStudents(Student[] Students);
        public string CreateStudent(string fullname);


    }
}