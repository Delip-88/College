// using System;

// class BankAccount {
//     private int account_no;
//     private float balance;

//     public int Account_no{
//         get{return account_no;}
//         set{account_no = value;}
//     }

//     public float Balance{
//         get{return balance;}
//         set{
//             if (value<0){
//                 Console.WriteLine("Balance Cannot be negative");
//             }else{
//                 balance = value;
//             }
//         }
//     }
//     public BankAccount (int account_no, float balance){
//         this.account_no=account_no;
//         Balance = balance;
//     }

//     public void Deposit(int amount){
//         if (amount<0){
//             Console.WriteLine("Please enter a positive amount");
//         }else{
//             Balance += amount;
//             Console.WriteLine($"The Deposited amount is {amount} and Your new Balance is {Balance}");
//         }
//     }
    
//     public void Withdraw(int amount){
//         if (amount<0){
//             Console.WriteLine("Enter a Positive amount");

//         }else{
//             if (Balance>=amount){
//                 Balance -= amount;
//                 Console.WriteLine($"You Withdrawn amount is {amount} and Your new balance is {Balance}");
//             }else{
//                 Console.WriteLine("Insufficient Balance.");
//             }
//         }

//     }

//     public void DisplayAccountInfo(){
//         Console.WriteLine($"Your Account No is {Account_no} \n Your Balance is {Balance}");
//     }
// }

// public class Program{
//     public static void Main(string[] args)
//     {
//         BankAccount b = new BankAccount(11111,1500);
//         b.DisplayAccountInfo();
//         // b.Withdraw(700);
//         b.Deposit(-5000);
//         // b.Withdraw(7000);
//     }
// }