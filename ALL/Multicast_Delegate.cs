// public delegate int mathDelegate(int x, int y);

// class Calculator{
//     public int sum(int x, int y){
//         return x + y;
//     }
//     public int dif(int x, int y){
//         return x-y;
//     }
// }


// public class Multicase_Delegates{
//     public static void Main(string[] args){

//         Calculator c = new Calculator();

//         mathDelegate del = c.sum;
        
//         del += c.sum;
//         int res2 = del(4,4);

//         Console.WriteLine("Result is " + res2);

//     }
// }