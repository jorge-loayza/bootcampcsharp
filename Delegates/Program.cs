using System;

namespace Delegates
{
    
    class Program
    {
        private delegate int MyDelegate(string input);
        public delegate void DisplayMessage(string input);

        public delegate int MyDelegateWithReturn(string input);

        public delegate T GenericDelegate<T>(T param1, T param2);

        static void Main(string[] args)
        {
            Program program = new();
            //int answer = program.MehodIWantToCall("Frog");
            //Console.WriteLine(answer);

            //MyDelegate myDelegate = new MyDelegate(program.MehodIWantToCall);
            //MyDelegate myDelegate = (string input) => input.Length;
            //MyDelegate myDelegate = program.MehodIWantToCall;
            //Console.WriteLine(myDelegate("test 123"));
            //Console.WriteLine(myDelegate.Invoke("test 123"));

            //Delegate as Parameter
            //DisplayMessage displayMessage = (string input) => Console.WriteLine(input);
            //UseMyDelegatePareameter(displayMessage);

            //DisplayMessage displayMessage1 = ClassA.WriteInformation;
            //DisplayMessage displayMessage2 = ClassB.WriteInformation;

            //DisplayMessage delegateOperations = displayMessage1 + displayMessage2;
            //delegateOperations("Hi :)");

            //DisplayMessage displayMessageWithLambda = (string input) => Console.WriteLine($"Called from lambda: {input}");
            //delegateOperations += displayMessageWithLambda;
            //delegateOperations("Hi :)");

            //delegateOperations = delegateOperations - displayMessage2;
            //delegateOperations("Hi3 :)");

            //delegateOperations -= displayMessage1;
            //delegateOperations("Hi4 :)");

            //MyDelegateWithReturn del1 = ClassA.GetSize;
            //MyDelegateWithReturn del2 = ClassB.GetSize;

            //MyDelegateWithReturn myDelegateWithReturnOperation = del1 + del2;

            //Console.WriteLine(myDelegateWithReturnOperation("parameter"));

            //GenericDelegate Delegates
            //GenericDelegate<int> sum = Sum;
            //Console.WriteLine(sum(10,20));

            //GenericDelegate<string> con = Concat;
            //Console.WriteLine(con("Hello ", "World!!!"));


            //Func delegate

            //Func<int, double, string> sumDelegate = Sum2;
            //Console.WriteLine(sumDelegate(10,20));

            //Action delegate
            //Action<string> writeLine = Console.WriteLine;
            //writeLine("Action with string parameter");

            //Predicate Delegate, always return bool
            Predicate<string> isUpper = IsUpperCase;
            bool result = isUpper("Hello World!!");
            Console.WriteLine(result);
        }

        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }
        public static string Sum2(int a, double b)
        {
            return "" + (a + (int)b);
        }

        public int MehodIWantToCall(string input)
        {
            return input.Length;
        }
        public static void UseMyDelegatePareameter(DisplayMessage displayMessage)
        {
            displayMessage("delegate from parameter");
        }
        public static int Sum(int val1, int val2)
        {
            return val1 + val2;
        }
       
        public static string Concat(string text1, string text2)
        {
            return text1 + text2;
        }
    }
   

    class ClassA
    {
        public static void WriteInformation(string input)
        {
            Console.WriteLine($"Called ClassA parameter: {input}");
        }
        public static int GetSize(string input)
        {
            return input.Length;
        }
        
    }
    class ClassB
    {
        public static void WriteInformation(string input)
        {
            Console.WriteLine($"Called ClassB parameter: {input}");
        }
        public static int GetSize(string input)
        {
            return input.Length;
        }
    }
}
