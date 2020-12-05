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
        public static List<User> LoadUser()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<User>("SELECT * FROM User", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<Stock> LoadStocks()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Stock>("SELECT * FROM Stocks;", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SavePerson(User user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"UPDATE User SET CashBalance = {user.CashBalance}, BookCost = {user.BookCost}, " + 
                    $"MarketValue = {user.MarketValue}, TotalValue = {user.TotalValue} WHERE ID = 1");
            }
        }

        public static void IncreaseQuantity(string symbol, int amount)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"UPDATE Stocks SET Quantity = Quantity + {amount} WHERE Symbol = {symbol};");
            }
        }

        public static void NewStock(Stock symbol, int amount)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"INSERT INTO Stocks VALUES ();");
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}