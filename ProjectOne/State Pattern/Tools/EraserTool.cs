using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.State_Pattern.Tools
{
    public class EraserTool : IPerformToolAction
    {
        public void PerformMouseUpAction()
        {
            Console.WriteLine("Erase Something");
        }

        public void PerformMouseDownAction()
        {
            Console.WriteLine("Eraser Icon");
        }
    }
}
