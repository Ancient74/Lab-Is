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
    }
}