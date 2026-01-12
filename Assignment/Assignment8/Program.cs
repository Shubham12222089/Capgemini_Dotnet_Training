using System;
// class Program
// {
//     public static void Main(string[] args)
//     {
//         try
//         {
            
//             double temperature = Convert.ToInt32(Console.ReadLine());
//             string str = Console.ReadLine();

//             if (str == "F")
//             {
//                 double celsius = (temperature - 32) * 5 / 9;
//                 Console.WriteLine($"Temperature in Celsius: {celsius:F2}");
//             }
//             else if(str=="C")
//             {
//                 double fahrenheit = (temperature * 9 / 5) + 32;
//                 Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit:F2}");
//             }
//             else
//             {
//                 Console.WriteLine($"Invalid Conversion. Please Enter 'F' or 'C'.");
//             }
//         }
//         catch(Exception e)
//         {
//             Console.WriteLine("Error: Invalid input provided.");
//             Console.WriteLine($"Exception Message : {e.Message}");
//         }
//     }
// }

//----------------------------------------


// class Program
// {
//     public static void Main(string[] args)
//     {
//         CricketMatch cricket = new CricketMatch();
//         Console.Write("Enter the Scores : ");
//         string scores = Console.ReadLine();
//         string[] values = scores.Split(' ');
//         foreach(string s in values)
//         {
//             int score = Convert.ToInt32(s);
//             cricket.AddPlayerScore(score);
//         }
//         Console.WriteLine($"Total Score of the Cricket Team: {cricket.CalculateTotalScore()}");
//     }
// }

// class CricketMatch
// {
//     public int[] playerScores;
//     public int currentIndex;
//     public CricketMatch()
//     {
//         playerScores = new int[5];
//         currentIndex=0;
//     }
//     public void AddPlayerScore(int score)
//     {
//         if(score<0 || score > 50)
//         {
//             throw new ArgumentException("Invalid score. Score must be between 0 and 50.");
//         }
//         if (currentIndex > 5)
//         {
//             throw new InvalidOperationException("Cannot add more than 5 player scores.");
//         }
//         playerScores[currentIndex] = score;
//         currentIndex++;
//     }

//     public int CalculateTotalScore()
//     {
//         int total=0;
//         foreach(int i in playerScores)
//         {
//             total+=i;
//         }
//         return total;
//     }
// }

//-------------------------------------------------

// class Program
// {
//     public static void Main(string[] args)
//     {
//         try
//         {
            
//             string inputArray1 = Console.ReadLine();
//             string[] Array1 = inputArray1.Split(' ');
//             int[] number1 = new int[Array1.Length];
//             for(int i = 0; i < Array1.Length; i++)
//             {
//                 number1[i] = Convert.ToInt32(Array1[i]);
//             }

//             string inputArray2 = Console.ReadLine();
//             string[] Array2 = inputArray2.Split(' ');
//             int[] number2 = new int[Array2.Length];
//             for(int i = 0; i < Array2.Length; i++)
//             {
//                 number2[i] = Convert.ToInt32(Array2[i]);
//             }
//             if (number1.Length != number2.Length)
//             {
//                 Console.WriteLine("Error: Arrays must have the same length for addition.");
//                 return;
//             }
//             int[] sumArray = new int[Array2.Length];
//             for(int i = 0; i < sumArray.Length; i++)
//             {
//                 sumArray[i] = number1[i]+number2[i];
//             }

//             int index = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine($"Element at index {index} in the sum array: {sumArray[index]}");
//         }
//         catch (FormatException e)
//         {
//             Console.WriteLine("Error: Invalid input format. Please enter integers only.");
//             Console.WriteLine($"Exception Message: {e.Message}");
//         }
//         catch(IndexOutOfRangeException e)
//         {
//             Console.WriteLine("Error: Index out of range for the sum array.");
//             Console.WriteLine($"Exception Message: {e.Message}");
//         }
//     }
// }

