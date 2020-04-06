using System;
using ProjectOne.CommandPattern.Core;

namespace ProjectOne.CommandPattern.Commands
{
    public class BlackAndWhiteCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Black And White filter command executed.");
        }
    }
}
