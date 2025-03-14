using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.Models;

namespace BookHaven.Business.Interfaces
{
    public interface IBookManagementService
    {
        Book AddBook(Book book);
        bool DeleteBook(int bookId);
        bool EditBook(Book book);
        List<Book> GetAllBooks(string searchTerm);
        //Book GetBookById(int bookId);
    }
}
