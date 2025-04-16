## 📚 Topics Covered

### 1. **Generics**
- Generics allow you to write flexible, reusable code for different data types.
- Syntax:
  ```csharp
  public class MyGenericClass<T> { ... }
  public interface IRepository<T> { ... }
  ```
- `T` can be **any data type**, like `Student`, `Product`, etc.
- Example:
  ```csharp
  EntityRepository<Student> studentRepo = new EntityRepository_implementation<Student>();
  ```

---

### 2. **Interfaces**
- Interfaces define **what a class must do**, but **not how**.
- We define:
  - `Entity`: forces all entities to have an `id`.
  - `EntityRepository<T>`: generic interface for CRUD operations.
- Syntax:
  ```csharp
  public interface Entity
  {
      int id { get; set; }
  }
  ```

---

### 3. **Generic Repository Pattern**
- A design pattern to abstract data access logic using a generic class.
- `EntityRepository_implementation<T>` implements the interface `EntityRepository<T>` using an in-memory `List<T>`.
- Syntax with constraint:
  ```csharp
  public class EntityRepository_implementation<T> : EntityRepository<T> where T : Entity
  ```

---

### 4. **In-Memory Data Storage**
- Data is stored in a `List<T>` within the repository class.
- Example:
  ```csharp
  List<T> items = new List<T>();
  ```

---

### 5. **Polymorphism via Interface References**
- You create an object of a class that implements the interface, but reference it via the interface.
- Syntax:
  ```csharp
  EntityRepository<Student> repo = new EntityRepository_implementation<Student>();
  ```

---
Sure! Here's the **"Common Doubts Clarified"** section rewritten in a clean, bullet-point format (no table):

---

## 🤔 Common Doubts Clarified

- **Why use generics?**  
  Generics allow you to create one reusable class or interface that works with multiple data types. No need to repeat code for each type like `Student`, `Product`, etc.

- **What is `T`?**  
  `T` is a placeholder for a data type. It could be `Student`, `Product`, or any other class you want to work with.

- **What is a generic repository?**  
  It's a class that uses generics to perform CRUD operations for any type of entity — instead of writing separate code for each type.

- **What is `where T : Entity`?**  
  It's a **type constraint**. It ensures that `T` must implement the `Entity` interface, so the repository knows `T` will have an `id` property.

- **What’s the use of interfaces here?**  
  Interfaces define the contract — the methods that must be implemented. This helps in enforcing structure and keeping the code loosely coupled.

- **Is `InMemoryRepository<T>` (or your `EntityRepository_implementation<T>`) the place to define all logic?**  
  Yes. This is where you actually implement all the functions (like `add`, `get`, etc.) declared in the interface.

- **Do we set the primary key here?**  
  Not exactly "set", but by enforcing that every entity must have an `id` through the `Entity` interface, you're treating that `id` as a universal primary key.

- **What does this mean: `EntityRepository<Student> repo = new EntityRepository_implementation<Student>()`?**  
  You're creating an object of the generic repository class, but referencing it through the interface. This is a common and recommended practice for flexibility and abstraction.

---

Let me know if you want this added to the README or styled differently!

## 💻 Final Code Overview

### ✅ Entity Interfaces
```csharp
public interface Entity { int id { get; set; } }

public interface EntityRepository<T>
{
    void add(T item);
    T get(int id);
    List<T> getall();
}
```

### ✅ Generic In-Memory Repository
```csharp
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
```

### ✅ Entity Classes
```csharp
class Student : Entity
{
    public int id { get; set; }
    public string name { get; set; }
    public string dept { get; set; }

    public Student(int id, string name, string dept)
    {
        this.id = id; this.name = name; this.dept = dept;
    }
}

class Product : Entity
{
    public int id { get; set; }
    public string pname { get; set; }
    public float price { get; set; }

    public Product(int id, string pname, float price)
    {
        this.id = id; this.pname = pname; this.price = price;
    }
}
```


