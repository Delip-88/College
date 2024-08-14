// /* WAP to demonstrate static constuctor ,
// WAP to implement indexer in c#endregion
// wAP to implement property in c#
// */

// class Question{
//     public static int StaticValue;

//     static Question(){
//         StaticValue = 10;
//     }
//     public Question() {
//         Console.WriteLine("I am Constructor , value : " + StaticValue);
//     }
//     public static void Main(string[] args)
//     {
//         Question question = new Question();

//     }
// }


//Question 2


// public class MyCollection
// {
//     private string[] data = new string[5]; // Internal data storage

//     // Indexer declaration
//     public string this[int index]
//     {
//         get => data[index];
//         set => data[index] = value;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         MyCollection collection = new MyCollection();

//         // Assign values using the indexer
//         collection[0] = "First";
//         collection[1] = "Second";
//         collection[2] = "Third";

//         // Retrieve values using the indexer
//         Console.WriteLine($"Value at index 0: {collection[0]}");
//         Console.WriteLine($"Value at index 2: {collection[2]}");
//     }
// }




// Question 3

// using System;

// public class Person
// {
//     // Private field
//     private string _name;

//     // Public property
//     public string Name
//     {
//         get { return _name; }   // Getter
//         set { _name = value; }  // Setter
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Create an instance of Person
//         Person person = new()
//         {
//             // Set the value of the Name property
//             Name = "Alice"
//         };

//         // Get the value of the Name property and print it
//         Console.WriteLine($"Person's name is: {person.Name}");
//     }
// }
