using System;
using SQLite;
namespace ExemploDeSQLXamarin
{
    public interface IDataBase
    {
        SQLiteConnection GetConnection();
    }
}
