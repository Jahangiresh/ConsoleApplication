using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleAppFinal
{
    class ServiceCode : IServiceCode
    {
        private List<Group> _groups = new List<Group>();
        public List<Group> Groups => _groups;
        private List<Student> _students => new List<Student>();
        public List<Student> Students => _students;
        public string CreateGroup(int online, int offline, Category categories, string no)
        {
            if (no.Length!=4)
            {
                return "please choose correct group name";
            }
            Group group = new Group(online, offline, categories, no);
            _groups.Add(group);
            return group.No;
        }
        public void ShowGroups()
        {
            if (_groups.Count==0)
            {
                Console.WriteLine("there is no group in this Academy");
                return;
            }
            foreach (Group group in _groups)
            {
                Console.WriteLine(group);
            }
        }

        public void EditGroupName(string no,string newNo)
        {
            Group existedGroup = FindGroup(no);
           
            if (existedGroup == null)
            {
                Console.WriteLine("plese choose correct grup num");
                return;
            }
           
            foreach (Group group in _groups)
            {
                if (group.No==newNo)
                {
                    Console.WriteLine($"{newNo} group is already exist");
                }
            }
            existedGroup.No = newNo;
        }
        public Group FindGroup(string no)
        {
            foreach (Group group in _groups)
            {
                if (group.No == no)
                {
                    return group;
                }
            }
            return null;
        }

        public void GetGroupStudents(string no)
        {
            Group group = FindGroup(no);
            if (group==null)
            {
                Console.WriteLine("pls choosevalid group no");
                return;
            }
            foreach (Student student in group.Students)
            {
                Console.WriteLine(student);
            }
        }
        public void GetAllStudents(Student[] Students)
        {
            foreach (Student student in Students)
            {
                Console.WriteLine(student);
            }
        }


        public string CreateStudent(string fullname,string groupno)
        {
            if (fullname.Length!=2)
            {
                return "please typevalid Student Name";
            }
            Student student = new Student(fullname,groupno);
            _students.Add(student);
            return student.Fullname;

        }
    }
}