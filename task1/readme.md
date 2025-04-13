## Installation Steps
To install C# and resolve these issues, I followed these steps:

### 1. Install .NET SDK
I downloaded and installed the .NET SDK from the official website: [Download .NET](https://dotnet.microsoft.com/en-us/download)

### 2. Verify Installation
After installation, I verified that `dotnet` was installed correctly by running:
```powershell
PS C:\> dotnet --version
```
This returned the installed version of .NET SDK.

### 3. Set Environment Variables
Since `dotnet` was not recognized initially, I had to manually add it to my system's PATH variable:
```powershell
PS C:\> [System.Environment]::SetEnvironmentVariable("Path", $env:Path + ";C:\Program Files\dotnet", [System.EnvironmentVariableTarget]::Machine)
```
To verify that the path was added correctly:
```powershell
PS C:\> $env:Path -split ";"
```
This confirmed that `C:\Program Files\dotnet\` was included in the PATH.

---

## Running the Project

```powershell
dotnet new console -n FactorialApp  # Create a new console project
cd FactorialApp
Move-Item -Path ../program.cs -Destination ./Program.cs -Force  # Replace default Program.cs
dotnet run  # Compile and run
```



---

Factorial Program
**Code:**
```csharp
using System;


class Program  // Renamed 'Main' to 'Program'
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine()); // Convert input to integer
        if(num == null || num<=0)
        {
            Console.WriteLine("Input should be valid");
            return;
        }
        int fact = Factorial(num);
        Console.WriteLine($"Factorial of {num} is: {fact}");
    }

    static int Factorial(int n)  // Parameter name corrected
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }
}

```
**This above code pops up a warning:**
<br>
![image](https://github.com/user-attachments/assets/db3ec378-651e-4cb5-a866-6c79f7379301)

**Code:**
```csharp
using System;

class Program  // Renamed 'Main' to 'Program'
{
    static void Main(string[] args)
    {
        string? input = Console.ReadLine(); // Read input as a nullable string

        if (!int.TryParse(input, out int num) || num <= 0) // Check for valid number
        {
            Console.WriteLine("Input should be a valid positive integer.");
            return;
        }
        int fact = Factorial(num);
        Console.WriteLine($"Factorial of {num} is: {fact}");
    }

    static int Factorial(int n)  // Parameter name corrected
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }
}
```
**Output:**
<br>
![image](https://github.com/user-attachments/assets/039b5d18-0a58-47f4-a36f-996cd3fdaa1f)

---

## Key Learnings
1. **`System` namespace:** Essential for using built-in classes like `Console`.
2. **`Console.ReadLine()` returns a string:** Must be parsed to an integer before use.
3. **Class name and function name should be different:** Avoids conflicts.
4. **`Console.WriteLine()` is similar to JavaScript's `console.log()`.**
5. **C# follows camelCase naming convention.**
6. **Nullable string handling:** `string? input = Console.ReadLine();` prevents potential null reference issues.
7. **Validating input:** `!int.TryParse(input, out int num)` ensures proper user input handling.

---
