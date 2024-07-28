// using System;

// public class Rectangle
// {
//     private double length;
//     private double width;

//     public double Length
//     {
//         get { return length; }
//         set
//         {
//             if (value < 0)
//             {
//                 Console.WriteLine("Enter a positive value for length.");
//             }
//             else
//             {
//                 length = value;
//             }
//         }
//     }

//     public double Width
//     {
//         get { return width; }
//         set
//         {
//             if (value < 0)
//             {
//                 Console.WriteLine("Enter a positive value for width.");
//             }
//             else
//             {
//                 width = value;
//             }
//         }
//     }

//     public double Area
//     {
//         get
//         {
//             return length * width;
//         }
//     }

//     public Rectangle(double length, double width)
//     {
//         this.length = length;
//         this.width = width;
//     }
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Rectangle rect = new(12, 12);
//         Console.WriteLine($"Area of the rectangle: {rect.Area}");
//     }
// }
