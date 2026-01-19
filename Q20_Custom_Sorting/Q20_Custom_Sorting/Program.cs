using System;
using System.Collections.Generic;

class Student
{
    public string Name;
    public int Age;
    public int Marks;

    public Student(string name, int age, int marks)
    {
        Name = name;
        Age = age;
        Marks = marks;
    }
}

class StudentComparer : IComparer<Student>
{
    public int Compare(Student x, Student y)
    {
        if (x.Marks != y.Marks)
            return y.Marks.CompareTo(x.Marks);

        return x.Age.CompareTo(y.Age);
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        students.Add(new Student("Amit", 21, 85));
        students.Add(new Student("Neha", 20, 90));
        students.Add(new Student("Ravi", 19, 90));
        students.Add(new Student("Priya", 22, 80));

        students.Sort(new StudentComparer());

        for (int i = 0; i < students.Count; i++)
        {
            Console.WriteLine(students[i].Name + " " + students[i].Age + " " + students[i].Marks);
        }
    }
}