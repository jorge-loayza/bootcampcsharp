using System;
using System.Collections.Generic;

namespace InterfacesClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            //Person[] people =
            //{
            //    new Person{ Name = "Simon"},
            //    new Person{ Name = "Pepe"},
            //    new Person{ Name = "Adam"},
            //    new Person{ Name = "Richard"},
            //    new Person{ Name = "Maria"},
            //};

            //foreach (var item in people)
            //{
            //    Console.WriteLine($"{item.Name}");
            //}

            ////Array.Sort(people);
            //Array.Sort(people, new PersonComparer());
            //Console.WriteLine("\n\nSorted");

            //foreach (var item in people)
            //{
            //    Console.WriteLine($"{item.Name}");
            //}


            //IPlayable dvDPlayer = new MP3Player();

            //dvDPlayer.Stop();

            Employee juan = new Employee
            {
                Name = "Juan",
                DateOfBirth = new DateTime(1990,7,28)
            };

            juan.EmplyeeCode = "111a";
            juan.HireDate = new DateTime(2014, 11, 20);
            Console.WriteLine($"{juan.Name} was gired on {juan.HireDate:dd/MM/yy}");
            //juan.WriteInformation();
            Console.WriteLine(juan);
        }
    }

    public class Employee : Person
    {
        public string EmplyeeCode { get; set; }
        public DateTime HireDate { get; set; }


        public override string ToString()
        {
            return $"{base.ToString()} and hired on { HireDate:dd/MM/yy}";
        }
    }
    public sealed class MysealedClass
    {

    }

    public class TesT
    {

    }

    public class Singer
    {
        public virtual void Sing()
        {
            Console.WriteLine("Singing...");
        }
    }
    public class LadyGaga: Singer
    {
        public sealed override void Sing()
        {
            Console.WriteLine("Singing with style...");
        }
    }
    //public class TestDinger : LadyGaga
    //{
    //    public sealed override void Sing()
    //    {
    //        Console.WriteLine("Singing with style...");
    //    }
    //}
    public class DvDPlayer : IPlayable
    {
        public void Pause()
        {
            Console.WriteLine("DVD player is in pause.");
        }

        public void Play()
        {
            Console.WriteLine("DVD payer is playing...");
        }
    }
    public class MP3Player : IPlayable
    {
        public void Pause()
        {
            Console.WriteLine("DVD player is in pause.");
        }

        public void Play()
        {
            Console.WriteLine("DVD payer is playing...");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping");
        }
    }

    public interface IPlayable
    {
        void Play();
        void Pause();
        void Stop()
        {
            Console.WriteLine("Default implementation for stop.");
        }
    }

    //class Person: IComparable<Person>
    //{
    //    public string Name {get; set;}

    //    public int CompareTo(Person otherPerson)
    //    {
    //        return Name.CompareTo(otherPerson.Name);
    //    }
    //}
    // From another dll
    public class Person
    {
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }
        public override string ToString()
        {
            return $"{Name} was born on a {DateOfBirth.DayOfWeek}";
        }
    }

    class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
