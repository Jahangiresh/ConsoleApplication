using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFinish
{
    class ServiceCode : IServiceCode
    {
        private List<Group> _groups = new List<Group>();
        public List<Group> Groups => _groups;
        public string CreateGroup(int online, int offline, string students, Category categories, string no) 
        {
            for (int i = 0; i <no.Length; i++)
            {

                if (no.Length == 4 && char.IsUpper(no[0]) && char.IsDigit(no[++i]))
                {
                    
                }

                else
                {
                    return "please type again";
                }
            }
            Group group = new Group(online,offline,students,categories,no);
            _groups.Add(group);
            return group.No;
        }

        


        //public string ShowGroupLits()
        //{
        //    throw new NotImplementedException();
        //}

        //public string EditGroupMembers()
        //{
        //    throw new NotImplementedException();
        //}

        //public string GroupStudentsList()
        //{
        //    throw new NotImplementedException();
        //}

        //public string AllStudentsList()
        //{
        //    throw new NotImplementedException();
        //}


        //public string CreateStudent()
        //{
        //    throw new NotImplementedException();
        //}





    }
}
