// using System;
// using Microsoft.VisualBasic;

// class Animal
// {
//     public string Name = "Pawan Rai";
//     public virtual void MakeSound()
//     {
//         Console.WriteLine("Animal is making Sound");
//     }
// }

// class Dog : Animal
// {
//     public string Name = " Hari ";
//     public void eat()
//     {
//         Console.WriteLine("Dog is eating");
//     }
//     public override void MakeSound()
//     {
//         Console.WriteLine("WOOF WOOF");
//         base.MakeSound();
//     }

//     public void CallName()
//     {
//         Console.WriteLine($"the name is {Name} from child class");
//         Console.WriteLine($"the name is {base.Name} from parent class");
//     }

// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Dog d = new Dog();
//         // d.CallName();

//         int[] arr = { 1, 2, 3, 4, 5 };

//         // Console.WriteLine(arr[3]);

//         int[][] jaggedaArr = new int[][] { new int[] { 12, 323, 4 }, new int[] { 123, 123, 4, 12, 12 }, new int[] { 32, 1 } };


//         for (int i = 0; i < jaggedaArr.Length; i++)
//         {
//             int sum = 0;

//             Console.WriteLine($"Row {i + 1}");
//             for (int j = 0; j < jaggedaArr[i].Length; j++)
//             {
//                 sum += jaggedaArr[i][j];
//             }
//             Console.WriteLine($"The sum is {sum}");
//         }


//         int[,] multiArr = {
//             {1,2,3},
//             {2,3,4},
//             {3,4,5},
//         };

//         for (int i = 0; i < multiArr.GetLength(0); i++) // GetLength(0) = Number of rows
//         {
//             for (int j = 0; j < multiArr.GetLength(1); j++) // GetLength(1) = Number of columns
//             {
//                 Console.Write(multiArr[i, j] + " "); // Print element with a space
//             }
//             Console.WriteLine(); // Newline after each row
//         }


//     }
// }


// class Fruit{
//     public string taste{ get; set; }
//     public string size{ get; set; }

//     public virtual void eat(){
//         Console.WriteLine($"eating fruit with size of {size} and its taste is {taste}");

//     }

//     public Fruit(){
//         Console.WriteLine("this is contructor of fruit auto calling.");
//     }
// }

// class Apple: Fruit{
//     public Apple(){
//         taste="Sweet and crispy";
//         size="Medium and red";
//     }

//     public override void eat(){
//         Console.WriteLine($"eating apple with size of {size} and its taste is {taste}");
//     }
// }

// class Orange: Fruit{
//     public Orange(){
//         taste="Sour";
//         size="medium";
//     }
//     public override void eat(){
//         Console.WriteLine($"eating orange with size of {size} and its taste is {taste}");
//     }
// }


// class Program{
//     public static void Main(string[] args){
//         Apple apple= new Apple();
//         Orange orange= new Orange();

//         Fruit fruit= new Fruit{taste="Unknow to manking" , size="infinetly expanding"};
//         fruit.eat();
//         apple.eat();
//         orange.eat();
//     }
// }


// abstract class Shape{
//     public abstract double CalculateArea();
//     public void DisplayArea(){
//         Console.WriteLine($"The area is {CalculateArea()}");
//     }

// }

// class Circle : Shape{
//     private int radius;
//     public Circle(int radius){
//         this.radius = radius;
//     }
//     public override double CalculateArea(){
//         return Math.PI* Math.Pow(radius,2);
//     }
// }
// class Square : Shape{
//     private int Length;
//     public Square(int Length){
//         this.Length = Length;
//     }
//     public override double CalculateArea(){
//         return Math.Pow(Length,2);
//     }
// }

// class Program{
//     public static void Main(string[] args){
//         Circle circle = new Circle(12);
//         circle.DisplayArea();

//         Square square = new Square(12);
//         square.DisplayArea();
//     }
// // }
// using System;

// class Account
// {
//     private double _balance;

