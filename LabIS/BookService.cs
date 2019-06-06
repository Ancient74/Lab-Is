using LabIS.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web;

namespace LabIS
{
    public class BookService
    {
        BooksRepository booksRepository;
        public BookService(BooksRepository booksRepository)
        {
            this.booksRepository = booksRepository;
        }

        public void CreateBook(string name, int pages)
        {
            Contract.Assert(pages > 0);

            Book book = new Book();
            book.Name = name;
            book.Pages = pages;
            this.booksRepository.Add(book);
        }

        public IEnumerable<TakeBook> GetTakeBooksFromDate(DateTime date)
        {
            return booksRepository.Context.GetTakenBooksFromDate(date).Select(x => booksRepository.Context.TakeBooks.Find(x.UserId, x.BookId));
        }

        public IEnumerable<TakeBook> GetTekenBooks()
        {
            return this.booksRepository.GetTakeBook(); 
        }


    }
}