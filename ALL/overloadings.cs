
// Unary (1 parameter) ++ -- + -
// Binary (more than 1 parameter) + - * %
// relational (==  > < )


// unary overloading

// class Unary{
//     public int x;


//     public Unary(int a){
//         x = a;
//     }


//     public static Unary operator -(Unary U){
//         return new Unary(-U.x);
//     }

//     public static Unary operator ++(Unary U){
//         return new Unary(U.x+1);
//     }

//     static void Main(String[] args){
//         Unary u1 = new Unary(1);
//         Unary u2 = -u1;

//         Unary u3 = ++u1;

//         System.Console.WriteLine(u2.x);
//         System.Console.WriteLine(u3.x);
//     }
// }


// class Binary{
//     public int x;
//     public int y;

//     public Binary(int x, int y) {
//         this.x = x;
//         this.y = y;
//     }

//     public static Binary operator +(Binary a, Binary b){
//         return new Binary(a.x+b.x,a.y+b.y);
//     }

//     public static bool operator ==(Binary a, Binary b){
//         return a.x == b.x && a.y==b.y;
//     }

//     public static bool operator !=(Binary a, Binary b){
//         return !(a == b);
//     }

//     public static bool operator >(Binary a, Binary b){
//         return a.x>b.x && a.y>b.y;
//     }

//     public static bool operator <(Binary a, Binary b){
//         return a.x<b.x && a.y<b.y;
//     }
//     public static void Main(string[] args) {
//         Binary b1 = new Binary(2,4);
//         Binary b2 = new Binary(12,22);

//         Binary b3 = b1+b2;

//         if(b1>b2){
//             Console.WriteLine("b1 is greater");
//         }else if(b1==b2){
//             Console.WriteLine("equal");
//         }else{
//             Console.WriteLine("b2 is greater");
//         }

//         // Console.WriteLine($"a= {b3.x} , b= {b3.y}");
//     }

// }



// using System.Security.Cryptography;

// class Time{
//     public int Hour;
//     public int Minute;
//     public int Second;

//     public Time(int hour, int minute, int second){
//         Hour = hour;
//         Minute = minute;
//         Second = second;
//     }

//     public static Time operator +(Time t1, Time t2){
//         int totalseconds = t1.Second +t2.Second;
//         int totalMinutes = t1.Minute + t2.Minute + totalseconds/60;
//         int totalHours = (t1.Hour + t2.Hour + totalMinutes /60)%24;
//         return new Time(totalHours,totalMinutes%60,totalseconds%60);
//     }
    
//     public static bool operator >(Time t1, Time t2){
//         return (t1.Hour*3600+t1.Minute*60+t1.Second)>(t2.Hour*3600+t2.Minute*60+t2.Second);
//     }

//     public static bool operator <(Time t1, Time t2){
//         return (t1.Hour*3600+t1.Minute*60+t1.Second)<(t2.Hour*3600+t2.Minute*60+t2.Second);
//     }
// }

// class Program{
//     static void Main(string[] args){
//         Time t1 = new Time(14,36,4);
//         Time t2 = new Time(12,32,8);

//         Time t3 = t1+t2;

//         Console.WriteLine($"The added time is : {t3.Hour} : {t3.Minute} : {t3.Second}");

//         if(t1>t2){
//             Console.WriteLine("Time one is Greater");
//         }else{
//             Console.WriteLine("Time two is Greater");
//         }
        
//     }
// }