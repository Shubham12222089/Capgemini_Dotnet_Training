/*
╔═══════════════════════════════════════════════════════════════════════════════╗
║                    COMPLETE REGEX TUTORIAL IN C#                               ║
║                    For Absolute Beginners                                       ║
╚═══════════════════════════════════════════════════════════════════════════════╝

This program demonstrates all regex concepts covered in the notes.
Run it section by section to understand each concept.

Required: using System.Text.RegularExpressions;
*/

using System;
using System.Text.RegularExpressions;

namespace RegExTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            // Uncomment the sections you want to run:
            
            Section1_WhatIsRegex();
            Section2_BasicSyntax_Literals();
            Section3_BasicSyntax_Dot();
            Section4_BasicSyntax_Anchors();
            Section5_BasicSyntax_Quantifiers();
            Section6_BasicSyntax_CharacterClasses();
            Section7_BasicSyntax_SpecialClasses();
            Section8_RegexIsMatch();
            Section9_RegexMatch();
            Section10_RegexMatches();
            Section11_RegexReplace();
            Section12_EmailValidation();
            Section13_PhoneValidation();
            Section14_PasswordStrength();
            Section15_ExtractNumbers();
            Section16_GreedyVsLazy();
            Section17_Groups();
            Section18_NamedGroups();
            Section19_RegexOptions();
            Section20_RealWorldExamples();
            
            Console.WriteLine("\n=== End of Tutorial ===");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        // ╔════════════════════════════════════════════════════════════════════╗
        // ║ SECTION 1: WHAT IS REGEX? - Simple Introduction                     ║
        // ╚════════════════════════════════════════════════════════════════════╝
        static void Section1_WhatIsRegex()
        {
            PrintHeader("SECTION 1: What is Regex?");
            
            Console.WriteLine("Regex = Regular Expression = A PATTERN to search text");
            Console.WriteLine();
            Console.WriteLine("Example: Finding all phone numbers in a document");
            Console.WriteLine("Without Regex: Check each character one by one (tedious!)");
            Console.WriteLine("With Regex: Use pattern '\\d{10}' (finds any 10 digits)");
            Console.WriteLine();
            
            // Simple demo
            string text = "Call me at 9876543210 or email me at test@mail.com";
            string pattern = @"\d{10}";  // Pattern: exactly 10 digits
            
            Console.WriteLine($"Text: {text}");
            Console.WriteLine($"Pattern: {pattern}");
            Console.WriteLine($"Found phone number? {Regex.IsMatch(text, pattern)}");
            
            Match match = Regex.Match(text, pattern);
            if (match.Success)
            {
                Console.WriteLine($"Phone number found: {match.Value}");
            }
            
            PrintSeparator();
        }

        // ╔════════════════════════════════════════════════════════════════════╗
        // ║ SECTION 2: LITERAL CHARACTERS                                       ║
        // ╚════════════════════════════════════════════════════════════════════╝
        static void Section2_BasicSyntax_Literals()
        {
            PrintHeader("SECTION 2: Literal Characters");
            
            Console.WriteLine("The simplest pattern - match exact text!");
            Console.WriteLine();
            
            string text = "The cat sat on the mat.";
            
            // Pattern: just the word "cat"
            Console.WriteLine($"Text: '{text}'");
            Console.WriteLine();
            
            // Test 1: Finding "cat"
            Console.WriteLine("Pattern: 'cat'");
            Console.WriteLine($"Contains 'cat'? {Regex.IsMatch(text, "cat")}");  // true
            
            // Test 2: Case sensitivity (default is case-sensitive)
            Console.WriteLine();
            Console.WriteLine("Pattern: 'Cat' (uppercase C)");
            Console.WriteLine($"Contains 'Cat'? {Regex.IsMatch(text, "Cat")}");  // false
            
            // Test 3: Finding "dog" (doesn't exist)
            Console.WriteLine();
            Console.WriteLine("Pattern: 'dog'");
            Console.WriteLine($"Contains 'dog'? {Regex.IsMatch(text, "dog")}");  // false
            
            PrintSeparator();   
        }

        // ╔════════════════════════════════════════════════════════════════════╗
        // ║ SECTION 3: THE DOT (.) - MATCH ANY CHARACTER                        ║
        // ╚════════════════════════════════════════════════════════════════════╝
        static void Section3_BasicSyntax_Dot()
        {
            PrintHeader("SECTION 3: The Dot (.) - Any Single Character");
            
            Console.WriteLine("The DOT (.) matches ANY single character (except newline)");
            Console.WriteLine();
            
            string pattern = "c.t";  // c, then ANY character, then t
            Console.WriteLine($"Pattern: '{pattern}' (c + any char + t)");
            Console.WriteLine();
            
            string[] testWords = { "cat", "cut", "cot", "c@t", "c1t", "ct", "cart" };
            
            foreach (string word in testWords)
            {
                bool matches = Regex.IsMatch(word, $"^{pattern}$");  // ^ and $ for exact match
                Console.WriteLine($"  '{word}' matches? {matches}");
            }
            
            Console.WriteLine();
            Console.WriteLine("Note: 'ct' fails (no character between c and t)");
            Console.WriteLine("      'cart' fails (2 characters between c and t)");
            
            PrintSeparator();
        }

        // ╔════════════════════════════════════════════════════════════════════╗
        // ║ SECTION 4: ANCHORS (^ and $)                                        ║
        // ╚════════════════════════════════════════════════════════════════════╝
        static void Section4_BasicSyntax_Anchors()
        {
            PrintHeader("SECTION 4: Anchors (^ and $)");
            
            Console.WriteLine("^ = Start of string");
            Console.WriteLine("$ = End of string");
            Console.WriteLine("They don't match characters - they match POSITIONS!");
            Console.WriteLine();
            
            string text = "Hello World";
            
            // Test ^Hello - must START with Hello
            Console.WriteLine($"Text: '{text}'");
            Console.WriteLine();
            Console.WriteLine("Test 1: Pattern '^Hello' (must start with Hello)");
            Console.WriteLine($"  Matches: {Regex.IsMatch(text, "^Hello")}");  // true
            
            Console.WriteLine();
            Console.WriteLine("Test 2: Pattern '^World' (must start with World)");
            Console.WriteLine($"  Matches: {Regex.IsMatch(text, "^World")}");  // false
            
            Console.WriteLine();
            Console.WriteLine("Test 3: Pattern 'World$' (must end with World)");
            Console.WriteLine($"  Matches: {Regex.IsMatch(text, "World$")}");  // true
            
            Console.WriteLine();
            Console.WriteLine("Test 4: Pattern '^Hello World$' (exact match)");
            Console.WriteLine($"  Matches: {Regex.IsMatch(text, "^Hello World$")}");  // true
            
            Console.WriteLine();
            Console.WriteLine("Test 5: Pattern '^Hello$' on 'Hello World'");
            Console.WriteLine($"  Matches: {Regex.IsMatch(text, "^Hello$")}");  // false - not exact
            
            PrintSeparator();
        }

        // ╔════════════════════════════════════════════════════════════════════╗
        // ║ SECTION 5: QUANTIFIERS (*, +, ?, {n}, {n,m})                        ║
        // ╚════════════════════════════════════════════════════════════════════╝
        static void Section5_BasicSyntax_Quantifiers()
        {
            PrintHeader("SECTION 5: Quantifiers (*, +, ?, {n}, {n,m})");
            
            Console.WriteLine("Quantifiers specify HOW MANY times to match:");
            Console.WriteLine("  *     = 0 or more times");
            Console.WriteLine("  +     = 1 or more times");
            Console.WriteLine("  ?     = 0 or 1 time (optional)");
            Console.WriteLine("  {n}   = exactly n times");
            Console.WriteLine("  {n,m} = between n and m times");
            Console.WriteLine();
            
            // * (zero or more)
            Console.WriteLine("=== * (Zero or More) ===");
            Console.WriteLine("Pattern: 'ab*c' (a, then 0 or more b's, then c)");
            string[] starTests = { "ac", "abc", "abbc", "abbbc" };
            foreach (string test in starTests)
            {
                Console.WriteLine($"  '{test}' matches? {Regex.IsMatch(test, "^ab*c$")}");
            }
            
            Console.WriteLine();
            
            // + (one or more)
            Console.WriteLine("=== + (One or More) ===");
            Console.WriteLine("Pattern: 'ab+c' (a, then 1 or more b's, then c)");
            string[] plusTests = { "ac", "abc", "abbc", "abbbc" };
            foreach (string test in plusTests)
            {
                Console.WriteLine($"  '{test}' matches? {Regex.IsMatch(test, "^ab+c$")}");
            }
            
            Console.WriteLine();
            
            // ? (optional)
            Console.WriteLine("=== ? (Optional - 0 or 1) ===");
            Console.WriteLine("Pattern: 'colou?r' (matches 'color' and 'colour')");
            Console.WriteLine($"  'color' matches? {Regex.IsMatch("color", "^colou?r$")}");
            Console.WriteLine($"  'colour' matches? {Regex.IsMatch("colour", "^colou?r$")}");
            Console.WriteLine($"  'colouur' matches? {Regex.IsMatch("colouur", "^colou?r$")}");
            
            Console.WriteLine();
            
            // {n} (exactly n)
            Console.WriteLine("=== {n} (Exactly n times) ===");
            Console.WriteLine(@"Pattern: '\d{3}' (exactly 3 digits)");
            string[] exactTests = { "12", "123", "1234" };
            foreach (string test in exactTests)
            {
                Console.WriteLine($"  '{test}' exact match? {Regex.IsMatch(test, @"^\d{3}$")}");
            }
            
            Console.WriteLine();
            
            // {n,m} (between n and m)
            Console.WriteLine("=== {n,m} (Between n and m times) ===");
            Console.WriteLine(@"Pattern: '\d{2,4}' (2 to 4 digits)");
            string[] rangeTests = { "1", "12", "123", "1234", "12345" };
            foreach (string test in rangeTests)
            {
                Console.WriteLine($"  '{test}' exact match? {Regex.IsMatch(test, @"^\d{2,4}$")}");
            }
            
            PrintSeparator();
        }

        // ╔════════════════════════════════════════════════════════════════════╗
        // ║ SECTION 6: CHARACTER CLASSES [abc], [a-z]                           ║
        // ╚════════════════════════════════════════════════════════════════════╝
        static void Section6_BasicSyntax_CharacterClasses()
        {
            PrintHeader("SECTION 6: Character Classes [abc], [a-z]");
            
            Console.WriteLine("Character classes match ANY ONE character from a set:");
            Console.WriteLine("  [abc]    = a or b or c");
            Console.WriteLine("  [a-z]    = any lowercase letter");
            Console.WriteLine("  [A-Z]    = any uppercase letter");
            Console.WriteLine("  [0-9]    = any digit");
            Console.WriteLine("  [a-zA-Z] = any letter");
            Console.WriteLine("  [^abc]   = NOT a, b, or c (negation)");
            Console.WriteLine();
            
            // [aeiou] - vowels
            Console.WriteLine("=== [aeiou] - Match any vowel ===");
            Console.WriteLine("Pattern: '[aeiou]'");
            string[] vowelTests = { "cat", "dog", "xyz" };
            foreach (string test in vowelTests)
            {
                Console.WriteLine($"  '{test}' has vowel? {Regex.IsMatch(test, "[aeiou]")}");
            }
            
            Console.WriteLine();
            
            // [a-z]+ - lowercase words
            Console.WriteLine("=== [a-z]+ - Only lowercase letters ===");
            Console.WriteLine("Pattern: '^[a-z]+$'");
            string[] lcTests = { "hello", "Hello", "hello123" };
            foreach (string test in lcTests)
            {
                Console.WriteLine($"  '{test}' all lowercase? {Regex.IsMatch(test, "^[a-z]+$")}");
            }
            
            Console.WriteLine();
            
            // [^0-9] - no digits
            Console.WriteLine("=== [^0-9] - Match anything EXCEPT digits ===");
            Console.WriteLine("Pattern: '^[^0-9]+$'");
            string[] noDigitTests = { "hello", "hello123", "HELLO" };
            foreach (string test in noDigitTests)
            {
                Console.WriteLine($"  '{test}' has no digits? {Regex.IsMatch(test, "^[^0-9]+$")}");
            }
            
            PrintSeparator();
        }

        // ╔════════════════════════════════════════════════════════════════════╗
        // ║ SECTION 7: SPECIAL CHARACTER CLASSES \d, \w, \s                     ║
        // ╚════════════════════════════════════════════════════════════════════╝
        static void Section7_BasicSyntax_SpecialClasses()
        {
            PrintHeader(@"SECTION 7: Special Classes \d, \w, \s");
            
            Console.WriteLine("Shortcuts for common patterns:");
            Console.WriteLine(@"  \d = [0-9]           Any digit");
            Console.WriteLine(@"  \D = [^0-9]          Any non-digit");
            Console.WriteLine(@"  \w = [a-zA-Z0-9_]    Word character");
            Console.WriteLine(@"  \W = [^a-zA-Z0-9_]   Non-word character");
            Console.WriteLine(@"  \s = [ \t\n\r]       Whitespace");
            Console.WriteLine(@"  \S = [^ \t\n\r]      Non-whitespace");
            Console.WriteLine();
            
            string text = "User123 has $50.00";
            Console.WriteLine($"Text: '{text}'");
            Console.WriteLine();
            
            // \d - digits
            Console.WriteLine(@"=== \d+ (one or more digits) ===");
            MatchCollection digits = Regex.Matches(text, @"\d+");
            Console.WriteLine($"Found {digits.Count} number(s):");
            foreach (Match m in digits)
            {
                Console.WriteLine($"  '{m.Value}' at position {m.Index}");
            }
            
            Console.WriteLine();
            
            // \w - word characters
            Console.WriteLine(@"=== \w+ (one or more word characters) ===");
            MatchCollection words = Regex.Matches(text, @"\w+");
            Console.WriteLine($"Found {words.Count} word(s):");
            foreach (Match m in words)
            {
                Console.WriteLine($"  '{m.Value}' at position {m.Index}");
            }
            
            Console.WriteLine();
            
            // \s - whitespace
            Console.WriteLine(@"=== \s (whitespace) ===");
            string spacey = "Hello   World";
            Console.WriteLine($"Text: '{spacey}'");
            Console.WriteLine($"Whitespace count: {Regex.Matches(spacey, @"\s").Count}");
            
            // Replace multiple spaces with single space
            string cleaned = Regex.Replace(spacey, @"\s+", " ");
            Console.WriteLine($"After cleanup: '{cleaned}'");
            
            PrintSeparator();
        }

        // ╔════════════════════════════════════════════════════════════════════╗
        // ║ SECTION 8: Regex.IsMatch() - Check if Pattern Exists                ║
        // ╚════════════════════════════════════════════════════════════════════╝
        static void Section8_RegexIsMatch()
        {
            PrintHeader("SECTION 8: Regex.IsMatch() - Check if Pattern Exists");
            
            Console.WriteLine("IsMatch() returns true/false - perfect for validation!");
            Console.WriteLine();
            
            // Example: Validate if string contains only letters
            string pattern = @"^[a-zA-Z]+$";
            Console.WriteLine($"Pattern: '{pattern}' (only letters, no spaces/numbers)");
            Console.WriteLine();
            
            string[] testInputs = { "Hello", "Hello123", "Hello World", "" };
            
            foreach (string input in testInputs)
            {
                bool isValid = Regex.IsMatch(input, pattern);
                string display = string.IsNullOrEmpty(input) ? "(empty)" : input;
                Console.WriteLine($"  '{display}' -> {(isValid ? "Valid" : "Invalid")}");
            }
            
            Console.WriteLine();
            Console.WriteLine("TIP: Use IsMatch() when you just need yes/no answer!");
            
            PrintSeparator();
        }

        // ╔════════════════════════════════════════════════════════════════════╗
        // ║ SECTION 9: Regex.Match() - Find First Match                         ║
        // ╚════════════════════════════════════════════════════════════════════╝
        static void Section9_RegexMatch()
        {
            PrintHeader("SECTION 9: Regex.Match() - Find First Match");
            
            Console.WriteLine("Match() returns details about the FIRST match found.");
            Console.WriteLine();
            
            string text = "Order #12345 placed on 2024-01-15 for $99.99";
            string pattern = @"\d+";  // Find digits
            
            Console.WriteLine($"Text: '{text}'");
            Console.WriteLine($"Pattern: '{pattern}' (one or more digits)");
            Console.WriteLine();
            
            Match match = Regex.Match(text, pattern);
            
            if (match.Success)
            {
                Console.WriteLine("First match found!");
                Console.WriteLine($"  Value   : {match.Value}");    // The matched text
                Console.WriteLine($"  Index   : {match.Index}");    // Position in string
                Console.WriteLine($"  Length  : {match.Length}");   // Length of match
            }
            else
            {
                Console.WriteLine("No match found.");
            }
            
            Console.WriteLine();
            Console.WriteLine("TIP: Use Match() when you only need the first occurrence!");
            
            PrintSeparator();
        }

        // ╔════════════════════════════════════════════════════════════════════╗
        // ║ SECTION 10: Regex.Matches() - Find All Matches                      ║
        // ╚════════════════════════════════════════════════════════════════════╝
        static void Section10_RegexMatches()
        {
            PrintHeader("SECTION 10: Regex.Matches() - Find All Matches");
            
            Console.WriteLine("Matches() returns ALL occurrences of the pattern.");
            Console.WriteLine();
            
            string text = "I have 3 apples, 5 oranges, and 12 bananas";
            string pattern = @"\d+";
            
            Console.WriteLine($"Text: '{text}'");
            Console.WriteLine($"Pattern: '{pattern}'");
            Console.WriteLine();
            
            MatchCollection matches = Regex.Matches(text, pattern);
            
            Console.WriteLine($"Found {matches.Count} matches:");
            
            int total = 0;
            foreach (Match match in matches)
            {
                Console.WriteLine($"  '{match.Value}' at position {match.Index}");
                total += int.Parse(match.Value);
            }
            
            Console.WriteLine();
            Console.WriteLine($"Total fruits: {total}");
            
            PrintSeparator();
        }

        // ╔════════════════════════════════════════════════════════════════════╗
        // ║ SECTION 11: Regex.Replace() - Find and Replace                      ║
        // ╚════════════════════════════════════════════════════════════════════╝
        static void Section11_RegexReplace()
        {
            PrintHeader("SECTION 11: Regex.Replace() - Find and Replace");
            
            Console.WriteLine("Replace() finds all matches and replaces them.");
            Console.WriteLine();
            
            // Example 1: Mask phone numbers
            Console.WriteLine("=== Example 1: Mask Phone Numbers ===");
            string text1 = "Contact: 9876543210 or 8765432109";
            string masked = Regex.Replace(text1, @"\d{10}", "**********");
            Console.WriteLine($"Original: {text1}");
            Console.WriteLine($"Masked  : {masked}");
            
            Console.WriteLine();
            
            // Example 2: Remove extra spaces
            Console.WriteLine("=== Example 2: Remove Extra Spaces ===");
            string text2 = "Too    many     spaces   here";
            string cleaned = Regex.Replace(text2, @"\s+", " ");
            Console.WriteLine($"Original: '{text2}'");
            Console.WriteLine($"Cleaned : '{cleaned}'");
            
            Console.WriteLine();
            
            // Example 3: Censor bad words
            Console.WriteLine("=== Example 3: Censor Words ===");
            string text3 = "This is bad and very bad indeed";
            string censored = Regex.Replace(text3, @"\bbad\b", "***", RegexOptions.IgnoreCase);
            Console.WriteLine($"Original: {text3}");
            Console.WriteLine($"Censored: {censored}");
            
            Console.WriteLine();
            
            // Example 4: Format phone number using groups
            Console.WriteLine("=== Example 4: Format Phone Using Groups ===");
            string phone = "9876543210";
            string formatted = Regex.Replace(phone, @"(\d{3})(\d{3})(\d{4})", "($1) $2-$3");
            Console.WriteLine($"Original : {phone}");
            Console.WriteLine($"Formatted: {formatted}");
            
            PrintSeparator();
        }

        // ╔════════════════════════════════════════════════════════════════════╗
        // ║ SECTION 12: EMAIL VALIDATION                                        ║
        // ╚════════════════════════════════════════════════════════════════════╝
        static void Section12_EmailValidation()
        {
            PrintHeader("SECTION 12: Email Validation");
            
            // Email Pattern Breakdown:
            // ^           - Start of string
            // [\w.-]+     - One or more: word char, dot, or hyphen (local part)
            // @           - The @ symbol (literal)
            // [\w.-]+     - One or more: word char, dot, or hyphen (domain)
            // \.          - A literal dot (escaped)
            // [a-zA-Z]{2,}- At least 2 letters (TLD like com, org, co.in)
            // $           - End of string
            
            string pattern = @"^[\w.-]+@[\w.-]+\.[a-zA-Z]{2,}$";
            
            Console.WriteLine("Email Validation Pattern:");
            Console.WriteLine($"  {pattern}");
            Console.WriteLine();
            Console.WriteLine("Pattern Breakdown:");
            Console.WriteLine(@"  ^           = Start of string");
            Console.WriteLine(@"  [\w.-]+     = Local part (letters, numbers, dot, hyphen)");
            Console.WriteLine(@"  @           = Literal @ symbol");
            Console.WriteLine(@"  [\w.-]+     = Domain (letters, numbers, dot, hyphen)");
            Console.WriteLine(@"  \.          = Literal dot");
            Console.WriteLine(@"  [a-zA-Z]{2,}= TLD with at least 2 letters");
            Console.WriteLine(@"  $           = End of string");
            Console.WriteLine();
            
            string[] emails = {
                "john@gmail.com",
                "jane.doe@company.co.in",
                "user123@test.org",
                "invalid@",
                "@nodomain.com",
                "spaces not@allowed.com",
                "missing.at.sign.com"
            };
            
            Console.WriteLine("Test Results:");
            foreach (string email in emails)
            {
                bool isValid = Regex.IsMatch(email, pattern);
                Console.WriteLine($"  {email,-30} {(isValid ? "[OK]" : "[FAIL]")}");
            }
            
            PrintSeparator();
        }

        // ╔════════════════════════════════════════════════════════════════════╗
        // ║ SECTION 13: PHONE NUMBER VALIDATION (INDIAN FORMAT)                 ║
        // ╚════════════════════════════════════════════════════════════════════╝
        static void Section13_PhoneValidation()
        {
            PrintHeader("SECTION 13: Phone Number Validation (Indian Format)");
            
            // Pattern Breakdown:
            // ^           - Start of string
            // (\+91|0)?   - Optional +91 or 0 (country/STD code)
            // [6-9]       - First digit must be 6, 7, 8, or 9
            // \d{9}       - Followed by exactly 9 more digits
            // $           - End of string
            
            string pattern = @"^(\+91|0)?[6-9]\d{9}$";
            
            Console.WriteLine("Indian Phone Number Pattern:");
            Console.WriteLine($"  {pattern}");
            Console.WriteLine();
            Console.WriteLine("Pattern Breakdown:");
            Console.WriteLine(@"  ^           = Start of string");
            Console.WriteLine(@"  (\+91|0)?   = Optional country code (+91 or 0)");
            Console.WriteLine(@"  [6-9]       = First digit: 6, 7, 8, or 9");
            Console.WriteLine(@"  \d{9}       = Exactly 9 more digits");
            Console.WriteLine(@"  $           = End of string");
            Console.WriteLine();
            
            string[] phones = {
                "9876543210",       // Valid - 10 digits starting with 9
                "+919876543210",    // Valid - with +91
                "09876543210",      // Valid - with 0
                "6789012345",       // Valid - starts with 6
                "5876543210",       // Invalid - starts with 5
                "987654321",        // Invalid - only 9 digits
                "98765432101",      // Invalid - 11 digits
                "1234567890"        // Invalid - starts with 1
            };
            
            Console.WriteLine("Test Results:");
            foreach (string phone in phones)
            {
                bool isValid = Regex.IsMatch(phone, pattern);
                Console.WriteLine($"  {phone,-15} {(isValid ? "[OK]" : "[FAIL]")}");
            }
            
            PrintSeparator();
        }

        // ╔════════════════════════════════════════════════════════════════════╗
        // ║ SECTION 14: PASSWORD STRENGTH CHECKER                               ║
        // ╚════════════════════════════════════════════════════════════════════╝
        static void Section14_PasswordStrength()
        {
            PrintHeader("SECTION 14: Password Strength Checker");
            
            // Strong Password Rules:
            // - At least 8 characters
            // - At least one lowercase letter
            // - At least one uppercase letter
            // - At least one digit
            // - At least one special character
            
            // Pattern uses LOOKAHEADS (?=...) to check multiple conditions
            // Lookahead = "Look ahead to see if pattern exists, don't consume"
            
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=!]).{8,}$";
            
            Console.WriteLine("Strong Password Pattern:");
            Console.WriteLine($"  {pattern}");
            Console.WriteLine();
            Console.WriteLine("Pattern Breakdown (Lookaheads):");
            Console.WriteLine(@"  ^              = Start of string");
            Console.WriteLine(@"  (?=.*[a-z])    = Must contain lowercase");
            Console.WriteLine(@"  (?=.*[A-Z])    = Must contain uppercase");
            Console.WriteLine(@"  (?=.*\d)       = Must contain digit");
            Console.WriteLine(@"  (?=.*[@#$...]) = Must contain special char");
            Console.WriteLine(@"  .{8,}          = At least 8 characters");
            Console.WriteLine(@"  $              = End of string");
            Console.WriteLine();
            
            string[] passwords = {
                "MyPass@123",     // Strong - has all
                "Str0ng@Pass",    // Strong - has all
                "weakpass",       // Weak - no uppercase, digit, special
                "ALLCAPS123!",    // Weak - no lowercase
                "NoSpecial1A",    // Weak - no special character
                "Short@1",        // Weak - less than 8 characters
                "12345678"        // Weak - only digits
            };
            
            Console.WriteLine("Test Results:");
            foreach (string password in passwords)
            {
                bool isStrong = Regex.IsMatch(password, pattern);
                Console.WriteLine($"  {password,-15} {(isStrong ? "[STRONG]" : "[WEAK]")}");
            }
            
            PrintSeparator();
        }

        // ╔════════════════════════════════════════════════════════════════════╗
        // ║ SECTION 15: EXTRACT NUMBERS FROM TEXT                               ║
        // ╚════════════════════════════════════════════════════════════════════╝
        static void Section15_ExtractNumbers()
        {
            PrintHeader("SECTION 15: Extract Numbers from Text");
            
            string text = "The price is Rs.45.99, quantity: 100, discount: 15%";
            
            Console.WriteLine($"Text: '{text}'");
            Console.WriteLine();
            
            // Pattern 1: Integers only
            Console.WriteLine(@"=== Pattern: \d+ (integers only) ===");
            MatchCollection integers = Regex.Matches(text, @"\d+");
            foreach (Match m in integers)
            {
                Console.WriteLine($"  Found: {m.Value}");
            }
            
            Console.WriteLine();
            
            // Pattern 2: Decimals too
            Console.WriteLine(@"=== Pattern: \d+\.?\d* (with decimals) ===");
            MatchCollection decimals = Regex.Matches(text, @"\d+\.?\d*");
            foreach (Match m in decimals)
            {
                Console.WriteLine($"  Found: {m.Value}");
            }
            
            Console.WriteLine();
            
            // Pattern 3: Currency amounts
            Console.WriteLine(@"=== Pattern: Rs\.?\d+\.?\d* (currency) ===");
            MatchCollection currency = Regex.Matches(text, @"Rs\.?\d+\.?\d*");
            foreach (Match m in currency)
            {
                Console.WriteLine($"  Found: {m.Value}");
            }
            
            PrintSeparator();
        }

        // ╔════════════════════════════════════════════════════════════════════╗
        // ║ SECTION 16: GREEDY vs LAZY MATCHING                                 ║
        // ╚════════════════════════════════════════════════════════════════════╝
        static void Section16_GreedyVsLazy()
        {
            PrintHeader("SECTION 16: Greedy vs Lazy Matching");
            
            Console.WriteLine("GREEDY (*,+,?) = Match as MUCH as possible");
            Console.WriteLine("LAZY (*?,+?,??) = Match as LITTLE as possible");
            Console.WriteLine();
            
            string html = "<div>Hello</div><div>World</div>";
            Console.WriteLine($"Text: '{html}'");
            Console.WriteLine();
            
            // Greedy: .* matches as much as possible
            Console.WriteLine("=== Greedy Pattern: <div>.*</div> ===");
            Match greedy = Regex.Match(html, @"<div>.*</div>");
            Console.WriteLine($"Matched: '{greedy.Value}'");
            Console.WriteLine("(Grabbed EVERYTHING from first <div> to LAST </div>)");
            
            Console.WriteLine();
            
            // Lazy: .*? matches as little as possible
            Console.WriteLine("=== Lazy Pattern: <div>.*?</div> ===");
            Match lazy = Regex.Match(html, @"<div>.*?</div>");
            Console.WriteLine($"Matched: '{lazy.Value}'");
            Console.WriteLine("(Stopped at FIRST </div>)");
            
            Console.WriteLine();
            
            // Get all with lazy
            Console.WriteLine("=== All Lazy Matches ===");
            MatchCollection allLazy = Regex.Matches(html, @"<div>.*?</div>");
            foreach (Match m in allLazy)
            {
                Console.WriteLine($"  Found: '{m.Value}'");
            }
            
            PrintSeparator();
        }

        // ╔════════════════════════════════════════════════════════════════════╗
        // ║ SECTION 17: GROUPS AND CAPTURING                                    ║
        // ╚════════════════════════════════════════════════════════════════════╝
        static void Section17_Groups()
        {
            PrintHeader("SECTION 17: Groups and Capturing");
            
            Console.WriteLine("Groups () let you capture PARTS of a match.");
            Console.WriteLine();
            
            string dateText = "Today is 2024-01-15 and tomorrow is 2024-01-16";
            
            // Pattern with groups: (year)-(month)-(day)
            string pattern = @"(\d{4})-(\d{2})-(\d{2})";
            
            Console.WriteLine($"Text: '{dateText}'");
            Console.WriteLine($"Pattern: '{pattern}'");
            Console.WriteLine();
            Console.WriteLine("Groups:");
            Console.WriteLine(@"  Group 0 = Entire match");
            Console.WriteLine(@"  Group 1 = (\d{4}) = Year");
            Console.WriteLine(@"  Group 2 = (\d{2}) = Month");
            Console.WriteLine(@"  Group 3 = (\d{2}) = Day");
            Console.WriteLine();
            
            MatchCollection matches = Regex.Matches(dateText, pattern);
            
            int count = 1;
            foreach (Match match in matches)
            {
                Console.WriteLine($"=== Date {count} ===");
                Console.WriteLine($"  Full Match: {match.Groups[0].Value}");
                Console.WriteLine($"  Year      : {match.Groups[1].Value}");
                Console.WriteLine($"  Month     : {match.Groups[2].Value}");
                Console.WriteLine($"  Day       : {match.Groups[3].Value}");
                
                // Convert to different format
                string formatted = $"{match.Groups[3].Value}/{match.Groups[2].Value}/{match.Groups[1].Value}";
                Console.WriteLine($"  Formatted : {formatted}");
                Console.WriteLine();
                count++;
            }
            
            PrintSeparator();
        }

        // ╔════════════════════════════════════════════════════════════════════╗
        // ║ SECTION 18: NAMED GROUPS                                            ║
        // ╚════════════════════════════════════════════════════════════════════╝
        static void Section18_NamedGroups()
        {
            PrintHeader("SECTION 18: Named Groups");
            
            Console.WriteLine("Named groups make code more readable!");
            Console.WriteLine("Syntax: (?<name>pattern)");
            Console.WriteLine();
            
            string email = "john.doe@example.com";
            
            // Named groups: username and domain
            string pattern = @"(?<username>[\w.]+)@(?<domain>[\w.]+)";
            
            Console.WriteLine($"Email: '{email}'");
            Console.WriteLine($"Pattern: '{pattern}'");
            Console.WriteLine();
            
            Match match = Regex.Match(email, pattern);
            
            if (match.Success)
            {
                // Access by name - much clearer than Groups[1], Groups[2]!
                string username = match.Groups["username"].Value;
                string domain = match.Groups["domain"].Value;
                
                Console.WriteLine($"Username: {username}");
                Console.WriteLine($"Domain  : {domain}");
            }
            
            Console.WriteLine();
            
            // Another example: Parse URL
            Console.WriteLine("=== Parse URL Example ===");
            string url = "https://www.example.com:8080/path/page.html";
            string urlPattern = @"(?<protocol>https?)://(?<host>[\w.]+):?(?<port>\d*)(?<path>/.*)?";
            
            Console.WriteLine($"URL: '{url}'");
            
            Match urlMatch = Regex.Match(url, urlPattern);
            if (urlMatch.Success)
            {
                Console.WriteLine($"  Protocol: {urlMatch.Groups["protocol"].Value}");
                Console.WriteLine($"  Host    : {urlMatch.Groups["host"].Value}");
                Console.WriteLine($"  Port    : {urlMatch.Groups["port"].Value}");
                Console.WriteLine($"  Path    : {urlMatch.Groups["path"].Value}");
            }
            
            PrintSeparator();
        }

        // ╔════════════════════════════════════════════════════════════════════╗
        // ║ SECTION 19: REGEX OPTIONS                                           ║
        // ╚════════════════════════════════════════════════════════════════════╝
        static void Section19_RegexOptions()
        {
            PrintHeader("SECTION 19: Regex Options (Flags)");
            
            // IgnoreCase
            Console.WriteLine("=== RegexOptions.IgnoreCase ===");
            Console.WriteLine("Makes matching case-insensitive (a = A)");
            Console.WriteLine();
            
            string text1 = "Hello WORLD";
            Console.WriteLine($"Text: '{text1}'");
            Console.WriteLine($"Pattern: 'hello'");
            Console.WriteLine($"Without IgnoreCase: {Regex.IsMatch(text1, "hello")}");
            Console.WriteLine($"With IgnoreCase   : {Regex.IsMatch(text1, "hello", RegexOptions.IgnoreCase)}");
            
            Console.WriteLine();
            
            // Multiline
            Console.WriteLine("=== RegexOptions.Multiline ===");
            Console.WriteLine("Makes ^ and $ match line boundaries, not just string boundaries");
            Console.WriteLine();
            
            string text2 = "Line 1\nLine 2\nLine 3";
            Console.WriteLine($"Text has 3 lines");
            Console.WriteLine($"Pattern: '^Line'");
            
            int withoutMulti = Regex.Matches(text2, "^Line").Count;
            int withMulti = Regex.Matches(text2, "^Line", RegexOptions.Multiline).Count;
            
            Console.WriteLine($"Without Multiline: {withoutMulti} match(es)");
            Console.WriteLine($"With Multiline   : {withMulti} match(es)");
            
            Console.WriteLine();
            
            // Singleline
            Console.WriteLine("=== RegexOptions.Singleline ===");
            Console.WriteLine("Makes . match newlines too");
            Console.WriteLine();
            
            string text3 = "Start\nMiddle\nEnd";
            Console.WriteLine($"Text: 'Start\\nMiddle\\nEnd'");
            Console.WriteLine($"Pattern: 'Start.*End'");
            
            bool withoutSingle = Regex.IsMatch(text3, "Start.*End");
            bool withSingle = Regex.IsMatch(text3, "Start.*End", RegexOptions.Singleline);
            
            Console.WriteLine($"Without Singleline: {withoutSingle}");
            Console.WriteLine($"With Singleline   : {withSingle}");
            
            Console.WriteLine();
            
            // Combining options
            Console.WriteLine("=== Combining Options ===");
            Console.WriteLine("Use | (OR) to combine: RegexOptions.IgnoreCase | RegexOptions.Multiline");
            
            RegexOptions combined = RegexOptions.IgnoreCase | RegexOptions.Multiline;
            int result = Regex.Matches(text2, "^line", combined).Count;
            Console.WriteLine($"Matches with IgnoreCase + Multiline: {result}");
            
            PrintSeparator();
        }

        // ╔════════════════════════════════════════════════════════════════════╗
        // ║ SECTION 20: REAL-WORLD EXAMPLES                                     ║
        // ╚════════════════════════════════════════════════════════════════════╝
        static void Section20_RealWorldExamples()
        {
            PrintHeader("SECTION 20: Real-World Examples");
            
            // 1. Form Validation
            Console.WriteLine("=== 1. Form Validation ===");
            ValidateForm("John Doe", "john@email.com", "9876543210", "400001");
            Console.WriteLine();
            
            // 2. Log Parsing
            Console.WriteLine("=== 2. Log Parsing ===");
            ParseLogs();
            Console.WriteLine();
            
            // 3. Input Sanitization
            Console.WriteLine("=== 3. Input Sanitization ===");
            SanitizeInput();
            Console.WriteLine();
            
            // 4. Data Cleaning
            Console.WriteLine("=== 4. Data Cleaning ===");
            CleanData();
            Console.WriteLine();
            
            // 5. Extract URLs
            Console.WriteLine("=== 5. Extract URLs from Text ===");
            ExtractUrls();
            
            PrintSeparator();
        }

        // Helper: Form Validation
        static void ValidateForm(string name, string email, string phone, string pincode)
        {
            Console.WriteLine($"Validating Form Data:");
            Console.WriteLine($"  Name   : {name}");
            Console.WriteLine($"  Email  : {email}");
            Console.WriteLine($"  Phone  : {phone}");
            Console.WriteLine($"  Pincode: {pincode}");
            Console.WriteLine();
            
            // Patterns
            bool nameValid = Regex.IsMatch(name, @"^[a-zA-Z\s]{2,50}$");
            bool emailValid = Regex.IsMatch(email, @"^[\w.-]+@[\w.-]+\.\w{2,}$");
            bool phoneValid = Regex.IsMatch(phone, @"^[6-9]\d{9}$");
            bool pincodeValid = Regex.IsMatch(pincode, @"^\d{6}$");
            
            Console.WriteLine($"Results:");
            Console.WriteLine($"  Name   : {(nameValid ? "[OK]" : "[FAIL]")}");
            Console.WriteLine($"  Email  : {(emailValid ? "[OK]" : "[FAIL]")}");
            Console.WriteLine($"  Phone  : {(phoneValid ? "[OK]" : "[FAIL]")}");
            Console.WriteLine($"  Pincode: {(pincodeValid ? "[OK]" : "[FAIL]")}");
        }

        // Helper: Log Parsing
        static void ParseLogs()
        {
            string[] logs = {
                "[2024-01-15 10:30:45] ERROR: Database connection failed",
                "[2024-01-15 10:30:46] INFO: Retrying connection...",
                "[2024-01-15 10:30:47] ERROR: Connection timeout",
                "[2024-01-15 10:30:48] INFO: Connected successfully"
            };
            
            string pattern = @"\[(?<timestamp>[\d-: ]+)\] (?<level>\w+): (?<message>.+)";
            Regex regex = new Regex(pattern);
            
            Console.WriteLine("Extracting ERROR logs:");
            
            foreach (string log in logs)
            {
                Match match = regex.Match(log);
                if (match.Success && match.Groups["level"].Value == "ERROR")
                {
                    Console.WriteLine($"  [{match.Groups["timestamp"].Value}] {match.Groups["message"].Value}");
                }
            }
        }

        // Helper: Input Sanitization
        static void SanitizeInput()
        {
            string dangerousInput = "Hello <script>alert('XSS')</script> World!";
            
            Console.WriteLine($"Original: {dangerousInput}");
            
            // Remove HTML tags
            string sanitized = Regex.Replace(dangerousInput, @"<[^>]+>", "");
            Console.WriteLine($"Sanitized: {sanitized}");
        }

        // Helper: Data Cleaning
        static void CleanData()
        {
            string messyData = "  Name:   John   Doe  ,  Age:  25  ";
            
            Console.WriteLine($"Original: '{messyData}'");
            
            // Remove extra spaces
            string cleaned = Regex.Replace(messyData, @"\s+", " ");
            cleaned = cleaned.Trim();
            
            Console.WriteLine($"Cleaned : '{cleaned}'");
        }

        // Helper: Extract URLs
        static void ExtractUrls()
        {
            string text = "Visit https://www.google.com or http://example.org for more info";
            string pattern = @"https?://[\w.-]+\.[a-z]{2,}";
            
            Console.WriteLine($"Text: {text}");
            Console.WriteLine("Found URLs:");
            
            foreach (Match match in Regex.Matches(text, pattern, RegexOptions.IgnoreCase))
            {
                Console.WriteLine($"  {match.Value}");
            }
        }

        // ╔════════════════════════════════════════════════════════════════════╗
        // ║ HELPER METHODS FOR FORMATTING                                       ║
        // ╚════════════════════════════════════════════════════════════════════╝
        static void PrintHeader(string title)
        {
            Console.WriteLine();
            Console.WriteLine(new string('=', 70));
            Console.WriteLine($"  {title}");
            Console.WriteLine(new string('=', 70));
            Console.WriteLine();
        }

        static void PrintSeparator()
        {
            Console.WriteLine();
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}
