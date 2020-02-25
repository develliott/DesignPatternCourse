using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.State_Pattern
{
    public class Canvas
    {
        private ToolType CurrentTool { get; set; }

        public void MouseDown()
        {
            if (CurrentTool == ToolType.Selection)
            {
                Console.WriteLine("Selection Icon");
            }
            else if (CurrentTool == ToolType.Brush)
            {
                Console.WriteLine("Brush Icon");
            }
            else if (CurrentTool == ToolType.Eraser)
            {
                Console.WriteLine("Eraser Icon");
            }
        }

        public void MouseUp()
        {
            if (CurrentTool == ToolType.Selection)
            {
                Console.WriteLine("Draw dashed rectangle");
            }
            else if (CurrentTool == ToolType.Brush)
            {
                Console.WriteLine("Draw Line");
            }
            else if (CurrentTool == ToolType.Eraser)
            {
                Console.WriteLine("Erase Something");
            }
        }
    }
}
