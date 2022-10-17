using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectConsoleApp
{
    internal class ArrayStudent
    {
        static void MainX()
        {
            int n;
            bool exit = true;
            //Student[] students = new Student[n];
            List<Student> lsStudent = new List<Student>();
            Console.WriteLine("****************STUDENT APPLICATION MANAGEMENT****************");
            while (exit)
            {
                Console.WriteLine("Please select menu");
                Console.WriteLine("1.Enter number 1 for add new student.");
                Console.WriteLine("2.Enter number 2 for add list student.");
                Console.WriteLine("3.Enter number not 1 2 for exit.");
                Console.Write("Enter Menu: ");
                n = int.Parse(Console.ReadLine());
                Console.Clear();
                if (n == 1)
                {
                    Console.WriteLine("******** ADD STUDENT*******");
                    Student student = new Student();
                    student.Input();
                    lsStudent.Add(student);
                }
                else if (n==2)
                {
                    Console.WriteLine("********STUDENT LIST*******");
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("ID\tName\tAge\tGender\tScore\tSubject");
                    foreach (Student student in lsStudent)
                    {
                        Console.WriteLine(student);
                    }
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine($"Tatal Student: {lsStudent.Count()}");
                    Console.WriteLine("--------------------");
                }
                else
                {
                    exit=false;
                }
            }

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Enter Studnet {i + 1}");
            //    students[i] = new Student();
            //    students[i].Input();
            //}

            
            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine(students[i]);
            //}

            //foreach (Student student in students)
            //{
            //    Console.WriteLine(student);
            //}

            //Console.ReadKey();
        }
    }
}
