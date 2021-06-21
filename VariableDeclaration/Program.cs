using System;

namespace VariableDeclaration
{
    class Program
    {
        static void Main(string[] args)
        {
            //Values
            sbyte val1 = -100;
            short val2 = -128;
            ushort val3 = 3540;
            ushort val4 = 64876;
            uint val5 = 2147483648;
            int val6 = -1141583228;
            long val7 = -1223372036854770;
            ushort val8 = 808;
            int val9 = 2_000_000;
            int val10 = 0b_0001_1110_1000_0100_1000_0000;
            int val11 = 0x_001E_8480;

            Console.WriteLine(val1);
            Console.WriteLine(val2);
            Console.WriteLine(val3);
            Console.WriteLine(val4);
            Console.WriteLine(val5);
            Console.WriteLine(val6);
            Console.WriteLine(val7);
            Console.WriteLine(val8);
            Console.WriteLine(val9);
            Console.WriteLine(val10);
            Console.WriteLine(val11);
            Console.WriteLine("-----------------");

            //Second part
            decimal val12 = 3.141592653589793238M;
            double val13 = 1.60217657;
            decimal val14 = 7.81842619745845552165353442341M;

            string val15 = "7.81842619745845552165353442341M";
            Console.WriteLine(val12);
            Console.WriteLine(val13);
            Console.WriteLine(val14.ToString());
            Console.WriteLine(val15.Length);



        }
    }
}
