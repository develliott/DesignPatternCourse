using System;
using System.Collections.Generic;
using System.Text;
using ProjectOne.ObserverPattern.Core;

namespace ProjectOne.ObserverPattern
{
    public class Chart : IObserver
    {
        private DataSource _dataSource;

        public Chart(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine($"Chart was updated. New Value: {_dataSource.Value}");
        }
    }
}
