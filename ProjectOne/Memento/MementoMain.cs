using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.Memento
{
    public class MomentoMain
    {
        public MomentoMain()
        {
            var editor = new Editor();
            var history = new History();

            editor.Content = "This is";
            history.Push(editor.CreateState());

            editor.Content = "Some new content";
            history.Push(editor.CreateState());

            editor.Content = "Final";

//            editor.Restore(history.Pop());

            Console.WriteLine(editor.Content);
        }
    }
}
