// using System;
// using System.Collections.Generic;
// using System.Linq;

// class Employee
// {
//     public string Name { get; set; }
//     public string Address { get; set; }
//     public double Salary { get; set; }

//     public Employee(string Name, string Address, double Salary)
//     {
//         this.Name = Name;
//         this.Address = Address;
//         this.Salary = Salary;
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         List<Employee> employees = new List<Employee>
// {
//     new Employee("Ram Shrestha", "Hetauda", 234242),
//     new Employee("Rohan Karki", "Kathmandu", 120000),
//     new Employee("Sita", "Kathmandu", 12000),
//     new Employee("Milan Gopali", "Hetauda", 130000),
//     new Employee("Kritika Sharma", "Pokhara", 45000),
//     new Employee("Ashok Rai", "Biratnagar", 30000),
//     new Employee("Kiran Maharjan", "Lalitpur", 60000),
//     new Employee("Bibek Lama", "Bhaktapur", 35000),
//     new Employee("Nisha Gurung", "Dharan", 40000),
//     new Employee("Pratik Shrestha", "Hetauda", 55000),
//     new Employee("Ritika Thapa", "Chitwan", 25000),
//     new Employee("Manish Khatri", "Pokhara", 70000),
//     new Employee("Suman Ghimire", "Kathmandu", 110000),
//     new Employee("Bishnu Bhattarai", "Hetauda", 20000),
//     new Employee("Sarita Tamang", "Hetauda", 50000),
//     new Employee("Alisha Rai", "Kathmandu", 80000),
//     new Employee("Bikash Poudel", "Butwal", 35000),
//     new Employee("Anita Shrestha", "Pokhara", 65000),
//     new Employee("Sudip Khadka", "Kathmandu", 45000),
//     new Employee("Pramila Singh", "Janakpur", 25000),
//     new Employee("Kushal Shrestha", "Itahari", 30000)
// };


//         // Use Where instead of Select
//         var selectedEmployee = employees
//             .Where(emp => emp.Address == "Kathmandu" && emp.Salary > 20000)
//             .ToList();

//         Console.WriteLine("Employees with Address 'Kathmandu' and Salary > 20000 are as follows:");
//         foreach (var emp in selectedEmployee)
//         {
//             Console.WriteLine($"Name = {emp.Name}, Salary = {emp.Salary}");
//         }
//     }
// }


// class Employee
// {
//     public string Name { get; set; }
//     public int Age { get; set; }
//     public string Department { get; set; }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         List<Employee> employees = new List<Employee>
//         {
//             new Employee { Name = "John", Age = 25, Department = "HR" },
//             new Employee { Name = "Alice", Age = 30, Department = "IT" },
//             new Employee { Name = "Bob", Age = 35, Department = "Finance" },
//             new Employee { Name = "Charlie", Age = 28, Department = "IT" }
//         };

//         // Query IT department employees
//         // var itEmployees = employees.Where(emp => emp.Department == "IT").ToList();

//         var itEmployees = from emp in employees where emp.Department == "IT" select emp;

//         Console.WriteLine("IT Employees:");
//         foreach (var emp in itEmployees)
//         {
//             Console.WriteLine($"Name: {emp.Name}, Age: {emp.Age}");
//         }

//         List<int> numbers = new List<int> {1,2,44,12,23,4,1,12,1341,2,14,23 };

//         // var sortedlist = numbers.OrderBy(num=>num);
//         var sortedlist = numbers.OrderByDescending(num=>num);

//         foreach(var num in sortedlist){
//             Console.WriteLine(num);
//         }

//          List<string> names = new List<string>
//         {
//             "John Smith",
//             "Emily Davis",
//             "Michael Brown",
//             "Sophia Wilson",
//             "James Johnson",
//             "Olivia Martinez",
//             "William Anderson",
//             "Emma Thomas",
//             "Henry Jackson",
//             "Isabella Garcia"
//         };

//         var sortednames = names.OrderBy(name=>name).Where(name=>name.Length > 10);

//         Console.WriteLine("Dummy list of names:");
//         foreach (var name in sortednames)
//         {
//             Console.WriteLine(name);
//         }
//     }

// }


// using System;
// using System.Collections.Generic;
// using System.Linq;
// class Employee
// {
//     public string Name { get; set; }
//     public string Address { get; set; }
//     public int Salary { get; set; }

//     public Employee(string name, string address, int salary)
//     {
//         Name = name;
//         Address = address;
//         Salary = salary;
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         List<Employee> employees = new List<Employee>{
//             new Employee("Sande","Kathmandu",12000),
//             new Employee("sandesha","Hetauda",10000),
//             new Employee("Rohan", "Kathmandu",40000),
//             new Employee("JohnCena","Kathmandu",120000),
//             new Employee("orton","Kathmandu",100000),
//             new Employee("undertaker","Kathmandu",400000),
//             new Employee("undertaker","a",400000),
//             new Employee("undertaker","b",400000),
//             new Employee("undertaker","c",400000),
//             new Employee("undertaker","d",400000),
//         };


//         int aggregatesalary = employees.Sum(emp=>emp.Salary);
//         int salaryyyyy= (from emp in employees select emp.Salary).Sum();
//         System.Console.WriteLine($"agg salary : {aggregatesalary}");
        

//         //Method Syntax of Linq 
//         var selectedEmployee= employees.Where(emp=>emp.Address == "Kathmandu" && emp.Salary > 20000).OrderByDescending(emp=>emp.Salary).ToList();

//         //Query syntax of Linq
//         // var selectedEmployee = from emp in employees where emp.Salary ==400000 orderby emp.Address descending select emp;

//         foreach (var emp in selectedEmployee)
//         {
//             Console.WriteLine($"Name = {emp.Name},address={emp.Address} , Salary = {emp.Salary} ");
//         }
//     }
// }


