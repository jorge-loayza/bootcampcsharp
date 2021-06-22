using System;

namespace NullValues
{
    class Address
    {
        public string? Building;
        public string Street;
        public string City;
        public string Region;
    }
    class Program
    {
        
        static void Main(string[] args)
        {

            //string thisCouldBeNull = null;
            //if (thisCouldBeNull != null)
            //{
            //    int? length = thisCouldBeNull.Length;
            //}

            //string authorName = null;
            //var result = authorName?.Length ?? 3;
            //Console.WriteLine(result);

            int x = 0;
            int? nx = null;

            Console.WriteLine("nx has a value? {0}", nx.HasValue);
            Console.WriteLine("x == nx: {0}", x == nx);
            Console.WriteLine("x != nx: {0}", x != nx);
            nx = 20;
            Console.WriteLine("nx has a value? {0}", nx.HasValue);
            Console.WriteLine("nx has the value {0}", nx.Value);
            Console.WriteLine("x == nx: {0}", x == nx);
            Console.WriteLine("x != nx: {0}", x != nx);

            nx = null;
            Console.WriteLine("nx = {0}", nx?? -1);
            Console.WriteLine("nx = {0}", nx.GetValueOrDefault());
            Console.WriteLine("nx = {0}", nx.GetValueOrDefault(-2));
            nx = 10;
            Console.WriteLine("nx = {0}", nx ?? -1);
            Console.WriteLine("nx = {0}", nx.GetValueOrDefault());
            Console.WriteLine("nx = {0}", nx.GetValueOrDefault(-2));
        }
    }
}
