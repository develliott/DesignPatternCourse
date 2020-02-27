using ProjectOne.StatePattern.Tools;

namespace ProjectOne.StatePattern
{
    public class Canvas
    {
        public IPerformToolAction CurrentTool { get; set; }

        public void MouseDown()
        {
            CurrentTool.PerformMouseDownAction();
        }

        public void MouseUp()
        {
            CurrentTool.PerformMouseUpAction();
        }
    }
}