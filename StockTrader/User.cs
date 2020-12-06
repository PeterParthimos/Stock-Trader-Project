using System;
using System.Collections.Generic;

namespace StockTrader
{
    class User
    {
        public int ID { get; set; }
        public decimal CashBalance { get; set; }
        public decimal BookCost { get; set; }
        public decimal MarketValue { get; set; }
        public decimal TotalValue { get; set; }
        public double Growth { get; set; }
        public List<Stock> Stocks { get; set; }


        public User() { }


        /// <summary>
        /// Constructor for User
        /// Retrieves user from database and populates variables
        /// </summary>
        public User(List<User> user)
        {
            this.ID = user[0].ID;
            this.CashBalance = user[0].CashBalance;
            this.BookCost = user[0].BookCost;
            this.MarketValue = user[0].MarketValue;
            this.TotalValue = user[0].TotalValue;
            this.Growth = user[0].Growth;
            this.Stocks = SqlLiteDataAccess.LoadStocks();
            UpdateStockPrice();
            UpdateDailyChange();
        }

        /// <summary>
        /// Updates all stocks to the most current pricing
        /// </summary>
        public void UpdateStockPrice()
        {
            for (int i = 0; i < Stocks.Count; i++)
            {
                SqlLiteDataAccess.UpdateStockPrice(Stocks[i], Convert.ToDecimal(ConnectToApi.GetStockPrice(Stocks[i].Symbol)));
            }
        }

        public void UpdateDailyChange()
        {
            for (int i = 0; i < Stocks.Count; i++)
            {
                Stocks[i].DailyChange = ConnectToApi.GetDailyChange(Stocks[i].Symbol);
            }
        }

        /// <summary>
        /// Searches for a stock by stock symbol
        /// </summary>
        /// <param name="symbol">stock symbol to look up</param>
        /// <returns>Stock object from results</returns>
        public Stock SearchStock(string symbol)
        {
            string result = ConnectToApi.GetStockPrice(symbol);
            if (result == null)
            {
                return null;
            }
            else
            {
                for (int i = 0; i < Stocks.Count; i++)
                {
                    if (Stocks[i].Symbol.Equals(symbol))
                    {
                        return Stocks[i];
                    }
                }
                Stock newStock = new Stock(symbol.ToUpper(), Convert.ToDecimal(result), 0, ConnectToApi.GetDailyChange(symbol), 0);
                return newStock;
            }
        }

        public bool BuyStock(Stock stock, int amount)
        {
            for (int i = 0; i < Stocks.Count; i++)
            {
                if (Stocks[i].Symbol == stock.Symbol)
                {
                    Stocks[i].Quantity += amount;
                    SqlLiteDataAccess.IncreaseQuantity(stock, amount);
                    return true;
                }
            }
            SqlLiteDataAccess.NewStock(stock, amount);
            return true;
        }
    }
}