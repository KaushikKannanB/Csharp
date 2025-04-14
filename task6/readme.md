
### Key Features:
- Custom delegate: `delegate1` which takes a string argument.
- Nullable event declaration to resolve CS8618 warning.
- Event handler invocation using `?.Invoke()`.
- A `Handler` class with two methods: `alert` and `log`, both subscribed to the event.
- The `Add()` method returns a `bool` to indicate if the threshold is crossed, providing a clean control flow.

---

## 🔧 Key Learnings From
### 1. **Delegates in C#**
- Delegates are type-safe function pointers.
- They define a method signature, and can point to any method matching that signature.
- Delegates can be multicast (point to multiple methods).

### 2. **Delegate Signature**
- A delegate's signature determines which methods it can point to.
- Any method subscribed to an event must match the delegate signature.

### 3. **Events in C#**
- Events use delegates under the hood.
- Events decouple publisher and subscriber logic.
- Event handlers are invoked through `?.Invoke()` or directly (in protected methods).

### 4. **Multicast Delegates**
- One event can have multiple methods (handlers) subscribed.
- All are executed in the order of subscription.

### 5. **Delegate vs Event**
- A delegate is like a standalone function pointer.
- An event wraps a delegate to restrict access: only the declaring class can invoke it.

### 6. **Nullable Events**
- Without initializing an event, C# 8+ gives CS8618 warning.
- Using nullable `?` (e.g., `delegate1?`) avoids the warning.

### 7. **Event Invocation Best Practice**
- Raising an event from within a class is typically done via a protected virtual method like `OnThresholdReached()`.
- But direct invocation through `?.Invoke()` also works and is often used in simpler cases.

---

## 🤔 Concepts

### ☑️ Delegate usage across same and different classes
- Yes, you can use delegates in both same and different classes as long as method signatures match.

### ☑️ Whether delegates can return values
- Yes, but with multicast delegates, only the last return value is preserved.

### ☑️ Can one event have multiple delegates?
- One event uses one delegate type, but that delegate can point to multiple methods.

### ☑️ Can one delegate be reused by multiple events?
- Yes, as long as the delegate signature fits all events, it can be reused.


<br>

Delegate is defined 
    ↓ 
  (Creates a type for methods to follow)
    ↓
Event is declared 
    ↓ 
 (Event of that type is set up)
    ↓ 
Methods are written
    ↓
(Methods match the signature of the delegate)
    ↓ 
Handlers subscribe to the event
    ↓
(Handlers are added to the event using `+=`)
    ↓ 
Event is triggered
    ↓ 
(Event is invoked when the condition is met)
    ↓ 
Handlers execute
    ↓ 
(All subscribed handlers run and execute their code)

---


