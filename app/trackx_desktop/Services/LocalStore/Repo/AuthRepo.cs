using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trackx_desktop.Models;

namespace trackx_desktop.Services.LocalStore.Repo
{
    public class AuthRepo : IAuthRepo
    {
        private string _auth = "auth";

        private static LiteDatabase Db
        {
            get
            {
                return new LiteDatabase(CreateLocalStore.DbPath);
            }
        }

        public Auth GetAuth()
        {
            using var db = Db;
            var result = db.GetCollection<Auth>(_auth);
            var auth = result.Query().Limit(1).FirstOrDefault();
            return auth;
        }

        public void SetAuth(Auth auth)
        {
            using var db = Db;
            var result = db.GetCollection<Auth>(_auth);
            result.Insert(auth);
        }

        public void UpdateAuth(Auth auth)
        {
            using var db = Db;
            var result = db.GetCollection<Auth>(_auth);
            result.DeleteAll();
            result.Insert(auth);
        }

        public void DeleteAuth()
        {
            using var db = Db;
            var result = db.GetCollection<Auth>(_auth);
            result.DeleteAll();
        }
    }
}
