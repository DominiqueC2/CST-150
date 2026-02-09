using System;
using System.Collections.Generic;
using System.Text;

namespace CST_150DogClass.BusinessLayer
{
    internal class Utility
    {
        /// <summary>
        /// Utility tht reurns false if the parameter String is null, empty,
        /// or just contains white spaces.
        /// </summary>
        /// <param name="textToTest"></param>
        /// <returns></returns>
        public bool NotNull(string textToTest)
        {
            //Check if the string is empty, null, or contains only whitespaces
            if (String.IsNullOrWhiteSpace(textToTest))
            {
                return false; 
            }
            return true;
        }


        public (double doublValue, bool isConverted) ValidDouble(string valueToTest)
        {
            // Declare & Initialize
            double convertValue = 0.00D;
            // Test to see if the string can be prsed to a double
            if(Double.TryParse(valueToTest, out convertValue))
            {
                return (convertValue, true);
            }
            //If parse fails return false and -1
            return (-1D, false);
        }

        public bool ConvertToBool(string YesOrNo)
        {
            if(YesOrNo == "Yes")
            {
                return true; 
            }
            return false;
        }
    }
}
