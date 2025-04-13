## Code Breakdown

```csharp
using System;
```
- This imports the `System` namespace, which contains essential classes like `Console` for input and output operations.

```csharp
class Program
```
- Defines the `Program` class, which serves as the entry point of the application.

```csharp
static void Main()
```
- The `Main` method is the starting point of execution for the program.

```csharp
Console.WriteLine("Enter your name");
```
- Displays a prompt to the user asking for their name.

```csharp
string? name = Console.ReadLine();
```
- Reads user input from the console and stores it in the `name` variable. The `?` denotes that the variable can be `null`.

```csharp
if (string.IsNullOrWhiteSpace(name))
```
- **Key Learning 2: `string.IsNullOrWhiteSpace(name)`**
- This checks if the user input is empty, contains only whitespace, or is `null`.

```csharp
Console.WriteLine("Please enter a valid name");
return;
```
- If the name is invalid, an error message is displayed, and the program terminates using `return`.

```csharp
Console.WriteLine("Enter your age");
string? input = Console.ReadLine();
```
- Prompts the user to enter their age and stores the input in `input`.

```csharp
if (!int.TryParse(input, out int age))
```
- **Key Learning 3: `!int.TryParse(input, out int age)`**
- This attempts to convert the user input into an integer.
- If successful, `age` will store the converted integer value.
- If unsuccessful, an error message is displayed and the program terminates.

```csharp
Console.WriteLine("Please enter a valid age");
return;
```
- If the conversion fails, an error message is displayed, and the program exits.

```csharp
Person person1 = new Person(name, age);
```
- Creates an instance of the `Person` class using the valid `name` and `age`.

```csharp
person1.Introduce();
```
- Calls the `Introduce` method to display a personalized message.

### `Person` Class Explanation

```csharp
class Person
```
- Defines a class named `Person`, representing a person with a name and age.

```csharp
public string Name { get; set; }
public int Age { get; set; }
```
- **Key Learning 4: `get; set;` Automated Properties**
- These are auto-implemented properties in C# that provide an efficient way to define class properties without writing explicit getter and setter methods.

```csharp
public Person(string name, int age)
```
- Defines a constructor that initializes the `Person` object with values for `Name` and `Age`.

```csharp
public void Introduce()
```
- Defines a method that prints a message introducing the person.

```csharp
Console.WriteLine($"Hello {Name}, welcome to Presidio, and you are {Age} years old, am I right?");
```
- Uses string interpolation (`$"..."`) to format and display the message.

## Key Learnings
1. **OOP in C#**: The program demonstrates object creation, constructors, and method calls in a class.
2. **`string.IsNullOrWhiteSpace(name)`**: Helps validate user input to ensure it's not empty or only whitespace.
3. **`!int.TryParse(input, out int age)`**: A safe way to parse user input into an integer, avoiding runtime errors.
4. **`get; set;` Automated Properties**: Simplifies class properties by auto-generating getter and setter methods.

![image](https://github.com/user-attachments/assets/650692e1-0f3f-4c55-a88b-441f38a96844)

