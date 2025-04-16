using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class DescriptionAttribute : Attribute
{
    public string desc {get;}
    public DescriptionAttribute(string desc)
    {
        this.desc = desc;
    }
}

[AttributeUsage(AttributeTargets.Method)]
class RunnableAttribute : Attribute
{

}

class TaskA
{
    [Runnable]
    public void runtask()
    {
        Console.WriteLine("hello");
    }
}
class TaskB
{
    [Runnable]
    public void executetask()
    {
        Console.WriteLine("world");
    }
}

class TaskC
{
    [Runnable]
    [Description("Common u can do it")]
    public void executethis()
    {
        Console.WriteLine("U did this!!!");
    }
}
class Program
{
    public static void Main()
    {
        var assembly = Assembly.GetExecutingAssembly();

        foreach(var type in assembly.GetTypes())
        {
            foreach(var method in type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly))
            {
                if(method.GetCustomAttribute(typeof(RunnableAttribute))!=null)
                {
                    var instance = Activator.CreateInstance(type);
                    method.Invoke(instance, null);
                }
            }
        }
    }
}