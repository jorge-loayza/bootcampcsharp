using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recursive aproach
            //Fibonacci_Recursive(5);

            //Common aproach
            Fibonacci(4);
            Console.ReadKey(true);
        }
        static void Fibonacci(int n)
        {
            int n1 = 0, n2 = 1, sum =0;
          
            Console.Write("{0} {1}", n1, n2);

            for (int i = 2; i < n; i++)
            {
                sum = n1 + n2;
                Console.Write(" {0}", sum);
                n1 = n2;
                n2 = sum;
        
            }
        }

        //Recursive method
        public static void Fibonacci_Recursive(int len)
        {
            Fibonacci_Rec_Temp(0, 1, 1, len);
        }
        private static void Fibonacci_Rec_Temp(int a, int b, int counter, int len)
        {
            if (counter <= len)
            {
                Console.Write("{0} ", a);
                Fibonacci_Rec_Temp(b, a + b, counter + 1, len);
            }
        }
    }
}
