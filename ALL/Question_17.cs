// using System;

// class Question
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Enter college name");
//         string? name = Console.ReadLine();

//         if (name == null)
//         {
//             Console.WriteLine("No name was entered.");
//             return;
//         }

//         int nameLen = name.Length;
//         int lenLimit = 10;

//         if (nameLen > lenLimit)
//         {
//             throw new ArithmeticException($"Name length cannot be more than {lenLimit}");
//         }
//         else
//         {
//             Console.WriteLine($"College Name: {name}");
//         }
//     }
// }
