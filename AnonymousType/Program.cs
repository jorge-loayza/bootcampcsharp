using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
            //var student = new
            //{
            //    Id = 1,
            //    FirstName = "James",
            //    Lastname = "Bond",
            //    Address = new
            //    {
            //        Id = 1,
            //        City = "London",
            //        Contry = "UK"
            //    }
            //};

            //Console.WriteLine(student.Id);
            //Console.WriteLine(student.FirstName);
            //Console.WriteLine(student.Lastname);


            //var students = new[]
            //{
            //    new {
            //        Id = 1,
            //        City = "London",
            //        Contry = "UK"
            //    },
            //    new {
            //        Id = 1,
            //        City = "Argentina",
            //        Contry = "AR"
            //    },
            //    new {
            //        Id = 1,
            //        City = "Bolivia",
            //        Contry = "BO"
            //    }
            //};

            //IList<Student> studentList = new List<Student>()
            //{
            //    new Student() { StudentID = 1, StudentName = "Pepe", Age = 18},
            //    new Student() { StudentID = 2, StudentName = "Maria", Age = 21},
            //};


            //var students = from s in studentList
            //               select new { Id = s.StudentID, Name = s.StudentName };

            //foreach (var stud in students)
            //{
            //    Console.WriteLine(stud);
            //}

            Anonymous anonymous = new Anonymous();
            dynamic anonymousDynamicData = anonymous.getData();
            Console.WriteLine(string.Format("{0} {1}", anonymousDynamicData.Name, anonymousDynamicData.EmailID));

            object anonymousData = anonymous.getData();
            var obj = new { Name = "", EmailID = "" };
            obj = Cast(obj, anonymousData);
            Console.WriteLine(string.Format("{0} {1}", obj.Name, obj.EmailID));

        }
        private static T Cast<T>(T typeHolder, Object x){
            return (T)x;
            }
        class Anonymous
        {
            public string Name;
            public string Email;
            public Anonymous()
            { 
            }

            internal dynamic getData()
            {
                return new { Name = "Pepe", EmailID = "pepe@gmail.com" };
            }
        }

        public object getDate()
        {
            return new { Name = "Pepe", EmailID = "pepe@gmail.com" };
        }
        public class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int Age { get; set; }

        }
    }

    
}
