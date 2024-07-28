// using System;

// class Animal
// {
//     // Fields
//     private string Name;
//     private string Address;
//     private string Gender;
//     private string Status;
//     private int Age;

//     // Default Constructor
//     public Animal()
//     {
//         Console.WriteLine("I am default Constructor");
//     }

//     // Parameterized Constructor
//     public Animal(string name, string address)
//     {
//         Name = name;
//         Address = address;
//     }

//     // Constructor Overloading
//     public Animal(string name, int age, string address, string gender, string status)
//     {
//         Name = name;
//         Age = age;
//         Address = address;
//         Gender = gender;
//         Status = status;
//     }

//     // Method to display animal information
//     public void DisplayInfo()
//     {
//         Console.WriteLine($"Name: {Name}");
//         Console.WriteLine($"Age: {Age}");
//         Console.WriteLine($"Address: {Address}");
//         Console.WriteLine($"Gender: {Gender}");
//         Console.WriteLine($"Status: {Status}");
//     }

//     static void Main(string[] args)
//     {
//         // Creating an instance using the default constructor
//         // Animal animal1 = new Animal();

//         // Creating an instance using the parameterized constructor
//         // Animal animal2 = new Animal("Saswtik Dhungel", "Hetauda");

//         // Creating an instance using the overloaded constructor
//         Animal animal3 = new Animal("Swastik Dhungel", 25, "Hetauda-17, Makwanpur", "Male", "Alive");

//         // Calling the DisplayInfo method on all instances
//         // animal1.DisplayInfo();
//         // animal2.DisplayInfo();
//         animal3.DisplayInfo();
//     }
// }
