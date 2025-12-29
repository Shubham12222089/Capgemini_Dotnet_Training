# 📚 Complete C# & .NET Notes
## Covering MCQ, Logical Coding & Interview Preparation

---

# 🔷 SECTION 1: COURSE FUNDAMENTALS & .NET OVERVIEW

## 1.1 What is .NET?
**Definition:** .NET is a free, open-source, cross-platform developer platform created by Microsoft for building many different types of applications.

### Key Components:
| Component | Description |
|-----------|-------------|
| **CLR (Common Language Runtime)** | Virtual machine that manages execution of .NET programs |
| **CLI (Common Language Infrastructure)** | Specification that allows multiple languages to work together |
| **BCL (Base Class Library)** | Collection of reusable classes, interfaces, and value types |
| **FCL (Framework Class Library)** | Superset of BCL with additional libraries |

### .NET Framework Architecture:
```
┌─────────────────────────────────────┐
│       Your C# Application           │
├─────────────────────────────────────┤
│    Framework Class Library (FCL)    │
├─────────────────────────────────────┤
│    Base Class Library (BCL)         │
├─────────────────────────────────────┤
│  Common Language Runtime (CLR)      │
├─────────────────────────────────────┤
│    Operating System (Windows/Linux) │
└─────────────────────────────────────┘
```

### MCQ Points:
- ✅ CLR provides memory management, security, and exception handling
- ✅ JIT (Just-In-Time) compiler converts IL code to native machine code
- ✅ MSIL/IL (Microsoft Intermediate Language) is platform-independent code
- ✅ Garbage Collector automatically manages memory

---

## 1.2 CLR (Common Language Runtime) - Deep Dive

**Definition:** CLR is the execution engine that handles running .NET programs.

### CLR Services:
1. **Memory Management** - Automatic allocation/deallocation
2. **Garbage Collection** - Removes unused objects
3. **Type Safety** - Ensures type correctness
4. **Exception Handling** - Manages runtime errors
5. **Security** - Code Access Security (CAS)
6. **Thread Management** - Multithreading support

### Compilation Process:
```
Source Code (.cs) → C# Compiler → IL Code (.exe/.dll) → JIT Compiler → Native Code
```

### MCQ Points:
- ✅ Managed Code = Code that runs under CLR supervision
- ✅ Unmanaged Code = Code that runs outside CLR (C/C++)
- ✅ Assembly = Compiled unit containing IL code + metadata

---

# 🔷 SECTION 2: C# LANGUAGE INTRODUCTION

## 2.1 C# Language Tokens

**Definition:** Tokens are the smallest individual units in a program.

### Types of Tokens:
| Token Type | Examples |
|------------|----------|
| **Keywords** | `class`, `int`, `if`, `public`, `static` |
| **Identifiers** | Variable names, class names, method names |
| **Literals** | `100`, `"Hello"`, `3.14`, `true` |
| **Operators** | `+`, `-`, `*`, `/`, `==`, `&&` |
| **Separators** | `;`, `,`, `{}`, `()`, `[]` |

### C# 8.0+ New Features:
```csharp
// 1. Nullable Reference Types
string? nullableName = null;

// 2. Switch Expressions
var result = day switch
{
    "Mon" => "Monday",
    "Tue" => "Tuesday",
    _ => "Unknown"
};

// 3. Using Declarations (no braces needed)
using var file = new StreamReader("test.txt");

// 4. Default Interface Methods
interface ILogger
{
    void Log(string message) => Console.WriteLine(message);
}

// 5. Pattern Matching Enhancements
if (obj is string { Length: > 5 } s)
    Console.WriteLine(s);

// 6. Range and Index operators
int[] arr = {1, 2, 3, 4, 5};
var slice = arr[1..3];  // {2, 3}
var last = arr[^1];     // 5
```

---

## 2.2 First C# Application

```csharp
using System;  // Importing namespace

namespace MyFirstApp  // Namespace declaration
{
    class Program  // Class declaration
    {
        static void Main(string[] args)  // Entry point
        {
            Console.WriteLine("Hello, World!");  // Output
        }
    }
}
```

### Key Points:
- ✅ `using System` imports the System namespace
- ✅ `Main()` is the entry point of every C# application
- ✅ `static` means method belongs to class, not object
- ✅ `Console.WriteLine()` prints output with newline
- ✅ `Console.Write()` prints without newline

---

# 🔷 SECTION 3: BASIC PROGRAMMING CONCEPTS

## 3.1 Variables & Data Types

### Primitive Data Types:
| Type | Size | Range | Default |
|------|------|-------|---------|
| `byte` | 1 byte | 0 to 255 | 0 |
| `sbyte` | 1 byte | -128 to 127 | 0 |
| `short` | 2 bytes | -32,768 to 32,767 | 0 |
| `int` | 4 bytes | -2.1B to 2.1B | 0 |
| `long` | 8 bytes | Very large | 0L |
| `float` | 4 bytes | 7 digits precision | 0.0f |
| `double` | 8 bytes | 15-16 digits | 0.0d |
| `decimal` | 16 bytes | 28-29 digits | 0.0m |
| `char` | 2 bytes | Unicode character | '\0' |
| `bool` | 1 byte | true/false | false |
| `string` | Variable | Text | null |

