using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsDemo
{
    class Student
    {
        int rn;
        string name;
        public static string batch;
        int score;
        public const string collegeName = "ABC";
        public Student() { }  // def constructor

        public Student(int rn)  // para constr
        {

        this.rn = rn;
            Console.WriteLine("enter name");
            name = Console.ReadLine();
             
            Console.WriteLine("enter score");
            score = byte.Parse(Console.ReadLine());
        }

        public Student(int rn, string name)
        {
            this.rn = rn;
            this.name = name;
            Console.WriteLine("enter score");
            score = byte.Parse(Console.ReadLine());

        }
        // fully para constr
        public Student(int rn, string name, int score)
        {
            this.rn = rn;
            this.name = name;
            this.score = score;
        }
            public static void BatchDetails()
        {
            //name = "aaa";
            batch = "DotNet";
            Console.WriteLine("Batch is " + batch);

        }

        // static cosnt
        // will be parameterless , no access specifier, can be only 1 in a class
//  good place to initialze all static variables of class
// this cons will be always invoked first before any other constr
        static Student()
        {
            batch = "DotNet Fullstack";
        }

        public Student(Student student) // copy const
        {
            Console.WriteLine("enter rn");
            rn = byte.Parse(Console.ReadLine());
            this.name = student.name;
            this.score = student.score;
        }
        public void GetDetails()
        {

            Console.WriteLine("enter rn");
            rn = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            //Console.WriteLine("enter batch");
            //batch = Console.ReadLine();
            Console.WriteLine("enter score");
            score = byte.Parse(Console.ReadLine());

        }
        public void DisplayDetails()
        {
            Console.WriteLine($"RN is {rn}");
            Console.WriteLine($"Name is {name}");
            //Console.WriteLine($"Batch is {batch}");
            Console.WriteLine($"Score is {score}");
        }


    }
}
