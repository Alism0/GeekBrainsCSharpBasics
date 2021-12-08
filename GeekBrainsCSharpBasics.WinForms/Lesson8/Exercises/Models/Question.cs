namespace GeekBrainsCSharpBasics.WinForms.Lesson8
{
    public class Question
    {
        public string Text { get; set; }

        public bool Answer { get; set; }

        public Question() { }

        public Question(string text, bool answer)
        {
            Text = text;
            Answer = answer;
        }
    }
}