### Variable Declaration:
```csharp
// Explicit type
int age = 25;
string name = "John";
double salary = 50000.50;

// Implicit type (var keyword)
var count = 10;        // Inferred as int
var message = "Hi";    // Inferred as string

// Constants (cannot be changed)
const double PI = 3.14159;

// Readonly (set once, in constructor)
readonly int MaxValue = 100;
```

### MCQ Points:
- ✅ `var` is compile-time type inference (NOT dynamic)
- ✅ `const` must be initialized at declaration
- ✅ `readonly` can be initialized in constructor
- ✅ Default value of reference types is `null`

---

## 3.2 Operators

### Arithmetic Operators:
```csharp
int a = 10, b = 3;
Console.WriteLine(a + b);  // 13 (Addition)
Console.WriteLine(a - b);  // 7  (Subtraction)
Console.WriteLine(a * b);  // 30 (Multiplication)
Console.WriteLine(a / b);  // 3  (Integer Division)
Console.WriteLine(a % b);  // 1  (Modulus)
```

### Comparison Operators:
```csharp
int x = 5, y = 10;
Console.WriteLine(x == y);  // false
Console.WriteLine(x != y);  // true
Console.WriteLine(x < y);   // true
Console.WriteLine(x > y);   // false
Console.WriteLine(x <= y);  // true
Console.WriteLine(x >= y);  // false
```

### Logical Operators:
```csharp
bool a = true, b = false;
Console.WriteLine(a && b);  // false (AND)
Console.WriteLine(a || b);  // true  (OR)
Console.WriteLine(!a);      // false (NOT)
```

### Null-Coalescing Operators:
```csharp
string? name = null;
string result = name ?? "Default";     // "Default"
name ??= "Assigned";                   // Assigns if null
int? num = null;
int value = num ?? 0;                  // 0
```

---

## 3.3 Practice Programs

### Program 1: Area of Circle
```csharp
using System;

class AreaOfCircle
{
    static void Main()
    {
        Console.Write("Enter radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        
        double area = Math.PI * radius * radius;
        Console.WriteLine($"Area of Circle: {area:F2}");
    }
}
// Formula: Area = π × r²
```

### Program 2: Feet to Centimeters
```csharp
using System;

class FeetToCm
{
    static void Main()
    {
        Console.Write("Enter feet: ");
        double feet = Convert.ToDouble(Console.ReadLine());
        
        double cm = feet * 30.48;
        Console.WriteLine($"{feet} feet = {cm} cm");
    }
}
// Formula: 1 foot = 30.48 cm
```

### Program 3: Seconds to Minutes
```csharp
using System;

class SecondsToMinutes
{
    static void Main()
    {
        Console.Write("Enter seconds: ");
        int seconds = Convert.ToInt32(Console.ReadLine());
        
        int minutes = seconds / 60;
        int remainingSeconds = seconds % 60;
        
        Console.WriteLine($"{seconds} seconds = {minutes} min {remainingSeconds} sec");
    }
}
```

---

# 🔷 SECTION 4: CONDITIONAL STATEMENTS

## 4.1 If-Else Statements

```csharp
// Simple if
if (condition)
{
    // code
}

// If-else
if (condition)
{
    // true block
}
else
{
    // false block
}

// If-else-if ladder
if (condition1)
{
    // block 1
}
else if (condition2)
{
    // block 2
}
else
{
    // default block
}

// Nested if
if (outerCondition)
{
    if (innerCondition)
    {
        // nested block
    }
}
```

## 4.2 Switch-Case

```csharp
// Traditional switch
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    default:
        Console.WriteLine("Invalid day");
        break;
}

// Switch Expression (C# 8.0+)
string result = day switch
{
    1 => "Monday",
    2 => "Tuesday",
    _ => "Invalid"
};
```

## 4.3 Practice: Height Category

```csharp
using System;

class HeightCategory
{
    static void Main()
    {
        Console.Write("Enter height in cm: ");
        double height = Convert.ToDouble(Console.ReadLine());
        
        string category;
        if (height < 150)
            category = "Short";
        else if (height >= 150 && height < 170)
            category = "Average";
        else if (height >= 170 && height < 190)
            category = "Tall";
        else
            category = "Very Tall";
            
        Console.WriteLine($"Category: {category}");
    }
}
```

## 4.4 Practice: Largest of Three Numbers

```csharp
using System;

class LargestOfThree
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers:");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        
        int largest;
        
        // Method 1: Using if-else
        if (a >= b && a >= c)
            largest = a;
        else if (b >= a && b >= c)
            largest = b;
        else
            largest = c;
            
        // Method 2: Using Math.Max
        largest = Math.Max(a, Math.Max(b, c));
        
        // Method 3: Using Ternary
        largest = (a > b) ? ((a > c) ? a : c) : ((b > c) ? b : c);
        
        Console.WriteLine($"Largest: {largest}");
    }
}
```

---

# 🔷 SECTION 5: LOOPS

## 5.1 While Loop
```csharp
// Definition: Executes while condition is true (entry-controlled)
int i = 1;
while (i <= 5)
{
    Console.WriteLine(i);
    i++;
}
```

## 5.2 Do-While Loop
```csharp
// Definition: Executes at least once (exit-controlled)
int i = 1;
do
{
    Console.WriteLine(i);
    i++;
} while (i <= 5);
```

## 5.3 For Loop
```csharp
// Definition: Known number of iterations
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
```

