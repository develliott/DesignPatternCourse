using System;
using System.Collections.Generic;
using System.Text;
using ProjectOne.CommandPattern.Core;
using ProjectOne.CommandPattern.Editor;

namespace ProjectOne.CommandPattern.Commands
{
    public class BoldCommand : IUndoableCommand
    {
        private string _prevContent;
        private HtmlDocument _htmlDocument;
        private History _history;

        public BoldCommand(HtmlDocument htmlDocument, History history )
        {
            _history = history;
            _htmlDocument = htmlDocument;
        }

        public void Execute()
        {
            _prevContent = _htmlDocument.Content;
            _htmlDocument.MakeBold();
            _history.Push(this);
        }

        public void Unexecute()
        {
            _htmlDocument.Content = _prevContent;
        }
    }
}
