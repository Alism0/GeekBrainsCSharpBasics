using System;

namespace GeekBrainsCSharpBasics.WinForms.Lesson8
{
    public class LogNote
    {
        public string Text { get; set; }

        public DateTime DateTime { get; set; }

        public LogNote() { }

        public LogNote(string text, DateTime dateTime)
        {
            Text = text;
            DateTime = dateTime;
        }
    }
}
