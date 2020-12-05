using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrader
{
    class Stock
    {
        private string symbol;
        private decimal open;
        private decimal high;
        private decimal low;
        private decimal close;
        private int quantity;

        public Stock(string symbol, decimal open, decimal high, decimal low, decimal close, int quantity)
        {
            this.symbol = symbol;
            this.open = open;
            this.high = high;
            this.low = low;
            this.close = close;
            this.quantity = quantity;
        }
    }
}