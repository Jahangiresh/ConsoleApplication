using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFinish
{
    interface IServiceCode
    {
        public List<Group> Groups { get; }
        public string CreateGroup(int online, int offline, string students, Category categories, string no);
        //public string ShowGroupLits();
        //public string EditGroupMembers();
        //public string GroupStudentsList();
        //public string AllStudentsList();
        //public string CreateStudent();


    }
}
