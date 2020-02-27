using System;

namespace ProjectOne.StatePattern.Tools
{
    public class BrushTool : IPerformToolAction
    {
        public void PerformMouseUpAction()
        {
            Console.WriteLine("Draw Line");
        }

        public void PerformMouseDownAction()
        {
            Console.WriteLine("Brush Icon");
        }
    }
}