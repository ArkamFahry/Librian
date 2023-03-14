using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using librian_desktop.Data.SearchDb.Authors;
using librian_desktop.Data.SearchDb.Models;
using librian_desktop.Data.SearchDb.Users;
using Microsoft.EntityFrameworkCore;

namespace librian_desktop.Data.MainDb.Authors
{
    public class AuthorRepo : IAuthorRepo
    {
        public async Task<bool> CreateAuthorAsync(Author author)
        {
            author.Id = Guid.NewGuid().ToString();
            author.CreatedAt = DateTime.Now;

            await using var lbContext = new LibrianContext();
            await lbContext.Authors.AddAsync(author);
            await lbContext.SaveChangesAsync();

            var indexAuthor = new AuthorIndexRepo();
            var iAuthor = new AuthorIndex
            {
                Id = author.Id,
                Name = author.Name,
                Description = author.Description,
                CreatedAt = author.CreatedAt.ToString(),
                UpdatedAt = "Not Updated",
            };
            await indexAuthor.CreateAuthorIndexAsync(iAuthor);

            return true;
        }

        public async Task<bool> UpdateAuthorAsync(Author author)
        {
            author.UpdatedAt = DateTime.Now;

            await using var lbContext = new LibrianContext();
            lbContext.Authors.Update(author);
            await lbContext.SaveChangesAsync();

            var indexAuthor = new AuthorIndexRepo();
            var iAuthor = new AuthorIndex
            {
                Id = author.Id,
                Name = author.Name,
                Description = author.Description,
                CreatedAt = author.CreatedAt.ToString(),
                UpdatedAt = author.UpdatedAt.ToString(),
            };
            await indexAuthor.UpdateAuthorIndexAsync(iAuthor);

            return true;
        }

        public async Task<bool> DeleteAuthorAsync(Author author)
        {
            await using var lbContext = new LibrianContext();
            lbContext.Authors.Remove(author);
            await lbContext.SaveChangesAsync();

            var indexAuthor = new AuthorIndexRepo();
            await indexAuthor.DeleteAuthorIndexAsync(author.Id);

            return true;
        }

        public async Task<Author?> GetAuthorByIdAsync(string id)
        {
            await using var lbContext = new LibrianContext();
            var author = await lbContext.Authors.SingleOrDefaultAsync(a => a.Id == id);
            return author;
        }

        public async Task<IEnumerable<Author>> GetAuthorsByNameAsync(string name)
        {
            await using var lbContext = new LibrianContext();
            var authors = lbContext.Authors.Where(a => a.Name == name).ToList();
            return authors;
        }

        public async Task<IEnumerable<Author>> GetAllAuthorsAsync()
        {
            await using var lbContext = new LibrianContext();
            var authors = lbContext.Authors.ToList();
            return authors;
        }
    }
}
