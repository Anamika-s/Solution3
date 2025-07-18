using System.Collections;

namespace OopsDemo
{
    //int num;  Int32
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            // object declaration
            Student student; // instance of a class > object
            student = new Student();
            // new keyword will allocate memory
            // // on heap

            Student student1 = new Student();
            // nwe keyword will do 2 things
            // 1. it allocates memory on heap
            // 2. it calls/invokes constructor to initialize member variables

            //int num1, num2, num3, num4;
            //student1.GetDetails();
            //student1.DisplayDetails();
            // declare 3 objects
            //Student s1 = new Student();
            //Student s2 = new Student(); 
            //Student s3 = new Student();
            //Console.WriteLine("enter details of student 1 ");
            //s1.GetDetails();
            //Console.WriteLine("enter details of student 2 ");
            //s2.GetDetails();
            //Console.WriteLine("enter details of student 3 ");
            //s3.GetDetails();
            //Console.WriteLine("Details of student 1");
            //s1.DisplayDetails();
            //Console.WriteLine("Details of student 2");
            //s2.DisplayDetails();
            //Console.WriteLine("Details of student 3");
            //s3.DisplayDetails();
            // Array of objects

            //Student[] students = new Student[10];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("enter details of student no " + (i + 1));
            //    students[i] = new Student();
            //    students[i].GetDetails();
            //}
            //foreach(Student temp in students)
            //{
            //      if(temp!=null)
            //    {
            //        temp.DisplayDetails();
            //    }
            //
            //}

            // collection to store objects
            //ArrayList students = new ArrayList();   
            //Student s1= new Student();
            //s1.GetDetails();
            //students.Add(s1);
            //Student s2 = new Student();
            //s2.GetDetails();
            //students.Add(s2);
            //Student s3 = new Student();
            //s3.GetDetails();
            //students.Add(s3);
            ////students.Add(1);
            //foreach (Student s in students)
            //{
            //    s.DisplayDetails();
            //}

            Console.WriteLine("College Name " + Student.collegeName);
            //Student.batch = "DotNet";
            //Console.WriteLine("Batch Name " + Student.batch);
            Student.BatchDetails();
            List<Student> students = new List<Student>();
            Student s1 = new Student();
            s1.GetDetails();
            students.Add(s1);
            Student s2 = new Student();
            s2.GetDetails();
            students.Add(s2);
            Student s3 = new Student();
            s3.GetDetails();
            students.Add(s3);
            //students.Add(1);
            foreach (Student s in students)
            {
                s.DisplayDetails();
            }















        }
    }
}
