namespace StockTrader
{
    partial class VirtualStockTrader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VirtualStockTrader));
            this.balanceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.symbolLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.buyButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.sellbutton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cashLabel = new System.Windows.Forms.Label();
            this.marketLabel = new System.Windows.Forms.Label();
            this.bookLabel = new System.Windows.Forms.Label();
            this.stockView = new System.Windows.Forms.ListView();
            this.symbolHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buyPanel = new System.Windows.Forms.Panel();
            this.costLabelBuy = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.confirmBuyButton = new System.Windows.Forms.Button();
            this.quantitySelectBuy = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.sellPanel = new System.Windows.Forms.Panel();
            this.costLabelSell = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.confirmSellButton = new System.Windows.Forms.Button();
            this.quantitySelectSell = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.buyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelectBuy)).BeginInit();
            this.sellPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelectSell)).BeginInit();
            this.SuspendLayout();
            // 
            // balanceLabel
            // 
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.Location = new System.Drawing.Point(192, 2);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(232, 42);
            this.balanceLabel.TabIndex = 1;
            this.balanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Balance: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(449, 18);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(166, 26);
            this.searchBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(449, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stock Symbol:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(449, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Current Price:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(446, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantity Owned:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // symbolLabel
            // 
            this.symbolLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.symbolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbolLabel.Location = new System.Drawing.Point(589, 60);
            this.symbolLabel.Name = "symbolLabel";
            this.symbolLabel.Size = new System.Drawing.Size(183, 27);
            this.symbolLabel.TabIndex = 9;
            this.symbolLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceLabel
            // 
            this.priceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(589, 98);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(183, 27);
            this.priceLabel.TabIndex = 10;
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quantityLabel
            // 
            this.quantityLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(589, 136);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(183, 27);
            this.quantityLabel.TabIndex = 12;
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buyButton
            // 
            this.buyButton.Enabled = false;
            this.buyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyButton.Location = new System.Drawing.Point(489, 176);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(94, 30);
            this.buyButton.TabIndex = 13;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(622, 18);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(150, 26);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "Search Stocks";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // sellbutton
            // 
            this.sellbutton.Enabled = false;
            this.sellbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellbutton.Location = new System.Drawing.Point(640, 176);
            this.sellbutton.Name = "sellbutton";
            this.sellbutton.Size = new System.Drawing.Size(94, 30);
            this.sellbutton.TabIndex = 16;
            this.sellbutton.Text = "Sell";
            this.sellbutton.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 27);
            this.label10.TabIndex = 17;
            this.label10.Text = "Cash:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 27);
            this.label11.TabIndex = 18;
            this.label11.Text = "Market Value:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 27);
            this.label12.TabIndex = 19;
            this.label12.Text = "Book Cost:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cashLabel
            // 
            this.cashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashLabel.Location = new System.Drawing.Point(131, 44);
            this.cashLabel.Name = "cashLabel";
            this.cashLabel.Size = new System.Drawing.Size(293, 27);
            this.cashLabel.TabIndex = 20;
            this.cashLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // marketLabel
            // 
            this.marketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marketLabel.Location = new System.Drawing.Point(131, 71);
            this.marketLabel.Name = "marketLabel";
            this.marketLabel.Size = new System.Drawing.Size(293, 27);
            this.marketLabel.TabIndex = 21;
            this.marketLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bookLabel
            // 
            this.bookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookLabel.Location = new System.Drawing.Point(131, 98);
            this.bookLabel.Name = "bookLabel";
            this.bookLabel.Size = new System.Drawing.Size(293, 27);
            this.bookLabel.TabIndex = 22;
            this.bookLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stockView
            // 
            this.stockView.BackColor = System.Drawing.SystemColors.Window;
            this.stockView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.symbolHeader,
            this.quantityHeader,
            this.priceHeader,
            this.bookHeader});
            this.stockView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.stockView.HideSelection = false;
            this.stockView.Location = new System.Drawing.Point(12, 141);
            this.stockView.Name = "stockView";
            this.stockView.Size = new System.Drawing.Size(412, 208);
            this.stockView.TabIndex = 25;
            this.stockView.UseCompatibleStateImageBehavior = false;
            this.stockView.View = System.Windows.Forms.View.Details;
            // 
            // symbolHeader
            // 
            this.symbolHeader.Text = "Stock";
            this.symbolHeader.Width = 102;
            // 
            // quantityHeader
            // 
            this.quantityHeader.Text = "Quantity";
            this.quantityHeader.Width = 102;
            // 
            // priceHeader
            // 
            this.priceHeader.Text = "Price";
            this.priceHeader.Width = 102;
            // 
            // bookHeader
            // 
            this.bookHeader.Text = "BookCost";
            this.bookHeader.Width = 102;
            // 
            // buyPanel
            // 
            this.buyPanel.Controls.Add(this.costLabelBuy);
            this.buyPanel.Controls.Add(this.label7);
            this.buyPanel.Controls.Add(this.confirmBuyButton);
            this.buyPanel.Controls.Add(this.quantitySelectBuy);
            this.buyPanel.Controls.Add(this.label6);
            this.buyPanel.Controls.Add(this.sellPanel);
            this.buyPanel.Location = new System.Drawing.Point(452, 225);
            this.buyPanel.Name = "buyPanel";
            this.buyPanel.Size = new System.Drawing.Size(320, 124);
            this.buyPanel.TabIndex = 26;
            this.buyPanel.Visible = false;
            // 
            // costLabelBuy
            // 
            this.costLabelBuy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costLabelBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabelBuy.Location = new System.Drawing.Point(154, 44);
            this.costLabelBuy.Name = "costLabelBuy";
            this.costLabelBuy.Size = new System.Drawing.Size(98, 23);
            this.costLabelBuy.TabIndex = 16;
            this.costLabelBuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cost:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // confirmBuyButton
            // 
            this.confirmBuyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBuyButton.Location = new System.Drawing.Point(96, 80);
            this.confirmBuyButton.Name = "confirmBuyButton";
            this.confirmBuyButton.Size = new System.Drawing.Size(133, 32);
            this.confirmBuyButton.TabIndex = 14;
            this.confirmBuyButton.Text = "Confirm Buy";
            this.confirmBuyButton.UseVisualStyleBackColor = true;
            this.confirmBuyButton.Click += new System.EventHandler(this.confirmBuyButton_Click);
            // 
            // quantitySelectBuy
            // 
            this.quantitySelectBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitySelectBuy.Location = new System.Drawing.Point(154, 10);
            this.quantitySelectBuy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantitySelectBuy.Name = "quantitySelectBuy";
            this.quantitySelectBuy.Size = new System.Drawing.Size(98, 24);
            this.quantitySelectBuy.TabIndex = 2;
            this.quantitySelectBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantitySelectBuy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantitySelectBuy.ValueChanged += new System.EventHandler(this.quantitySelectBuy_ValueChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Quantity:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sellPanel
            // 
            this.sellPanel.Controls.Add(this.costLabelSell);
            this.sellPanel.Controls.Add(this.label9);
            this.sellPanel.Controls.Add(this.confirmSellButton);
            this.sellPanel.Controls.Add(this.quantitySelectSell);
            this.sellPanel.Controls.Add(this.label13);
            this.sellPanel.Location = new System.Drawing.Point(0, 0);
            this.sellPanel.Name = "sellPanel";
            this.sellPanel.Size = new System.Drawing.Size(320, 124);
            this.sellPanel.TabIndex = 27;
            this.sellPanel.Visible = false;
            // 
            // costLabelSell
            // 
            this.costLabelSell.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costLabelSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabelSell.Location = new System.Drawing.Point(154, 44);
            this.costLabelSell.Name = "costLabelSell";
            this.costLabelSell.Size = new System.Drawing.Size(98, 23);
            this.costLabelSell.TabIndex = 16;
            this.costLabelSell.Text = "$0";
            this.costLabelSell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(65, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Income:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // confirmSellButton
            // 
            this.confirmSellButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmSellButton.Location = new System.Drawing.Point(96, 80);
            this.confirmSellButton.Name = "confirmSellButton";
            this.confirmSellButton.Size = new System.Drawing.Size(133, 32);
            this.confirmSellButton.TabIndex = 14;
            this.confirmSellButton.Text = "Confirm Sell";
            this.confirmSellButton.UseVisualStyleBackColor = true;
            // 
            // quantitySelectSell
            // 
            this.quantitySelectSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitySelectSell.Location = new System.Drawing.Point(154, 10);
            this.quantitySelectSell.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantitySelectSell.Name = "quantitySelectSell";
            this.quantitySelectSell.Size = new System.Drawing.Size(98, 24);
            this.quantitySelectSell.TabIndex = 2;
            this.quantitySelectSell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantitySelectSell.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(65, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 24);
            this.label13.TabIndex = 1;
            this.label13.Text = "Quantity:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VirtualStockTrader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.buyPanel);
            this.Controls.Add(this.stockView);
            this.Controls.Add(this.bookLabel);
            this.Controls.Add(this.marketLabel);
            this.Controls.Add(this.cashLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sellbutton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.symbolLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.balanceLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "VirtualStockTrader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Virtual Stock Trader";
            this.buyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelectBuy)).EndInit();
            this.sellPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelectSell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label symbolLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button sellbutton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label cashLabel;
        private System.Windows.Forms.Label marketLabel;
        private System.Windows.Forms.Label bookLabel;
        private System.Windows.Forms.ListView stockView;
        private System.Windows.Forms.ColumnHeader symbolHeader;
        private System.Windows.Forms.ColumnHeader quantityHeader;
        private System.Windows.Forms.ColumnHeader priceHeader;
        private System.Windows.Forms.ColumnHeader bookHeader;
        private System.Windows.Forms.Panel buyPanel;
        private System.Windows.Forms.NumericUpDown quantitySelectBuy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button confirmBuyButton;
        private System.Windows.Forms.Label costLabelBuy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel sellPanel;
        private System.Windows.Forms.Label costLabelSell;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button confirmSellButton;
        private System.Windows.Forms.NumericUpDown quantitySelectSell;
        private System.Windows.Forms.Label label13;
    }
}

