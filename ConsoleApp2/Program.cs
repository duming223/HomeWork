using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Linq;

namespace Show
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int a = 1; a < 10; a++)
            //{
            //    for (int b = 1; b < a+1; b++)
            //    {
            //        Console.Write("{0}x{1}={2}\t",a,b,a*b);
            //    }
            //    Console.WriteLine();
            //}
            Student WalkMan = new Student { Name = "WalkMan",OtherName="xr", Ages = 23 };
            Student FreeMan = new Student { Name = "FreeMan", Ages = 22 };
            Student WorkMan = new Student { Name = "WorkMan", Ages = 21 };
            IList<Student> students = new List<Student>();
            students.Add(WalkMan);
            students.Add(FreeMan);
            students.Add(WorkMan);

            var excellent = from s in students
                            where s.Name.ToLower().Contains("w")
                            select s;

            foreach (var item in excellent)
            {
                Console.WriteLine(item.Name);
            }
        }
    }

    class Student
    {
        public int Ages { get; set; }
        public string Name { get; set; }
        public string OtherName { get; set; }

        public void Read()
        {
        }
    }
    class Book
    {
        public string Name { get; set; }
    }
}
