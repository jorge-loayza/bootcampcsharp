using System;
using System.Collections.Generic;

namespace ValueReferanceType
{
    class Program
    {
        class Point
        {
            public int X;
            int Y;

            public Point(int X, int Y)
            {
                this.X = X;
                this.Y = Y;
            }

            public override string ToString()
            {
                return X + ", "+ Y;
            }
        }

        struct DetailedInteger
        {
            public int Number;
          
            List<string> Detail;
            public DetailedInteger(int x )
            {
                this.Number = x;
                this.Detail = new List<string>();
            }

            public void addDetail(string v)
            {
                this.Detail.Add(v);
            }

            public override string ToString()
            {
                return this.Number + " " + String.Join(",", this.Detail);
            }
        }
        class Student
        {
            public string Name;

        }
        static void Main(string[] args)
        {
            /*int i = 100;
            int j = 100;

            i = j;
            j = 400;
            Console.WriteLine(i);
            ChangeValue(i);
            Console.WriteLine(i);*/

            /* var p1 = new Point(1, 2);
            var p2 = p1;

            Console.WriteLine($"{nameof(p1)} after {nameof(p2)} is modified: {p1}");
            Console.WriteLine($"{nameof(p2)} {p2}");

            ChangeValue(p2);
            Console.WriteLine($"{nameof(p2)} after call a method {p2}");*/


            //var n1 = new DetailedInteger(0);
            //n1.addDetail("A");
            //Console.WriteLine(n1);  //0 [A]

            //var n2 = n1;
            //n2.Number = 7;
            //n2.addDetail("B");

            //Console.WriteLine(n1);  //0 [A, B]
            //Console.WriteLine(n2);  //7 [A, B]

            Student student = new Student();
            student.Name = "Pedro";
            ChangeReferencetype(student);
            Console.WriteLine(student.Name);
        }

        
        static void ChangeReferencetype(Student student)
        {
            student.Name = "Juan";
        }
        static void ChangeReferencetype(string name)
        {
            name = "Juan";
        }

        static void ChangeValue(Point p)
        {
            p.X = 100;
            Console.WriteLine($"changed to : {p}");
        }
        static void ChangeValue(int x)
        {
            x = 200;
            Console.WriteLine(x);
        }
    }
}
