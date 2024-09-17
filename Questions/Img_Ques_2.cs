// class Employee
// {
//     public int EmployeeID { get; set; }
//     public string Name { get; set; }
//     public int Salary { get; set; }
// }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         List<Employee> employees = new List<Employee>{
//             new Employee{EmployeeID=1, Name = "Rohan shah", Salary= 12000},
//             new Employee{EmployeeID=2, Name= "Bardan Paudel", Salary= 23000},
//             new Employee{EmployeeID= 3, Name ="Saphin rana", Salary= 20000}
//         };

//         int totalSalary = employees.Sum(employee => employee.Salary);
//         System.Console.WriteLine($"Total salary is : {totalSalary}");

//         var sortedEmployees = employees.OrderByDescending(employee => employee.Salary);
//         System.Console.WriteLine("\n Employee records in descending order of salary : ");

//         foreach (var employee in sortedEmployees)
//         {
//             System.Console.WriteLine($"EmployeeId : {employee.EmployeeID} , Name : {employee.Name} , Salary : {employee.Salary}");
//         }

//     }
// }