## 5.4 Foreach Loop
```csharp
// Definition: Iterates over collections
int[] numbers = {1, 2, 3, 4, 5};
foreach (int num in numbers)
{
    Console.WriteLine(num);
}
```

## 5.5 Loop Control Statements

```csharp
// break - exits the loop immediately
for (int i = 1; i <= 10; i++)
{
    if (i == 5) break;
    Console.WriteLine(i);  // Prints 1, 2, 3, 4
}

// continue - skips current iteration
for (int i = 1; i <= 5; i++)
{
    if (i == 3) continue;
    Console.WriteLine(i);  // Prints 1, 2, 4, 5
}

// goto - jumps to labeled statement (avoid using)
for (int i = 0; i < 10; i++)
{
    if (i == 5) goto EndLoop;
}
EndLoop:
Console.WriteLine("Loop ended");
```

## 5.6 Nested Loops - Pattern Programs

```csharp
// Right Triangle Pattern
// *
// * *
// * * *
// * * * *

for (int i = 1; i <= 4; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}

// Number Triangle
// 1
// 1 2
// 1 2 3

for (int i = 1; i <= 3; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j + " ");
    }
    Console.WriteLine();
}

// Pyramid Pattern
//     *
//    * *
//   * * *
//  * * * *

int n = 4;
for (int i = 1; i <= n; i++)
{
    for (int space = 1; space <= n - i; space++)
        Console.Write(" ");
    for (int j = 1; j <= i; j++)
        Console.Write("* ");
    Console.WriteLine();
}
```

### MCQ Points:
- ✅ `while` is entry-controlled (checks before executing)
- ✅ `do-while` is exit-controlled (executes at least once)
- ✅ `break` exits loop, `continue` skips iteration
- ✅ `foreach` is read-only (cannot modify collection elements)

---

# 🔷 SECTION 6: OOP CONCEPTS (CORE)

## 6.1 Object, Class, Fields, Methods

### Definitions:
- **Class:** Blueprint/template for creating objects. Defines properties and behaviors.
- **Object:** Instance of a class. Occupies memory at runtime.
- **Fields:** Variables declared inside a class (data members)
- **Methods:** Functions inside a class (member functions)

```csharp
// Class Definition
class Student
{
    // Fields (data members)
    public int Id;
    public string Name;
    
    // Method (member function)
    public void Display()
    {
        Console.WriteLine($"Id: {Id}, Name: {Name}");
    }
}

// Creating Object
class Program
{
    static void Main()
    {
        Student s1 = new Student();  // Object creation
        s1.Id = 101;                 // Assigning field value
        s1.Name = "Amit";
        s1.Display();                // Calling method
    }
}
```

### MCQ Points:
- ✅ Object is created using `new` keyword
- ✅ Object gets memory allocation in **Heap**
- ✅ Reference variable stored in **Stack**
- ✅ Multiple objects can be created from one class

---

## 6.2 Access Modifiers

| Modifier | Same Class | Same Assembly | Child Class | Outside |
|----------|------------|---------------|-------------|---------|
| `public` | ✅ | ✅ | ✅ | ✅ |
| `private` | ✅ | ❌ | ❌ | ❌ |
| `protected` | ✅ | ❌ | ✅ | ❌ |
| `internal` | ✅ | ✅ | ❌ | ❌ |
| `protected internal` | ✅ | ✅ | ✅ | ❌ |
| `private protected` | ✅ | ❌ | ✅* | ❌ |

*Only if child is in same assembly

```csharp
class Example
{
    public int PublicField;        // Accessible everywhere
    private int PrivateField;       // Only in this class
    protected int ProtectedField;   // This class + child classes
    internal int InternalField;     // Same assembly only
}
```

---

## 6.3 Static, Constant & Readonly Fields

```csharp
class Demo
{
    // Static - Belongs to class, shared by all objects
    public static int Count = 0;
    
    // Constant - Compile-time constant, cannot change
    public const double PI = 3.14159;
    
    // Readonly - Runtime constant, set once (in constructor)
    public readonly int MaxSize;
    
    public Demo(int size)
    {
        MaxSize = size;  // Can set readonly in constructor
    }
}

// Usage
Console.WriteLine(Demo.Count);  // Static accessed via class name
Console.WriteLine(Demo.PI);     // Constant accessed via class name
```

### MCQ Points:
| Feature | `const` | `readonly` | `static` |
|---------|---------|------------|----------|
| When assigned | Compile-time | Runtime (constructor) | Any time |
| Memory | Per class | Per object | Per class |
| Can change | ❌ | ❌ (after constructor) | ✅ |

---

## 6.4 Encapsulation

**Definition:** Bundling data (fields) and methods together, hiding internal implementation using access modifiers.

### Benefits:
1. Data Hiding - Internal data is protected
2. Controlled Access - Through getters/setters
3. Flexibility - Can change implementation without affecting users

```csharp
class BankAccount
{
    // Private field - Data hiding
    private double balance;
    
    // Public methods - Controlled access
    public void Deposit(double amount)
    {
        if (amount > 0)
            balance += amount;
    }
    
    public bool Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            return true;
        }
        return false;
    }
    
    public double GetBalance()
    {
        return balance;
    }
}
```

---

# 🔷 SECTION 7: METHODS & ENCAPSULATION

## 7.1 Static Methods

**Definition:** Methods that belong to the class, not to any specific object.

