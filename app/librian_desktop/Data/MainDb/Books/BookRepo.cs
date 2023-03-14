using librian_desktop.Data.SearchDb.Models;
using librian_desktop.Data.SearchDb.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using librian_desktop.Data.SearchDb.Books;

namespace librian_desktop.Data.MainDb.Books
{
    public class BookRepo : IBookRepo
    {
        public async Task<bool> CreateBookAsync(Book book)
        {
            book.Id = Guid.NewGuid().ToString();
            book.CreatedAt = DateTime.Now;

            await using var lbContext = new LibrianContext();
            await lbContext.Books.AddAsync(book);
            await lbContext.SaveChangesAsync();

            var indexBook = new BookIndexRepo();
            var iBook = new BookIndex()
            {
                Id = book.Id,
                Name = book.Name,
                Description = book.Description,
                PublishedDate = book.PublishedDate.ToString(),
                CreatedAt = book.CreatedAt.ToString(),
                UpdatedAt = "Not Updated"
            };
            await indexBook.CreateBookIndexAsync(iBook);

            return true;
        }

        public async Task<bool> UpdateBookAsync(Book book)
        {
            book.UpdatedAt = DateTime.Now;

            await using var lbContext = new LibrianContext();
            lbContext.Books.Update(book);
            await lbContext.SaveChangesAsync();


            var indexBook = new BookIndexRepo();
            var iBook = new BookIndex()
            {
                Id = book.Id,
                Name = book.Name,
                Description = book.Description,
                PublishedDate = book.PublishedDate.ToString(),
                CreatedAt = book.CreatedAt.ToString(),
                UpdatedAt = book.UpdatedAt.ToString(),
            };
            await indexBook.UpdateBookIndexAsync(iBook);

            return true;
        }

        public async Task<bool> DeleteBookAsync(Book book)
        {
            await using var lbContext = new LibrianContext();
            lbContext.Books.Remove(book);
            await lbContext.SaveChangesAsync();

            var indexBook = new BookIndexRepo();
            await indexBook.DeleteBookIndexAsync(book.Id);

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
        
        public async Task<IEnumerable<Book>> GetBooksByCategoryAsync(string category)
        {
            await using var lbContext = new LibrianContext();
            var books =
                (from b in lbContext.Books
                    join bc in lbContext.BookCategories on b.Id equals bc.BookId
                    join c in lbContext.Categories on bc.CategoryId equals c.Id
                        where c.Name == category select b).AsEnumerable<Book>();

            return books;
        }

        public async Task<IEnumerable<Book>> GetBooksByAuthorAsync(string author)
        {
            await using var lbContext = new LibrianContext();
            var books = 
                (from b in lbContext.Books
                    join ba in lbContext.BookAuthors on b.Id equals ba.BookId
                    join a in lbContext.Authors on ba.AuthorId equals a.Id
                        where a.Name == author select b).AsEnumerable<Book>();

            return books;
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            await using var lbContext = new LibrianContext();
            var books = lbContext.Books.ToList();
            return books;
        }
    }
}
