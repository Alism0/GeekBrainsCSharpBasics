using System.Collections.Generic;

namespace GeekBrainsCSharpBasics
{
    public static class FormatHelper
    {
        public static string[] FormatFormulaNumbers(params int[] formulaValues)
        {
            List<string> formatValues = new List<string>();

            bool wasFirstValueInitiated = false;
            foreach (int value in formulaValues)
            {
                if (value == 0)
                {
                    formatValues.Add("");
                    continue;
                }
                else if (!wasFirstValueInitiated)
                {
                    formatValues.Add(value.ToString());
                    wasFirstValueInitiated = true;
                    continue;
                }

                formatValues.Add(value.ToString("+#;-#;+0"));
            }

            return formatValues.ToArray();
        }

        public static string FormatComplexNumber(ComplexNumber complexNumber)
        {
            string[] formatComplexNumberParts = FormatFormulaNumbers(complexNumber.RealNumber, complexNumber.ImaginaryNumber);
            string formatComplexNumber = $"{formatComplexNumberParts[0]}{formatComplexNumberParts[1]}{(string.IsNullOrEmpty(formatComplexNumberParts[1]) ? string.Empty : "i")}";
            return string.IsNullOrEmpty(formatComplexNumber) ? "0" : formatComplexNumber;
        }
    }
}
