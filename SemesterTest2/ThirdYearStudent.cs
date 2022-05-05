using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterTest2
{
    class ThirdYearStudent:Student
    {
        public string code;
        public int assignment;
        public int test;
        public double yearMark;
        public double finMark;

        public ThirdYearStudent()
        {
            code = null;
            assignment = 0;
            test = 0;
        }

        public void setStudent(int studentNumber, string name, string surname,string subjectCode, int assignmentMark, int testMark)
        {
            setStudent(studentNumber, name, surname);
            code = subjectCode;
            assignment = assignmentMark;
            test = testMark;
        }
        public double calcYearMark(int assignment, int test)
        {
            double studentYearMark = (assignment * (45 / 100)) +( test * (55 / 100));
            return studentYearMark;
        }
        public double finalMark(double yearMark)
        {
            Random random = new Random();
            int examMark = random.Next(15, 99);
            double final = (yearMark + examMark) / 2;
            return final;
        }
        public override void displayStudent()
        {
            Console.WriteLine("\n" + studentNumber + " " + name + " " + surname);
                yearMark = calcYearMark(assignment, test);
                finMark = finalMark(yearMark);
            Console.WriteLine("\n" + code + " " + assignment + " " + test + " " + yearMark + " " + finMark );

        }
    }
}
