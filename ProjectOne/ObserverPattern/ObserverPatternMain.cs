using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.ObserverPattern
{
    public class ObserverPatternMain
    {
        public ObserverPatternMain()
        {
            var data = new DataSource();
            var spreadsheet = new Spreadsheet(data);
            var chart = new Chart(data);

            data.AddObserver(spreadsheet);
            data.AddObserver(chart);

            data.Value = 12;
            data.Value = 15;

        }
    }
}
