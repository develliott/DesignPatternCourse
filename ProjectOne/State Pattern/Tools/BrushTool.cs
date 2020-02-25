using System;

namespace ProjectOne.State_Pattern.Tools
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