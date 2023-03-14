using librian_desktop.Data.SearchDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librian_desktop.Data.SearchDb.Books
{
    public interface IBookIndexRepo
    {
        Task<bool> CreateBookIndexAsync(BookIndex bookIndex);

        Task<bool> UpdateBookIndexAsync(BookIndex  bookIndex);

        Task<bool> DeleteBookIndexAsync(string  id);

        Task<IEnumerable<BookIndex>> SearchBookIndexAsync(string query);

        Task<BookIndex> GetBookIndexByIdAsync(string id);
    }
}
