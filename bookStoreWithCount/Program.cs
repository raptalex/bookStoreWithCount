// Alexander Raptis, Feb 6th 2023

using System;

namespace bookStore
{
    class myStore
    {
        static void Main(string[] args)
        {
            book book1 = new book();
            book1.SetTrans();
            book1.SetId(1852);
            book1.SetAuthor("George Orwell");
            book1.SetTitle("Nineteen Eighty-Four");

            book book2 = new book();
            book2.SetTrans();
            Console.WriteLine("Please enter the book's ID:");
            book2.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the book's author:");
            book2.SetAuthor(Console.ReadLine());
            Console.WriteLine("Please enter the book's title:");
            book2.SetTitle(Console.ReadLine());

            book book3 = new book(5814, "The BFG", "Roald Dahl");
            book3.SetTrans();

            Console.WriteLine("Please enter the book's ID:");
            int tempId = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the book's author:");
            string tempAuthor = Console.ReadLine();
            Console.WriteLine("Please enter the book's title:");
            string tempTitle = Console.ReadLine();

            book book4 = new book(tempId, tempAuthor, tempTitle);
            book3.SetTrans();

            Console.WriteLine($"There are {book1.GetTrans()} books ordered.");
            displayMembers(book1);
            displayMembers(book2);
            displayMembers(book3);
            displayMembers(book4);
        }

        static void displayMembers(book member)
        {
            Console.WriteLine("Here is your book information:");
            Console.WriteLine($"Book ID: {member.GetId()}");
            Console.WriteLine($"Book Title: {member.GetTitle()}");
            Console.WriteLine($"Book Author: {member.GetAuthor()}");
        }
    }

    class book
    {
        private int _Id;
        private string _Title;
        private string _Author;
        private static int _transactions = 0;
        public book()
        {
            _Id = 0;
            _Title = "none";
            _Author = "none";
        }
        public book(int newId, string newTitle, string newAuthor)
        {
            _Id = newId;
            _Title = newTitle;
            _Author = newAuthor;
        }
        public void SetId(int newId)
        {
            _Id = newId;
        }
        public void SetTitle(string newTitle)
        {
            _Title = newTitle;
        }
        public void SetAuthor(string newAuthor)
        {
            _Author = newAuthor;
        }
        public int GetId()
        {
            return _Id;
        }
        public string GetTitle()
        {
            return _Title;
        }
        public string GetAuthor()
        {
            return _Author;
        }
        public int GetTrans()
        {
            return _transactions;
        }
        public void SetTrans()
        {
            _transactions += 1;
        }
    }
}