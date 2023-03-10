using LiteDB;

namespace trackx_desktop.Services.LocalStore
{
    public class CreateDb
    {
        public LiteDatabase Db()
        {
            var db = new LiteDatabase("@\"C:\\Temp\\MyData.db\"");
            return db;
        }
    }

}
