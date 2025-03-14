using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Business.Interfaces;
using BookHaven.Data.Models;
using BookHaven.Data.Repositories;
using BookHaven.Data.Repositories.BookManagementRepository;

namespace BookHaven.Business.Services
{
    public class BookManagementService : IBookManagementService
    {
        private readonly IBookRepository _bookRepository;

        public BookManagementService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public Book AddBook(Book book)
        {
            return _bookRepository.AddBook(book);
        }
        public List<Book> GetAllBooks(string searchterm)
        {
            return _bookRepository.GetAllBooks(searchterm);
        }
        public bool EditBook(Book book)
        {
            return _bookRepository.EditBook(book);
        }
        public bool DeleteBook(int bookId)
        {
            return _bookRepository.DeleteBook(bookId);
        }
    }
}
