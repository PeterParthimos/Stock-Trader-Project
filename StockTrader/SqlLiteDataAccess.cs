using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System;

namespace StockTrader
{
    class SqlLiteDataAccess
    {
        public static List<User> LoadUser()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                Console.WriteLine("Hello");
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

        public static void IncreaseQuantity(Stock stock, int amount)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"UPDATE Stocks SET Quantity = Quantity + {amount} WHERE Symbol = '{stock.Symbol}';");
                UpdateBookCost(stock, stock.Price, amount);
            }
        }

        public static void NewStock(Stock stock, int amount)
        {
            decimal bookCost = stock.Price * amount;
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"INSERT INTO Stocks VALUES ('{stock.Symbol}', {stock.Price}, {amount}, {bookCost});");
            }
        }

        public static void UpdateStockPrice(Stock stock, decimal newPrice)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"UPDATE Stocks SET Price = {newPrice} WHERE Symbol = '{stock.Symbol}';");
            }
        }

        public static void UpdateBookCost(Stock stock, decimal newPrice, int amount)
        {
            decimal bookCost = newPrice * amount;
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"UPDATE Stocks SET BookCost = BookCost + {bookCost} WHERE Symbol = '{stock.Symbol}';");
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}