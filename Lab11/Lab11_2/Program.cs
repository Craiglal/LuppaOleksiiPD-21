using System;
using System.Collections.Generic;
using static Lab11_2.Student;

namespace Lab11_2
{
    class Program
    {
        static public StudentPredicateDelegate studentPredicateDelegate;
        static void Main(string[] args)
        {
            Student s1 = new Student("Andrew", "Troelsen", 25);
            Student s2 = new Student("Alex", "Lafrok", 18);
            Student s3 = new Student("Anna", "Jordan", 20);
            Student s4 = new Student("Inna", "Gizmos", 15);
            Student s5 = new Student("Kate", "Sven", 29);
            Student s6 = new Student("John", "Maxfil", 19);
            Student s7 = new Student("Max", "Volterin", 33);
            Student s8 = new Student("Shone", "Zumberg", 23);
            Student s9 = new Student("Martin", "Lalakopt", 27);
            Student s10 = new Student("Bill", "Canbeam", 17);

            List<Student> students = new List<Student>() {s1, s2, s3, s4, s5, s6, s7, s8, s9, s10 };

            StudentPredicateDelegate myDelegate = Student.isFirstName;
            myDelegate += Student.isLastName;
            myDelegate += Student.isAge;

            List<Student> task8 = students.FindStudent(myDelegate);
            Console.WriteLine("task 8:");
            task8.ShowOnScreen();

            List<Student> task9 = students.FindStudent(
                new StudentPredicateDelegate(
                    student => student.Age >= 18 && student.FirstName[0] == 'A' && student.LastName.Length > 3
                    ));
            Console.WriteLine("task 9:");
            task9.ShowOnScreen();

            List<Student> task10 = students.FindStudent(
                new StudentPredicateDelegate(
                    student => student.Age >= 20 && 25 >= student.Age
                    ));
            Console.WriteLine("task 10:");
            task10.ShowOnScreen();

            List<Student> task11 = students.FindStudent(
                new StudentPredicateDelegate(
                    student => student.FirstName == "Andrew"
                    ));
            Console.WriteLine("task 11:");
            task11.ShowOnScreen();

            List<Student> task12 = students.FindStudent(
                new StudentPredicateDelegate(
                    student => student.LastName == "Troelsen"
                    ));
            Console.WriteLine("task 11:");
            task12.ShowOnScreen();
        }
    }
}
