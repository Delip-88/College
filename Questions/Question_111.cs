// // Write a program to handle indexoutofrange eception &  invalid cast exception.
// // how base keywrod is used to call member function adn constructor of parent class.
// // Boxing & Unboxing (program)

// // 1.

// // class Question_111{
// //     public static void Main(string[] args)
// //     {
// //         // int [] arr = {1,2,3};
// //         // try
// //         // {
// //         //     System.Console.WriteLine(arr[3]);
// //         // }
// //         // catch (Exception e)
// //         // {
            
// //         //     System.Console.WriteLine(e);
// //         // }

// //          try
// //         {
// //             // Example that causes an InvalidCastException
// //             object obj = "This is a string";
// //             int num = (int)obj; // Invalid cast: object is a string, not an int
// //         }
// //         catch (InvalidCastException e)
// //         {
// //             Console.WriteLine("Caught an InvalidCastException:");
// //             Console.WriteLine(e.Message);
// //         }
// //     }
// // }
// class Vehicle {
//     public int x = 12;
//     public int y = 13;
//     public void show() {
//         System.Console.WriteLine($"Vehicle x = {x} y = {y}");
//     }
// }

// class Car : Vehicle {
//     public int x = 35;
//     public int y = 33;

//     public new void show() {
//         // Call the Vehicle class's show method
//         base.show();

//         // Display the Car class's x and y
//         System.Console.WriteLine($"Car x = {x} y = {y}");
//     }
// }

// class Program {
//     public static void Main(string[] args) {
//         Car c = new Car();
//         c.show();
//     }
// }
