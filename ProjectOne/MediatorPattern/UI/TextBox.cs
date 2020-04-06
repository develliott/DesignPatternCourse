using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.MediatorPattern.UI
{
    public class TextBox : UIControl
    {
        private string _content;

        public string Content
        {
            get => _content;
            set
            {
                _content = value;
                NotifyObservers();
            }
        }


    }
}
