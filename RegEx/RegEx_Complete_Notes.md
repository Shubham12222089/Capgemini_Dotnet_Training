# 📘 Complete Beginner's Guide to Regular Expressions (Regex) in C#

---

## 📌 Table of Contents
1. [What is Regex?](#1-what-is-regex)
2. [Why Regex is Needed](#2-why-regex-is-needed)
3. [Regex in Real Life (Analogy)](#3-regex-in-real-life-analogy)
4. [Regex in C#](#4-regex-in-c)
5. [Basic Regex Syntax](#5-basic-regex-syntax-beginner-level)
6. [Creating and Using Regex in C#](#6-creating-and-using-regex-in-c)
7. [Common Regex Examples](#7-common-regex-examples)
8. [Greedy vs Lazy Matching](#8-greedy-vs-lazy-matching)
9. [Groups and Capturing](#9-groups-and-capturing)
10. [Regex Flags / Options](#10-regex-flags--options)
11. [Common Regex Mistakes Beginners Make](#11-common-regex-mistakes-beginners-make)
12. [Regex Performance Tips](#12-regex-performance-tips-beginner-safe)
13. [Real-World Use Cases](#13-real-world-use-cases)
14. [Interview-Ready Summary](#14-interview-ready-summary)

---

## 1. What is Regex?

### 🔹 Simple Definition
**Regex** (short for **Regular Expression**) is a **pattern** that describes a set of strings. Think of it as a **search template** or **rule** that helps you find, match, or replace text.

### 🔹 Analogy: The Search Template
Imagine you have a big phone book with thousands of entries. You want to find all phone numbers that start with "98". Instead of looking at each number one by one, you use a **rule/pattern** that says:
> "Find anything that starts with 98 and has 10 digits"

That rule is essentially what regex does!

### 🔹 Why It Exists
- To **search** for patterns in text (not just exact words)
- To **validate** if text follows a specific format
- To **extract** specific parts from text
- To **replace** text based on patterns

### 🔹 Where It Is Used
| Area | Example |
|------|---------|
| Form Validation | Check if email is valid |
| Password Rules | Ensure password has uppercase, number, etc. |
| Data Extraction | Pull phone numbers from a document |
| Log Parsing | Find error messages in log files |
| Search & Replace | Replace all dates in a specific format |
| Input Sanitization | Remove unwanted characters |

---

## 2. Why Regex is Needed

### 🔹 Problems WITHOUT Regex

Let's say you want to check if a string is a valid email. Without regex, you'd have to:

```csharp
// Without Regex - Complex and Error-Prone!
bool IsValidEmail(string email)
{
    // Check if @ exists
    if (!email.Contains("@")) return false;
    
    // Check if there's text before @
    int atIndex = email.IndexOf("@");
    if (atIndex == 0) return false;
    
    // Check if there's a dot after @
    string afterAt = email.Substring(atIndex + 1);
    if (!afterAt.Contains(".")) return false;
    
    // Check if domain has at least 2 characters after dot
    int dotIndex = afterAt.LastIndexOf(".");
    string extension = afterAt.Substring(dotIndex + 1);
    if (extension.Length < 2) return false;
    
    // And many more checks...
    return true;
}
```

**Problems:**
- 😫 Too much code
- 🐛 Easy to miss edge cases
- 🔧 Hard to maintain
- 📚 Difficult to read

### 🔹 WITH Regex - Simple and Clean!

```csharp
using System.Text.RegularExpressions;

bool IsValidEmail(string email)
{
    string pattern = @"^[\w.-]+@[\w.-]+\.\w{2,}$";
    return Regex.IsMatch(email, pattern);
}
```

**Benefits:**
- ✅ One line of pattern matching
- ✅ Industry-standard patterns available
- ✅ Easy to modify rules
- ✅ Handles edge cases automatically

---

## 3. Regex in Real Life (Analogy)

Think of regex as **filters** or **rules** you apply to text:

### 📱 Finding Phone Numbers
**Rule:** "A phone number is 10 digits, may start with +91"
```
Pattern: \+?91?\d{10}
Matches: 9876543210, +919876543210
```

### 📧 Checking Email Format
**Rule:** "Something, then @, then something, then dot, then 2-3 letters"
```
Pattern: [\w.-]+@[\w.-]+\.\w{2,3}
Matches: john@gmail.com, user.name@company.co
```

### 🔐 Password Rules
**Rule:** "At least 8 characters, must have uppercase, lowercase, number"
```
Pattern: ^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$
Matches: Password1, MySecure123
```

### 🔍 Real-Life Analogy: Security Guard at a Party
Imagine a security guard checking guests:
- **Without Regex:** Check each person's name against a list manually
- **With Regex:** "Let in anyone whose name starts with 'Dr.' or 'Mr.'"

The guard now has a **pattern** (rule) to follow!

---

## 4. Regex in C#

### 🔹 The Namespace
In C#, regex lives in the `System.Text.RegularExpressions` namespace.

```csharp
using System.Text.RegularExpressions;
```

### 🔹 The Regex Class
The `Regex` class is your main tool. It provides methods to:
- **Match** text against patterns
- **Find** all occurrences
- **Replace** text
- **Split** text

### 🔹 Two Ways to Use Regex

**Method 1: Static Methods (Quick and Easy)**
```csharp
bool result = Regex.IsMatch("hello", "h.*o");
```

**Method 2: Create Regex Object (Better for Reuse)**
```csharp
Regex regex = new Regex("h.*o");
bool result = regex.IsMatch("hello");
```

> 💡 **Tip:** Use Method 2 when you need to apply the same pattern multiple times.

---

## 5. Basic Regex Syntax (Beginner Level)

Let's learn regex symbols one by one. Don't rush – understand each before moving on!

### 5.1 Literal Characters
The simplest pattern – just match the exact text!

```csharp
string pattern = "cat";
// Matches: "cat", "category", "bobcat"
// Does NOT match: "Cat", "CAT" (case-sensitive by default)
```

### 5.2 The Dot (.) – Any Single Character
The dot matches **any character except newline**.

```csharp
string pattern = "c.t";
// Matches: "cat", "cut", "c@t", "c1t"
// Does NOT match: "ct", "cart" (must be exactly 1 character)
```

| Pattern | Matches | Explanation |
|---------|---------|-------------|
| `a.b` | "aab", "a1b", "a@b" | Any single character between a and b |
| `...` | "abc", "123", "@#$" | Any 3 characters |

### 5.3 Anchors: ^ and $
These don't match characters – they match **positions**!

| Symbol | Meaning |
|--------|---------|
| `^` | Start of the string |
| `$` | End of the string |

```csharp
string pattern1 = "^Hello";    // Must START with "Hello"
string pattern2 = "World$";    // Must END with "World"
string pattern3 = "^Hello$";   // Must be EXACTLY "Hello"
```

**Examples:**
```csharp
// ^Hello
Regex.IsMatch("Hello World", "^Hello");  // ✅ true (starts with Hello)
Regex.IsMatch("Say Hello", "^Hello");    // ❌ false (doesn't start with Hello)

// World$
Regex.IsMatch("Hello World", "World$");  // ✅ true (ends with World)
Regex.IsMatch("World Cup", "World$");    // ❌ false (doesn't end with World)
```

### 5.4 Quantifiers: *, +, ?

These specify **how many times** the previous character can appear.

| Symbol | Meaning | Example Pattern | Matches |
|--------|---------|-----------------|---------|
| `*` | 0 or more | `ab*c` | "ac", "abc", "abbc", "abbbc" |
| `+` | 1 or more | `ab+c` | "abc", "abbc" (NOT "ac") |
| `?` | 0 or 1 (optional) | `colou?r` | "color", "colour" |

```csharp
// * (zero or more)
Regex.IsMatch("ac", "ab*c");      // ✅ true (0 b's)
Regex.IsMatch("abbc", "ab*c");    // ✅ true (2 b's)

// + (one or more)
Regex.IsMatch("ac", "ab+c");      // ❌ false (needs at least 1 b)
Regex.IsMatch("abc", "ab+c");     // ✅ true (1 b)

// ? (optional)
Regex.IsMatch("color", "colou?r");   // ✅ true (no u)
Regex.IsMatch("colour", "colou?r");  // ✅ true (with u)
```

### 5.5 Specific Counts: {n} and {n,m}

| Symbol | Meaning |
|--------|---------|
| `{n}` | Exactly n times |
| `{n,}` | n or more times |
| `{n,m}` | Between n and m times |

```csharp
string pattern1 = @"\d{3}";      // Exactly 3 digits
string pattern2 = @"\d{2,4}";    // 2 to 4 digits
string pattern3 = @"\d{5,}";     // 5 or more digits
```

**Examples:**
```csharp
// {3} - exactly 3
Regex.IsMatch("123", @"\d{3}");    // ✅ true
Regex.IsMatch("12", @"^\d{3}$");   // ❌ false (only 2 digits)

// {2,4} - between 2 and 4
Regex.IsMatch("12", @"^\d{2,4}$");     // ✅ true
Regex.IsMatch("12345", @"^\d{2,4}$"); // ❌ false (5 digits)
```

### 5.6 Character Classes: [abc], [a-z]

Match **any one character** from the set.

| Pattern | Meaning |
|---------|---------|
| `[abc]` | Match a, b, or c |
| `[a-z]` | Match any lowercase letter |
| `[A-Z]` | Match any uppercase letter |
| `[0-9]` | Match any digit |
| `[a-zA-Z]` | Match any letter |
| `[^abc]` | Match anything EXCEPT a, b, c |

```csharp
// [aeiou] - match any vowel
Regex.IsMatch("cat", "[aeiou]");   // ✅ true (has 'a')

// [a-z]+ - one or more lowercase letters
Regex.IsMatch("hello", "^[a-z]+$");  // ✅ true
Regex.IsMatch("Hello", "^[a-z]+$");  // ❌ false (has uppercase)

// [^0-9] - anything except digits
Regex.IsMatch("abc", "[^0-9]");    // ✅ true (has non-digits)
```

### 5.7 Special Character Classes: \d, \w, \s

These are **shortcuts** for common patterns:

| Symbol | Meaning | Equivalent |
|--------|---------|------------|
| `\d` | Any digit | `[0-9]` |
| `\D` | Any non-digit | `[^0-9]` |
| `\w` | Word character | `[a-zA-Z0-9_]` |
| `\W` | Non-word character | `[^a-zA-Z0-9_]` |
| `\s` | Whitespace | `[ \t\n\r]` |
| `\S` | Non-whitespace | `[^ \t\n\r]` |

```csharp
// \d - digits
Regex.IsMatch("Price: 100", @"\d+");   // ✅ true (finds "100")

// \w - word characters
Regex.IsMatch("user_123", @"^\w+$");   // ✅ true

// \s - whitespace
Regex.IsMatch("Hello World", @"\s");   // ✅ true (has space)
```

> 💡 **Note:** In C#, use `@` before the string to avoid escaping backslashes.
> - `"\\d"` without @ = `\d`
> - `@"\d"` with @ = `\d` (easier to read!)

---

## 6. Creating and Using Regex in C#

### 6.1 Regex.IsMatch() – Does It Match?

**Purpose:** Returns `true` or `false` – checks if pattern exists in the string.

```csharp
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // The text we want to check
        string email = "john@example.com";
        
        // The pattern: word chars, @, word chars, dot, 2-4 word chars
        string pattern = @"^\w+@\w+\.\w{2,4}$";
        
        // IsMatch returns true if pattern matches
        bool isValid = Regex.IsMatch(email, pattern);
        
        // Output the result
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Is Valid: {isValid}");  // Output: Is Valid: True
    }
}
```

**Pattern Breakdown:**
- `^` → Start of string
- `\w+` → One or more word characters (letters, digits, underscore)
- `@` → Literal @ symbol
- `\w+` → One or more word characters
- `\.` → Literal dot (escaped with \)
- `\w{2,4}` → 2 to 4 word characters
- `$` → End of string

### 6.2 Regex.Match() – Find First Match

**Purpose:** Finds the **first** match and returns a `Match` object with details.

```csharp
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Text containing numbers
        string text = "Order #12345 was placed on 2024-01-15";
        
        // Pattern to find numbers
        string pattern = @"\d+";
        
        // Match returns the first match found
        Match match = Regex.Match(text, pattern);
        
        // Check if we found a match
        if (match.Success)
        {
            Console.WriteLine($"Found: {match.Value}");      // Output: Found: 12345
            Console.WriteLine($"Position: {match.Index}");   // Output: Position: 7
            Console.WriteLine($"Length: {match.Length}");    // Output: Length: 5
        }
    }
}
```

**Match Object Properties:**
| Property | Description |
|----------|-------------|
| `Success` | True if match was found |
| `Value` | The matched text |
| `Index` | Position where match starts |
| `Length` | Length of matched text |

### 6.3 Regex.Matches() – Find All Matches

**Purpose:** Finds **all** matches and returns a collection.

```csharp
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Text with multiple numbers
        string text = "I have 3 apples, 5 oranges, and 12 bananas";
        
        // Pattern to find all numbers
        string pattern = @"\d+";
        
        // Matches returns ALL matches found
        MatchCollection matches = Regex.Matches(text, pattern);
        
        // Print count of matches
        Console.WriteLine($"Found {matches.Count} numbers:");
        
        // Loop through each match
        foreach (Match match in matches)
        {
            Console.WriteLine($"  - {match.Value} at position {match.Index}");
        }
        
        // Output:
        // Found 3 numbers:
        //   - 3 at position 7
        //   - 5 at position 17
        //   - 12 at position 32
    }
}
```

### 6.4 Regex.Replace() – Find and Replace

**Purpose:** Replace all matches with new text.

```csharp
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Example 1: Hide phone numbers
        string text1 = "Call me at 9876543210 or 8765432109";
        string pattern1 = @"\d{10}";
        string hidden = Regex.Replace(text1, pattern1, "**********");
        Console.WriteLine(hidden);  
        // Output: Call me at ********** or **********
        
        // Example 2: Remove extra spaces
        string text2 = "Hello    World   !";
        string pattern2 = @"\s+";  // One or more spaces
        string cleaned = Regex.Replace(text2, pattern2, " ");
        Console.WriteLine(cleaned);  
        // Output: Hello World !
        
        // Example 3: Format phone number
        string phone = "9876543210";
        string pattern3 = @"(\d{3})(\d{3})(\d{4})";
        string formatted = Regex.Replace(phone, pattern3, "($1) $2-$3");
        Console.WriteLine(formatted);  
        // Output: (987) 654-3210
    }
}
```

---

## 7. Common Regex Examples

### 7.1 Validate Email

```csharp
using System;
using System.Text.RegularExpressions;

class EmailValidator
{
    static void Main()
    {
        // Email pattern explanation:
        // ^           - Start of string
        // [\w.-]+     - One or more word chars, dots, or hyphens (local part)
        // @           - The @ symbol
        // [\w.-]+     - One or more word chars, dots, or hyphens (domain)
        // \.          - A literal dot
        // [a-zA-Z]{2,} - At least 2 letters (TLD like .com, .org)
        // $           - End of string
        
        string pattern = @"^[\w.-]+@[\w.-]+\.[a-zA-Z]{2,}$";
        
        string[] emails = {
            "john@gmail.com",        // Valid
            "jane.doe@company.co.in", // Valid
            "invalid@",              // Invalid
            "@nodomain.com",         // Invalid
            "spaces not@allowed.com" // Invalid
        };
        
        Console.WriteLine("=== Email Validation ===\n");
        
        foreach (string email in emails)
        {
            bool isValid = Regex.IsMatch(email, pattern);
            Console.WriteLine($"{email,-25} → {(isValid ? "✅ Valid" : "❌ Invalid")}");
        }
    }
}
```

**Output:**
```
=== Email Validation ===

john@gmail.com            → ✅ Valid
jane.doe@company.co.in    → ✅ Valid
invalid@                  → ❌ Invalid
@nodomain.com             → ❌ Invalid
spaces not@allowed.com    → ❌ Invalid
```

### 7.2 Validate Phone Number (Indian Format)

```csharp
using System;
using System.Text.RegularExpressions;

class PhoneValidator
{
    static void Main()
    {
        // Phone pattern explanation:
        // ^           - Start of string
        // (\+91|0)?   - Optional +91 or 0 (country/STD code)
        // [6-9]       - First digit must be 6, 7, 8, or 9
        // \d{9}       - Followed by exactly 9 digits
        // $           - End of string
        
        string pattern = @"^(\+91|0)?[6-9]\d{9}$";
        
        string[] phones = {
            "9876543210",     // Valid
            "+919876543210",  // Valid
            "09876543210",    // Valid
            "5876543210",     // Invalid (starts with 5)
            "987654321",      // Invalid (only 9 digits)
            "98765432101"     // Invalid (11 digits)
        };
        
        Console.WriteLine("=== Phone Number Validation ===\n");
        
        foreach (string phone in phones)
        {
            bool isValid = Regex.IsMatch(phone, pattern);
            Console.WriteLine($"{phone,-15} → {(isValid ? "✅ Valid" : "❌ Invalid")}");
        }
    }
}
```

### 7.3 Check Password Strength

```csharp
using System;
using System.Text.RegularExpressions;

class PasswordChecker
{
    static void Main()
    {
        // Password rules:
        // - At least 8 characters
        // - At least one lowercase letter
        // - At least one uppercase letter
        // - At least one digit
        // - At least one special character
        
        // Pattern explanation:
        // ^                - Start
        // (?=.*[a-z])      - Must have at least one lowercase (lookahead)
        // (?=.*[A-Z])      - Must have at least one uppercase (lookahead)
        // (?=.*\d)         - Must have at least one digit (lookahead)
        // (?=.*[@#$%^&+=]) - Must have at least one special char (lookahead)
        // .{8,}            - At least 8 of any character
        // $                - End
        
        string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=]).{8,}$";
        
        string[] passwords = {
            "MyPass@123",    // Strong
            "weakpass",      // Weak - no uppercase, number, special
            "NoSpecial1",    // Weak - no special character
            "Short@1",       // Weak - less than 8 chars
            "Str0ng@Pass"    // Strong
        };
        
        Console.WriteLine("=== Password Strength Checker ===\n");
        
        foreach (string password in passwords)
        {
            bool isStrong = Regex.IsMatch(password, pattern);
            Console.WriteLine($"{password,-15} → {(isStrong ? "✅ Strong" : "❌ Weak")}");
        }
    }
}
```

### 7.4 Extract Numbers from Text

```csharp
using System;
using System.Text.RegularExpressions;

class NumberExtractor
{
    static void Main()
    {
        string text = "The price is $45.99, quantity is 100, and discount is 15%";
        
        // Pattern: \d+ matches one or more digits
        // \.? matches optional dot
        // \d* matches zero or more digits after dot
        string pattern = @"\d+\.?\d*";
        
        Console.WriteLine($"Text: {text}\n");
        Console.WriteLine("Extracted Numbers:");
        
        MatchCollection matches = Regex.Matches(text, pattern);
        
        foreach (Match match in matches)
        {
            Console.WriteLine($"  → {match.Value}");
        }
        
        // Output:
        // Extracted Numbers:
        //   → 45.99
        //   → 100
        //   → 15
    }
}
```

---

## 8. Greedy vs Lazy Matching

### 🔹 What's the Difference?

| Type | Symbol | Behavior |
|------|--------|----------|
| **Greedy** | `*`, `+`, `?` | Matches as MUCH as possible |
| **Lazy** | `*?`, `+?`, `??` | Matches as LITTLE as possible |

### 🔹 Visual Example

```csharp
using System;
using System.Text.RegularExpressions;

class GreedyVsLazy
{
    static void Main()
    {
        string html = "<div>Hello</div><div>World</div>";
        
        // Greedy: .* matches as much as possible
        string greedyPattern = @"<div>.*</div>";
        
        // Lazy: .*? matches as little as possible
        string lazyPattern = @"<div>.*?</div>";
        
        Console.WriteLine($"Text: {html}\n");
        
        // Greedy matching
        Match greedyMatch = Regex.Match(html, greedyPattern);
        Console.WriteLine($"Greedy (.*)  : {greedyMatch.Value}");
        // Output: <div>Hello</div><div>World</div>
        // It grabbed EVERYTHING between first <div> and LAST </div>
        
        // Lazy matching
        Match lazyMatch = Regex.Match(html, lazyPattern);
        Console.WriteLine($"Lazy   (.*?) : {lazyMatch.Value}");
        // Output: <div>Hello</div>
        // It stopped at the FIRST </div>
        
        Console.WriteLine("\n--- All Lazy Matches ---");
        MatchCollection lazyMatches = Regex.Matches(html, lazyPattern);
        foreach (Match match in lazyMatches)
        {
            Console.WriteLine($"  → {match.Value}");
        }
        // Output:
        //   → <div>Hello</div>
        //   → <div>World</div>
    }
}
```

### 🔹 When to Use Which?

| Situation | Use |
|-----------|-----|
| Extract content between tags | **Lazy** (`.*?`) |
| Match entire line/block | **Greedy** (`.*`) |
| Find shortest match | **Lazy** |
| Find longest match | **Greedy** |

---

## 9. Groups and Capturing

### 🔹 What Are Groups?

Groups let you **capture parts** of a match. They're created using parentheses `()`.

### 🔹 Why Are They Useful?

1. **Extract specific parts** from matched text
2. **Reuse matched content** in replacements
3. **Apply quantifiers** to multiple characters

### 🔹 Example: Extract Date Parts

```csharp
using System;
using System.Text.RegularExpressions;

class GroupExample
{
    static void Main()
    {
        string dateText = "Today's date is 2024-01-15";
        
        // Pattern with 3 groups:
        // Group 1: (\d{4}) - Year (4 digits)
        // Group 2: (\d{2}) - Month (2 digits)
        // Group 3: (\d{2}) - Day (2 digits)
        string pattern = @"(\d{4})-(\d{2})-(\d{2})";
        
        Match match = Regex.Match(dateText, pattern);
        
        if (match.Success)
        {
            Console.WriteLine($"Full Match : {match.Value}");     // 2024-01-15
            Console.WriteLine($"Group 0    : {match.Groups[0]}"); // 2024-01-15 (entire match)
            Console.WriteLine($"Group 1    : {match.Groups[1]}"); // 2024 (year)
            Console.WriteLine($"Group 2    : {match.Groups[2]}"); // 01 (month)
            Console.WriteLine($"Group 3    : {match.Groups[3]}"); // 15 (day)
            
            // Use the captured groups
            string year = match.Groups[1].Value;
            string month = match.Groups[2].Value;
            string day = match.Groups[3].Value;
            
            Console.WriteLine($"\nFormatted: {day}/{month}/{year}"); // 15/01/2024
        }
    }
}
```

### 🔹 Named Groups (Cleaner Code)

```csharp
using System;
using System.Text.RegularExpressions;

class NamedGroupExample
{
    static void Main()
    {
        string email = "john.doe@example.com";
        
        // Named groups: (?<name>pattern)
        string pattern = @"(?<username>[\w.]+)@(?<domain>[\w.]+)";
        
        Match match = Regex.Match(email, pattern);
        
        if (match.Success)
        {
            // Access by name instead of number
            string username = match.Groups["username"].Value;
            string domain = match.Groups["domain"].Value;
            
            Console.WriteLine($"Username: {username}");  // john.doe
            Console.WriteLine($"Domain  : {domain}");    // example.com
        }
    }
}
```

### 🔹 Using Groups in Replace

```csharp
using System;
using System.Text.RegularExpressions;

class GroupReplaceExample
{
    static void Main()
    {
        // Convert date format: YYYY-MM-DD → DD/MM/YYYY
        string dateUS = "2024-01-15";
        string pattern = @"(\d{4})-(\d{2})-(\d{2})";
        
        // $1, $2, $3 refer to the captured groups
        string dateIN = Regex.Replace(dateUS, pattern, "$3/$2/$1");
        
        Console.WriteLine($"US Format : {dateUS}");   // 2024-01-15
        Console.WriteLine($"IN Format : {dateIN}");   // 15/01/2024
    }
}
```

---

## 10. Regex Flags / Options

Regex options change how the pattern matching behaves.

### 🔹 RegexOptions.IgnoreCase

Matches letters regardless of case (uppercase/lowercase).

```csharp
using System;
using System.Text.RegularExpressions;

class IgnoreCaseExample
{
    static void Main()
    {
        string text = "Hello WORLD";
        string pattern = "hello";
        
        // Without IgnoreCase
        bool match1 = Regex.IsMatch(text, pattern);
        Console.WriteLine($"Without IgnoreCase: {match1}"); // False
        
        // With IgnoreCase
        bool match2 = Regex.IsMatch(text, pattern, RegexOptions.IgnoreCase);
        Console.WriteLine($"With IgnoreCase   : {match2}"); // True
    }
}
```

### 🔹 RegexOptions.Multiline

Makes `^` and `$` match start/end of **each line** (not just the string).

```csharp
using System;
using System.Text.RegularExpressions;

class MultilineExample
{
    static void Main()
    {
        string text = "Line 1\nLine 2\nLine 3";
        string pattern = "^Line";  // Match "Line" at start of line
        
        // Without Multiline - only matches start of entire string
        MatchCollection match1 = Regex.Matches(text, pattern);
        Console.WriteLine($"Without Multiline: {match1.Count} matches"); // 1 match
        
        // With Multiline - matches start of each line
        MatchCollection match2 = Regex.Matches(text, pattern, RegexOptions.Multiline);
        Console.WriteLine($"With Multiline   : {match2.Count} matches"); // 3 matches
    }
}
```

### 🔹 RegexOptions.Singleline

Makes `.` match **everything including newlines**.

```csharp
using System;
using System.Text.RegularExpressions;

class SinglelineExample
{
    static void Main()
    {
        string text = "Start\nMiddle\nEnd";
        string pattern = "Start.*End";  // Match everything between Start and End
        
        // Without Singleline - . doesn't match newlines
        bool match1 = Regex.IsMatch(text, pattern);
        Console.WriteLine($"Without Singleline: {match1}"); // False
        
        // With Singleline - . matches newlines too
        bool match2 = Regex.IsMatch(text, pattern, RegexOptions.Singleline);
        Console.WriteLine($"With Singleline   : {match2}"); // True
    }
}
```

### 🔹 Combining Options

```csharp
// Use | to combine multiple options
RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.Multiline;
bool result = Regex.IsMatch(text, pattern, options);
```

### 🔹 Summary Table

| Option | Effect | When to Use |
|--------|--------|-------------|
| `IgnoreCase` | a = A | When case doesn't matter |
| `Multiline` | ^ and $ match line boundaries | Multi-line text processing |
| `Singleline` | . matches newlines | When pattern spans lines |

---

## 11. Common Regex Mistakes Beginners Make

### ❌ Mistake 1: Over-Complicated Patterns

**Wrong Approach:**
```csharp
// Trying to match a number between 1-100 with complex pattern
string pattern = @"^([1-9]|[1-9][0-9]|100)$";
```

**Better Approach:**
```csharp
// Use regex for format, C# for logic
string pattern = @"^\d+$";
if (Regex.IsMatch(input, pattern))
{
    int number = int.Parse(input);
    if (number >= 1 && number <= 100)
    {
        Console.WriteLine("Valid!");
    }
}
```

### ❌ Mistake 2: Forgetting Escape Characters

Some characters have special meaning in regex. You must escape them with `\`:

| Character | Meaning | To Match Literally |
|-----------|---------|-------------------|
| `.` | Any character | `\.` |
| `*` | Zero or more | `\*` |
| `+` | One or more | `\+` |
| `?` | Optional | `\?` |
| `^` | Start of string | `\^` |
| `$` | End of string | `\$` |
| `(` `)` | Groups | `\(` `\)` |
| `[` `]` | Character class | `\[` `\]` |
| `{` `}` | Quantifier | `\{` `\}` |
| `\` | Escape | `\\` |
| `|` | OR | `\|` |

```csharp
// WRONG - trying to match "3.14"
string wrong = "3.14";  // This matches "3X14" where X is any character!

// CORRECT
string correct = @"3\.14";  // This matches exactly "3.14"
```

### ❌ Mistake 3: Using Regex When Not Needed

**Don't use regex for simple operations:**

```csharp
// ❌ Overkill - using regex to check if string contains "hello"
bool hasHello = Regex.IsMatch(text, "hello");

// ✅ Better - use simple string methods
bool hasHello = text.Contains("hello");

// ❌ Overkill - using regex to check string starts with "http"
bool startsWithHttp = Regex.IsMatch(url, "^http");

// ✅ Better - use string methods
bool startsWithHttp = url.StartsWith("http");
```

### ❌ Mistake 4: Not Using Raw Strings (@)

```csharp
// ❌ Confusing - need to double escape
string pattern = "\\d+\\.\\d+";  // Matches digits.digits

// ✅ Clear - use @ for raw string
string pattern = @"\d+\.\d+";    // Same pattern, easier to read
```

### ❌ Mistake 5: Not Anchoring When Needed

```csharp
string pattern = @"\d{10}";  // Finds 10 digits ANYWHERE in string

// "abc12345678901234" would match because it CONTAINS 10 digits!

// If you need EXACTLY 10 digits:
string pattern = @"^\d{10}$";  // Start and end anchors
```

---

## 12. Regex Performance Tips (Beginner-Safe)

### 🔹 When Regex is Slow

1. **Backtracking** - Complex patterns with many `.*` can be slow
2. **Large text** - Scanning huge files with complex patterns
3. **Repeated compilation** - Creating regex objects in loops

### 🔹 Performance Best Practices

#### 1. Reuse Compiled Regex Objects

```csharp
// ❌ BAD - Creates new Regex object every time
for (int i = 0; i < 10000; i++)
{
    Regex.IsMatch(text[i], @"\d+");  // Compiled 10000 times!
}

// ✅ GOOD - Create once, use many times
Regex regex = new Regex(@"\d+", RegexOptions.Compiled);
for (int i = 0; i < 10000; i++)
{
    regex.IsMatch(text[i]);  // Reuses compiled pattern
}
```

#### 2. Use RegexOptions.Compiled for Heavy Use

```csharp
// For patterns used many times, compile them
Regex emailRegex = new Regex(@"^[\w.-]+@[\w.-]+\.\w+$", RegexOptions.Compiled);
```

#### 3. Be Specific, Avoid Broad Patterns

```csharp
// ❌ Slow - too broad
string slow = @".*hello.*";

// ✅ Fast - more specific
string fast = @"\bhello\b";  // \b is word boundary
```

### 🔹 When NOT to Use Regex

| Task | Use Instead |
|------|-------------|
| Check if contains substring | `string.Contains()` |
| Check start/end | `StartsWith()`, `EndsWith()` |
| Split by single character | `string.Split()` |
| Replace exact string | `string.Replace()` |
| Parse structured data (JSON, XML) | Built-in parsers |

```csharp
// Don't use regex for these:
text.Contains("hello");           // ✅ Simple
text.StartsWith("http");          // ✅ Simple
text.Split(',');                  // ✅ Simple
text.Replace("old", "new");       // ✅ Simple
```

---

## 13. Real-World Use Cases

### 13.1 Form Validation

```csharp
using System;
using System.Text.RegularExpressions;

class FormValidator
{
    // Reusable compiled patterns
    private static readonly Regex EmailRegex = new Regex(
        @"^[\w.-]+@[\w.-]+\.[a-zA-Z]{2,}$", 
        RegexOptions.Compiled
    );
    
    private static readonly Regex PhoneRegex = new Regex(
        @"^[6-9]\d{9}$", 
        RegexOptions.Compiled
    );
    
    private static readonly Regex PinCodeRegex = new Regex(
        @"^\d{6}$", 
        RegexOptions.Compiled
    );
    
    public static bool ValidateEmail(string email) => EmailRegex.IsMatch(email);
    public static bool ValidatePhone(string phone) => PhoneRegex.IsMatch(phone);
    public static bool ValidatePinCode(string pin) => PinCodeRegex.IsMatch(pin);
    
    static void Main()
    {
        Console.WriteLine("=== Form Validation Demo ===\n");
        
        Console.WriteLine($"Email 'test@mail.com': {ValidateEmail("test@mail.com")}");
        Console.WriteLine($"Phone '9876543210': {ValidatePhone("9876543210")}");
        Console.WriteLine($"PinCode '400001': {ValidatePinCode("400001")}");
    }
}
```

### 13.2 Log Parsing

```csharp
using System;
using System.Text.RegularExpressions;

class LogParser
{
    static void Main()
    {
        string[] logLines = {
            "[2024-01-15 10:30:45] ERROR: Database connection failed",
            "[2024-01-15 10:30:46] INFO: Retrying connection...",
            "[2024-01-15 10:30:47] ERROR: Connection timeout",
            "[2024-01-15 10:30:48] INFO: Connected successfully"
        };
        
        // Pattern to extract: timestamp, level, message
        string pattern = @"\[(?<timestamp>[\d-: ]+)\] (?<level>\w+): (?<message>.+)";
        Regex regex = new Regex(pattern);
        
        Console.WriteLine("=== Parsing Error Logs ===\n");
        
        foreach (string line in logLines)
        {
            Match match = regex.Match(line);
            if (match.Success && match.Groups["level"].Value == "ERROR")
            {
                Console.WriteLine($"Time   : {match.Groups["timestamp"].Value}");
                Console.WriteLine($"Error  : {match.Groups["message"].Value}");
                Console.WriteLine();
            }
        }
    }
}
```

### 13.3 Input Sanitization

```csharp
using System;
using System.Text.RegularExpressions;

class InputSanitizer
{
    static void Main()
    {
        // Remove potentially dangerous characters from user input
        string userInput = "Hello <script>alert('XSS')</script> World!";
        
        // Remove HTML tags
        string noHtml = Regex.Replace(userInput, @"<[^>]+>", "");
        Console.WriteLine($"Sanitized: {noHtml}");
        // Output: Hello alert('XSS') World!
        
        // Keep only alphanumeric and spaces
        string alphaOnly = Regex.Replace(userInput, @"[^a-zA-Z0-9\s]", "");
        Console.WriteLine($"Alpha Only: {alphaOnly}");
        // Output: Hello scriptalertXSSscript World
    }
}
```

### 13.4 Data Cleaning

```csharp
using System;
using System.Text.RegularExpressions;

class DataCleaner
{
    static void Main()
    {
        // Messy data
        string messyData = "  Name:   John   Doe  ,  Age:  25  ,  City:  New   York  ";
        
        // Step 1: Remove extra spaces
        string cleaned = Regex.Replace(messyData, @"\s+", " ");
        
        // Step 2: Remove spaces around punctuation
        cleaned = Regex.Replace(cleaned, @"\s*([,:;])\s*", "$1 ");
        
        // Step 3: Trim
        cleaned = cleaned.Trim();
        
        Console.WriteLine("Original:");
        Console.WriteLine($"'{messyData}'\n");
        
        Console.WriteLine("Cleaned:");
        Console.WriteLine($"'{cleaned}'");
        // Output: 'Name: John Doe, Age: 25, City: New York'
    }
}
```

---

## 14. Interview-Ready Summary

### 🔹 Key Definitions

| Term | Definition |
|------|------------|
| **Regex** | A pattern that describes a set of strings for matching |
| **Pattern** | The regex rule/template to search for |
| **Match** | A successful result when pattern is found |
| **Capture Group** | Part of pattern in () that extracts text |
| **Quantifier** | Specifies how many times to match (*, +, ?) |
| **Anchor** | Matches position, not characters (^, $) |
| **Character Class** | Set of characters to match ([a-z], \d) |

### 🔹 Important Methods

| Method | Purpose | Returns |
|--------|---------|---------|
| `Regex.IsMatch()` | Check if pattern exists | `bool` |
| `Regex.Match()` | Find first match | `Match` object |
| `Regex.Matches()` | Find all matches | `MatchCollection` |
| `Regex.Replace()` | Replace matches | `string` |
| `Regex.Split()` | Split by pattern | `string[]` |

### 🔹 Essential Symbols Cheat Sheet

```
.        Any character (except newline)
^        Start of string/line
$        End of string/line
*        0 or more
+        1 or more
?        0 or 1 (optional)
{n}      Exactly n times
{n,m}    Between n and m times

[abc]    Match a, b, or c
[^abc]   Match anything except a, b, c
[a-z]    Match any lowercase letter

\d       Digit [0-9]
\w       Word character [a-zA-Z0-9_]
\s       Whitespace
\b       Word boundary

()       Capture group
|        OR operator
```

### 🔹 When to Use Regex vs String Methods

| Use Regex When | Use String Methods When |
|----------------|------------------------|
| Pattern is complex | Simple contains/replace |
| Need flexible matching | Exact string matching |
| Extracting parts of text | Checking start/end |
| Format validation | Simple splitting |
| Multiple conditions | Performance critical |

### 🔹 Quick Code Templates

**Validation:**
```csharp
bool isValid = Regex.IsMatch(input, pattern);
```

**Extract First Match:**
```csharp
Match match = Regex.Match(text, pattern);
if (match.Success) { /* use match.Value */ }
```

**Extract All Matches:**
```csharp
foreach (Match m in Regex.Matches(text, pattern))
{
    Console.WriteLine(m.Value);
}
```

**Find and Replace:**
```csharp
string result = Regex.Replace(text, pattern, replacement);
```

**Use Groups:**
```csharp
Match m = Regex.Match(text, @"(\d+)-(\d+)");
string first = m.Groups[1].Value;
string second = m.Groups[2].Value;
```

---

## 🎯 Final Checklist: What You Should Know Now

After studying these notes, you should be able to:

- [ ] Explain what regex is in simple terms
- [ ] Write basic patterns using `.`, `^`, `$`, `*`, `+`, `?`
- [ ] Use character classes like `[a-z]`, `\d`, `\w`, `\s`
- [ ] Use `Regex.IsMatch()` for validation
- [ ] Use `Regex.Match()` and `Regex.Matches()` for extraction
- [ ] Use `Regex.Replace()` for find-and-replace
- [ ] Understand greedy vs lazy matching
- [ ] Use groups to capture parts of matches
- [ ] Apply regex options like `IgnoreCase` and `Multiline`
- [ ] Know when to use regex and when not to
- [ ] Write patterns for email, phone, and password validation

---

## 📚 Practice Exercises

Try these on your own:

1. Write a regex to validate a date in DD/MM/YYYY format
2. Extract all hashtags from a tweet
3. Validate a username (4-20 chars, alphanumeric, underscores allowed)
4. Find all words that start with capital letter
5. Replace all credit card numbers with `****-****-****-XXXX` (keep last 4)

---

**Happy Coding! 🚀**

*Remember: The best way to learn regex is to practice. Use online tools like regex101.com to test your patterns!*
