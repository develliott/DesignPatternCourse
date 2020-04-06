using System;
using System.Collections.Generic;
using System.Text;
using ProjectOne.ObserverPattern.StockCode;

namespace ProjectOne.ObserverPattern
{
    public class ObserverPatternMain
    {
        public ObserverPatternMain()
        {
            // Stocks
            Stock stock1 = new Stock("EMR", 1);
            Stock stock2 = new Stock("SHS", 3);
            Stock stock3 = new Stock("JSK", 7);

            // Presentation Layers
            var statusBar = new StatusBar();
            var stockListView = new StockListView();


            statusBar.AddStock(stock1);
            stockListView.AddStock(stock1);
            stockListView.AddStock(stock2);
            stockListView.AddStock(stock3);


            // stock1.Price = 10;
            stock2.Price = 12;
        }
    }
}