//     // Property for balance with validation to prevent negative values
//     public double Balance
//     {
//         get { return _balance; }
//         set
//         {
//             if (value < 0)
//             {
//                 Console.WriteLine("Error: Balance cannot be negative.");
//                 // Do not change balance if the new value is negative
//             }
//             else
//             {
//                 _balance = value;
//             }
//         }
//     }

//     // Constructor to initialize the account balance
//     public Account(double balance)
//     {
//         if (balance < 0)
//         {
//             Console.WriteLine("Error: Balance cannot be negative. Setting balance to 0.");
//             _balance = 0; // Set balance to 0 if the initial value is negative
//         }
//         else
//         {
//             _balance = balance;
//         }
//         Console.WriteLine($"Your initial balance is {_balance}");
//     }
// }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         // Create an account with a valid balance
//         Account account = new Account(1000);

//         // Try to set a negative balance
//         account.Balance = -500;  // This should show an error message

//         // Try to set a valid balance
//         account.Balance = 5000;  // This should update the balance

//         // Display the final balance
//         Console.WriteLine($"Final balance is: {account.Balance}");
//     }
// }



// using System;

// class Rectangle
// {
//     // Read-only properties for length and width
//     public int Length { get; }
//     public int Width { get; }

//     // Read-only property for the area, calculated based on Length and Width
//     public int Area => Length * Width;

//     // Constructor to initialize Length and Width
//     public Rectangle(int length, int width)
//     {
//         this.Length = length;
//         this.Width = width;
//     }

//     // Method to display the area
//     public void Show()
//     {
//         Console.WriteLine($"The area is {Area}");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Create an object with initial dimensions
//         Rectangle rect = new Rectangle(12, 34);
//         rect.Show();  // Displays the area

//         // Attempting to change Width or Length directly will result in a compilation error
//         // rect.Width = 12;  // Error: Cannot modify read-only property

//         // To change dimensions, create a new instance with new values
//         Rectangle rect2 = new Rectangle(12, 12);
//         rect2.Show();  // Displays the new area


//     }
// }



// class Number
// {
//     public int value { get; set; }
//     public int value2 { get; set; }

//     public Number(int value,int value2){
//         this.value = value;
//         this.value2 = value2;
//     }

//     public static Number operator +(Number a, Number b)
//     {
//         return new Number(a.value + b.value, a.value2 + b.value2);
//     }

//     public static Number operator -(Number a, Number b){
//         return new Number(a.value-b.value, a.value2-b.value2);
//     }

//     public static bool operator <(Number a, Number b){
//         return a.value < b.value && a.value2 <b.value2;
//     }
//     public static bool operator >(Number a, Number b){
//         return a.value > b.value && a.value2 > b.value2;
//     }

// }
// class Program
// {
//     public static void Main(string[] args)
//     {
//         Number n1 = new Number(4,2);
//         Number n2 = new Number(13,4);

//         Number n3 = n1+n2;
//         Number n4 = n1-n2;
//         Console.WriteLine(n3.value);
//         Console.WriteLine(n3.value2);
//         Console.WriteLine(n4.value);
//         Console.WriteLine(n4.value2);
//         Console.WriteLine(n1>n2);
//     }
// }
// class Time
// {
//     public int Hour { get; set; }
//     public int Minute { get; set; }
//     public int Seconds { get; set; }

//     public Time(int hour, int minute, int second){
//         Hour = hour;
//         Minute = minute;
//         Seconds = second;
//     }

//     public static Time operator +(Time a, Time b)
//     {
//         return new Time(a.Hour+b.Hour,a.Minute+b.Minute,a.Seconds+b.Seconds);
//     }

//     public static Time operator -(Time a, Time b){
//         return new Time(a.Hour-b.Hour,a.Minute-b.Minute,a.Seconds-b.Seconds);
//     }

//     public static bool operator <(Time a, Time b){
//         return a.Hour < b.Hour ;
//     }
//     public static bool operator >(Time a, Time b){
//         return a.Hour > b.Hour;
//     }

