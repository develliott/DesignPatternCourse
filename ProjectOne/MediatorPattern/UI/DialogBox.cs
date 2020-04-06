using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.MediatorPattern.UI
{
    public abstract class DialogBox
    {
        public abstract void Changed(UIControl control);
    }
}
