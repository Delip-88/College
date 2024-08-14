// using System;

// class Balance
// {
//     private int amount;

//     public Balance(int amount)
//     {
//         this.amount = amount;
//     }

//     public void ShowBalance()
//     {
//         Console.WriteLine($"Your current balance is {amount}");
//     }

//     public void Withdraw(int value)
//     {
//         if (amount < value)
//         {
//             Console.WriteLine("Insufficient balance");
//         }
//         else
//         {
//             amount -= value;
//             Console.WriteLine($"You withdrew: {value}");
//             Console.WriteLine($"Your new balance is {amount}");
//         }
//     }

//     public void AddBalance(int value)
//     {
//         amount += value;
//         Console.WriteLine($"You added: {value}");
//         Console.WriteLine($"Your new balance is {amount}");
//     }
// }

// class Question
// {
//     public static void Main(string[] args)
//     {
//         Balance b = new Balance(100);
//         bool running = true;

//         Console.WriteLine("Starting");
//         while (running)
//         {
//             Console.WriteLine("_______________________");
//             Console.WriteLine("\n1. View Balance \n2. Add Amount \n3. Withdraw Amount \n4. Exit");
//             int ans = Convert.ToInt32(Console.ReadLine());
//             int amt = 0;

//             switch (ans)
//             {
//                 case 1:
//                     b.ShowBalance();
//                     break;

//                 case 2:
//                     Console.WriteLine("Enter amount: ");
//                     amt = Convert.ToInt32(Console.ReadLine());
//                     if (amt <= 0)
//                     {
//                         Console.WriteLine("Enter a valid amount");
//                     }
//                     else
//                     {
//                         b.AddBalance(amt);
//                     }
//                     break;

//                 case 3:
//                     Console.WriteLine("Enter amount: ");
//                     amt = Convert.ToInt32(Console.ReadLine());
//                     if (amt <= 0)
//                     {
//                         Console.WriteLine("Enter a valid amount");
//                     }
//                     else
//                     {
//                         b.Withdraw(amt);
//                     }
//                     break;

//                 case 4:
//                     running = false;
//                     break;

//                 default:
//                     Console.WriteLine("Enter a valid input");
//                     break;
//             }
//         }
//     }
// }
