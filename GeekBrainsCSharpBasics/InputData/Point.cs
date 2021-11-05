namespace GeekBrainsCSharpBasics
{
    public class Point: IInputData
    {
        [InputDescriptionProperty("Х: ", 0)]
        public int X { get; set; }

        [InputDescriptionProperty("Y: ", 1)]
        public int Y { get; set; }
    }
}
