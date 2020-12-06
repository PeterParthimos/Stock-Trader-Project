using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrader
{
    class Stock
    {
        public string Symbol { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal BookCost { get; set; }
        public double DailyChange { get; set; }


        public Stock() {}


        public Stock(string symbol, decimal price, decimal bookCost, double dailyChange, int quantity)
        {
            this.Symbol = symbol;
            this.Price = price;
            this.Quantity = quantity;
            this.BookCost = bookCost;
            this.DailyChange = dailyChange;
        }
    }
}