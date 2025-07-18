namespace ConstructorsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BATCH IS " +  Student.batch);
           Student s1 = new Student(); // this will call def constr
            s1.GetDetails();
            s1.DisplayDetails();

            Student s2= new Student(2); // this shud call another constr, para const
            s2.DisplayDetails();

            Student s3 = new Student(3, "ajay");  //this shud call another constr, para const

            s3.DisplayDetails();

            Student s4 = new Student(4, "deepak", 89);
            s4.DisplayDetails();

            Student s5 = new Student(s3); // this will call copy const
            s5.DisplayDetails();
        }  
    }
}
