using System;

namespace Generics
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //int a, b;
            //char c, d;
            //a = 10;
            //b = 20;
            //c = 'I';
            //d = 'V';

            //Console.WriteLine("Before calling swap:");
            //Console.WriteLine("a = {0}, b = {1}", a , b);
            //Console.WriteLine("c = {0}, d = {1}", c , d);

            //Swap<int>(ref a, ref b);
            //Swap<char>(ref c, ref d);

            //Console.WriteLine("Before calling swap:");
            //Console.WriteLine("a = {0}, b = {1}", a, b);
            //Console.WriteLine("c = {0}, d = {1}", c, d);

            //MyGeneric<Example> name = new MyGeneric<Example>();

            Person.Unique.Name = "pepe";
            Console.WriteLine(Person.Unique.Name);
            
            
        }
        class Person : UniqueInstance<Person>
        {
        
            public string Name;
        }

        class UniqueInstance<T> where T: new()
        {
            public static T Unique = new();
        }






        public class MyGeneric<T> where T: Example2
        {


        }
        public class Example : Example2
        {
            public Example()
            {

            }
        }
        public class Example2
        {
            public Example2()
            {

            }
        }
        public class Example3
        {
            public Example3()
            {

            }
        }
        public static void Swap<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }
    }

   
}
