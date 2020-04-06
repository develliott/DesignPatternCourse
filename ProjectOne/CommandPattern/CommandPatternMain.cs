using ProjectOne.CommandPattern.Commands;
using ProjectOne.CommandPattern.Core;

namespace ProjectOne.CommandPattern
{
    public class CommandPatternMain
    {
        private readonly ICommand _consoleLogCommand = new ConsoleLogCommand();
        private readonly ICommand _consoleLogCommand2 = new ConsoleLogCommand("This is a brand new message.");

        public CommandPatternMain()
        {
            Button button = new Button(_consoleLogCommand);
            button.ClickHandler();

            Button button2 = new Button(_consoleLogCommand2);
            button2.ClickHandler();
        }
    }
}
