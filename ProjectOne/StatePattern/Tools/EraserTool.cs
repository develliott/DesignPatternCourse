using System;

namespace ProjectOne.StatePattern.Tools
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