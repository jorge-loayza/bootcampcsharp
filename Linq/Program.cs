using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new string[] { "Michael", "Pam", "Jim", "Dwight", "Angela", "Kevin", "Toby", "Creed" };

            //var query = names.Where(n => n.Length > 4);
            //var query = names.Where(new Func<string, bool>(MoreThanFour));
            var query = names
                .Where(MoreThanFour)
                .OrderBy(name => name.Length)
                .ThenBy(name => name);

            //Query Comprehension sintax
            query = from name in names
                    where name.Length >4
                    orderby name.Length, name
                    select name;

            var query2 = (from name in names
                     where MoreThanFour(name)
                     select name)
                     .Skip(3)
                     .Take(10);

            foreach (string item in query2)
            {
                Console.WriteLine(item);

            }

            var filteredExceptions = GetExceptions()
                .OfType<ArithmeticException>();

            foreach (var item in filteredExceptions)
            {
                //Console.WriteLine(item);
            }

            var group1 = new string[] { "Michael", "Maria", "Joel", "Joel" };
            var group2 = new string[] { "Bob", "Kevin", "Angela", "Adan", "Maria"};
            var group3 = new string[] { "Pepe", "Pedro" };

            ShowArray(group1, "Group 1");
            ShowArray(group2, "Group 2");
            ShowArray(group3, "Group 3");
            ShowArray(group1.Distinct(), "Group1.Distinct(group3): ");
            ShowArray(group1.Union(group3), "Group1.Union(group3): ");
            ShowArray(group1.Concat(group3), "Group1.Concat(group3): ");
            ShowArray(group1.Intersect(group2), "Group1.Intersect(group2): ");
            ShowArray(group1.Except(group2), "Group1.Except(group2): ");
            ShowArray(group1.Zip(group2, (p1, p2)=> $"{p1} mathched with {p2}"), "Group1.Except(group2): ");

            //Multithread LINQ
            //var watch = new Stopwatch();
            //Console.WriteLine("Press enter to start: ");
            //Console.ReadLine();
            //watch.Start();
            //IEnumerable<int> numbers = Enumerable.Range(1, 2_000_000_000);
            //var squares = numbers.Select(number => number * number).ToArray();
            //var squares = numbers.AsParallel().Select(number => number * number).ToArray();
            //watch.Stop();
            //Console.WriteLine("{0:#,##0} elapsed millisenconds.", arg0: watch.ElapsedMilliseconds);


            //Extension Methods
            List<Product> people = new List<Product>() {
                new Product(){ Id =1, Price = 35},
                new Product(){ Id =2, Price = 150},
                new Product(){ Id =3, Price = 650},
                new Product(){ Id =4, Price = 150},
                new Product(){ Id =5, Price = 15},
                new Product(){ Id =6, Price = 35},
                new Product(){ Id =7, Price = 650},
                new Product(){ Id =8, Price = 78},
                new Product(){ Id =9, Price = 35},
                new Product(){ Id =10, Price = 78},
             
            };

            Console.WriteLine(people.Average(p => p.Price));
            Console.WriteLine(people.Mode(p => p.Price));
            //The less commmon number
            //Console.WriteLine(people.UnMode(p => p.Price));
            Console.WriteLine(people.Median(p => p.Price));

        }
        public class Product
        {
            public int Id { get; set; }
            public int Price { get; set; }
        }

        public static void ShowArray(IEnumerable<string> group, string description)
        {
            Console.WriteLine("{0} {1}", description, string.Join(",", group.ToArray()));
        }
        public static bool  MoreThanFour (string text)
        {
            return text.Length > 3;
        }
        static Exception[] GetExceptions()
        {
            return new Exception[]
            {
                new ArgumentException(),
                new SystemException(),
                new IndexOutOfRangeException(),
                new InvalidOperationException(),
                new NullReferenceException(),
                new InvalidCastException(),
                new OverflowException(),
                new DivideByZeroException(),
                new ApplicationException()
            };
        }
    }
}
