using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.MediatorPattern.UI
{
    public class UIControl
    {
        protected DialogBox _owner;

        public UIControl(DialogBox owner)
        {
            this._owner = owner;
        }
    }
}
