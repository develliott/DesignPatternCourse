using ProjectOne.MediatorPattern.UI;

namespace ProjectOne.MediatorPattern
{
    public class MediatorPatternMain
    {
        public MediatorPatternMain()
        {
            var dialogBox = new ArticlesDialogBox();

            dialogBox.SimulateInteraction();
        }
    }
}
