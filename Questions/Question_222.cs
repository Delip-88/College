// //Write a program to overload unary operator , binary operator , relational operator.


// class Program{
//     private int x;
//     private int y;

//     public Program(int x, int y) {
//         this.x = x;
//         this.y = y;
//     }


//     //binary pulus(+) operator
//     public static Program operator +(Program A,Program B){
//         return new Program(A.x+B.x, A.y+B.y);
//     }
//     //Unary Operator
//     public static Program operator -(Program A){
//         return new Program(-A.x, -A.y);
//     }

//     // relational operator
//     public static bool operator ==(Program A,Program B){
//         return A.x == B.x && A.y == B.y;
//     }
//     // relational operator
//     public static bool operator !=(Program A,Program B){
//         // return A.x != B.x && A.y != B.y;
//         return !(A==B);
//     }

//     //show data
//     public void showData(){
//         System.Console.WriteLine($"The value of x is {x} and the value of y is {y}");
//     }

// }
// class Question_222{
//     public static void Main(string[] args)
//     {
//         Program p1 = new Program(2,5);
//         Program p2 = new Program(2,5);

//         Program p3 = p1+p2;

//         p3.showData();

//         Program p4= -p1;
//         p4.showData();

//         if(p1==p2){
//             Console.WriteLine("They are equal");
//         }else{
//             System.Console.WriteLine("They are not equal");
//         }
//     }
// }