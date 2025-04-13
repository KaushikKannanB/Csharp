using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your name");
        string?name = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Please enter a valid name");
            return ;
        }
        Console.WriteLine("Enter your age");
        string?input = Console.ReadLine();

        if(!int.TryParse(input, out int age))
        {
            Console.WriteLine("Please enter a valid age");
            return ;
        }

        Person person1 = new Person(name, age);
        // Person person2 = new Person("Dharun",21);

        person1.Introduce();
        // person2.Introduce();
    }
}
class Person
{
    public string Name {get;set;}
    public int Age {get;set;}
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void Introduce()
    {
        Console.WriteLine($"Hello {Name}, welcome to Presidio, and you are {Age} years old, am I right?");
    }
}