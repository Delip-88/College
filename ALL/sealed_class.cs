// using System;

// class Animal
// {
//     public void eat()
//     {
//         Console.WriteLine("I am eating");

//     }
//     sealed class Dog : Animal
//     {
//         public void bark()
//         {
//             Console.WriteLine("I am barking");
//         }
//     }
//     class Bulldog : Dog
//     {
//         public void bark()
//         {
//             Console.WriteLine("Wauf Wauf Wauf");
//         }
//     }
//     static void Main(string[] args)
//     {
//         Dog d = new Dog();
//         // d.eat();
//         d.bark();

//         Bulldog b = new Bulldog();
//         b.bark();
//     }
// }