```csharp
class MathHelper
{
    // Static method - No object needed
    public static int Add(int a, int b) => a + b;
    public static int Max(int a, int b) => (a > b) ? a : b;
}

// Usage
int sum = MathHelper.Add(5, 3);  // Called using class name
```

### MCQ Points:
- ✅ Static methods cannot access instance members directly
- ✅ Static methods can access other static members
- ✅ Called using ClassName.MethodName()

---

## 7.2 Parameters & Overloading

### Method Overloading (Compile-time Polymorphism):
**Definition:** Same method name, different parameters (type/count/order)

```csharp
class Calculator
{
    public int Add(int a, int b) => a + b;           // 2 int params
    public int Add(int a, int b, int c) => a + b + c; // 3 int params
    public double Add(double a, double b) => a + b;   // 2 double params
}

// Usage
Calculator calc = new Calculator();
Console.WriteLine(calc.Add(2, 3));       // Calls int version
Console.WriteLine(calc.Add(2, 3, 4));    // Calls 3-param version
Console.WriteLine(calc.Add(2.5, 3.5));   // Calls double version
```

### MCQ Points:
- ✅ Return type alone cannot differentiate overloaded methods
- ✅ Parameter order matters in overloading
- ✅ Resolved at compile time

---

## 7.3 Default & Named Arguments

```csharp
// Default Parameters
void Greet(string name, string greeting = "Hello")
{
    Console.WriteLine($"{greeting}, {name}!");
}

Greet("John");           // Output: Hello, John!
Greet("John", "Hi");     // Output: Hi, John!

// Named Arguments
void CreateUser(string name, int age, string city)
{
    Console.WriteLine($"{name}, {age}, {city}");
}

CreateUser(age: 25, name: "Amit", city: "Delhi");  // Order doesn't matter
```

---

## 7.4 ref, out, in Parameter Modifiers

```csharp
// ref - Must be initialized before passing
void DoubleValue(ref int x)
{
    x = x * 2;
}
int num = 5;
DoubleValue(ref num);  // num is now 10

// out - Can be uninitialized, must be assigned in method
void GetValues(out int a, out int b)
{
    a = 10;
    b = 20;
}
GetValues(out int x, out int y);  // x=10, y=20

// in - Read-only reference (cannot modify)
void PrintValue(in int x)
{
    Console.WriteLine(x);
    // x = 5;  // Error: cannot modify
}
```

### MCQ Comparison:
| Modifier | Initialization | Modified in Method | Value Changes Reflect |
|----------|----------------|--------------------|-----------------------|
| `ref` | Required | ✅ | ✅ |
| `out` | Not required | Must assign | ✅ |
| `in` | Required | ❌ | N/A |

---

## 7.5 Local Functions

```csharp
void ProcessData()
{
    // Local function inside method
    int Square(int x) => x * x;
    
    // Static local function (C# 8.0) - cannot access outer variables
    static int Cube(int x) => x * x * x;
    
    Console.WriteLine(Square(5));  // 25
    Console.WriteLine(Cube(3));    // 27
}
```

---

## 7.6 Recursion

**Definition:** A method that calls itself.

```csharp
// Factorial using recursion
int Factorial(int n)
{
    if (n <= 1) return 1;  // Base case
    return n * Factorial(n - 1);  // Recursive call
}
// Factorial(5) = 5 * 4 * 3 * 2 * 1 = 120

// Fibonacci using recursion
int Fibonacci(int n)
{
    if (n <= 1) return n;
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}
// 0, 1, 1, 2, 3, 5, 8, 13...
```

---

## 7.7 Type Conversions

```csharp
// Implicit Casting (Automatic) - Smaller to larger
int myInt = 100;
double myDouble = myInt;  // int → double (safe)

// Explicit Casting (Manual) - Larger to smaller
double d = 9.78;
int i = (int)d;  // d → int (may lose data)

// Parse Methods
string str = "123";
int num = int.Parse(str);           // Throws exception if invalid
int num2 = int.TryParse(str, out int result) ? result : 0;  // Safe

// Convert Class
string s = "456";
int val = Convert.ToInt32(s);
double dval = Convert.ToDouble(s);
```

### TryParse vs Parse:
| Method | Invalid Input | Returns |
|--------|---------------|---------|
| `Parse` | Throws exception | Parsed value |
| `TryParse` | Returns false | bool + out param |

---

# 🔷 SECTION 8: CONSTRUCTORS

## 8.1 Types of Constructors

**Definition:** Special method called automatically when object is created. Same name as class, no return type.

```csharp
class Employee
{
    public int Id;
    public string Name;
    
    // 1. Default Constructor (Parameterless)
    public Employee()
    {
        Id = 0;
        Name = "Unknown";
    }
    
    // 2. Parameterized Constructor
    public Employee(int id, string name)
    {
        Id = id;
        Name = name;
    }
    
    // 3. Copy Constructor
    public Employee(Employee other)
    {
        Id = other.Id;
        Name = other.Name;
    }
}

// 4. Static Constructor
class Logger
{
    public static string LogPath;
    
    static Logger()  // Called once, before first use
    {
        LogPath = "C:/logs";
    }
}
```

### Object Initializer Syntax:
```csharp
Employee emp = new Employee { Id = 1, Name = "Rahul" };
```

