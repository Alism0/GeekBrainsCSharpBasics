namespace GeekBrainsCSharpBasics
{
    public enum ArithmeticOperation
    {
        None = 0,

        [MenuDescription("+", 0)]
        Addition = 1,

        [MenuDescription("-", 1)]
        Subtraction = 2,

        [MenuDescription("*", 2)]
        Multiplication = 3,

        [MenuDescription("/", 3)]
        Division = 4
    }
}
