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
        /// <summary>
        /// Loads the user from the database
        /// </summary>
        /// <returns> List of user </returns>
        public static List<User> LoadUser()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                Console.WriteLine("Hello");
                var output = cnn.Query<User>("SELECT * FROM User", new DynamicParameters());
                return output.ToList();
            }
        }

        /// <summary>
        /// Loads the stocks from the database
        /// </summary>
        /// <returns> List of stock </returns>
        public static List<Stock> LoadStocks()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Stock>("SELECT * FROM Stocks;", new DynamicParameters());
                return output.ToList();
            }
        }

        /// <summary>
        /// Saves the user
        /// </summary>
        /// <param name="user"> the user </param>
        public static void SavePerson(User user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"UPDATE User SET CashBalance = {user.CashBalance}, BookCost = {user.BookCost} WHERE ID = 1");
            }
        }

        /// <summary>
        /// Increases the quantity 
        /// </summary>
        /// <param name="stock"> the stock to increase </param>
        /// <param name="amount"> the amount to increase it by </param>
        public static void IncreaseQuantity(Stock stock, int amount)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"UPDATE Stocks SET Quantity = Quantity + {amount} WHERE Symbol = '{stock.Symbol}';");
                UpdateBookCost(stock, stock.Price, amount);
            }
        }

        /// <summary>
        /// Decreases the quantity
        /// </summary>
        /// <param name="stock"> the stock to reduce </param>
        /// <param name="amount">the quantity to reduce </param>
        public static void DecreaseQuantity(Stock stock, int amount)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"UPDATE Stocks SET Quantity = Quantity - {amount} WHERE Symbol = '{stock.Symbol}';");
                ReduceBookCost(stock, stock.Price, amount);
            }
        }
        
        /// <summary>
        /// Creates a new stock
        /// </summary>
        /// <param name="stock"> the stock to add </param>
        /// <param name="amount"></param>
        public static void NewStock(Stock stock, int amount)
        {
            decimal bookCost = stock.Price * amount;
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"INSERT INTO Stocks VALUES ('{stock.Symbol}', {stock.Price}, {amount}, {bookCost});");
            }
        }

        /// <summary>
        /// Updates the stock price
        /// </summary>
        /// <param name="stock"> the stock to update </param>
        /// <param name="newPrice"></param>
        public static void UpdateStockPrice(Stock stock, decimal newPrice)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"UPDATE Stocks SET Price = {newPrice} WHERE Symbol = '{stock.Symbol}';");
            }
        }

        /// <summary>
        /// Updates the book cost
        /// </summary>
        /// <param name="stock"> the stock </param>
        /// <param name="newPrice"> the new price </param>
        /// <param name="amount"> the amount </param>
        public static void UpdateBookCost(Stock stock, decimal newPrice, int amount)
        {
            decimal bookCost = newPrice * amount;
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"UPDATE Stocks SET BookCost = BookCost + {bookCost} WHERE Symbol = '{stock.Symbol}';");
            }
        }

        /// <summary>
        /// Reduces the book cost
        /// </summary>
        /// <param name="stock"></param>
        /// <param name="newPrice"></param>
        /// <param name="amount"></param>
        public static void ReduceBookCost(Stock stock, decimal newPrice, int amount)
        {
            decimal bookCost = newPrice * amount;
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"UPDATE Stocks SET BookCost = BookCost - {bookCost} WHERE Symbol = '{stock.Symbol}';");
            }
        }

        /// <summary>
        /// deletes the stock
        /// </summary>
        /// <param name="stock"> the stock to delete </param>
        public static void DeleteStock(Stock stock)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"DELETE FROM Stocks WHERE Symbol = '{stock.Symbol}'");
            }
        }

        /// <summary>
        /// Loads the connection string
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}