### MCQ Points:
- ✅ Constructor has no return type
- ✅ Static constructor runs only once
- ✅ Static constructor cannot have parameters
- ✅ If no constructor defined, compiler creates default

---

## 8.2 Constructor Chaining

```csharp
class Person
{
    public string Name;
    public int Age;
    public string City;
    
    public Person() : this("Unknown", 0, "Unknown") { }
    
    public Person(string name) : this(name, 0, "Unknown") { }
    
    public Person(string name, int age, string city)
    {
        Name = name;
        Age = age;
        City = city;
    }
}
```

---

# 🔷 SECTION 9: PROPERTIES & INDEXERS

## 9.1 Properties

**Definition:** Special members providing controlled access to private fields.

```csharp
class Product
{
    // Auto-implemented properties
    public int Id { get; set; }
    public string Name { get; set; }
    
    // Read-only property
    public string Code { get; }
    
    // Property with backing field
    private decimal _price;
    public decimal Price
    {
        get { return _price; }
        set
        {
            if (value >= 0)
                _price = value;
        }
    }
    
    // Computed property (read-only)
    public decimal Tax => Price * 0.18m;
    
    // Expression-bodied property
    public string DisplayName => $"{Id}: {Name}";
}
```

### Property Types:
| Type | Description |
|------|-------------|
| Read-Write | `{ get; set; }` |
| Read-Only | `{ get; }` or only `get` accessor |
| Write-Only | `{ set; }` (rare) |
| Computed | No backing field, calculated |

---

## 9.2 Indexers

**Definition:** Allow objects to be indexed like arrays.

```csharp
class StringCollection
{
    private string[] data = new string[10];
    
    // Indexer
    public string this[int index]
    {
        get => data[index];
        set => data[index] = value;
    }
    
    // Overloaded indexer
    public string this[string key]
    {
        get => Array.Find(data, s => s == key);
    }
}

// Usage
StringCollection collection = new StringCollection();
collection[0] = "Hello";  // Using indexer
string value = collection[0];
```

---

# 🔷 SECTION 10: INHERITANCE

## 10.1 Inheritance Basics

**Definition:** Mechanism where child class acquires properties and methods of parent class.

```csharp
// Base (Parent) class
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    
    public void Speak() => Console.WriteLine($"{Name} is speaking");
}

// Derived (Child) class
class Student : Person
{
    public int RollNo { get; set; }
    
    public void Study() => Console.WriteLine($"{Name} is studying");
}

// Usage
Student s = new Student();
s.Name = "Rahul";  // Inherited property
s.Speak();         // Inherited method
s.Study();         // Own method
```

## 10.2 base Keyword

```csharp
class Animal
{
    public string Name;
    
    public Animal(string name)
    {
        Name = name;
    }
    
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes sound");
    }
}

class Dog : Animal
{
    public Dog(string name) : base(name) { }  // Calling parent constructor
    
    public override void Sound()
    {
        base.Sound();  // Calling parent method
        Console.WriteLine("Dog barks");
    }
}
```

## 10.3 Method Hiding (new keyword)

```csharp
class Parent
{
    public void Show() => Console.WriteLine("Parent Show");
}

class Child : Parent
{
    public new void Show() => Console.WriteLine("Child Show");  // Hides parent method
}

// Usage
Parent p = new Child();
p.Show();  // Output: "Parent Show" (resolved by reference type)

Child c = new Child();
c.Show();  // Output: "Child Show"
```

## 10.4 Method Overriding (virtual/override)

```csharp
class Animal
{
    public virtual void Sound() => Console.WriteLine("Animal sound");
}

class Dog : Animal
{
    public override void Sound() => Console.WriteLine("Dog barks");
}

// Usage
Animal a = new Dog();
a.Sound();  // Output: "Dog barks" (resolved at runtime)
```

### Method Hiding vs Overriding:
| Feature | Hiding (`new`) | Overriding (`override`) |
|---------|----------------|------------------------|
| Keyword | `new` | `override` (requires `virtual`) |
| Binding | Compile-time | Runtime |
| Base ref behavior | Calls base method | Calls derived method |

---

## 10.5 Sealed Classes & Methods

**Definition:** Sealed prevents inheritance (class) or further overriding (method).

```csharp
// Sealed class - cannot be inherited
sealed class FinalClass
{
    public void Display() => Console.WriteLine("Cannot inherit me");
}

// Sealed method - cannot be overridden further
class Animal
{
    public virtual void Eat() => Console.WriteLine("Eating");
}

class Dog : Animal
{
    public sealed override void Eat() => Console.WriteLine("Dog eating");
}

class Bulldog : Dog
{
    // public override void Eat() { }  // Error: Cannot override sealed
}
```

---

# 🔷 SECTION 11: ABSTRACT CLASSES & METHODS

**Definition:** Abstract class provides partial implementation and cannot be instantiated.

```csharp
abstract class Shape
{
    public string Color { get; set; }
    
    // Abstract method (no implementation)
    public abstract double CalculateArea();
    
    // Virtual method (has implementation, can be overridden)
    public virtual void Display()
    {
        Console.WriteLine($"Shape with color: {Color}");
    }
    
    // Regular method
    public void PrintInfo()
    {
        Console.WriteLine($"Area: {CalculateArea()}");
    }
}

class Circle : Shape
{
    public double Radius { get; set; }
    
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    
    public override double CalculateArea()
    {
        return Width * Height;
    }
}

// Usage
Shape shape = new Circle { Radius = 5, Color = "Red" };
Console.WriteLine(shape.CalculateArea());  // 78.54
```

