using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trackx_desktop.Models;

namespace trackx_desktop.Services.LocalStore.Repo
{
    public class UserRepo : IUserRepo
    {
        private string _user = "user";

        private CreateDb _createDb = new CreateDb();

        public User GetUser()
        {
            var result = _createDb.Db().GetCollection<User>(_user);
            var user = result.Query().Limit(1).FirstOrDefault();
            return user;
        }

        public void SetUser(User user)
        {
            var result = _createDb.Db().GetCollection<User>(_user);
            result.Insert(user);
        }

        public void UpdateUser(User user)
        {
            var result = _createDb.Db().GetCollection<User>(_user);
            result.DeleteAll();
            result.Insert(user);
        }

        public void DeleteUser()
        {
            var result = _createDb.Db().GetCollection<User>(_user);
            result.DeleteAll();
        }
    }
}
