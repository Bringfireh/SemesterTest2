using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterTest2
{
    class Student
    {
        protected  int studentNumber;
        protected string name;
        protected string surname;

        public Student()
        {
            studentNumber = 0;
            name = null;
            surname = null;
        }
        public void setStudent(int num, string n, string s)
        {
            studentNumber = num;
            name = n;
            surname = s;
        }
        public virtual void displayStudent()
        {
            Console.WriteLine("\n" + studentNumber + " " + name + " " + surname);
        }
    }
}
