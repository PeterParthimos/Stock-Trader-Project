using System.Collections.Generic;
using System.Windows.Forms;
using System;

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
            PopulateListView();
        }

        private void PopulateListView()
        {
            for (int i = 0; i < user.Stocks.Count; i++)
            {
                ListViewItem item = new ListViewItem(user.Stocks[i].Symbol);
                item.SubItems.Add("" + user.Stocks[i].Quantity);
                item.SubItems.Add(Decimal.Round(user.Stocks[i].Price, 2) + "$");
                item.SubItems.Add(Math.Round(user.Stocks[i].DailyChange, 2) + "%");
                item.SubItems.Add(user.Stocks[i].BookCost + "$");
                stockView.Items.Add(item);
            }
        }

        private void searchButton_Click(object sender, System.EventArgs e)
        {
            string symbol = searchBox.Text;
            Stock stock = user.SearchStock(symbol);
            searchBox.Text = "";
            if (stock == null)
            {
                symbolLabel.Text = "Invalid!";
                priceLabel.Text = "";
                changeLabel.Text = "";
                quantityLabel.Text = "";
            }
            else
            {
                symbolLabel.Text = stock.Symbol;
                priceLabel.Text = "$" + Decimal.Round(stock.Price, 2);
                if (stock.DailyChange > 0)
                {
                    changeLabel.Text = "+" + Math.Round(stock.DailyChange, 2) + "%";
                }
                else if (stock.DailyChange < -101.00)
                {
                    changeLabel.Text = "Unable to fetch data!";
                }
                else
                {
                    changeLabel.Text = Math.Round(stock.DailyChange, 2) + "%";
                }
                quantityLabel.Text = stock.Quantity + "";
                buyButton.Enabled = true;
                if (stock.Quantity > 0)
                {
                    sellbutton.Enabled = true;
                }
            }
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            //Stock stock = user.SearchStock
        }
    }
}
