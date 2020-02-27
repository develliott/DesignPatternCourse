using ProjectOne.StatePattern.Tools;

namespace ProjectOne.StatePattern
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