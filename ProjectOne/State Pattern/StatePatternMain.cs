using ProjectOne.State_Pattern.Tools;

namespace ProjectOne.State_Pattern
{
    public class StatePatternMain
    {
        public StatePatternMain()
        {
            var canvas = new Canvas();
            canvas.CurrentTool = new BrushTool();

            canvas.MouseUp();
        }
    }
}