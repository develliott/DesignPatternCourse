using System;
using System.Collections.Generic;
using System.Text;
using ProjectOne.CommandPattern.Core;

namespace ProjectOne.CommandPattern.Commands
{
    public class UndoCommand : ICommand
    {
        private readonly History _history;

        public UndoCommand(History history)
        {
            _history = history;
        }

        public void Execute()
        {
            if (_history.HasCommands())
            {
                _history.Pop().Unexecute();
            }
        }
    }
}
