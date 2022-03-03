using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFinish
{
    class Group
    {
        public string No;
        public Category Categories;
        public bool IsOnline;
        public int[,] Limit;
        public string Students;
        public static int count=127;
        public static int count1=101;
        public static int count2=334;
        public Group(  int online, int offline, string students,Category categories, string no)
        {

            switch (Categories)
            {
                case Category.Programming:
                    No = $"P-{count}";
                    break;
                case Category.Design:
                    No = $"D-{count}";
                    
                    break;
                case Category.System_Administration:
                    No = $"S-{count}";
                    
                    break;
                default:
                    break;
            }
            Categories = categories;
            IsOnline = false;
            Limit = new int[online, offline];
            No = no;

            
        }

    }

}
