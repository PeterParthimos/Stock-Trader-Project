using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using Microsoft.Data.Analysis;

namespace StockTrader
{
    class ConnectToApi
    {
        //Api Key for AlphaVantage API
        private readonly string apiKey = "V1R94VAIVGQHI9Q8";

        /// <summary>
        /// Retrieves Daily stock data from AlphaVantage API
        /// Stores open, high, low, and close in list 
        /// </summary>
        /// <param name="symbol"> The Stock Symbol to search for </param>
        /// <returns> List of strings including open, high, low, and close of stock price </returns>
        public List<string> GetStockData(string symbol)
        {
            //Create Request to the AlphaVantage API and record the response
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://" + $@"www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol={symbol}&apikey={this.apiKey}&datatype=csv");
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();

            //Go through the response and save it to a string
            StreamReader sr = new StreamReader(res.GetResponseStream());
            string results = sr.ReadToEnd();
            sr.Close();

            //Save the response string as a csv file and create the dataframe
            File.WriteAllText("stockdata.csv", results);
            DataFrame df = DataFrame.LoadCsv("stockdata.csv");

            //Create the return list with the data
            List<string> data = new List<string>();

            try
            {
                //Goes through the dataframe and adds the proper data to the list
                data.Add("" + df[0, 1]);
                data.Add("" + df[0, 2]);
                data.Add("" + df[0, 3]);
                data.Add("" + df[0, 4]);
            }
            catch (Exception e) //Exception is thrown if the stock symbol isn't real
            {
                //Adds the message to the list
                data.Add("Invalid Stock Symbol!");
            }

            //Returns the list of data or the invalid message
            return data;
        }
    }
}