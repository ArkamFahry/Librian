using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using librian_desktop.Connetions;
using librian_desktop.Data.SearchDb.Models;
using Meilisearch;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace librian_desktop.Data.SearchDb.Users
{
    public class UserIndexRepo : IUserIndexRepo
    {
        private const string UsersIndex = "Users";

        public async Task<bool> CreateUserIndexAsync(UserIndex userIndex)
        {
            try
            {
                var client = new MeilisearchClient(SeConnection.Url, SeConnection.MasterKey);
                var index = client.Index(UsersIndex);
                var users = new[]
                {
                    userIndex
                };
                await index.AddDocumentsAsync(users);
                return true;

            }
            catch (MeilisearchCommunicationError)
            {
                return false;
            }
        }

        public async Task<bool> UpdateUserIndexAsync(UserIndex userIndex)
        {
            try
            {
                var client = new MeilisearchClient(SeConnection.Url, SeConnection.MasterKey);
                var index = client.Index(UsersIndex);
                var users = new[]
                {
                    userIndex
                };
                await index.UpdateDocumentsAsync(users);
                return true;

            }
            catch (MeilisearchCommunicationError)
            {
                return false;
            }
        }

        public async Task<bool> DeleteUserIndexAsync(string id)
        {
            try
            {
                var client = new MeilisearchClient(SeConnection.Url, SeConnection.MasterKey);
                var index = client.Index(UsersIndex);
                await index.DeleteOneDocumentAsync(id);
                return true;
            }
            catch (MeilisearchCommunicationError)
            {
                return false;
            }
        }

        public async Task<IEnumerable<UserIndex>> SearchUserIndexAsync(string query)
        {
            try
            {
                var client = new MeilisearchClient(SeConnection.Url, SeConnection.MasterKey);
                var index = client.Index(UsersIndex);
                var users = await index.SearchAsync<UserIndex>(query);
                return users.Hits;
            }
            catch (MeilisearchCommunicationError)
            {
                return Enumerable.Empty<UserIndex>();
            }
        }

        public async Task<UserIndex> GetUserIndexByIdAsync(string id)
        {
            try
            {
                var client = new MeilisearchClient(SeConnection.Url, SeConnection.MasterKey);
                var index = client.Index(UsersIndex);
                var user = await index.GetDocumentAsync<UserIndex>(id);
                return user;
            }
            catch (MeilisearchCommunicationError)
            {
                return null;
            }
        }
    }
}
