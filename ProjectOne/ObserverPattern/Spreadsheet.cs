using System;
using System.Collections.Generic;
using System.Text;
using ProjectOne.ObserverPattern.Core;

namespace ProjectOne.ObserverPattern
{
    public class Spreadsheet : IObserver
    {
        private DataSource _dataSource;

        public Spreadsheet(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine($"Spreadsheet was updated. New Value: {_dataSource.Value}");

        }
    }
}
