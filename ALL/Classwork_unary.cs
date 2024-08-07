//Write a program to Overload unary operator / binary operator / relational operator

// class Unary{
//     private int x;
//     private int y;
//     public Unary(int x, int y) {
//         this.x = x;
//         this.y = y;
//     }

//     public static Unary operator +(Unary x, Unary y){
//         return new Unary(x.x+y.x, x.y+y.y);
//     }

//     public void show(){
//         Console.WriteLine($"The Value of x is {x} and y is {y}");
//     }
//     public static void Main(string[] args)
//     {
//         Unary val1 =new Unary(1, 2);
//         Unary val2 =new Unary(2,5);
//         Unary val3 =val1+val2;
//         val3.show();
//     }
// }

// class Binary{
//     private int x;
//     private int y;
//     public Binary(int x, int y){
//         this.x = x;
//         this.y = y;
//     }

//     public static bool operator ==(Binary left, Binary right){
//         return left.x == right.x && left.y == right.y;
//     }
    
//     public static bool operator !=(Binary left, Binary right){
//         return left.x == right.x && left.y == right.y;
//     }
    

//     public static void Main(string[] args)
//     {
//         Binary b1 = new Binary(5,6);
//         Binary b2 = new Binary(5,7);

//         if(b1 == b2){
//             Console.WriteLine("It is equal");
//         }else{
//             Console.WriteLine("Not Equal");
//         }
//     }
// }

//Realtional Operator

// class Relational
// {
//     private int x;

//     public Relational(int x)
//     {
//         this.x = x;
//     }

//     public static bool operator >(Relational a, Relational b)
//     {
//         return a.x > b.x;
//     }
//     public static bool operator<(Relational a, Relational b)
//     {
//         return a.x< b.x;
//     }

//     public static void Main(string[] args)
//     {
//         Relational r1 = new Relational(6);
//         Relational r2 = new Relational(8);

//         if (r1 > r2)
//         {
//             Console.WriteLine("First is greater");
//         }
//         else if (r1 == r2)
//         {
//             Console.WriteLine("They are equal");
//         }
//         else
//         {
//             Console.WriteLine("Second is greater.");
//         }
//     }
// }
