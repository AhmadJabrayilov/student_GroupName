using System;
using StudentGroup.Models;
using StudentGroup.Extension;

namespace StudentGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Fullname = "Ahmed Jabrayilov";

            Student student2 = new Student("Ilkin Ibrahimov","BBBBB",1);

            Console.WriteLine(student1);
            Console.WriteLine(student2.GroupNo);

            Extensions.GroupName()
        }
    }
}
