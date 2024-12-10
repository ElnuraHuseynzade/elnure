using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st.Grades = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.WriteLine(string.Join(", ", st.Grades));
        }

    }

    
    
}
