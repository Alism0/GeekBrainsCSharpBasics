using System;

namespace GeekBrainsCSharpBasics
{
    public class Stopwatch
    {
        private DateTime startDateTime;

        private Stopwatch() { }

        public static Stopwatch GetStopwatch() => new Stopwatch();

        public void Start() =>
            startDateTime = DateTime.Now;

        public string Stop() =>
            (DateTime.Now - startDateTime).TotalSeconds.ToString("#");
    }
}
