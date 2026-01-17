# LINQ (Language Integrated Query) in C# - Study Guide

---

## Table of Contents
1. [Introduction to LINQ](#introduction-to-linq)
2. [LINQ Basics](#linq-basics)
3. [LINQ Syntax Types](#linq-syntax-types)
4. [Filtering & Projection](#filtering--projection)
5. [Sorting](#sorting)
6. [Element Operators](#element-operators)
7. [Quantifier Operators](#quantifier-operators)
8. [Aggregation Operators](#aggregation-operators)
9. [Set Operators](#set-operators)
10. [Partitioning Operators](#partitioning-operators)
11. [Grouping](#grouping)
12. [Joining Data](#joining-data)
13. [Conversion Operators](#conversion-operators)
14. [Generation Operators](#generation-operators)
15. [LINQ with Custom Objects](#linq-with-custom-objects)
16. [LINQ Execution Flow](#linq-execution-flow)
17. [LINQ Best Practices](#linq-best-practices)
18. [Common LINQ Interview Questions](#common-linq-interview-questions)

---

## 1. Introduction to LINQ

- **What is LINQ?**
  - LINQ (Language Integrated Query) is a set of features in C# for querying data from different sources (collections, databases, XML, etc.) using a unified syntax.
- **Why LINQ exists?**
  - To provide a consistent, readable, and type-safe way to query data.
- **Advantages over traditional loops:**
  - Concise and expressive code
  - Compile-time checking
  - Supports complex queries
  - Works with multiple data sources

---

## 2. LINQ Basics

- **IEnumerable<T>:**
  - The core interface for LINQ queries. Most LINQ methods operate on `IEnumerable<T>`.
  - Example:
    ```csharp
    IEnumerable<int> numbers = new List<int> { 1, 2, 3 };
    ```
- **Deferred vs Immediate Execution:**
  - *Deferred*: Query is not executed until iterated (e.g., `Where`, `Select`).
  - *Immediate*: Query executes and returns results immediately (e.g., `ToList()`, `Count()`).
- **Lambda Expressions:**
  - Anonymous functions used in LINQ.
    ```csharp
    var evens = numbers.Where(n => n % 2 == 0);
    ```

---

## 3. LINQ Syntax Types

- **Method Syntax:**
  - Uses extension methods and lambdas.
    ```csharp
    var result = numbers.Where(n => n > 2).Select(n => n * 2);
    ```
- **Query Syntax:**
  - SQL-like, more readable for complex queries.
    ```csharp
    var result = from n in numbers
                 where n > 2
                 select n * 2;
    ```
- **Comparison Table:**

| Feature         | Method Syntax                | Query Syntax                |
|-----------------|-----------------------------|-----------------------------|
| Readability     | Good for simple queries      | Good for complex queries    |
| Flexibility     | All LINQ features supported  | Some features limited       |
| SQL-like        | No                          | Yes                         |

---

## 4. Filtering & Projection

- **Where:**
    ```csharp
    var evens = numbers.Where(n => n % 2 == 0); // Filters even numbers
    ```
- **Select:**
    ```csharp
    var squares = numbers.Select(n => n * n); // Projects each number to its square
    ```
- **SelectMany:**
    ```csharp
    var listOfLists = new List<List<int>> { new List<int>{1,2}, new List<int>{3,4} };
    var flat = listOfLists.SelectMany(l => l); // Flattens nested lists
    ```

---

## 5. Sorting

- **OrderBy:**
    ```csharp
    var sorted = numbers.OrderBy(n => n); // Ascending order
    ```
- **OrderByDescending:**
    ```csharp
    var desc = numbers.OrderByDescending(n => n); // Descending order
    ```
- **ThenBy / ThenByDescending:**
    ```csharp
    var people = new[] {
        new { Name = "A", Age = 30 },
        new { Name = "B", Age = 25 },
        new { Name = "A", Age = 20 }
    };
    var sorted = people.OrderBy(p => p.Name).ThenBy(p => p.Age);
    ```

---

## 6. Element Operators

- **First / FirstOrDefault:**
    ```csharp
    var first = numbers.First(); // Throws if empty
    var firstOrDefault = numbers.FirstOrDefault(); // Returns default if empty
    ```
- **Single / SingleOrDefault:**
    ```csharp
    var single = numbers.Single(n => n == 2); // Throws if not exactly one match
    var singleOrDefault = numbers.SingleOrDefault(n => n == 2);
    ```
- **Last / LastOrDefault:**
    ```csharp
    var last = numbers.Last();
    var lastOrDefault = numbers.LastOrDefault();
    ```
- **ElementAt:**
    ```csharp
    var third = numbers.ElementAt(2); // Zero-based index
    ```

---

## 7. Quantifier Operators

- **Any:**
    ```csharp
    bool hasEven = numbers.Any(n => n % 2 == 0); // True if any even
    ```
- **All:**
    ```csharp
    bool allPositive = numbers.All(n => n > 0); // True if all positive
    ```
- **Contains:**
    ```csharp
    bool hasThree = numbers.Contains(3); // True if 3 exists
    ```

---

## 8. Aggregation Operators

- **Count:**
    ```csharp
    int count = numbers.Count();
    ```
- **Sum:**
    ```csharp
    int total = numbers.Sum();
    ```
- **Min:**
    ```csharp
    int min = numbers.Min();
    ```
- **Max:**
    ```csharp
    int max = numbers.Max();
    ```
- **Average:**
    ```csharp
    double avg = numbers.Average();
    ```

---

## 9. Set Operators

- **Distinct:**
    ```csharp
    var unique = numbers.Distinct();
    ```
- **Union:**
    ```csharp
    var union = numbers.Union(new[] { 3, 4, 5 });
    ```
- **Intersect:**
    ```csharp
    var intersect = numbers.Intersect(new[] { 2, 3 });
    ```
- **Except:**
    ```csharp
    var except = numbers.Except(new[] { 1, 2 });
    ```

---

## 10. Partitioning Operators

- **Take:**
    ```csharp
    var firstTwo = numbers.Take(2); // Takes first 2 elements
    ```
- **Skip:**
    ```csharp
    var skipTwo = numbers.Skip(2); // Skips first 2 elements
    ```
- **TakeWhile:**
    ```csharp
    var takeWhile = numbers.TakeWhile(n => n < 3);
    ```
- **SkipWhile:**
    ```csharp
    var skipWhile = numbers.SkipWhile(n => n < 3);
    ```
- **Pagination Example:**
    ```csharp
    int page = 2, pageSize = 3;
    var paged = numbers.Skip((page - 1) * pageSize).Take(pageSize);
    ```

---

## 11. Grouping

- **GroupBy:**
    ```csharp
    var grouped = numbers.GroupBy(n => n % 2 == 0 ? "Even" : "Odd");
    foreach (var group in grouped)
    {
        Console.WriteLine($"{group.Key}: {string.Join(",", group)}");
    }
    ```
- **Grouping with objects:**
    ```csharp
    var students = new[] {
        new { Name = "A", Grade = "A" },
        new { Name = "B", Grade = "B" },
        new { Name = "C", Grade = "A" }
    };
    var byGrade = students.GroupBy(s => s.Grade);
    ```
- **Nested grouping example:**
    ```csharp
    var nested = students.GroupBy(s => s.Grade)
                         .Select(g => new { Grade = g.Key, Students = g });
    ```

---

## 12. Joining Data

- **Join:**
    ```csharp
    var employees = new[] { new { Id = 1, Name = "A" } };
    var departments = new[] { new { Id = 1, Dept = "HR" } };
    var join = employees.Join(departments,
                             e => e.Id,
                             d => d.Id,
                             (e, d) => new { e.Name, d.Dept });
    ```
- **GroupJoin:**
    ```csharp
    var groupJoin = departments.GroupJoin(employees,
        d => d.Id,
        e => e.Id,
        (d, es) => new { d.Dept, Employees = es });
    ```
- **Left Join simulation:**
    ```csharp
    var leftJoin = from d in departments
                   join e in employees on d.Id equals e.Id into empGroup
                   from e in empGroup.DefaultIfEmpty()
                   select new { d.Dept, Employee = e?.Name };
    ```
- **SQL vs LINQ Join comparison:**

| SQL Join Syntax         | LINQ Join Syntax                |
|------------------------|---------------------------------|
| SELECT ... FROM ...    | from ... in ...                 |
| INNER JOIN ... ON ...  | join ... in ... on ... equals ...|
| LEFT JOIN ...          | join ... into ... from ... in ...DefaultIfEmpty() |

---

## 13. Conversion Operators

- **ToList:**
    ```csharp
    var list = numbers.ToList();
    ```
- **ToArray:**
    ```csharp
    var array = numbers.ToArray();
    ```
- **ToDictionary:**
    ```csharp
    var dict = students.ToDictionary(s => s.Name, s => s.Grade);
    ```
- **Cast / OfType:**
    ```csharp
    var objects = new object[] { 1, "two", 3 };
    var ints = objects.OfType<int>(); // Filters only ints
    ```

---

## 14. Generation Operators

- **Range:**
    ```csharp
    var range = Enumerable.Range(1, 5); // 1,2,3,4,5
    ```
- **Repeat:**
    ```csharp
    var repeat = Enumerable.Repeat("A", 3); // "A","A","A"
    ```
- **Empty:**
    ```csharp
    var empty = Enumerable.Empty<int>();
    ```

---

## 15. LINQ with Custom Objects

- **Example:**
    ```csharp
    class Student { public string Name; public int Marks; }
    var students = new List<Student> {
        new Student { Name = "A", Marks = 80 },
        new Student { Name = "B", Marks = 60 }
    };
    var toppers = students.Where(s => s.Marks > 70);
    ```

---

## 16. LINQ Execution Flow

- **Deferred execution:**
  - Query is executed when iterated (e.g., `foreach`, `ToList()`).
- **Immediate execution:**
  - Query executes immediately (e.g., `Count()`, `ToArray()`).
- **Performance impact:**
  - Deferred execution can improve performance by avoiding unnecessary computation.
  - Be careful: modifying the source after query definition but before execution can lead to unexpected results.

---

## 17. LINQ Best Practices

- **When to use LINQ:**
  - For readable, concise, and maintainable code
  - When working with in-memory collections
- **When NOT to use LINQ:**
  - For performance-critical, low-level operations
  - When query complexity hurts readability
- **Readability vs performance:**
  - Prefer readability for most business logic
  - Profile and optimize only if performance is a bottleneck

---

## 18. Common LINQ Interview Questions

- **What is deferred execution?**
  - Query is not executed until results are requested.
- **Difference between First and Single?**
  - `First` returns the first element; `Single` expects exactly one element.
- **How to perform a left join in LINQ?**
  - Use `join ... into` and `DefaultIfEmpty()`.
- **What is the output of `numbers.Where(n => n > 10).FirstOrDefault()` if no element > 10?**
  - Returns default value (0 for int).
- **Can you chain multiple LINQ operators?**
  - Yes, LINQ supports fluent chaining.
- **One-line definitions:**
  - *Select*: Projects each element
  - *Where*: Filters elements
  - *GroupBy*: Groups elements by key
  - *Join*: Combines elements from two sequences

---

### Interview Tips
- Always mention deferred vs immediate execution.
- Know the difference between `First`, `Single`, and `Default` variants.
- Be ready to write both method and query syntax.
- Understand how LINQ works with custom objects.
- Be aware of performance implications in large datasets.

### Common Pitfalls
- Using `Single` when multiple matches are possible (throws exception).
- Forgetting to materialize queries (e.g., not calling `ToList()` when needed).
- Modifying source collection after defining a deferred query.

---

*End of Guide*