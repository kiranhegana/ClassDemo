using System;
namespace ClassDemo
{
    class Student
    {
        string _firstName;
        string _lastName;

        public Student(string Fname, string Lname)
        {
            _firstName = Fname;
            _lastName = Lname;
        }
        public void FullName()
        {
            Console.WriteLine("Full Name of Student = {0} {1}",_firstName,_lastName);
        }
    }
    class Program
    {
        static void Main()
        {
            string FN, LN;
            Console.WriteLine("Enter the First Name  ");
            FN = Console.ReadLine();

            Console.WriteLine("Enter the Last Name  ");
            LN = Console.ReadLine();

            Student std = new Student(FN,LN);
            std.FullName();

            Console.ReadLine();
        }
    }
}
