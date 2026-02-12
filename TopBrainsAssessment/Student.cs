using System;
using System.Collections.Generic;
public class Student
{
    public string Name {get; set;}
    public int Age {get; set;}
    public int Marks {get; set;}
    
    public Student(string name, int age, int marks)
    {
        this.Name=name;
        this.Age=age;
        this.Marks=marks;
        
    }
    public override string ToString()
    {
        return $"{Name} - Age: {Age}, Marks: {Marks}";
    }
}

public class StudentComparer : IComparer<Student>
{
    public int Compare(Student x, Student y)
    {
        if(x.Marks != y.Marks)
    {
    return y.Marks.CompareTo(x.Marks);
    }
    return x.Age.CompareTo(y.Age);
}
}
public class Program
{
    static void Main(string[] args)
    {
        List<Student> students=new List<Student>()
        {
            new Student("Teja",21,85),
            new Student("Sai",22,89),
            new Student("Ram",45,78)
        };
        
        students.Sort(new StudentComparer());
        
        foreach(var item in students)
        {
            Console.WriteLine(item);
        }
    }
}