using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.CommandPattern.Core
{
    interface ICompositeCommand : ICommand
    {
        void AddCommand(ICommand command);
    }
}
