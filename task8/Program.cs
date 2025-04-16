using System;

public interface Entity
{
    int id {get; set;}
}

public interface EntityRepository<T>
{
    void add(T item);
    T get(int id);
    List<T>getall();
}
public class EntityRepository_implementation<T> : EntityRepository<T> where T:Entity
{
    List<T> items = new List<T>();

    public void add(T item)
    {
        items.Add(item);
    }
    public T get(int id)
    {
        return items.FirstOrDefault(i=> i.id==id);
    }
    public List<T> getall()
    {
        return items;
    }
}
class Student : Entity
{
    public int id {get; set;}
    public string name {get; set;}
    public string dept {get; set;}

    public Student(int id, string name, string dept)
    {
        this.id = id;
        this.name = name;
        this.dept = dept;
    }
}
class Product : Entity
{
    public int id {get; set;}
    public string pname {get; set;}
    public float price {get; set;}

    public Product(int id, string pname, float price)
    {
        this.id = id;
        this.pname = pname;
        this.price = price;
    }
}
class Program
{
    public static void Main()
    {
        Student s1 = new Student(1,"Mitchell","AIDS");
        Student s2 = new Student(2,"Claire","AIML");
        Student s3 = new Student(3,"Gloria","AIML");

        EntityRepository<Student> studentRepo = new EntityRepository_implementation<Student>();

        studentRepo.add(s1);
        studentRepo.add(s2);
        studentRepo.add(s3);

        Product p1 = new Product(101,"Laptop", 9999.09f);
        Product p2 = new Product(102,"Table", 999.09f);
        Product p3 = new Product(103,"House Lamp", 19.09f);
        EntityRepository<Product> productRepo = new EntityRepository_implementation<Product>();

        productRepo.add(p1);
        productRepo.add(p2);
        productRepo.add(p3);

        
        foreach (var student in studentRepo.getall())
        {
            Console.WriteLine($"ID: {student.id}, Name: {student.name}, Dept: {student.dept}");
        }
        // Console.WriteLine(studentRepo.get(2).name);
        foreach (var product in productRepo.getall())
        {
            Console.WriteLine($"ID: {product.id}, Name: {product.pname}, Price: {product.price}");
        }

    }
}
