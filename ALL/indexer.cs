// using System;

// class Books
// {
//     public string[] books = new string[3]; // Array with 3 elements

//     public string this[int index]
//     {
//         get
//         {
//             if (index >= 0 && index < books.Length)  // Index should be within bounds
//             {
//                 return books[index];
//             }
//             else
//             {
//                 return "invalid index";
//             }
//         }
//         set
//         {
//             if (index >= 0 && index < books.Length)  // Index should be within bounds for setting value
//             {
//                 books[index] = value;
//             }
//             else
//             {
//                 Console.WriteLine("invalid index");
//             }
//         }
//     }

//     static void Main(string[] args)
//     {
//         Books books = new Books();
//         books[0] = "Harry Potter";
//         books[1] = "The Hobbit";
//         books[2] = "1984";
        
//         // Attempting to assign a value to an invalid index
//         books[3] = "Moby Dick";  // This will output "invalid index" because index 3 is out of bounds

//         // Print the value at index 2 (which is valid)
//         Console.WriteLine(books[2]);  // Output: 1984
//     }
// }
