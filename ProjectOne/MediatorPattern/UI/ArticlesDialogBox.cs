using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.MediatorPattern.UI
{
    class ArticlesDialogBox
    {
        private readonly ListBox _articlesListBox;
        private readonly TextBox _titleTextBox;
        private readonly Button _saveButton;

        public ArticlesDialogBox()
        {
            _articlesListBox = new ListBox();
            _titleTextBox = new TextBox();
            _saveButton = new Button();

            _articlesListBox.Attach(ArticleSelected);
            _titleTextBox.Attach(TitleChanged);
        }

        private void TitleChanged()
        {
            var content = _titleTextBox.Content;
            var isEmpty = string.IsNullOrEmpty(content);
            _saveButton.IsEnabled = !isEmpty;
        }

        private void ArticleSelected()
        {
            _saveButton.IsEnabled = true;
            _titleTextBox.Content = _articlesListBox.Selection;
        }

        public void SimulateInteraction()
        {
            _articlesListBox.Selection = "Article 1";
            _articlesListBox.Selection = "";
            // _articlesListBox.Selection = "Article 2";
            Console.WriteLine($"TextBox: {_titleTextBox.Content}");
            Console.WriteLine($"Button: {_saveButton.IsEnabled}");
        }

    }
}
