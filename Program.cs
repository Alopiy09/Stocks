using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("NASDAQ", "National Association of Securities Dealers Automated Quotations");
            stocks.Add("DJIA", "Dow Jones Industrial Average");

            string GM = stocks["GM"];
            string CAT = stocks["CAT"];
            string NASDAQ = stocks["NASDAQ"];
            string DJIA = stocks["DJIA"];

            

            List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();
            purchases.Add(new Dictionary<string, double>() { { "GM", 230.21 } });
            purchases.Add(new Dictionary<string, double>() { { "GM", 580.98 } });
            purchases.Add(new Dictionary<string, double>() { { "GM", 406.34 } });
            purchases.Add(new Dictionary<string, double>() { { "CAT", 406.34 } });
            purchases.Add(new Dictionary<string, double>() { { "NASDAQ", 406.34 } });
            purchases.Add(new Dictionary<string, double>() { { "CAT", 406.34 } });
            purchases.Add(new Dictionary<string, double>() { { "DJIA", 406.34 } });

            Dictionary<string, double> stockReport = new Dictionary<string, double>();

            foreach (Dictionary<string, double> purchase in purchases)
            {
                foreach (KeyValuePair<string, double> transaction in purchase)
                {
                    string fullCompanyName = stocks[transaction.Key];

                    if (stockReport.ContainsKey(fullCompanyName))
                    {
                        stockReport[fullCompanyName] = stockReport[fullCompanyName] + transaction.Value;
                    } else {
                        stockReport[fullCompanyName] = transaction.Value;
                    }
                }
            }
            foreach (KeyValuePair<string, double> valuation in stockReport)
            {
                Console.WriteLine($"The position in {valuation.Key} is worth {valuation.Value.ToString("C")}");
            }

        }
    }
}
