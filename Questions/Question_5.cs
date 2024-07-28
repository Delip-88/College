// // What are different type of delegate in C# ? Write a C# program to create a class Time Which represents time. 
// // The class should have three fields for hours, minutes and seconds. It should have constructor to initialize hours , minutes and seconds and  method displayTime() to print current time. Overload follwing operators. [4+3+3]
// //a) +(add two time objects on 24 hours clock)
// // b) < (compare two time objects)

// class Time{
//     private int hours;
//     private int minutes;
//     private int seconds;

//     public Time(int hours, int minutes, int seconds) {
//         this.hours = hours;
//         this.minutes = minutes;
//         this.seconds = seconds;
//     }

//     public int Hours{
//         get { return hours; }
//     }

//     public int Minutes{
//         get { return minutes; }
//     }

//     public int Seconds{
//         get { return seconds; }
//     }

//     public void displayTime(){
//         Console.WriteLine($"{hours}:{minutes}:{seconds}");
//     }

//     public static Time operator +(Time a, Time b){
//         return new Time(a.hours+b.hours, a.minutes+b.minutes,a.seconds+b.seconds);
//     }

//     public static bool operator >(Time a, Time b){
//         return a.hours > b.hours;
//     }
//     public static bool operator <(Time a, Time b){
//         return a.hours < b.hours;
//     }
// }

// class Demo{
//     public static void Main(string[] args)
//     {
//         Time t1 = new(1,2,3);
//         Time t2 = new(5,2,3);

//         Time t3 = t1+t2;

//         t3.displayTime();

//         if (t1 > t2){
//             Console.WriteLine("t1 is greater");
//         }else{
//             Console.WriteLine("t2 is greater");
//         }
//     }
// }