using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1	Create a data structure e.g. ArrayList or List that must store 5 objects of type ThirdYearStudent

            // Using List
           // List<ThirdYearStudent> tyStudents = new List<ThirdYearStudent>();

            // Using ArrayList (this is the one implemented).
            ThirdYearStudent[] tyStudents = new ThirdYearStudent[5];

            //2. Read Inputs -	Prompt the use for the following
             for(int i=0; i < 5; i++)
            {

                Console.Write("Enter Student Number: ");
                int studentNumber = Convert.ToInt16(Console.ReadLine());

                Console.Write("Enter Student Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Surname: ");
                string surname = Console.ReadLine();

                Console.Write("Enter course code: ");
                string courseCode = Console.ReadLine();

                Console.Write("Enter assignment Mark: ");
                int assignmentMark = Convert.ToInt16(Console.ReadLine());

                Console.Write("Enter Test Mark: ");
                int testMark = Convert.ToInt16(Console.ReadLine());


                //setting the object with user data.
                ThirdYearStudent tyStudent = new ThirdYearStudent();
                tyStudent.setStudent(studentNumber, name, surname, courseCode, assignmentMark, testMark);
                tyStudents[i] = tyStudent;
                Console.WriteLine("=======================================================================");
            }
            Console.WriteLine("");


            //Displaying the data  
            Console.WriteLine("Displaying Students data");
            for(int j = 0; j < 5; j++)
            {
                tyStudents[j].displayStudent();
                Console.WriteLine("***************************");
            }
            Console.WriteLine("");


            //Determine the average final mark of all the student’s objects populate in the data structure.
            Console.WriteLine("Finding the average final Mark of all the Students is: " + tyStudents.Average(x => x.finMark));
            ;

        }
    }
}
