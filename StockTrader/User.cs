using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrader
{
    class User
    {
        public int Id { get; set; }
        public decimal CashBalance { get; set; }
        public decimal BookCost { get; set; }
        public decimal MarketValue { get; set; }
        public decimal TotalValue { get; set; }
        public string LastLogin { get; set; }
    }
}
