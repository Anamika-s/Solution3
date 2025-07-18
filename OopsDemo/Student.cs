using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    //encapsulation > binding of the members of a class
    //abstraction > means hiding/showing details
    // they go side by side
    // acheived thru access specifiers
    // 1. private  // by def all the members of a class are private, cannot access them outside the class 
    // 2. public  // the members which we can access outside the class
    // 3. internal // by def class is internal, can be accessesd in same assembly/project
    // 4. protected   // used in inheritance
    // 5. internal protected  // used in inheritance
    // Data hiding > data shud be hidden from outside the class
    class Student
    {
        int rn;
        string name;
        string batch;
        int score;
        public void GetDetails()
        {
            Console.WriteLine("enter rn");
            rn = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter batch");
            batch = Console.ReadLine();
            Console.WriteLine("enter score");
            score = byte.Parse(Console.ReadLine());

        }
        public void DisplayDetails()
        {
            Console.WriteLine($"RN is {rn}");
            Console.WriteLine($"Name is {name}");
            Console.WriteLine($"Batch is {batch}");
            Console.WriteLine($"Score is {score}");
        }


    }
}
