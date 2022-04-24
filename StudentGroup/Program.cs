using System;
using StudentGroup.Models;
using StudentGroup.Extension;


using StudentGroup.Extension;
namespace StudentGroup

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Fullname = "Ahmed Jabrayilov";
            student1.Subject = "Riyaziyyat";


            Student student2 = new Student("Ilkin Ibrahimov","BBBBB");

            Console.WriteLine(Extensions.GroupName(student1.Subject)+student1.GroupNo);

            
            
        }
    }
}
