using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.MediatorPattern.UI
{
    public class ListBox : UIControl
    {
        private string _selection;

        public string Selection
        {
            get => _selection;
            set
            {
                _selection = value;
                NotifyObservers();
            }
        }
    }
}
