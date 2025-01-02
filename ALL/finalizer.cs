// class Program
// {
//     public Program()
//     {
//         Console.WriteLine("Constructor invoked automatically");
//     }

//     ~Program()
//     {
//         Console.WriteLine("Destructor called");
//     }

//     static void Main(string[] args)
//     {
//         Program p = new Program();
//         GC.Collect(); // Forces garbage collection to run
//         GC.WaitForPendingFinalizers(); // Ensures finalizers are called before exiting
//     }
// }
