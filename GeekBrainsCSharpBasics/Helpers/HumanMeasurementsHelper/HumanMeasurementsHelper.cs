namespace GeekBrainsCSharpBasics
{
    public static class HumanMeasurementsHelper
    {
        public static double GetBodyMassIndex()
        {
            HumanMeasurements humanMeasurements = GetHumanMeasurements();

            return CalculationHelper.CalculateBodyMassIndex(humanMeasurements.Height, humanMeasurements.Weight);
        }

        public static BodyMassIndexAnalysisInfo GetBodyMassIndexAnalysisInfo()
        {
            HumanMeasurements humanMeasurements = GetHumanMeasurements();
            double bodyMassIndex = CalculationHelper.CalculateBodyMassIndex(humanMeasurements.Height, humanMeasurements.Weight);
            string analysisResult;

            double weightIncrement;
            if (bodyMassIndex < 18.5)
            {
                weightIncrement = CalculationHelper.CalculateWeightByBodyMassIndex(humanMeasurements.Height, 18.5 - bodyMassIndex);
                analysisResult = $"Дефицит массы тела. Рекомендуется набрать: {weightIncrement:#.##} кг";
            }
            else if (bodyMassIndex > 25)
            {
                weightIncrement = CalculationHelper.CalculateWeightByBodyMassIndex(humanMeasurements.Height, bodyMassIndex - 25);
                analysisResult = $"Избыточная масса тела. Рекомендуется сбросить: {weightIncrement:#.##} кг";
            }
            else
            {
                analysisResult = "Вес в пределах нормы";
            }

            return new BodyMassIndexAnalysisInfo
            {
                BodyMassIndex = bodyMassIndex,
                AnalysisResult = analysisResult
            };
        }

        private static HumanMeasurements GetHumanMeasurements()
        {
            HumanMeasurements humanMeasurements = new HumanMeasurements();

            humanMeasurements.PrintDescription();
            humanMeasurements.InputData();

            return humanMeasurements;
        }
    }
}
