using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassA obj = new ClassA();
            obj.Test1();
            //Calling exrension methods
            obj.Test2();
            obj.Test3(10);
            obj.Test4();
            
            string myWord = "The string example for extension methods.";
            int wordCount = myWord.GetWordCount();
            Console.WriteLine("String : " + myWord);
            Console.WriteLine("Count : " + wordCount);

        }
    }
    public class ClassA
    {
        public int x = 100;
        public void Test1()
        {
            Console.WriteLine("Method one: " + this.x);
        }
    }
    public static class ClassB
    {
        public static void Test2(this ClassA classA)
        {
            Console.WriteLine("Method Two");
        }
        public static void Test3(this ClassA classA, int x)
        {
            Console.WriteLine("Method Three: " + x);
        }
        public static void Test4(this ClassA classA)
        {
            Console.WriteLine("Method Four:" + classA.x);
        }
    }

    public static class StringExtension
    {
        public static int GetWordCount(this string inputstring)
        {
            if (!string.IsNullOrEmpty(inputstring))
            {
                string[] strArray = inputstring.Split(' ');
                return strArray.Length;
            }
            else
            {
                return 0;
            }

        }
    }
}
