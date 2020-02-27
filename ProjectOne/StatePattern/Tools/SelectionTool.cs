using System;

namespace ProjectOne.StatePattern.Tools
{
    internal class SelectionTool : IPerformToolAction
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