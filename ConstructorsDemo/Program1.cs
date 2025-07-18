using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Program1
    {
        static void Main()
        {
             Student student = new Student();
            student.Rn = 10;
            Console.WriteLine("rn is " + student.Rn);
            // how to initialize object using property
            // Object initializer
            Student student1 = new Student()
            {
                Rn = 10,
                Name = "Deepak",
                Age = 19,
                Score = 90
            };

            // List initializer
            List<Student> students = new List<Student>()
            {
                new Student (){ Rn=1, Name="a", Age=19, Score=89},
                new Student (){ Rn=2, Name="a1", Age=19, Score=89},
                new Student (){ Rn=3, Name="a2", Age=19, Score=89},
                new Student (){ Rn=4, Name="a3", Age=19, Score=89},
                new Student (){ Rn=5, Name="a4", Age=19, Score=89},
                new Student (){ Rn=6, Name="a5", Age=19, Score=89}

            };

            Console.WriteLine("List of students");

            foreach (Student student2 in students)
            {
                Console.WriteLine(student2.Rn + " " + student2.Name + " " + student2.Age + " " + student2.Score); ;

            }







            }
    }
}
