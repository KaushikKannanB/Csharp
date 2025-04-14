using System;

class Student
{
    public string Name{get; set;}
    public string dept{get; set;}
    public float cgpa{get; set;}
    public int Age{get; set;}
}
class Program
{
    public static void Main()
    {
        List<Student>students = new List<Student>();
        Student s1 = new Student { Name = "Ayaan", dept = "CSE", cgpa = 8.6f, Age = 20 };
        Student s2 = new Student { Name = "Bella", dept = "ECE", cgpa = 8.1f, Age = 21 };
        Student s3 = new Student { Name = "Kunal", dept = "ME", cgpa = 7.9f, Age = 22 };
        Student s4 = new Student { Name = "Diya", dept = "IT", cgpa = 9.3f, Age = 20 };
        Student s5 = new Student { Name = "Ravi", dept = "CE", cgpa = 7.6f, Age = 23 };
        Student s6 = new Student { Name = "Sneha", dept = "ECE", cgpa = 8.4f, Age = 21 };
        Student s7 = new Student { Name = "Zaid", dept = "IT", cgpa = 8.0f, Age = 22 };
        Student s8 = new Student { Name = "Mira", dept = "CSE", cgpa = 9.1f, Age = 20 };
        Student s9 = new Student { Name = "Ansh", dept = "EEE", cgpa = 8.3f, Age = 23 };
        Student s10 = new Student { Name = "Riya", dept = "ME", cgpa = 7.8f, Age = 21 };
        Student s11 = new Student { Name = "Yash", dept = "CE", cgpa = 7.5f, Age = 22 };
        Student s12 = new Student { Name = "Sara", dept = "ECE", cgpa = 9.2f, Age = 20 };
        Student s13 = new Student { Name = "Dev", dept = "IT", cgpa = 8.5f, Age = 21 };
        Student s14 = new Student { Name = "Tina", dept = "CSE", cgpa = 9.4f, Age = 20 };
        Student s15 = new Student { Name = "Kabir", dept = "EEE", cgpa = 8.7f, Age = 22 };

        students.Add(s1);
        students.Add(s2);
        students.Add(s3);
        students.Add(s4);
        students.Add(s5);
        students.Add(s6);
        students.Add(s7);
        students.Add(s8);
        students.Add(s9);
        students.Add(s10);
        students.Add(s11);
        students.Add(s12);
        students.Add(s13);
        students.Add(s14);
        students.Add(s15);

        
        Console.WriteLine("Welcome to the Student Console:");

        var morethan8 = students.Where(i=> i.cgpa>8.0f);
        Console.WriteLine("Students with more than 8: ");

        foreach(var v in morethan8)
        {
            Console.WriteLine("* "+v.Name);
        }
        Console.WriteLine("\nStudents with more than 8: ordered in increasing order of cgpa ");
        morethan8 = morethan8.OrderBy(i=>i.cgpa);
        foreach(var v in morethan8)
        {
            Console.WriteLine("* "+v.Name);
        }
        Console.WriteLine("\nStudents with more than 8: ordered in increasing order of cgpa ");
        var deptwise = students.GroupBy(i=>i.dept);
        foreach(var v in deptwise)
        {
            Console.WriteLine("\n* "+v.Key +" --> Average cgpa: "+ v.Average(s=>s.cgpa));
            Console.WriteLine("\nStudents");
            foreach(var stud in v)
            {
                Console.WriteLine(" **" + stud.Name);
            }

        }
    }
}