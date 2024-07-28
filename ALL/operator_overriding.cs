// class Program{
//     private int x;
//     private int y;

//     public Program(int x, int y) {
//         this.x = x;
//         this.y = y;
//     }

//     // Operator Overriding
//     public static Program operator + (Program p1, Program p2) {
//         return new Program (p1.x+p2.x, p1.y+p2.y); 
//     }

//     void showData(){
//         Console.WriteLine($"The value of x is {x} & the value of y is {y}");
//     }


//     public static void Main(string[] args)
//     {
//         Program p1 = new Program( 1, 1 );
//         Program p2 = new Program ( 2, 2 );

//         Program p3 = p1+p2;
//         p3.showData();
//     }
// }