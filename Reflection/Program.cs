using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {

            var className = "Reflection.ExampleClass";
            //Assembly asm = Assembly.Load("mscorlib.dll");
            var assembly = Assembly.GetAssembly(typeof(Program));
            var type = assembly.GetType(className);

            Console.WriteLine($"Version: {assembly.GetName().Version}");

            foreach (var t in assembly.DefinedTypes)
            {
                Console.WriteLine("Content: {0}", t);
            }


            //var dynamicObject = assembly.CreateInstance("Reflection.ExampleClass"
            //                               , false
            //                               , BindingFlags.ExactBinding
            //                               , null
            //                               , new object[] { 2 }
            //                               , null
            //                               , null);
            //var method = dynamicObject.GetType().GetMethod("Multiply");
            //var result = method.Invoke(dynamicObject, new object[] { 3 });
            //Console.WriteLine($"The result of the function is: {result}");


            var constructorWithParameters = type.GetConstructor(new[] { typeof(int) });

            var constructorWithoutParameters = type.GetConstructor(Type.EmptyTypes);

            var dynamicObjectWithParameters = constructorWithParameters.Invoke(new object[] { 2 });
            var dynamicObjectWithoutParameters = constructorWithoutParameters.Invoke(new object[] { });

            var method = assembly.GetType(className).GetMethod("Multiply");

            var resultParameterConstructor = method.Invoke(dynamicObjectWithParameters, new object[] { 2 });
            var resultGenericConstructor = method.Invoke(dynamicObjectWithoutParameters, new object[] { 3 });
            Console.WriteLine($"The return of the function with the constructor with parameters is: {resultParameterConstructor}");
            Console.WriteLine($"The return of the function with the generic constructor is: {resultGenericConstructor}");
        }
    }

    public class ExampleClass
    {
        private int value;
        public ExampleClass()
        {
            value = 0;
        }
        public ExampleClass(int value)
        {
            this.value = value;
        }
        public int Multiply(int number)
        {
            Console.WriteLine($"Call of {nameof(Multiply)} with parameter {number}");
            return value * number;
        }
    }
}
