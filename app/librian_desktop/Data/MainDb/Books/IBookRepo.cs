using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librian_desktop.Data.MainDb.Books
{
    public interface IBookRepo
    {
        Task<bool> CreateBookAsync(Book book);

        Task<bool> UpdateBookAsync(Book book);

        Task<bool> DeleteBookAsync(Book book);

        Task<Book?> GetBookByIdAsync(string id);

        Task<Book?> GetBookByNameAsync(string name);

        Task<IEnumerable<Book>> GetBooksByNameAsync(string name);

        Task<IEnumerable<Book>> GetBooksByCategoryAsync(string category)

        Task<IEnumerable<Book>> GetBooksByAuthorAsync(string author);

        Task<IEnumerable<Book>> GetAllBooksAsync();
    }
}
