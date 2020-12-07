namespace StockTrader
{
    class Stock
    {
        public string Symbol { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal BookCost { get; set; }


        public Stock() {}

        /// <summary>
        /// Constructor for stock
        /// </summary>
        /// <param name="symbol"> the stock symbol </param>
        /// <param name="price"> the stock price </param>
        /// <param name="bookCost"> the book cost </param>
        /// <param name="quantity"> the quantity </param>
        public Stock(string symbol, decimal price, decimal bookCost, int quantity)
        {
            this.Symbol = symbol;
            this.Price = price;
            this.Quantity = quantity;
            this.BookCost = bookCost;
        }
    }
}