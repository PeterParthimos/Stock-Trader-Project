using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace StockTrader
{
    public partial class VirtualStockTrader : Form
    {
        static readonly List<User> userList = SqlLiteDataAccess.LoadUser();
        private readonly User user = new User(userList);
        private Stock tempStock;

        public VirtualStockTrader()
        {
            InitializeComponent();
            UpdateData();
            PopulateListView();
            if (user.Stocks.Count >= 5)
            {
                searchButton.Enabled = false;
            }
        }

        private void UpdateData()
        {
            balanceLabel.Text = "$" + user.TotalValue;
            cashLabel.Text = "$" + user.CashBalance;
            marketLabel.Text = "$" + user.MarketValue;
            bookLabel.Text = "$" + user.BookCost;
        }

        private void PopulateListView()
        {
            stockView.Items.Clear();
            for (int i = 0; i < user.Stocks.Count; i++)
            {
                ListViewItem item = new ListViewItem(user.Stocks[i].Symbol);
                item.SubItems.Add("" + user.Stocks[i].Quantity);
                item.SubItems.Add(Decimal.Round(user.Stocks[i].Price, 2) + "$");
                item.SubItems.Add(user.Stocks[i].BookCost + "$");
                stockView.Items.Add(item);
            }
        }

        private void searchButton_Click(object sender, System.EventArgs e)
        {
            string symbol = searchBox.Text;
            Stock stock = user.SearchStock(symbol);
            this.tempStock = stock;
            searchBox.Text = "";
            symbolLabel.Text = stock.Symbol;
            priceLabel.Text = "$" + Decimal.Round(stock.Price, 2);
            quantityLabel.Text = stock.Quantity + "";
            buyButton.Enabled = true;
            if (stock.Quantity > 0)
            {
                sellbutton.Enabled = true;
            }
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            buyPanel.Visible = true;
            buyButton.Enabled = false;
            quantitySelectBuy.Value = 1M;
            decimal cost = tempStock.Price;
            costLabelBuy.Text = $"${Decimal.Round(cost, 2)}";
        }

        private void quantitySelectBuy_ValueChanged(object sender, EventArgs e)
        {
            decimal amount = quantitySelectBuy.Value;
            decimal cost = tempStock.Price * amount;
            costLabelBuy.Text = $"${Decimal.Round(cost, 2)}";
        }

        private void confirmBuyButton_Click(object sender, EventArgs e)
        {
            int amount = (int)quantitySelectBuy.Value;
            tempStock.Quantity += amount;
            user.BuyStock(tempStock, amount);
            PopulateListView();
            UpdateData();
            buyPanel.Visible = false;
        }
    }
}