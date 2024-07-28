// // write a program to inherit class circle square triangle from base class shape and claculate area in each class.
// using System;

// // Base class
// public abstract class Shape
// {
//     // Abstract method for area calculation, to be implemented by derived classes
//     public abstract double Area();
// }

// // Circle derived from Shape
// public class Circle : Shape
// {
//     private double radius;

//     public Circle(double r)
//     {
//         radius = r;
//     }

//     public override double Area()
//     {
//         return Math.PI * radius * radius; // Area of circle πr^2
//     }
// }

// // Square derived from Shape
// public class Square : Shape
// {
//     private double side;

//     public Square(double s)
//     {
//         side = s;
//     }

//     public override double Area()
//     {
//         return side * side; // Area of square side^2
//     }
// }

// // Triangle derived from Shape
// public class Triangle : Shape
// {
//     private double baseLength;
//     private double height;

//     public Triangle(double b, double h)
//     {
//         baseLength = b;
//         height = h;
//     }

//     public override double Area()
//     {
//         return 0.5 * baseLength * height; // Area of triangle 1/2 * base * height
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Example usage:
//         Circle c = new Circle(5.0);
//         Square s = new Square(4.0);
//         Triangle t = new Triangle(3.0, 6.0);

//         // Calculate and display areas
//         Console.WriteLine("Area of Circle: " + c.Area());
//         Console.WriteLine("Area of Square: " + s.Area());
//         Console.WriteLine("Area of Triangle: " + t.Area());
//     }
// }
