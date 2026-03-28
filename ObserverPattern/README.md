# Observer Pattern

## Overview

The **Observer Pattern** is a behavioral design pattern that defines a one-to-many dependency between objects. When one object (the **Subject**) changes state, all its dependents (**Observers**) are automatically notified and updated.

---

## When to Use

- When a change in one object requires updating others, and you don't know how many objects need to change.
- When you want loose coupling between related objects.
- Common in event systems, UI frameworks, and pub-sub architectures.

---

## Structure

```
+----------------+        +------------------+
|    ISubject    |        |    IObserver     |
|----------------|        |------------------|
| +Attach()      |<------>| +Update()        |
| +Detach()      |        +------------------+
| +Notify()      |                ^
+----------------+                |
        ^               +---------+---------+
        |               |                   |
+---------------+  ConcreteObserverA  ConcreteObserverB
| ConcreteSubject|
|----------------|
| -state         |
| +GetState()    |
| +SetState()    |
+---------------+
```

---

## C# Implementation

### IObserver Interface

```csharp
public interface IObserver
{
    void Update(string state);
}
```

### ISubject Interface

```csharp
public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}
```

### ConcreteSubject

```csharp
public class ConcreteSubject : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();
    private string _state;

    public string State
    {
        get => _state;
        set
        {
            _state = value;
            Notify();
        }
    }

    public void Attach(IObserver observer) => _observers.Add(observer);
    public void Detach(IObserver observer) => _observers.Remove(observer);

    public void Notify()
    {
        foreach (var observer in _observers)
            observer.Update(_state);
    }
}
```

### ConcreteObserver

```csharp
public class ConcreteObserver : IObserver
{
    private readonly string _name;

    public ConcreteObserver(string name) => _name = name;

    public void Update(string state)
    {
        Console.WriteLine($"[{_name}] Received update: {state}");
    }
}
```

### Usage

```csharp
var subject = new ConcreteSubject();

var observerA = new ConcreteObserver("Observer A");
var observerB = new ConcreteObserver("Observer B");

subject.Attach(observerA);
subject.Attach(observerB);

subject.State = "Active";   // Both observers notified
subject.State = "Inactive"; // Both observers notified

subject.Detach(observerA);
subject.State = "Pending";  // Only Observer B notified
```

### Output

```
[Observer A] Received update: Active
[Observer B] Received update: Active
[Observer A] Received update: Inactive
[Observer B] Received update: Inactive
[Observer B] Received update: Pending
```

---

## Real-World Examples

| Scenario | Subject | Observer |
|----------|---------|----------|
| UI Button click | Button | Event Handler |
| Stock price change | StockMarket | Investor |
| News feed | NewsAgency | Subscriber |
| .NET Events | EventPublisher | EventHandler delegate |

---

## Pros & Cons

### ✅ Pros
- Loose coupling between subject and observers
- Supports broadcast communication
- Easy to add new observers without changing subject

### ❌ Cons
- Unexpected updates if observers have side effects
- Memory leaks if observers are not detached properly
- Order of notification is not guaranteed

---

## Related Patterns

- **Mediator** — centralizes communication between objects
- **Event Aggregator** — extends Observer for cross-module events
- **Publish-Subscribe** — decoupled variant using message broker

---

*Part of the [DesignPatterns](https://github.com/Anand513/DesignPatterns) repository.*
