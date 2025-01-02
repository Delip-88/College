// // public class BaseClass
// // {
// //     public BaseClass()
// //     {
// //         Console.WriteLine("Base class constructor called");
// //     }

// //     public BaseClass(string message)
// //     {
// //         Console.WriteLine($"Base class constructor called with message: {message}");
// //     }
// // }

// // public class DerivedClass : BaseClass
// // {
// //     public DerivedClass() : base("Hello from DerivedClass")
// //     {
// //         Console.WriteLine("Derived class constructor called");
// //     }
// // }

// // class Program
// // {
// //     static void Main(string[] args)
// //     {
// //         DerivedClass obj = new DerivedClass();
// //     }
// // }


// class Tea{
//     public Tea(){
//         Console.WriteLine("Tea is good");
//     }
//     public Tea(string msg){
//         Console.WriteLine($"This is message: {msg}");
//     }

//     public Tea(string msg, int value){
//         Console.WriteLine($"this is {msg}:{value}");
//     }
//     public void mytea(){
//         Console.WriteLine("it's vbetter");
//     }
// }

// class Chai: Tea{
//     public Chai():base("you are good to go"){
//         Console.WriteLine("This is from chai");
//     }
//     public void CallParent(){
//     base.mytea();
//     }
// }

// class Program{
//     static void Main(string[] args){
//         // Tea tea0= new Tea();
//         // Tea tea= new Tea("this is good");
//         // Tea tea2= new Tea("this is good",12);
//         Chai chai= new Chai();
//         chai.CallParent();
//     }
// }