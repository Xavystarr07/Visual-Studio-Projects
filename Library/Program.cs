using System;
using System.Collections.Generic;

// Class to represent a Book
public class Book
{
	// Properties of a Book
	public string Title { get; set; }
	public string Author { get; set; }
	public bool IsAvailable { get; set; }

	// Constructor to initialize a Book
	public Book(string title, string author)
	{
		Title = title;
		Author = author;
		IsAvailable = true; // By default, a new book is available
	}

	// Method to display book details
	public void DisplayBookDetails()
	{
		string availability = IsAvailable ? "Available" : "Not Available";
		Console.WriteLine($"Title: {Title}, Author: {Author}, Status: {availability}");
	}
}

// Class to represent a Library Member
public class Member
{
	// Properties of a Member
	public string Name { get; set; }
	public int StudNumber { get; set; }

	// Constructor to initialize a Member
	public Member(string name, int studNumber)
	{
		Name = name;
		StudNumber = studNumber;
	}

	// Method to display member details
	public void DisplayMemberDetails()
	{
		Console.WriteLine($"Member Name: {Name}, Student Number: {StudNumber}");
	}
}

// Class to manage the Library
public class Library
{
	// Collections to store books and members
	private List<Book> books;
	private List<Member> members;

	// Constructor to initialize the Library
	public Library()
	{
		books = new List<Book>();
		members = new List<Member>();
	}

	// Method to add a new book to the library
	public void AddBook(Book book)
	{
		books.Add(book);
		Console.WriteLine($"Book '{book.Title}' by {book.Author} added to the library.");
	}

	// Method to add a new member to the library
	public void AddMember(Member member)
	{
		members.Add(member);
		Console.WriteLine($"Member '{member.Name}' added to the library.");
	}

	// Method for a member to borrow a book
	public void BorrowBook(int studNumber, string bookTitle)
	{
		// Check if member exists
		Member member = members.Find(m => m.StudNumber == studNumber);
		if (member == null)
		{
			Console.WriteLine("Member not found.");
			return;
		}

		// Check if the book exists and is available
		Book book = books.Find(b => b.Title == bookTitle);
		if (book == null)
		{
			Console.WriteLine("Book not found.");
			return;
		}

		if (!book.IsAvailable)
		{
			Console.WriteLine($"Sorry, the book '{book.Title}' is already borrowed.");
			return;
		}

		// Borrow the book
		book.IsAvailable = false;
		Console.WriteLine($"{member.Name} has borrowed the book '{book.Title}'.");
	}

	// Method for a member to return a book
	public void ReturnBook(int studNumber, string bookTitle)
	{
		// Check if member exists
		Member member = members.Find(m => m.StudNumber == studNumber);
		if (member == null)
		{
			Console.WriteLine("Member not found.");
			return;
		}

		// Check if the book exists
		Book book = books.Find(b => b.Title == bookTitle);
		if (book == null)
		{
			Console.WriteLine("Book not found.");
			return;
		}

		if (book.IsAvailable)
		{
			Console.WriteLine($"The book '{book.Title}' is already in the library.");
			return;
		}

		// Return the book
		book.IsAvailable = true;
		Console.WriteLine($"{member.Name} has returned the book '{book.Title}'.");
	}

	// Method to display all books in the library
	public void DisplayAllBooks()
	{
		Console.WriteLine("Library Books:");
		foreach (var book in books)
		{
			book.DisplayBookDetails();
		}
	}

	// Method to display all members in the library
	public void DisplayAllMembers()
	{
		Console.WriteLine("Library Members:");
		foreach (var member in members)
		{
			member.DisplayMemberDetails();
		}
	}
}

// Main class to test the Library Management System
public class Program
{
	public static void Main(string[] args)
	{
		// Create the Library
		Library library = new Library();

		// Create and add books to the library
		Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
		Book book2 = new Book("1984", "George Orwell");
		Book book3 = new Book("To Kill a Mockingbird", "Harper Lee");
		library.AddBook(book1);
		library.AddBook(book2);
		library.AddBook(book3);

		// Create and add members to the library
		Member member1 = new Member("Alice Johnson", 101);
		Member member2 = new Member("Bob Smith", 102);
		library.AddMember(member1);
		library.AddMember(member2);

		// Display all books
		library.DisplayAllBooks();

		// Display all members
		library.DisplayAllMembers();

		// Simulate borrowing a book
		library.BorrowBook(101, "1984");

		// Try borrowing the same book again (should show not available)
		library.BorrowBook(102, "1984");

		// Return the borrowed book
		library.ReturnBook(101, "1984");

		// Try returning the book again (should show already in library)
		library.ReturnBook(101, "1984");

		// Borrow a book that does not exist (should show book not found)
		library.BorrowBook(102, "A Book That Doesn't Exist");
	}
}
