// //WAP to select employees whose salary is greater thatn 20000 and whose address is kathmandu using LINQ.

// using System;
// using System.Collections.Generic;
// using System.Linq;

// class Employee{
//     public string? Name {get; set;}
//     public int? Salary {get; set;}
//     public string? Address {get; set;}
// }

// class Question{
//     public static void Main(string[] args)
//     {
//         List<Employee> list = new List<Employee>{
//             new Employee{Name="Bardan Paudel",Salary = 10000, Address="Pokhara"},
//             new Employee{Name="arpit Paudel",Salary = 60000, Address="Kathmandu"},
//             new Employee{Name="Nikesh Paudel",Salary = 30000, Address="Kathmandu"},
//             new Employee{Name="Rohan barula",Salary = 10000, Address="Kathmandu"},
//             new Employee{Name="Milan Paudel",Salary = 56000, Address="Pokhara"},
//             new Employee{Name="Delip Shrestha",Salary = 100000, Address="Kathmandu"},
//         };

//         var selectedEmployee = list.Where(employee=> employee.Salary > 20000 && employee.Address == "Kathmandu").ToList();

//         Console.WriteLine("Employees with salary > 20000 and adddress is kathmandu : ");

//         foreach(var employee in selectedEmployee){
//             Console.WriteLine($"Name : {employee.Name} , Salary : {employee.Salary} , Address : {employee.Address}");
//         }

//     }
// }