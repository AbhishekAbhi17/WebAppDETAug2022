using LibraryAPI.Models;
using System;


namespace LibraryAPI.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();
        Book Add(Book newBook);
        Book GetById(Guid id);
        Book Remove(Guid id);
    }
}
