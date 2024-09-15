// // WAP to select student who lived in Hetauda and study in Hetauda city college using Linq.

// class Student{
//     public string? name{get; set;}
//     public string? address{get; set;}
//     public string? college{get; set;}
// }

// class Question_12{
//     public static void Main(string[] args)
//     {
//         List<Student> students = new List<Student>{
//             new Student{name="rohan",address="kathmandu" , college="hetauda city college"},
//             new Student{name="Swastik",address="hetauda",college="hetauda city college"},
//             new Student{name="milan gaupalika",address="kathmandu",college="janapriya"},
//             new Student{name="bicky", address="pokhara",college="hetauda city college"},
//             new Student{name="salman", address="hetauda",college="hetauda city college"}
//         };

//         var selectedStudents= students.Where(student=> student.address == "hetauda" && student.college == "hetauda city college").ToList();
        
//         Console.WriteLine("Students who live in hetauda and study in hetauda city college are : ");
//         foreach(var student in selectedStudents){
//             Console.WriteLine($"Name : {student.name} , Address : student.address , College : {student.college}");
//         }
//     }
// }