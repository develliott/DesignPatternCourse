using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.CommandPattern.Core
{
    public class History
    {
        private readonly Stack<IUndoableCommand> _undoableCommands = new Stack<IUndoableCommand>();

        public void Push(IUndoableCommand command)
        {
            _undoableCommands.Push(command);
        }

        public IUndoableCommand Pop()
        {
            return _undoableCommands.Pop();
        }

        public bool HasCommands() => _undoableCommands.Count > 0;
    }
}
