using Avalonia.Controls;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using trackx_desktop.Models;

namespace trackx_desktop.Services.LocalStore.Repo
{
    public class UserRepo : IUserRepo
    {
        private string _user = "user";

        private static LiteDatabase Db
        {
            get
            {
                return new LiteDatabase(CreateLocalStore.DbPath);
            }
        }

        public User GetUser()
        {
            using var db = Db;
            var result = db.GetCollection<User>(_user);
            var user = result.Query().Limit(1).FirstOrDefault();
            return user;
        }

        public void SetUser(User user)
        {
            using var db = Db;
            var result = db.GetCollection<User>(_user);
            result.Insert(user);
        }

        public void UpdateUser(User user)
        {
            using var db = Db;
            var result = db.GetCollection<User>(_user);
            result.DeleteAll();
            result.Insert(user);
        }

        public void DeleteUser()
        {
            using var db = Db;
            var result = db.GetCollection<User>(_user);
            result.DeleteAll();
        }
    }
}
