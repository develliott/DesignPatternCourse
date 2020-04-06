using System;
using ProjectOne.CommandPattern.Core;

namespace ProjectOne.CommandPattern.Commands
{
    public class ConsoleLogCommand : ICommand
    {
        private readonly string _message;

        public ConsoleLogCommand(string message)
        {
            _message = message;
        }

        public ConsoleLogCommand()
        {
            _message = "Command successfully executed.";
        }


        public void Execute()
        {
            Console.WriteLine($"[ConsoleLogCommand] - {_message}");
        }
    }
}
