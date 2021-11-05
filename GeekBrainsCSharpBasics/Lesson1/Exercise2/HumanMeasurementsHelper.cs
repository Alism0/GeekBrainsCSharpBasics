namespace GeekBrainsCSharpBasics.Lesson1.Exercise2
{
    public static class HumanMeasurementsHelper
    {
        public static double GetBodyMassIndex()
        {
            HumanMeasurements humanMeasurements = new HumanMeasurements();

            humanMeasurements.PrintDescription();
            humanMeasurements.InputData();

            return FormulasHelper.CalculateBodyMassIndex(humanMeasurements.Height, humanMeasurements.Weight);
        }
    }
}
