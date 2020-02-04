using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.Memento
{
    public class EditorState
    {
        public string Content { get; }

        public EditorState(string content)
        {
            Content = content;
        }
    }
}
