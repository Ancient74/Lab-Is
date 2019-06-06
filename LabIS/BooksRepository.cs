using LabIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabIS
{
    public class BooksRepository : IRepository<Book>
    {
        BooksEntities context = new BooksEntities();

        public BooksEntities Context => context;

        public void Add(Book data)
        {
            context.Books.Add(data);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Books.Remove(context.Books.Find(id));
            context.SaveChanges();
        }

        public IEnumerable<TakeBook> GetTakeBook()
        {
            return this.context.TakeBooks;
        }


        public Book Read(int id)
        {
            return context.Books.Find(id);
        }

        public IEnumerable<Book> ReadAll()
        {
            return context.Books;
        }

        public void Update(int id, Book data)
        {
            var book = context.Books.Find(id);
            if(book != null)
            {
                book.Name = data.Name;
                book.Pages = data.Pages;
                context.SaveChanges();
            }

        }
    }
}