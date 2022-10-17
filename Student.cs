using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectConsoleApp
{
    internal class Student
    {
        public int id;
        public string name;
        public string gender;
        public double score;
        public double age;
        public string subject;

        public Student()
        {
            id = 1;
            name = "Long Dara";
            gender = "Male";
            age = 18;
            score = 80.50;
            subject = "Web Base";
        }

        public Student(int id, string name, string gender, double score, string subject)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.score = score;
            this.subject = subject;
        }

        public void Input()
        {
            Console.Write("Enter ID = ");
            id = int.Parse(Console.ReadLine());
            gender = Console.ReadLine();
            Console.Write("Enter Name = ");
            name = Console.ReadLine();
            Console.Write("Enter Age = ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter Gender = ");
            Console.Write("Enter Scores= ");
            score = double.Parse(Console.ReadLine());
            Console.Write("Enter Subject = ");
            subject = Console.ReadLine();
            Console.WriteLine("--------------------------");
        }

        public override string ToString()
        {
            return $"{id:000}\t{name}\t{age}\t{gender}\t{score}\t{subject}";
        }
    }
}