### MCQ Points:
- ✅ Abstract class cannot be instantiated
- ✅ Abstract method has no body
- ✅ Derived class must implement all abstract methods
- ✅ Abstract class can have constructors (called by derived)

---

# 🔷 SECTION 12: INTERFACES

## 12.1 Interface Basics

**Definition:** Contract that defines what a class must implement. Provides 100% abstraction.

```csharp
// Interface definition
interface IPayment
{
    void Pay(decimal amount);     // Method signature
    bool Validate();              // No implementation
    decimal ProcessingFee { get; }  // Property
}

// Implementation
class CreditCardPayment : IPayment
{
    public decimal ProcessingFee => 2.5m;
    
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount} via Credit Card");
    }
    
    public bool Validate() => true;
}

class UpiPayment : IPayment
{
    public decimal ProcessingFee => 0m;
    
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount} via UPI");
    }
    
    public bool Validate() => true;
}
```

## 12.2 Multiple Interface Implementation

```csharp
interface IReadable
{
    void Read();
}

interface IWritable
{
    void Write();
}

// Class implementing multiple interfaces
class File : IReadable, IWritable
{
    public void Read() => Console.WriteLine("Reading file");
    public void Write() => Console.WriteLine("Writing file");
}
```

## 12.3 Explicit Interface Implementation

```csharp
interface IA
{
    void Show();
}

interface IB
{
    void Show();
}

class Demo : IA, IB
{
    // Explicit implementation
    void IA.Show() => Console.WriteLine("IA Show");
    void IB.Show() => Console.WriteLine("IB Show");
}

// Usage
Demo d = new Demo();
((IA)d).Show();  // "IA Show"
((IB)d).Show();  // "IB Show"
```

## 12.4 Default Interface Methods (C# 8.0)

```csharp
interface ILogger
{
    void Log(string message);
    
    // Default implementation (C# 8.0)
    void LogError(string error) => Log($"ERROR: {error}");
}
```

---

## 12.5 Interface vs Abstract Class

