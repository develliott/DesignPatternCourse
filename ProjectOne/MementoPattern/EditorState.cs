namespace ProjectOne.MementoPattern
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
