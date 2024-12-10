using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Student
    {
        private int[] grades;

        public int[] Grades
        {
            get { return grades; }
            set
            {
                grades = value.Where(x => x % 2 == 0).ToArray();
            }
        }

    }
}
