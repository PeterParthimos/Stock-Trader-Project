using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTrader
{
    public partial class VirtualStockTrader : Form
    {
        private User user;

        public VirtualStockTrader()
        {
            InitializeComponent();
            user = new User();
            balanceLabel.Text = "$" + user.TotalValue;
            cashLabel.Text = "$" + user.CashBalance;
            marketLabel.Text = "$" + user.MarketValue;
            bookLabel.Text = "$" + user.BookCost;
            if (user.Growth > 0)
            {
                growthLabel.Text = "+" + user.Growth + "%";
            }
            else
            {
                growthLabel.Text = user.Growth + "%";
            }
        }
    }
}
