namespace ProjectOne.CommandPattern.Core
{
    public class Button
    {
        private readonly ICommand _command;
        public string Label { get; set; }

        public Button(ICommand command)
        {
            _command = command;
        }

        public void ClickHandler()
        {
            _command.Execute();
        }
    }
}
