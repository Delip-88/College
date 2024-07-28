// /* write a program in c# that performs the following operations using a 'Dictionary' 
// 1. Add key value pairs to the dictionary
// 2. Remove a key-value pair from the dictionary.
// 3. Retrieve and display a value based on a key.
// 4. Display all key-value pairs in the dictionary
// */

// using System.ComponentModel;

// class Question_777{
//     public static void Main(string[] args)
//     {


//         Dictionary<int,string> dict = new Dictionary<int,string>();

//         bool run = true;
//         int key ;
//         string value ;
//         string opt;
//         Console.WriteLine("1. To Add \n2. To delete \n3. To Display based on key4.To display All \n:");
//         opt = Console.ReadLine();
        
//         switch (opt)
//         {
//             case 1:
//             add();
//             default:
//         }

//         while (run){
//             Console.WriteLine("Enter the key : ");
//             key = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Enter the Value : ");
//             value = Console.ReadLine();
//             dict.Add(key, value);

//             string ans;
//             Console.WriteLine("Continue y/n");
//             ans = Console.ReadLine().ToLower();
//             if (ans == "y"){
//                 continue;
//             }
//             else if (ans == "n"){
//                 run = false;
//             }
//         }
//     }
// }