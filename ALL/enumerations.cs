// using System;

// // Define the Department enumeration
// enum Department
// {
//     ComputerScience,
//     Mathematics,
//     Physics,
//     Biology,
//     Economics
// }

// // Define the College enumeration
// enum College
// {
//     Engineering,
//     Arts,
//     Science,
//     Commerce,
//     Medical
// }

// class Program
// {
//     // Function to display all values in the Department enumeration
//     static void DisplayDepartments()
//     {
//         Console.WriteLine("Departments:");
//         foreach (string department in Enum.GetNames(typeof(Department)))
//         {
//             Console.WriteLine($"- {department}");
//         }
//     }

//     // Function to display all values in the College enumeration
//     static void DisplayColleges()
//     {
//         Console.WriteLine("\nColleges:");
//         foreach (string college in Enum.GetNames(typeof(College)))
//         {
//             Console.WriteLine($"- {college}");
//         }
//     }

//     static void Main(string[] args)
//     {
//         // Call functions to display the enumerations
//         DisplayDepartments();
//         DisplayColleges();

//         // Example: Access specific enumeration values
//         Department myDepartment = Department.ComputerScience;
//         College myCollege = College.Engineering;

//         Console.WriteLine($"\nSelected Department: {myDepartment}");
//         Console.WriteLine($"Selected College: {myCollege}");
//     }
// }

//     enum Days{
//         sunday,
//         monday,
//         tuesday,
//         wednesday,
//         thursday,
//         friday,
//         saturday
//     }
// public class Program{
//     static void Main(string[] args){
//         foreach(string day in Enum.GetNames(typeof(Days))){
//             Console.WriteLine(day);
//         }

//     }
// }