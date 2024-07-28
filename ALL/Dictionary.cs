// class Dictionary{
//     public static void Main(string[] args)
//     {
//         Dictionary<int,string> dic = new Dictionary<int,string>();
//         dic.Add(1,"Shahi");
//         dic.Add(2,"Rohan");
//         dic.Add(5,"2001");

//         foreach (var item in dic)
//         {
//             Console.WriteLine($"The key is {item.Key} & value is {item.Value}");
//         }

//         dic.Remove(1);
//         Console.WriteLine("________________");
//         foreach (var item in dic)
//         {
//             Console.WriteLine($"The key is {item.Key} & value is {item.Value}");
//         }

//         if(dic.ContainsKey(1)){
//             Console.WriteLine("present..");
//         }else{
//             Console.WriteLine("Absent");
//         }
//     }
// }