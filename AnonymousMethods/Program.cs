using System;

namespace AnonymousMethods
{
    class Program
    {
        public delegate void Print(int value);
        static void Main(string[] args)
        {
            int i = 10;
            Print print = delegate (int val)
            {
                val += i;
                Console.WriteLine("Inside Anynous method. Value: {0}", val);
            };
            print(100);
            //AnonymousMethod as parameter
            PrintHelperMethod(delegate (int val)
            {
                Console.WriteLine("Anonymous method: {0}",val);
            }, 100);
            
        }

        public static void PrintHelperMethod(Print printDel, int val) {
            val += 10;
            printDel(val);
        }
    }
}
