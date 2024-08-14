// class Exception{
//     public static void Main(string[] args)
//     {
//         try
//         {
//             int a= 0;
//             int b=20;

//             int c= b/a;
//             Console.WriteLine(c);
//         }
//         catch (SystemException e)
//         {
//             Console.WriteLine(e.Message);
//         }finally{
//             Console.WriteLine("Finally running..");
//         }
//         Console.WriteLine("rest of the program, continuing...");
//     }
// }



// class Exception{
//     public static void Main(string[] args)
//     {
//         int age =20 ;
//         if (age < 18){
//             throw new ArithmeticException("You cannot vote");
//         }else{
//             Console.WriteLine("You can vote");
//         }
//         Console.WriteLine("end of program..");
//     }
// }