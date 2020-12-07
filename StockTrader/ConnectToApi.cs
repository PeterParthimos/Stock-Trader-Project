using System;
using System.Net;
using System.IO;
using Microsoft.Data.Analysis;

namespace StockTrader
{
    class ConnectToApi
    {
        /// <summary>
        /// Retrieves stock price from AlphaVantage API
        /// Returns a string of the most recent stock price
        /// </summary>
        /// <param name="symbol"> The Stock Symbol to search for </param>
        /// <returns> Most recent stock price </returns>
        public static string GetStockPrice(string symbol)
        {
            //Create Request to the AlphaVantage API and record the response
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://" + $@"www.alphavantage.co/query?function=TIME_SERIES_INTRADAY&symbol={symbol}&interval=1min&apikey=V1R94VAIVGQHI9Q8&datatype=csv");
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();

            //Go through the response and save it to a string
            StreamReader sr = new StreamReader(res.GetResponseStream());
            string results = sr.ReadToEnd();
            sr.Close();

            //Save the response string as a csv file and load it into a dataframe
            File.WriteAllText("stockdata.csv", results);
            DataFrame df = DataFrame.LoadCsv("stockdata.csv");

            try
            {
                //Gets the most current stock price from the list and returns it
                return ("" + df[0, 4]);
            }
            catch (Exception e) //Exception is thrown if stock isnt real
            {
                return "null";
            }
        }
    }
}