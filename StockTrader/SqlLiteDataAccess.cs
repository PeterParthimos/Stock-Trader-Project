using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace StockTrader
{
    class SqlLiteDataAccess
    {
        public static List<string> LoadPeople()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<string>("Select * From User", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SavePerson(string person)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into User (ID, CashBalance, BookCost, MarketValue, TotalValue, LastLogin) " +
                    "values (@ID, @CashBalance, @BookCost, @MarketValue, @TotalValue, @LastLogin)", person);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