// }
// class Program
// {
//     public static void Main(string[] args)
//     {
//         Time n1 = new Time(4,2,4);
//         Time n2 = new Time(1,6,4);

//         Time n3 = n1+n2;
//         Time n4 = n1-n2;
//         Console.WriteLine(n3.Hour);
//         Console.WriteLine(n3.Minute);
//         Console.WriteLine(n3.Seconds);
//         Console.WriteLine(n1>n2);
//     }
// }



// namespace customnamespace{
//     class Greeting{
//         public void greet(){
//             Console.WriteLine("Good Morning, How u doing?");
//         }
//     }
// }

// namespace anotherone{
//     class Bye{
//         public void condelence(){
//             Console.WriteLine("My pleasure, Good bye~!");
//         }
//     }
// }


// class Program{
//     static void Main(string[] args){
//         customnamespace.Greeting  g= new customnamespace.Greeting();
//         g.greet();

//         anotherone.Bye  b = new anotherone.Bye();
//         b.condelence();
//     }
// }

// using System.Collections.Generic;
// class Program
// {
//     public static void Main(string[] args)
//     {
//         List<string> list = new List<string>();
//         list.Add("a");
//         list.Add("b");
//         list.Add("c");
//         list.Add("d");
//         list.Remove("b");

//         foreach (string s in list)
//         {
//             Console.WriteLine(s);
//         }
//         Console.WriteLine("-----------");
//         Queue<string> queue = new Queue<string>();
//         queue.Enqueue("a");
//         queue.Enqueue("b");
//         queue.Enqueue("c");
//         queue.Dequeue();


//         foreach (string s in queue){
//             Console.WriteLine(s);
//         }

//         Console.WriteLine("-----------");

//         Stack<string> stack = new Stack<string>();
//         stack.Push("a");
//         stack.Push("b");
//         stack.Push("c");
//         stack.Push("d");

//         stack.Pop();

//         foreach (string s in stack){
//             Console.WriteLine(s);
//         }

//         Console.WriteLine("---[]-----");

//         Dictionary<int,string> dict = new Dictionary<int,string>();

//         dict.Add(1, "a");
//         dict.Add(2, "b");
//         dict.Add(3, "c");
//         dict.Add(4, "d");
//         dict.Add(5, "e");

//         foreach (var s in dict){
//             Console.WriteLine($"The key is {s.Key}, item is {s.Value}");
//         }

//         Console.WriteLine(dict.ContainsValue("z"));


//     }

// }


// class Program{
//     public static void Main(string[] args){
//         Console.WriteLine("Enter a word ( Must be less than 10 character)");
//         string word = Console.ReadLine();
//         if(word.Length > 10){
//             throw new Exception("Word should be less than 10 character");
//         }
//         Console.WriteLine($"The word is {word}");
//     }
// }


// class Program{
//     public static void Main(string[] args){
//         int a= 100;
//         int b= 0;
//         int [] arrr={1,2,3,4,5,4};
//         object word = "hello";


//         try{
//             int num = (int)word;
//             Console.WriteLine(arrr[7]);
//             int c= a/b;
//             Console.WriteLine(c);
//         }catch(DivideByZeroException ex){
//             throw new DivideByZeroException("divided by zero"+ex.Message);

//         }catch(IndexOutOfRangeException ex){
//             throw new IndexOutOfRangeException("index doesn't exist"+ ex.Message);
//         }catch(InvalidCastException ex){
//             throw new InvalidCastException("Invalid cast : "+ ex.Message);
//         }
//         finally{
//             Console.WriteLine("Finally executed");
//         }
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {

//         int[,] arr ={
//     {12,3,4},
//     {13,4,5},
//     {14,5,6}
// };

//         for (int i = 0; i < arr.GetLength(0); i++)
//         {
//             for (int j = 0; j < arr.GetLength(1); j++)
//             {
//                 Console.Write(arr[i, j]);
//             }
//             Console.WriteLine();
//         }
//     }
// }