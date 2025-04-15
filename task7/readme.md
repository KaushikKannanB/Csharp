## 📌 Topics Covered

### 1. What is a `Task<T>`?
- Represents an **asynchronous operation** that may return a result.
- `Task<string>` = A task that eventually returns a string.
- Syntax:
  ```csharp
  public static async Task<string> GetDataAsync()
  {
      await Task.Delay(1000);
      return "Data";
  }
  ```

---

### 2. Is a Task the same as a function?
- ❌ Not quite.
- A **function**: Runs synchronously and returns a value immediately.
- A **Task**: Represents ongoing or future work, often executed asynchronously.

---

### 3. Can a Task be non-async?
✅ Yes. A Task can be created manually using:

```csharp
Task<string> task = Task.Run(() => "Hello");
```

But to use `await`, the method must be marked `async`.

---

### 4. What’s the purpose of a Task?
- Avoid blocking the current thread (especially in UI/web apps).
- Allows long-running tasks to execute concurrently (e.g., file read, API calls).
- Makes applications more responsive and efficient.

---

### 5. Why static for async methods?
Since `Main()` is `static`, any method called from it must also be `static`, unless you create an instance of the class.

```csharp
public static async Task<string> MyMethodAsync()
{
    await Task.Delay(1000);
    return "Done";
}
```

---

### 6. What's returned by an async method?
An `async Task<string>` method returns a **Task<string>**, **not** a plain `string`.

To get the result:

```csharp
string result = await MyMethodAsync();
```

---

### 7. When to use normal functions instead?
Use **non-async functions** when:
- You don’t need concurrency
- Your operations are fast
- You want predictable, step-by-step execution

```csharp
public static string GetData()
{
    return "Data";
}
```

---

### 8. Task.WhenAll() vs Sequential Execution in the progran given:

| Type         | Total Time  | Execution Style       |
|--------------|-------------|------------------------|
| Synchronous  | ~5 seconds  | One after the other    |
| Asynchronous | ~3 seconds  | Runs concurrently      |

---

## ✅ Syntax Learned

### 🔹 Async Task Method

```csharp
public static async Task<string> MyAsyncMethod(string input)
{
    await Task.Delay(2000);
    return "Result " + input;
}
```

---

### 🔹 Calling and Awaiting Tasks

```csharp
Task<string> t1 = MyAsyncMethod("value1");
Task<string> t2 = MyAsyncMethod("value2");

string[] results = await Task.WhenAll(t1, t2);
```

---

### 🔹 Synchronous Version

```csharp
public static string MySyncMethod(string input)
{
    Thread.Sleep(2000);
    return "Result " + input;
}
```

---

### 🔹 Timing Execution with Stopwatch

```csharp
Stopwatch sw = new Stopwatch();
sw.Start();
// code block
sw.Stop();
Console.WriteLine("Time: " + sw.Elapsed.TotalSeconds);
```

### workflow
Step 1: Define the Async Task Method
────────────────────────────────────────────
```
        async Task<string> GetDataAsync()
        {
            await Task.Delay(2000);
            return "Data from Source";
        }
```
⇩

Step 2: Call the Method – This Returns a Task<string>
──────────────────────────────────────────────────────
        ```Task<string> dataTask = GetDataAsync();```

    🔹 At this point, the task is created and running asynchronously.
    🔹 The program continues execution without waiting here.

⇩

Step 3: Await the Task to Get the Result
────────────────────────────────────────────
      ```  string result = await dataTask;```

    🔹 The `await` pauses execution of the current method
      until the task is complete.
    🔹 Once the task finishes, the result is retrieved and used.

⇩

Step 4: Use the Result
────────────────────────────────────────────
     ```   Console.WriteLine(result);```

    🔹 Now the result can be printed or processed further.

---

![image](https://github.com/user-attachments/assets/43112e89-f7b0-40ad-9c5d-68326056c655)
