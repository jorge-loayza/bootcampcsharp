using System;

namespace AnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new
            {
                Id = 1,
                FirstName = "James",
                Lastname = "Bond",
                Address = new
                {
                    Id = 1,
                    City = "London",
                    Contry = "UK"
                }
            };
            
            Console.WriteLine(student.Id);
            Console.WriteLine(student.FirstName);
            Console.WriteLine(student.Lastname);
        }
    }
}
