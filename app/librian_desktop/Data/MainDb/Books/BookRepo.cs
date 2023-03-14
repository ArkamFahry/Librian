using Microsoft.EntityFrameworkCore;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librian_desktop.Data.MainDb.Books
{
    public class BookRepo : IBookRepo
    {
        public async Task<bool> CreateBookAsync(Book book)
        {
            book.CreatedAt = DateTime.Now;

            await using var lbContext = new LibrianContext();
            await lbContext.Books.AddAsync(book);
            await lbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateBookAsync(Book book)
        {
            book.UpdatedAt = DateTime.Now;

            await using var lbContext = new LibrianContext();
            lbContext.Books.Update(book);
            await lbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteBookAsync(Book book)
        {
            await using var lbContext = new LibrianContext();
            lbContext.Books.Remove(book);
            await lbContext.SaveChangesAsync();

            return true;
        }

        public async Task<Book?> GetBookByIdAsync(string id)
        {
            await using var lbContext = new LibrianContext();
            var book = await lbContext.Books.SingleOrDefaultAsync(a => a.Id == id);
            return book;
        }

        public async Task<Book?> GetBookByNameAsync(string name)
        {
            await using var lbContext = new LibrianContext();
            var book = await lbContext.Books.SingleOrDefaultAsync(a => a.Name == name);
            return book;
        }

        public async Task<IEnumerable<Book>> GetBooksByNameAsync(string name)
        {
            await using var lbContext = new LibrianContext();
            var books = lbContext.Books.Where(b => b.Name == name).ToList();
            return books;
        }

        // todo implement this function to search by categories
        public async Task<IEnumerable<Book>> GetBooksByCategoryAsync(string category)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            await using var lbContext = new LibrianContext();
            var books = lbContext.Books.ToList();
            return books;
        }
    }
}
