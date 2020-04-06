using System;
using ProjectOne.CommandPattern.Core;

namespace ProjectOne.CommandPattern.Commands
{
    public class ResizeCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Resize command executed.");
        }
    }
}
