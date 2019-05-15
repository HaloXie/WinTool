using Dos.ORM;
using System.Data.SQLite;

namespace NeuSoft.ServiceInterface.Common.Helper
{
    public static class DbHelper
    {
        private static DbSession _dbSession = null;
        public static object objLock = null;
        public static DbSession dbSession
        {
            get
            {
                //lock (objLock)
                {
                    if (_dbSession == null)
                    {
                        SQLiteConnectionStringBuilder sqLiteConnectionStringBuilder = new SQLiteConnectionStringBuilder();
                        sqLiteConnectionStringBuilder.DataSource = System.IO.Directory.GetCurrentDirectory() + "\\ClientMES.db";
                        sqLiteConnectionStringBuilder.Pooling = true;
                        sqLiteConnectionStringBuilder.FailIfMissing = false;
                        string connectionString = sqLiteConnectionStringBuilder.ToString();
                        _dbSession = new DbSession(DatabaseType.Sqlite3, connectionString);
                    }
                    return _dbSession;
                }
            }           
        }
    }
}
