// /* Create a program in C# that maintains a collection of books in a library using a 'Queue<T>' . Each book should he the following properties:
// * Title
// * Author
// * ISBN
// Use a generic 'Queue<T>' to store the books. Implement functionality to : 
// 1. Add a new book to the collection.
// 2. Display all books in the collection.
// 3. Search for a book by titile.
// 5. Remove a book from the front of the queue.

// */

// class Books{
//     private string title;
//     private string author;
//     private string isbn;

//     public string Title{
//         get{return title;}
//         set{title=value;}
//     }

//     public string Author{
//         get{return author;}
//         set{author=value;}
//     }

//     public string ISBN{
//         get{return isbn;}
//         set{isbn=value;}
//     }
//     public Books(string title, string author, string isbn)
//     {
//         this.title = title;
//         this.author = author;
//         this.isbn = isbn;
//     }   

//     public void display(){
//         Console.WriteLine($"The book title is {title} \n The book author is {author} \n The isbn is {isbn}");
//     }
    
// }

// class Question_6{
//     public static void Main(string[] args)
//     {
//         string title = "English";
//         string author="shahi";
//         string isbn="47555";

//         Books books= new Books(title,author,isbn);
//         books.display();

//         Queue<string> titles = new Queue<string>();
//         Queue<string> authors = new Queue<string>();
//         Queue<string> isbns = new Queue<string>();

//         // for (var i = 0; i < 3; i++)
//         // {
//         // Console.WriteLine("Enter title : ");
//         // title = Console.ReadLine();
//         // Console.WriteLine("Enter author : ");
//         // author = Console.ReadLine();
//         // Console.WriteLine("Enter isbn : ");
//         // isbn = Console.ReadLine();
//         // titles.Enqueue(title);
//         // authors.Enqueue(author);
//         // isbns.Enqueue(isbn);
//         // }

//         titles.Enqueue(books.Title);
//         authors.Enqueue(books.Author);
//         isbns.Enqueue(books.ISBN);
//         foreach (string item in titles)
//         {   
//             Console.WriteLine(item);
//         }
//     }
// }