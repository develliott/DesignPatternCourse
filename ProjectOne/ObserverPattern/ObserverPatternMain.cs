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
            var spreadsheet = new Spreadsheet();
            var chart = new Chart();

            data.AddObserver(spreadsheet);
            data.AddObserver(chart);

            data.Value = 12;
        }
    }
}
