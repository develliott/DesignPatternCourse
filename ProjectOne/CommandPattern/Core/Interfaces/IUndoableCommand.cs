using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.CommandPattern.Core
{
    public interface IUndoableCommand : ICommand
    {
        void Unexecute();
    }
}
