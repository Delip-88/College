// /* write a class distance containing private variable feet of type int and inches of type int, suitable constructor and three mehtod addDistance , subtractDistance  and displayDistance for adding  subtracting and display distance object . Write a separate class MyDistance containing main method to create add, subtract and display object. */

// public class Distance
// {
//     private int feet;
//     private int inches;

//     public Distance(int feet, int inches){
//         this.feet = feet;
//         this.inches = inches;
//     }
    
//     public int Feet{
//         get{ return feet; }
//         set{ feet = value; }
//     }
//     public int Inches{
//         get{ return inches; }
//         set{ inches = value; }
//     }

//     public void addDistance(int value, int value2){
//         if(feet < 0){
//             Console.WriteLine("Cannot be negative");
//         }else{
//             feet += value;
//             inches += value2;
//         }
//         Console.WriteLine($"Feet = {feet} , Inches = {inches} ");
//     }

//     public void subDistance(int value, int value2){
//         if(feet < 0){
//             Console.WriteLine("Cannot be negative");
//         }else{
//             feet -= value;
//             inches -= value2;
//         }
//         Console.WriteLine($"Feet = {feet} , Inches = {inches} ");
//     }

//     public void display(){
//         Console.WriteLine($"Feet = {feet} , Inches = {inches} ");
//     }
// }

// class Program{
//     public static void Main(string[] args)
//     {
//         Distance d = new Distance(10,10);
//         d.display();
//         d.addDistance(20,10);
//         d.subDistance(3,3);
//     }
// }