using System;
using ProjectOne.CommandPattern.Commands;
using ProjectOne.CommandPattern.Core;
using ProjectOne.CommandPattern.Editor;

namespace ProjectOne.CommandPattern
{
    public class CommandPatternMain
    {
        private readonly History _history = new History();
        private readonly HtmlDocument _htmlDocument = new HtmlDocument();

        public CommandPatternMain()
        {
            var boldCommand = new BoldCommand(_htmlDocument, _history);
            var undoCommand = new UndoCommand(_history);

            _htmlDocument.Content = "Hello World!";

            Console.WriteLine(_htmlDocument.Content);


            boldCommand.Execute();
            Console.WriteLine(_htmlDocument.Content);

            undoCommand.Execute();
            Console.WriteLine(_htmlDocument.Content);
        }
    }
}
