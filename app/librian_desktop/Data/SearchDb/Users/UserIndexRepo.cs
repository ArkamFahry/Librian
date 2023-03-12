using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using librian_desktop.Connetions;
using librian_desktop.Data.SearchDb.Models;
using Meilisearch;

namespace librian_desktop.Data.SearchDb.Users
{
    public class UserIndexRepo : IUserIndexRepo
    {
        private string _usersIndex = "Users";

        public async Task<bool> CreateUser(UserIndex user)
        {
            var client = new MeilisearchClient(SearchEngineConnection.Url, SearchEngineConnection.MasterKey);
            var index = client.Index(_usersIndex);
            var users = new[]
            {
                user
            };
            await index.AddDocumentsAsync(users);

            return true;
        }

        public Task<bool> UpdateUser(UserIndex user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUser(UserIndex user)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UserIndex>> GetUsers(string query)
        {
            var client = new MeilisearchClient(SearchEngineConnection.Url, SearchEngineConnection.MasterKey);
            var index = client.Index(_usersIndex);
            var users = await index.SearchAsync<UserIndex>(query);
            return users.Hits;
        }
    }
}
