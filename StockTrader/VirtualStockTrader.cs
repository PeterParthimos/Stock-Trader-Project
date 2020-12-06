using System.Collections.Generic;
using System.Windows.Forms;

namespace StockTrader
{
    public partial class VirtualStockTrader : Form
    {
        static readonly List<User> userList = SqlLiteDataAccess.LoadUser();
        private readonly User user = new User(userList);

        public VirtualStockTrader()
        {
            InitializeComponent();
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
