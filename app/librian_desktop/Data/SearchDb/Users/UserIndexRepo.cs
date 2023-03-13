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

        public async Task<bool> CreateUserIndex(UserIndex user)
        {
            try
            {
                var client = new MeilisearchClient(SeConnection.Url, SeConnection.MasterKey);
                var index = client.Index(UsersIndex);
                var users = new[]
                {
                    user
                };
                await index.AddDocumentsAsync(users);
                return true;

            }
            catch (MeilisearchCommunicationError)
            {
                return false;
            }
        }

        public async Task<bool> UpdateUserIndex(UserIndex user)
        {
            try
            {
                var client = new MeilisearchClient(SeConnection.Url, SeConnection.MasterKey);
                var index = client.Index(UsersIndex);
                var users = new[]
                {
                    user
                };
                await index.UpdateDocumentsAsync(users);
                return true;

            }
            catch (MeilisearchCommunicationError)
            {
                return false;
            }
        }

        public async Task<bool> DeleteUserIndex(string id)
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

        public async Task<IEnumerable<UserIndex>> SearchUserIndex(string query)
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

        public async Task<UserIndex> GetUserIndexById(string id)
        {
            try
            {

                var client = new MeilisearchClient(SeConnection.Url, SeConnection.MasterKey);
                var index = client.Index(UsersIndex);
                var users = await index.GetDocumentAsync<UserIndex>(id);
                return users;
            }
            catch (MeilisearchCommunicationError)
            {
                return null;
            }
        }
    }
}
