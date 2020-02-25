using ProjectOne.State_Pattern.Tools;

namespace ProjectOne.State_Pattern
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