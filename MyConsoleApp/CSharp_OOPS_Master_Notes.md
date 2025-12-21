# C# OOPS Master Notes

## 1. Class & Object
- **Class:** Blueprint for objects.
- **Object:** Real instance of a class.

```csharp
class Student
{
    public int Id;
    public string Name;
    public void Display() => Console.WriteLine($"Id: {Id}, Name: {Name}");
}
```

## 2. Encapsulation
- **Concept:** Bind data + methods. Use `private` fields, `public` methods.

```csharp
class Account
{
    private double balance;
    public void Deposit(double amount) => balance += amount;
    public double GetBalance() => balance;
}
```

## 3. Constructor
- **Concept:** Initializes object data, called automatically.

```csharp
class Employee
{
    public int Id;
    public string Name;
    public Employee(int id, string name) { Id = id; Name = name; }
}
```

## 4. Inheritance
- **Concept:** Child class inherits parent class (`:`).

```csharp
class Person { public void Speak() => Console.WriteLine("Person speaking"); }
class Student : Person { public void Study() => Console.WriteLine("Student studying"); }
```

## 5. Polymorphism (Overloading)
- **Concept:** Same method name, different parameters.

```csharp
class Calculator
{
    public int Add(int a, int b) => a + b;
    public double Add(double a, double b) => a + b;
}
```

## 6. Polymorphism (Overriding)
- **Concept:** Child overrides parent method. Use `virtual` & `override`.

```csharp
class Animal { public virtual void Sound() => Console.WriteLine("Animal sound"); }
class Dog : Animal { public override void Sound() => Console.WriteLine("Dog barks"); }
```

## 7. Abstraction (Abstract Class)
- **Concept:** Partial implementation, cannot instantiate.

```csharp
abstract class Shape { public abstract void Draw(); }
class Circle : Shape { public override void Draw() => Console.WriteLine("Drawing Circle"); }
```

## 8. Interface
- **Concept:** 100% abstraction, multiple inheritance.

```csharp
interface IPayment { void Pay(); }
class UpiPayment : IPayment { public void Pay() => Console.WriteLine("Payment via UPI"); }
```

## 9. Interface vs Abstract (Table)

| Feature           | Abstract | Interface |
|-------------------|----------|-----------|
| Method body       | Yes      | No        |
| Multiple inherit. | ❌       | ✅        |
| Fields            | Yes      | ❌        |
| Constructor       | Yes      | ❌        |

## 10. Access Modifiers

| Modifier   | Scope                |
|------------|----------------------|
| public     | Everywhere           |
| private    | Same class           |
| protected  | Same + child         |
| internal   | Same assembly        |

## 11. Exception Handling

```csharp
try { int c = 10 / 0; }
catch (Exception ex) { Console.WriteLine(ex.Message); }
finally { Console.WriteLine("Always executes"); }
```

## 12. Properties

```csharp
class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
}
```

---

### Capgemini Focus Tips
- OOPS definitions
- Interface vs Abstract
- Virtual vs Override
- Constructor types
- Encapsulation

**Master these for a strong interview foundation!**
