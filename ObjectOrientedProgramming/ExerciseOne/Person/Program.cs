using System;
using Classes;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Stephen", 22);
            Console.WriteLine($"Hi {student.GetName()}, you are {student.GetAge()}");
        }
    }
}
