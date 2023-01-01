using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book
            {
                Author = "Orhan Pamuk",
                Isbn = "123456",
                Title = "Snow"
            };

            book.ShowBook();
            // create history and put the last changes to its memory
            CareTaker history = new CareTaker();
            history.Memento = book.CreateUndo();

            // change the book
            Thread.Sleep(2000);
            book.Author = "Elif Shafak";
            book.ShowBook();

            // undo the changes
            book.RestoreFromUndo(history.Memento);
            book.ShowBook();

            Console.ReadLine();
        }
    }

    class Book
    {
        private string _title;
        private string _author;
        private string _isbn;
        private DateTime _lastEditedTime;

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                SetLastEdited();

            }
        }

        public string Author
        {
            get => _author;
            set
            {
                _author = value;
                SetLastEdited();
            }
        }

        public string Isbn
        {
            get => _isbn;
            set
            {
                _isbn = value;
                SetLastEdited();
            }
        }

        private void SetLastEdited()
        {
            _lastEditedTime = DateTime.UtcNow;
        }

        // Create a memory
        public Memento CreateUndo()
        {
            return new Memento(_isbn, _title, _author, _lastEditedTime);
        }
        // Restore From Memory
        public void RestoreFromUndo(Memento memento)
        {
            _isbn = memento.Isbn;
            _title = memento.Title;
            _author = memento.Author;
            _lastEditedTime = memento.LastEditedTime;
        }
        // Show class info
        public void ShowBook()
        {
            Console.WriteLine("Isbn: {0}, Title: {1}, Author: {2}, Last edited time: {3}", Isbn, Title, Author, _lastEditedTime);
        }
    }

    // Memory class just like custom Book class
    class Memento
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime LastEditedTime { get; set; }

        public Memento(string isbn, string title, string author, DateTime lastEditedTime)
        {
            Isbn = isbn;
            Title = title;
            Author = author;
            LastEditedTime = lastEditedTime;
        }
    }

    // Memory Holder
    class CareTaker
    {
        public Memento Memento { get; set; }
    }
}
