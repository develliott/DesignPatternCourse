using System;
using System.Collections.Generic;
using ProjectOne.ObserverPattern.Core;

namespace ProjectOne.ObserverPattern.StockCode
{
    // Popular Stocks
    public class StatusBar : IObserver
    {
        private List<Stock> _stocks = new List<Stock>();

        public void AddStock(Stock stock)
        {
            _stocks.Add(stock);
            stock.AddObserver(this);
        }

        public void Show()
        {
            _stocks.ForEach(Console.WriteLine);
        }

        public void Update()
        {
            Show();
        }
    }
}
