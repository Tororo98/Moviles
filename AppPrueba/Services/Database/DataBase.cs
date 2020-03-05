using System;
using SQLite;

namespace AppPrueba.Services.Database
{
    public class DataBase
    {

        public readonly SQLiteAsyncConnection connection;

        public DataBase(string dbPath)
        {
            connection = new SQLiteAsyncConnection(dbPath);
        }

    }
}
