using System;
using System.Collections.Generic;

namespace DelegatesExercise
{
    class Program
    {
        
        public enum Operation { Sum, Subtract, Multiply }
        static void Main(string[] args)
        {
            Expresion expresion = new(20, 10);
            var result = expresion.ApplyOperator(Operation.Sum);
            Console.WriteLine($"Result: {result}");
        }
        public class Expresion
        {
            public IDictionary<Operation, Func<int>> Operations = new Dictionary<Operation, Func<int>>();
            private int first;
            private int second;
            public Expresion(int first, int second)
            {
                this.first = first;
                this.second = second;
                Operations.Add(Operation.Sum, Sum);
                Operations.Add(Operation.Subtract, Subtract);
                Operations.Add(Operation.Multiply, Multiply);
            }
            public int Sum()
            {
                return this.first + this.second;
            }
            private int Subtract()
            {
                return first - second;
            }
            private int Multiply()
            {
                return first * second;
            }
            public int ApplyOperator(Operation operation)
            {

                return Operations[operation]();
                //switch (operation)
                //{
                //    case Operation.Sum:
                        
                //        return Sum();
                //    case Operation.Subtract:
                //        return Subtract();
                //    case Operation.Multiply:
                //        return Multiply();
                //    default:
                //        return -1;
                //}
            }
        }
    }
    
}
