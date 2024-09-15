
// Built in Delegate (Func Delegate)
// class Program{

//     static void Main(string[] args) {
//         Func<int, int, int> multiply = (x,y) => x*y;
//         int result = multiply(20,40);
//         Console.WriteLine(result);
//     }
// }

// public delegate int Sum(int x, int y);

// class Calculator{
//     public int Add(int x, int y){
//         return x+y;
//     }
// }


// class Program{
//     public static void Main(string[] args)
//     {
//         Calculator calculator = new Calculator();
//         Sum s = new Sum(calculator.Add);
        
//         int result = s(3,4);
//         Console.WriteLine(result);
//     }
// }