using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.State_Pattern.Tools
{
    class SelectionTool : IPerformToolAction
    {
        public void PerformMouseUpAction()
        {
            Console.WriteLine("Draw dashed rectangle");
        }

        public void PerformMouseDownAction()
        {
            Console.WriteLine("Selection Icon");
        }
    }
}
