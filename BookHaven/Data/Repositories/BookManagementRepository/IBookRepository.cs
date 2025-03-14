using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.Models;

namespace BookHaven.Data.Repositories.BookManagementRepository
{
    public interface IBookRepository
    {
        Book AddBook(Book book);
        bool DeleteBook(int bookId);
        bool EditBook(Book book);
        List<Book> GetAllBooks(string searchparam);
        //Book GetBookById(int bookId);

        bool UpdateStock(int bookId, int quantity);
    }
}
