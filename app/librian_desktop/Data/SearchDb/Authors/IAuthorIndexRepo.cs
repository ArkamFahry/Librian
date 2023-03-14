using librian_desktop.Data.SearchDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librian_desktop.Data.SearchDb.Authors
{
    public interface IAuthorIndexRepo
    {
        Task<bool> CreateAuthorIndexAsync(AuthorIndex authorIndex);

        Task<bool> UpdateAuthorIndexAsync(AuthorIndex authorIndex);

        Task<bool> DeleteAuthorIndexAsync(string id);

        Task<IEnumerable<AuthorIndex>> SearchAuthorIndexAsync(string query);

        Task<AuthorIndex> GetAuthorIndexByIdAsync(string id);
    }
}
