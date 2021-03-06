﻿using System;

namespace ProjectOne.MementoPattern
{
    public class MementoMain
    {
        public MementoMain()
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
