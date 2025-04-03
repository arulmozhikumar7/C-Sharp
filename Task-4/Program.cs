using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }
    public int Age { get; set; }

    public Student(string name, int grade, int age)
    {
        Name = name;
        Grade = grade;
        Age = age;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Grade: {Grade}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student("Student1", 85, 20),
            new Student("Student2", 92, 21),
            new Student("Student3", 78, 22),
            new Student("Student4", 90, 20),
            new Student("Student5", 95, 19)
        };

        Console.Write("Enter grade threshold: ");
        int threshold = int.Parse(Console.ReadLine()!.Trim());

        // Using LINQ to filter students with grades above threshold
        var filteredStudents = students
            .Where(s => s.Grade > threshold)   // Filter students
            .OrderByDescending(s => s.Grade)   // Sort by grade (descending)
            .ThenBy(s => s.Name);              // Sort by name if grades are equal

        Console.WriteLine("\nFiltered & Sorted Students:");
        foreach (var student in filteredStudents)
        {
            student.Display();
        }
    }
}
