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
            this.Stocks = SqlLiteDataAccess.LoadStocks();
            UpdateStockPrice();
            UpdateTotalValue();
            UpdateMarketValue();
        }

        /// <summary>
        /// Updates all stocks to the most current pricing
        /// </summary>
        public void UpdateStockPrice()
        {
            for (int i = 0; i < Stocks.Count; i++)
            {
                decimal newPrice = Convert.ToDecimal(ConnectToApi.GetStockPrice(Stocks[i].Symbol));
                SqlLiteDataAccess.UpdateStockPrice(Stocks[i], newPrice);
            }
        }

        /// <summary>
        /// Updates the users total value
        /// </summary>
        public void UpdateTotalValue()
        {
            decimal total = 0;
            for (int i = 0; i < Stocks.Count; i++)
            {
                total += Stocks[i].Price * Stocks[i].Quantity;
            }
            total += this.CashBalance;
            this.TotalValue = total;
        }

        /// <summary>
        /// Updates the users market value
        /// </summary>
        public void UpdateMarketValue()
        {
            decimal total = 0;
            for (int i = 0; i < Stocks.Count; i++)
            {
                total += Stocks[i].Price * Stocks[i].Quantity;
            }
            this.MarketValue = total;
        }

        /// <summary>
        /// Searches for a stock by stock symbol
        /// </summary>
        /// <param name="symbol">stock symbol to look up</param>
        /// <returns>Stock object from results</returns>
        public Stock SearchStock(string symbol)
        {
            string result = ConnectToApi.GetStockPrice(symbol);
            if (result.Equals("null"))
            {
                Stock badStock = new Stock("Unable to retrieve data!", 0.0M, 0, 0);
                return badStock;
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
                Stock newStock = new Stock(symbol.ToUpper(), Convert.ToDecimal(result), 0.0M, 0);
                return newStock;
            }
        }

        /// <summary>
        /// Buys a stock 
        /// </summary>
        /// <param name="stock"> the stock to buy </param>
        /// <param name="amount">the amount to buy </param>
        /// <returns> true if bought successfully </returns>
        public bool BuyStock(Stock stock, int amount)
        {
            decimal cost = stock.Price * amount;
            int stockNum = Stocks.Count;

            for (int i = 0; i < Stocks.Count; i++)
            {
                if (Stocks[i].Symbol == stock.Symbol && CashBalance >= cost)
                {
                    SqlLiteDataAccess.IncreaseQuantity(stock, amount);
                    CashBalance -= cost;
                    MarketValue += cost;
                    BookCost += cost;
                    return true;
                }
            }
            if (stockNum < 5 && CashBalance >= cost)
            {
                CashBalance -= cost;
                MarketValue += cost;
                BookCost += cost;
                SqlLiteDataAccess.NewStock(stock, amount);
                stock.BookCost += cost;
                Stocks.Add(stock);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Sells a stock
        /// </summary>
        /// <param name="stock"> the stock to sell </param>
        /// <param name="amount"> the amount to sell </param>
        /// <returns> true if sold successfully </returns>
        public bool SellStock(Stock stock, int amount)
        {
            decimal income = stock.Price * amount;

            for (int i = 0; i < Stocks.Count; i++)
            {
                if (Stocks[i].Symbol == stock.Symbol && amount < stock.Quantity)
                {
                    SqlLiteDataAccess.DecreaseQuantity(stock, amount);
                    CashBalance += income;
                    BookCost -= income;
                    Stocks[i].Quantity -= amount;
                    Stocks[i].BookCost -= income;
                    return true;
                }
                else if (Stocks[i].Symbol == stock.Symbol && amount == stock.Quantity)
                {
                    SqlLiteDataAccess.DeleteStock(stock);
                    CashBalance += income;
                    BookCost -= income;
                    Stocks.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
    }
}