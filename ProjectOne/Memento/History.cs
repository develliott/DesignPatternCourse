using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.Memento
{
    public class History
    {
        private List<EditorState> _states = new List<EditorState>();

        public void Push(EditorState state)
        {
            _states.Add(state);
        }

        public EditorState Pop()
        {
            var lastState = _states[^1];
            _states.Remove(lastState);
            return lastState;
        }
    }
}
