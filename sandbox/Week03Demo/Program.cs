﻿using System:
class Program
{
    static void Main(string[] args)
    {
        // List<Student> students = new List<Student>();


        
        Student s1 = new Student();
        s1._firstName = "Bob";
        s1._lastName = "Jones";
        s1._id = "123456789";
        // students.Add(s1);

        Student s2 = new Student();
        s2._firstName = "Betty";
        s2._lastName = "White";
        s2._id = "987654321";
        // students.Add(s2);

        // foreach (Student s in students)
        // {
        //     s.DisplayInfo();
        // }

        Course c1 = new Course();
        c1._courseName = "Programming with Classes";
        c1._students.Add(s1);
        c1._students.Add(s2);
        c1.DisplayCourseInfo();
    }
}