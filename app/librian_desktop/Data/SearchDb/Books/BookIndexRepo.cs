using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using librian_desktop.Connetions;
using librian_desktop.Data.SearchDb.Models;
using Meilisearch;

namespace librian_desktop.Data.SearchDb.Books
{
    public class BookIndexRepo : IBookIndexRepo
    {
        private const string BooksIndex = "Books";

        public async Task<bool> CreateBookIndexAsync(BookIndex bookIndex)
        {
            try
            {
                var client = new MeilisearchClient(SeConnection.Url, SeConnection.MasterKey);
                var index = client.Index(BooksIndex);
                var books = new[]
                {
                    bookIndex
                };
                await index.AddDocumentsAsync(books);
                return true;

            }
            catch (MeilisearchCommunicationError)
            {
                return false;
            }
        }

        public async Task<bool> UpdateBookIndexAsync(BookIndex bookIndex)
        {
            try
            {
                var client = new MeilisearchClient(SeConnection.Url, SeConnection.MasterKey);
                var index = client.Index(BooksIndex);
                var books = new[]
                {
                    bookIndex
                };
                await index.UpdateDocumentsAsync(books);
                return true;

            }
            catch (MeilisearchCommunicationError)
            {
                return false;
            }
        }

        public async Task<bool> DeleteBookIndexAsync(string id)
        {
            try
            {
                var client = new MeilisearchClient(SeConnection.Url, SeConnection.MasterKey);
                var index = client.Index(BooksIndex);
                await index.DeleteOneDocumentAsync(id);
                return true;
            }
            catch (MeilisearchCommunicationError)
            {
                return false;
            }
        }

        public async Task<IEnumerable<BookIndex>> SearchBookIndexAsync(string query)
        {
            try
            {
                var client = new MeilisearchClient(SeConnection.Url, SeConnection.MasterKey);
                var index = client.Index(BooksIndex);
                var users = await index.SearchAsync<BookIndex>(query);
                return users.Hits;
            }
            catch (MeilisearchCommunicationError)
            {
                return Enumerable.Empty<BookIndex>();
            }
        }

        public async Task<BookIndex> GetBookIndexByIdAsync(string id)
        {
            try
            {
                var client = new MeilisearchClient(SeConnection.Url, SeConnection.MasterKey);
                var index = client.Index(BooksIndex);
                var user = await index.GetDocumentAsync<BookIndex>(id);
                return user;
            }
            catch (MeilisearchCommunicationError)
            {
                return null;
            }
        }
    }
}
