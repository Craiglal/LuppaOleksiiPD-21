using System;
using System.Collections.Generic;
using System.Text;
using static Lab11_2.Student;

namespace Lab11_2
{
    static class Extension
    {
        public static List<Student> FindStudent(this List<Student> students, StudentPredicateDelegate studentPredicateDelegate)
        {
            List<Student> temp = new List<Student>();

            foreach (Student student in students)
            {
                if (studentPredicateDelegate.Invoke(student))
                    temp.Add(student);
            }
            return temp;
        }

        public static void ShowOnScreen(this List<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine("First name: " + student.FirstName);
                Console.WriteLine("Last name: " + student.LastName);
                Console.WriteLine("Age: " + student.Age + "\n");
            }
        }
    }
}
