namespace GeekBrainsCSharpBasics.Lesson6
{
    public enum MathFunction : short
    {
        None = 0,

        [MenuDescription("Квадратичная функция - a*x^2", 1)]
        QuadraticFunction = 1,

        [MenuDescription("Функция синуса - a*sin(x)", 2)]
        SineFunction = 2
    }
}
