// // using System;

// // class Account
// // {
// //     private int _balance; // Private backing field

// //     public int Balance
// //     {
// //         get { return _balance; }
// //         set
// //         {
// //             if (value < 0)
// //             {
// //                 throw new Exception("Amountt cannot be negative");
// //             }
// //             else
// //             {
// //                 _balance = value;
// //             }
// //         }
// //     }

// //     public Account(int balance)
// //     {
// //         if (balance < 0)
// //         {
// //             throw new Exception("Initial balance cannot be negative");
// //         }
// //         _balance = balance;
// //     }

// //     public void Deposit(int amount)
// //     {
// //         if (amount < 0)
// //         {
// //             throw new Exception("Deposit amount cannot be negative");
// //         }
// //         else
// //         {
// //             _balance += amount;
// //             Console.WriteLine($"You deposited Rs {amount}. Your new balance is Rs {_balance}.");
// //         }
// //     }

// //     public void Withdraw(int amount)
// //     {
// //         if (amount > _balance)
// //         {
// //             throw new Exception("Not sufficient balance");
// //         }
// //         else
// //         {
// //             _balance -= amount;
// //             Console.WriteLine($"You withdrew Rs {amount}. Your new balance is Rs {_balance}.");
// //         }
// //     }

// //     public void ShowBalance()
// //     {
// //         Console.WriteLine($"Your balance is Rs {_balance}");
// //     }
// // }

// // class Program
// // {
// //     static void Main(string[] args)
// //     {
// //         try
// //         {
// //             Account account = new Account(1000); // Initialize with Rs 1000
// //             account.ShowBalance();

// //             account.Balance = -5;

// //             account.Deposit(500);   // Deposit Rs 500
// //             account.Withdraw(300);  // Withdraw Rs 300
// //             account.Withdraw(1500); // Attempt to withdraw more than balance (will throw an exception)
// //         }
// //         catch (Exception ex)
// //         {
// //             Console.WriteLine($"Error: {ex.Message}");
// //         }
// //     }
// // }


// public delegate  void notifications(string Message);

// class Program{
//     public static void sms(string Message){
//         Console.WriteLine($"In Sim : {Message}");
//     }
//     public static void email(string Message){
//         Console.WriteLine($"in Email : {Message}");
//     }
//     public static void gmail(string Message){
//         Console.WriteLine($"in Gmail : {Message}");
//     }
//     static void Main(string[] args){
//         notifications notify = new notifications(sms);
//         notify +=email;
//         notify +=gmail;
//         notify("ROhan you are under attack");

//         Func<int,int,int,int> volume = (length , breadth, height)=>length*breadth*height;
//         Console.WriteLine(volume(12,4,4));
        
//         Func<string> msg=()=>"Hellow";
//         Console.WriteLine(msg());
        

//         Action<int> action= (number)=>Console.WriteLine($"the number is {number}");
//         action(123);

//         Predicate<int> divby5 = (num)=> num%5==0;
//         Console.WriteLine(divby5(23));
        
//     }
// }