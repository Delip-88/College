// using System;

// public class Fruit
// {
//     // Properties with default values
//     public virtual string Name { get; set; } = "Fruit";
//     public virtual string Taste { get; set; } = "Good";
//     public virtual string Size { get; set; } = "Big";
    
//     // Virtual method
//     public virtual void Eat()
//     {
//         Console.WriteLine($"Name = {Name} \nTaste = {Taste} \nSize = {Size}");
//     }
// }

// public class Apple : Fruit
// {
//     // Override properties
//     public override string Name { get; set; } = "Apple";
//     public override string Taste { get; set; } = "Sweet";
//     public override string Size { get; set; } = "Medium";

//     // Override method
//     public override void Eat()
//     {
//         Console.WriteLine($"Name = {Name} \nTaste = {Taste} \nSize = {Size}");
//     }
// }

// public class Orange : Fruit
// {
//     // Override properties
//     public override string Name { get; set; } = "Orange";
//     public override string Taste { get; set; } = "Citric";
//     public override string Size { get; set; } = "Medium";

//     // Override method
//     public override void Eat()
//     {
//         Console.WriteLine($"Name = {Name} \nTaste = {Taste} \nSize = {Size}");
//     }
// }

// public class Demo
// {
//     public static void Main(string[] args)
//     {
//         Fruit f = new Fruit();
//         f.Eat();
//         Console.WriteLine("_____________");

//         Orange o = new Orange();
//         o.Eat();
//         Console.WriteLine("_____________");

//         Apple a = new Apple();
//         a.Eat();
//     }
// }
