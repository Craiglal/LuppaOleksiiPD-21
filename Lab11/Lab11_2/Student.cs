using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11_2
{
    public delegate bool StudentPredicateDelegate(Student student);
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Student(string FirstName, string LastName, int Age)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
        }

        static public bool isAge(Student student)
        {
            return (student.Age >= 18 ? true : false);
        }

        static public bool isFirstName(Student student)
        {
            return (student.FirstName == "A" ? true : false);
        }

        static public bool isLastName(Student student)
        {
            return (student.LastName.Length > 3 ? true : false);
        }
    }
}
