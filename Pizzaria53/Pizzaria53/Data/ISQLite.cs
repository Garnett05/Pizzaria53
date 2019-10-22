using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Pizzaria53.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
