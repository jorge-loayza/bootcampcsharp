using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Bill");

            var arrayList2 = new ArrayList() {
                2,"pepe", true,null
            };

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            foreach (var item in arrayList2)
            {
                Console.WriteLine(item);
            }

            //Don't: ArrayList<int> arrayList3 = new ArrayList<int>();

            //Add Range
            var arrayList4 = new ArrayList();
            int[] array1 = { 100, 200, 300, 400 };

            Queue queue = new Queue();
            queue.Enqueue("Data");

            arrayList4.AddRange(arrayList2);
            arrayList4.AddRange(array1);
            arrayList4.AddRange(queue);
            //Accessing
            int testInt = (int)arrayList2[0];
            string testStrint = (string)arrayList2[1];

            //Remove
            arrayList4.Remove(null);
            arrayList4.Remove(4);
            arrayList4.RemoveRange(3,2);


            //List<T>
            var students = new List<Student>() { 
            new Student(){ Id = 1, Name ="Pepe"},
            new Student(){ Id = 2, Name ="Steve"},
            new Student(){ Id = 2, Name ="Maria"}
            };

            string[] cities = new string[3] { "Mumbai", "London", "New York" };
            var popularCities = new List<string>();
            popularCities.AddRange(cities);
            var favouritesCities = new List<string>();
            favouritesCities.AddRange(popularCities);

            Console.WriteLine(popularCities[0]);

            popularCities.ForEach(city => Console.WriteLine(city));


            //Linq
            var result = from s in students
                         where s.Name == "Maria"
                         select s;

            foreach (var student in result)
                Console.WriteLine($"{student.Id}, {student.Name}");

            //Contains
            Console.WriteLine(popularCities.Contains("Mumbai"));

            //SortedList
            SortedList<int, string> numberNames = new SortedList<int, string>();
            numberNames.Add(3, "Three");
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(4, null);
            numberNames.Add(10, "Ten");
            numberNames.Add(5, "Five");

            foreach (KeyValuePair<int, string> item in numberNames)
            {
                Console.WriteLine($"{item.Key}, {item.Value}");
            }

            Console.WriteLine(numberNames[3]);
            numberNames[2] = "TWO";
            numberNames[11] = "eleven";

            Console.WriteLine(numberNames[2]);
            Console.WriteLine(numberNames[11]);

            Console.WriteLine("Dictionary\n\n");
            Dictionary<int, string> keyName = new Dictionary<int, string>();
            keyName.Add(1, "One");
            keyName.Add(2, "Two");
            keyName.Add(3, "Three");

            foreach (KeyValuePair<int,string> item in keyName)
                Console.WriteLine($"{item.Key}, {item.Value}");

            var cities2 = new Dictionary<string, string>
            {
                {"UK","London, Manchester, Birmingham" },
                {"USA","Chicago, New York, Washington" },
                {"India","Mumbai, New Delhi, Pune" },
            };

            foreach (KeyValuePair<string, string> item in cities2)
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");

            Console.WriteLine(cities2["USA"]);

            if (cities2.ContainsKey("USA"))
            {
                Console.WriteLine(cities2["USA"]);
            }


            string result2;

            if (cities2.TryGetValue("USA", out result2))
            {
                Console.WriteLine(result2);
            }

            for (int i = 0; i < cities2.Count; i++)
            {
                Console.WriteLine($"{cities2.ElementAt(i).Key}, {cities2.ElementAt(i).Value}");
            }
            cities2["UK"] = "Liverpool, Bristol";
            
            
            Console.WriteLine("HASHTABLE\n\n");
            Hashtable hashtable = new ();
            hashtable.Add(1, "One");
            hashtable.Add(2, "Two");

            Hashtable hashtable2 = new ()
            {
                {"UK","London, Manchester, Birmingham" },
                {"USA","Chicago, New York, Washington" },
                {"India","Mumbai, New Delhi, Pune" },
            };
            foreach (DictionaryEntry item in hashtable2)
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");

            Hashtable hashtable1FromDictionary = new(keyName);

            string fromHashTable = (string)hashtable2["USA"];
            hashtable2["OR"] = "Oruro";

            Console.WriteLine("STACK\n\n");

            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);


            //foreach (var item in myStack)
            //{
            //    Console.WriteLine(item + ",");
            //}

            while (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Pop());
            }
        }
    }

    internal class Student
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; }
    }
}
