using System;

namespace ProjectOne.State_Pattern.Tools
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