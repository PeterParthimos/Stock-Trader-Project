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
        }

        /// <summary>
        /// Updates the data in the label
        /// </summary>
        private void UpdateData()
        {
            balanceLabel.Text = "$" + Decimal.Round(user.TotalValue);
            cashLabel.Text = "$" + Decimal.Round(user.CashBalance, 2);
            marketLabel.Text = "$" + Decimal.Round(user.MarketValue, 2);
            bookLabel.Text = "$" + Decimal.Round(user.BookCost, 2);
        }

        /// <summary>
        /// Populates the list view
        /// </summary>
        private void PopulateListView()
        {
            stockView.Items.Clear();
            for (int i = 0; i < user.Stocks.Count; i++)
            {
                ListViewItem item = new ListViewItem(user.Stocks[i].Symbol);
                item.SubItems.Add("" + user.Stocks[i].Quantity);
                item.SubItems.Add(Decimal.Round(user.Stocks[i].Price, 2) + "$");
                item.SubItems.Add(Decimal.Round(user.Stocks[i].BookCost, 2) + "$");
                stockView.Items.Add(item);
            }
        }

        /// <summary>
        /// Searches for a stock and populates the boxes
        /// </summary>
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
            buyButton.Enabled = true;
            sellbutton.Enabled = true;
        }

        /// <summary>
        /// Opens the buy panel
        /// </summary>
        private void buyButton_Click(object sender, EventArgs e)
        {
            buyPanel.Visible = true;
            sellPanel.Visible = false;
            buyPanel.BringToFront();
            quantitySelectBuy.Value = 1M;
            decimal cost = tempStock.Price;
            costLabelBuy.Text = $"${Decimal.Round(cost, 2)}";
        }

        /// <summary>
        /// Increases the cost text box
        /// </summary>
        private void quantitySelectBuy_ValueChanged(object sender, EventArgs e)
        {
            decimal amount = quantitySelectBuy.Value;
            decimal cost = tempStock.Price * amount;
            costLabelBuy.Text = $"${Decimal.Round(cost, 2)}";
        }

        /// <summary>
        /// Confirms a buy
        /// </summary>
        private void confirmBuyButton_Click(object sender, EventArgs e)
        {
            int amount = (int)quantitySelectBuy.Value;
            tempStock.Quantity += amount;
            if (!user.BuyStock(tempStock, amount))
            {
                MessageBox.Show("Unable to buy stock!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            PopulateListView();
            UpdateData();
            buyPanel.Visible = false;
        }

        /// <summary>
        /// Opens the sell panel
        /// </summary>
        private void sellbutton_Click(object sender, EventArgs e)
        {
            sellPanel.Visible = true;
            buyPanel.Visible = false;
            sellPanel.BringToFront();
            quantitySelectSell.Value = 1M;
            decimal cost = tempStock.Price;
            costLabelSell.Text = $"${Decimal.Round(cost, 2)}";
        }

        /// <summary>
        /// Confirms a sell
        /// </summary>
        private void confirmSellButton_Click(object sender, EventArgs e)
        {
            int amount = (int)quantitySelectSell.Value;
            if (!user.SellStock(tempStock, amount))
            {
                MessageBox.Show("You don't own enough stock to sell!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            PopulateListView();
            UpdateData();
            sellPanel.Visible = false;
        }

        /// <summary>
        /// Increases the income text box
        /// </summary>
        private void quantitySelectSell_ValueChanged(object sender, EventArgs e)
        {
            decimal amount = quantitySelectSell.Value;
            decimal cost = tempStock.Price * amount;
            costLabelSell.Text = $"${Decimal.Round(cost, 2)}";
        }

        /// <summary>
        /// Saves the user on form close
        /// </summary>
        private void VirtualStockTrader_FormClosing(object sender, FormClosingEventArgs e)
        {
            SqlLiteDataAccess.SavePerson(user);
        }
    }
}