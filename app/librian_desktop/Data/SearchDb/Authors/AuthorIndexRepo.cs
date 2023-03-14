using librian_desktop.Connetions;
using librian_desktop.Data.SearchDb.Models;
using Meilisearch;

namespace librian_desktop.Data.SearchDb.Authors
{
    public class AuthorIndexRepo : IAuthorIndexRepo
    {
        private const string AuthorsIndex = "Authors";

        public async Task<bool> CreateAuthorIndexAsync(AuthorIndex authorIndex)
        {
            try
            {
                var client = new MeilisearchClient(SeConnection.Url, SeConnection.MasterKey);
                var index = client.Index(AuthorsIndex);
                var author = new[]
                {
                    authorIndex
                };
                await index.AddDocumentsAsync(author);
                return true;
            }
            catch (MeilisearchCommunicationError)
            {
                return false;
            }
        }

        public async Task<bool> UpdateAuthorIndexAsync(AuthorIndex authorIndex)
        {
            try
            {
                var client = new MeilisearchClient(SeConnection.Url, SeConnection.MasterKey);
                var index = client.Index(AuthorsIndex);
                var author = new[]
                {
                    authorIndex
                };
                await index.UpdateDocumentsAsync(author);
                return true;
            }
            catch (MeilisearchCommunicationError)
            {
                return false;
            }
        }

        public async Task<bool> DeleteAuthorIndexAsync(string id)
        {
            try
            {
                var client = new MeilisearchClient(SeConnection.Url, SeConnection.MasterKey);
                var index = client.Index(AuthorsIndex);
                await index.DeleteOneDocumentAsync(id);
                return true;
            }
            catch (MeilisearchCommunicationError)
            {
                return false;
            }
        }

        public async Task<IEnumerable<AuthorIndex>> SearchAuthorIndexAsync(string query)
        {
            try
            {
                var client = new MeilisearchClient(SeConnection.Url, SeConnection.MasterKey);
                var index = client.Index(AuthorsIndex);
                var authors = await index.SearchAsync<AuthorIndex>(query);
                return authors.Hits;
            }
            catch (MeilisearchCommunicationError)
            {
                return Enumerable.Empty<AuthorIndex>();
            }
        }

        public async Task<AuthorIndex> GetAuthorIndexByIdAsync(string id)
        {
            try
            {
                var client = new MeilisearchClient(SeConnection.Url, SeConnection.MasterKey);
                var index = client.Index(AuthorsIndex);
                var author = await index.GetDocumentAsync<AuthorIndex>(id);
                return author;
            }
            catch (MeilisearchCommunicationError)
            {
                return null;
            }
        }
    }
}
