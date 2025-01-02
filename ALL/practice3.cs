// using System;

// class Program
// {
//     static void ByValue(int x)
//     {
//         x = 100;
//     }
//     static void Byref(ref int x)
//     {
//         x = 100;
//     }
//     static void Main(string[] args)
//     {
//         int orginal = 20;
//         Console.WriteLine($"Orginal nubmer : {orginal}");//20
//         ByValue(orginal);
//         Console.WriteLine($"Orginal nubmer after pass by value : {orginal}"); // 20
//         Byref(ref orginal);
//         Console.WriteLine($"Orginal nubmer after pass by reference : {orginal}"); // 100
//     }
// }


// using System.Collections.Generic;
// using System.Linq;
// class Employee{
//     public string Name;
//     public int Salary;

//     public Employee(string Name, int Salary) { 
//         this.Name = Name;
//         this.Salary = Salary;
//     }

// }

// class Program{
//     static void Main(string[] args){
//         List<Employee> employees = new List<Employee>{
//             new Employee("Ram", 12000),
//             new Employee("Haru", 22000),
//             new Employee("swastik", 3000),
//             new Employee("Sandesh", 23000),
//         };

//         int aggregateSalary = employees.Sum(e=>e.Salary);

//         // var sortedList = employees.OrderByDescending(e=>e.Salary).ToList(); 

//         var sortedList = from emp in employees orderby emp.Salary descending select emp;

//         Console.WriteLine($"Aggregate Salary : {aggregateSalary}");
//         Console.WriteLine("EMployyees in descending order based on Salary");
        
//         foreach(var emp in sortedList){
//             Console.WriteLine($"Name : {emp.Name}, Salary : {emp.Salary}");
//         }
//     }
// }