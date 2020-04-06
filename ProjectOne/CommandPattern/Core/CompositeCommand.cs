using System.Collections.Generic;

namespace ProjectOne.CommandPattern.Core
{
    public class CompositeCommand : ICompositeCommand
    {

        private readonly List<ICommand> _commands = new List<ICommand>();

        public void Execute()
        {
            _commands.ForEach(command => command.Execute());
        }

        public void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }
    }
}
