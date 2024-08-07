// using System;
// using System.Collections.Generic; // Necessary for Stack, Queue, List, Dictionary

// // Rename your classes to avoid conflicts with built-in types
// class MyStack {
//     public void Display() {
//         Stack<int> stack = new Stack<int>();
//         stack.Push(1);
//         stack.Push(2);
//         stack.Push(3);
//         stack.Push(4);

//         foreach (var item in stack) {
//             Console.WriteLine(item);
//         }
//     }
// }

// class MyQueue {
//     public void Display() {
//         Queue<int> queue = new Queue<int>();
//         queue.Enqueue(1);
//         queue.Enqueue(2);
//         queue.Enqueue(3);
//         queue.Enqueue(4);
//         queue.Enqueue(5);

//         foreach (var item in queue) {
//             Console.WriteLine(item);
//         }
//     }
// }

// class MyList {
//     public void Display() {
//         List<string> strings = new List<string>();
//         strings.Add("Hello");
//         strings.Add("Namaste");
//         strings.Add("Konnichiwa");

//         foreach (var item in strings) {
//             Console.WriteLine(item);
//         }
//     }
// }

// class MyDictionary {
//     public void Display(int key) {
//         Dictionary<int, string> dictionary = new Dictionary<int, string>();
//         dictionary.Add(1, "item1");
//         dictionary.Add(2, "item2");
//         dictionary.Add(3, "item3");

//         if (dictionary.TryGetValue(key, out string value)) {
//             Console.WriteLine(value);
//         } else {
//             Console.WriteLine("Key not found.");
//         }
//     }
// }

// class Program {
//     public static void Main(string[] args) {
//         // Uncomment the sections you want to test

//         // MyStack stack = new MyStack();
//         // stack.Display();

//         // MyQueue queue = new MyQueue();
//         // queue.Display();

//         // MyList list = new MyList();
//         // list.Display();

//         MyDictionary dict = new MyDictionary();
//         dict.Display(1); // Test with a valid key
//         dict.Display(4); // Test with an invalid key
//     }
// }
