using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGroup.Models
{
    public class Student
    {
        private static int _id;
        public int Id { get; }
        public string Fullname { get; set; }
        public string Subject { get; set; }
        private static int _groupNo = 1000;
        public int GroupNo { get; }


        public Student()
        {

        }

        public Student(string fullName,string subject)
        {
            _id++;
            Id = _id;
            Fullname = fullName;
            Subject = subject;
            _groupNo++;
            GroupNo = _groupNo;
        }


    }
}
