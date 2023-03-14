using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librian_desktop.Data.MainDb.Authors
{
    public interface IAuthorRepo
    {
        Task<bool> CreateAuthorAsync(Author author);

        Task<bool> UpdateAuthorAsync(Author author);

        Task<bool> DeleteAuthorAsync(Author author);

        Task<Author?> GetAuthorByIdAsync(string id);

        Task<IEnumerable<Author>> GetAuthorsByNameAsync(string name);

        Task<IEnumerable<Author>> GetAllAuthorsAsync();
    }
}