| Feature | Interface | Abstract Class |
|---------|-----------|----------------|
| **Instantiation** | ❌ Cannot | ❌ Cannot |
| **Method Body** | Default methods only (C# 8+) | Can have full implementation |
| **Fields** | ❌ Not allowed | ✅ Allowed |
| **Constructor** | ❌ Not allowed | ✅ Allowed |
| **Access Modifiers** | Public by default | Any modifier |
| **Multiple Inheritance** | ✅ Yes | ❌ No |
| **Use When** | Unrelated classes share behavior | Related classes share code |

### MCQ Points:
- ✅ Interface members are public by default
- ✅ Class can implement multiple interfaces
- ✅ Interface provides "can-do" relationship
- ✅ Abstract class provides "is-a" relationship

---

# 🔷 SECTION 13: POLYMORPHISM

## 13.1 Compile-Time Polymorphism (Method Overloading)

```csharp
class Calculator
{
    // Same name, different parameters
    public int Add(int a, int b) => a + b;
    public double Add(double a, double b) => a + b;
    public int Add(int a, int b, int c) => a + b + c;
}
```

## 13.2 Runtime Polymorphism (Method Overriding)

```csharp
class Animal
{
    public virtual void MakeSound() => Console.WriteLine("Some sound");
}

class Dog : Animal
{
    public override void MakeSound() => Console.WriteLine("Bark!");
}

class Cat : Animal
{
    public override void MakeSound() => Console.WriteLine("Meow!");
}

// Dynamic Polymorphism in action
Animal[] animals = { new Dog(), new Cat(), new Animal() };
foreach (Animal a in animals)
{
    a.MakeSound();  // Calls appropriate method based on actual object type
}
// Output: Bark!, Meow!, Some sound
```

### MCQ Points:
- ✅ Overloading = Compile-time = Early binding
- ✅ Overriding = Runtime = Late binding = Dynamic polymorphism
- ✅ Virtual method can be overridden
- ✅ Abstract method must be overridden

---

# 🔷 SECTION 14: EXCEPTION HANDLING

## 14.1 Try-Catch-Finally

**Definition:** Mechanism to handle runtime errors gracefully.

```csharp
try
{
    int[] arr = { 1, 2, 3 };
    Console.WriteLine(arr[5]);  // IndexOutOfRangeException
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Index error: " + ex.Message);
}
catch (Exception ex)  // Generic catch (should be last)
{
    Console.WriteLine("Error: " + ex.Message);
}
finally
{
    Console.WriteLine("Cleanup code - always runs");
}
```

## 14.2 Common Exception Types

| Exception | When Thrown |
|-----------|-------------|
| `NullReferenceException` | Accessing null object |
| `IndexOutOfRangeException` | Invalid array index |
| `DivideByZeroException` | Division by zero (integers) |
| `FormatException` | Invalid format conversion |
| `InvalidOperationException` | Invalid operation for current state |
| `ArgumentNullException` | Null argument passed |
| `ArgumentException` | Invalid argument value |
| `FileNotFoundException` | File not found |

## 14.3 Throwing Exceptions

```csharp
void SetAge(int age)
{
    if (age < 0)
        throw new ArgumentException("Age cannot be negative");
    if (age > 150)
        throw new ArgumentOutOfRangeException("Age too high");
}

// Re-throwing
try
{
    // code
}
catch (Exception ex)
{
    // Log error
    throw;  // Re-throw with original stack trace
}
```

## 14.4 Custom Exceptions

```csharp
class InsufficientFundsException : Exception
{
    public decimal Balance { get; }
    public decimal Requested { get; }
    
    public InsufficientFundsException(decimal balance, decimal requested)
        : base($"Insufficient funds. Balance: {balance}, Requested: {requested}")
    {
        Balance = balance;
        Requested = requested;
    }
}

// Usage
void Withdraw(decimal amount)
{
    if (amount > balance)
        throw new InsufficientFundsException(balance, amount);
}
```

---

# 🔷 SECTION 15: NAMESPACES

## 15.1 Namespace Basics

**Definition:** Container for organizing classes and preventing naming conflicts.

```csharp
// Defining namespace
namespace MyCompany.Project.DataLayer
{
    public class Customer
    {
        public int Id { get; set; }
    }
}

// Using namespace
using MyCompany.Project.DataLayer;

class Program
{
    static void Main()
    {
        Customer c = new Customer();
    }
}
```

## 15.2 Nested Namespaces

```csharp
namespace MyCompany
{
    namespace Project
    {
        class Helper { }
    }
}

// Shorthand
namespace MyCompany.Project
{
    class Helper { }
}

// File-scoped namespace (C# 10)
namespace MyCompany.Project;

class Helper { }
```

## 15.3 Using Directives

```csharp
// Regular using
using System;
using System.Collections.Generic;

// Using alias
using Project = MyCompany.LongNamespace.Project;

// Static import
using static System.Math;
using static System.Console;

class Program
{
    static void Main()
    {
        WriteLine(Sqrt(16));  // No need for Console. or Math.
    }
}

// Global using (C# 10) - applies to entire project
global using System;
```

---

# 🔷 SECTION 16: PARTIAL & STATIC CLASSES

## 16.1 Partial Classes

**Definition:** Allows splitting a class across multiple files.

```csharp
// File: PartialEmployeeOne.cs
public partial class PartialEmployee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    partial void PartialMethod();  // Declaration
}

// File: PartialEmployeeTwo.cs
public partial class PartialEmployee
{
    public double Salary { get; set; }
    
    public void DisplayFullName()
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }
    
    partial void PartialMethod()  // Implementation
    {
        Console.WriteLine("Partial method executed");
    }
}
```

### Use Cases:
- ✅ Auto-generated code (designer files)
- ✅ Large classes split for maintainability
- ✅ Multiple developers working on same class

## 16.2 Static Classes

**Definition:** Class that cannot be instantiated. Contains only static members.

```csharp
public static class MathHelper
{
    public static double PI = 3.14159;
    
    public static int Add(int a, int b) => a + b;
    public static int Max(int a, int b) => Math.Max(a, b);
    
    // Extension method
    public static bool IsEven(this int number) => number % 2 == 0;
}

// Usage
int sum = MathHelper.Add(5, 3);
bool isEven = 10.IsEven();  // Extension method
```

### MCQ Points:
- ✅ Static class cannot be inherited
- ✅ Static class cannot be instantiated
- ✅ All members must be static
- ✅ Extension methods must be in static class

---

# 🔷 SECTION 17: ENUMERATIONS

**Definition:** Named constants representing integral values.

```csharp
// Basic enum
enum Days
{
    Sunday,     // 0
    Monday,     // 1
    Tuesday,    // 2
    Wednesday,  // 3
    Thursday,   // 4
    Friday,     // 5
    Saturday    // 6
}

// Enum with explicit values
enum Status
{
    Pending = 1,
    Active = 5,
    Inactive = 10
}

// Enum with underlying type
enum Priority : byte
{
    Low = 1,
    Medium = 2,
    High = 3
}

// Flags enum (bitwise operations)
[Flags]
enum Permissions
{
    None = 0,
    Read = 1,
    Write = 2,
    Execute = 4,
    All = Read | Write | Execute
}

// Usage
Days today = Days.Monday;
Console.WriteLine((int)today);  // 1
Console.WriteLine(today.ToString());  // "Monday"

// Parsing
Days d = (Days)Enum.Parse(typeof(Days), "Friday");
bool success = Enum.TryParse("Saturday", out Days result);

// Flags usage
Permissions p = Permissions.Read | Permissions.Write;
bool canRead = (p & Permissions.Read) != 0;  // true
```

---

# 🔷 SECTION 18: DELEGATES (BONUS)

**Definition:** Type-safe function pointer that can reference methods.

```csharp
// Delegate declaration
public delegate int CalculatorDelegate(int a, int b);

class Program
{
    static int Add(int a, int b) => a + b;
    static int Subtract(int a, int b) => a - b;
    
    static void Main()
    {
        // Single delegate
        CalculatorDelegate calc = Add;
        Console.WriteLine(calc(5, 3));  // 8
        
        // Multicast delegate
        calc += Subtract;
        Console.WriteLine(calc(5, 3));  // 2 (returns last)
        
        // Lambda expression
        CalculatorDelegate multiply = (a, b) => a * b;
    }
}
```

### Built-in Delegates:
```csharp
// Action - void return
Action<string> print = s => Console.WriteLine(s);

// Func - with return value
Func<int, int, int> add = (a, b) => a + b;

// Predicate - returns bool
Predicate<int> isEven = n => n % 2 == 0;
```

---

# 🔷 SECTION 19: QUICK REFERENCE TABLES

## Access Modifiers Summary:
| Modifier | Same Class | Derived (Same Assembly) | Derived (Other Assembly) | Non-Derived |
|----------|------------|------------------------|--------------------------|-------------|
| `public` | ✅ | ✅ | ✅ | ✅ |
| `private` | ✅ | ❌ | ❌ | ❌ |
| `protected` | ✅ | ✅ | ✅ | ❌ |
| `internal` | ✅ | ✅ | ❌ | ✅ (same assembly) |
| `protected internal` | ✅ | ✅ | ✅ | ✅ (same assembly) |

## Keywords Comparison:
| Keyword | Purpose | When Used |
|---------|---------|-----------|
| `virtual` | Allows override | Base class method |
| `override` | Overrides virtual | Derived class method |
| `abstract` | No implementation | Abstract class/method |
| `sealed` | Prevents override/inherit | Final class/method |
| `new` | Hides base member | Method hiding |
| `static` | Class-level member | Utility methods |
| `readonly` | Set once | Runtime constants |
| `const` | Compile-time constant | Fixed values |

## OOP Principles:
| Principle | Definition | Implementation |
|-----------|------------|----------------|
| **Encapsulation** | Hide data, expose behavior | Private fields, public methods |
| **Inheritance** | Acquire parent features | `: BaseClass` |
| **Polymorphism** | Many forms | Overloading, Overriding |
| **Abstraction** | Hide complexity | Abstract class, Interface |

---

# 🔷 SECTION 20: COMMON MCQ QUESTIONS

### Q1: What is the output?
```csharp
int x = 5;
Console.WriteLine(x++);
Console.WriteLine(++x);
```
**Answer:** 5, 7 (post-increment returns old value, pre-increment returns new)

### Q2: What is CLR?
**Answer:** Common Language Runtime - manages execution, memory, security.

### Q3: Difference between `==` and `Equals()`?
**Answer:** `==` compares references (for objects), `Equals()` can be overridden for value comparison.

### Q4: Can abstract class have constructor?
**Answer:** Yes, called by derived class constructors.

### Q5: What is boxing/unboxing?
**Answer:** Boxing = value type → object (heap). Unboxing = object → value type.

### Q6: Default access modifier for class?
**Answer:** `internal`

### Q7: Default access modifier for class members?
**Answer:** `private`

### Q8: Can we have static constructor with parameters?
**Answer:** No

### Q9: Difference between `throw` and `throw ex`?
**Answer:** `throw` preserves stack trace, `throw ex` resets it.

### Q10: What is the entry point of C# program?
**Answer:** `static void Main(string[] args)`

---

# 📝 LOGICAL CODING PRACTICE

## Pattern 1: Fibonacci Series
```csharp
void Fibonacci(int n)
{
    int a = 0, b = 1;
    for (int i = 0; i < n; i++)
    {
        Console.Write(a + " ");
        int temp = a + b;
        a = b;
        b = temp;
    }
}
// Output: 0 1 1 2 3 5 8 13...
```

## Pattern 2: Prime Number Check
```csharp
bool IsPrime(int n)
{
    if (n < 2) return false;
    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0) return false;
    }
    return true;
}
```

## Pattern 3: Palindrome Check
```csharp
bool IsPalindrome(string s)
{
    s = s.ToLower();
    int left = 0, right = s.Length - 1;
    while (left < right)
    {
        if (s[left++] != s[right--]) return false;
    }
    return true;
}
```

## Pattern 4: Reverse a Number
```csharp
int ReverseNumber(int n)
{
    int reversed = 0;
    while (n > 0)
    {
        reversed = reversed * 10 + n % 10;
        n /= 10;
    }
    return reversed;
}
```

## Pattern 5: Armstrong Number
```csharp
bool IsArmstrong(int n)
{
    int original = n, sum = 0;
    int digits = n.ToString().Length;
    while (n > 0)
    {
        int digit = n % 10;
        sum += (int)Math.Pow(digit, digits);
        n /= 10;
    }
    return sum == original;
}
// 153 = 1³ + 5³ + 3³ = 153 ✓
```

## Pattern 6: Array Operations
```csharp
// Find max element
int FindMax(int[] arr)
{
    int max = arr[0];
    foreach (int num in arr)
        if (num > max) max = num;
    return max;
}

// Find second largest
int SecondLargest(int[] arr)
{
    int first = int.MinValue, second = int.MinValue;
    foreach (int num in arr)
    {
        if (num > first)
        {
            second = first;
            first = num;
        }
        else if (num > second && num != first)
        {
            second = num;
        }
    }
    return second;
}
```

---

# ✅ INTERVIEW TIPS

1. **Always explain OOP principles with examples**
2. **Know the difference between abstract class and interface**
3. **Understand value types vs reference types**
4. **Be clear about access modifiers**
5. **Practice pattern programs and logical questions**
6. **Understand CLR, JIT, and .NET architecture**
7. **Know exception handling best practices**
8. **Understand constructor chaining and inheritance**

---

**🎯 Master these concepts for a strong foundation in C# and .NET!**

---
*Notes prepared for Capgemini .NET Training*
*Last Updated: December 2024*
