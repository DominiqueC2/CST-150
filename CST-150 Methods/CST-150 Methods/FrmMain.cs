/*
 * Dominique Canada
 * CST - 150
 * Activity 4 part 2
 * 01/31/2026
 */
namespace CST_150_Methods
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button click event handler to execute the methods
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExecuteMethods(object sender, EventArgs e) 
        {
            //This will be consibered ourMain Method and our
            // goal is to keep this methods clean(no logic just calling methods)
            // Declare & Initialize
            int num1 = 2, num2 = 3, num3 = 4;
            int randomSum = 0;
            double double1 = 1.1D, double2 = 2.2D, double3 = 3.3D;
            double double4 = 4.4D, double5 = 5.5D;
            string firstString = "This is test number 82.";
            string secondString = "The sky is blue today";
            double[] doubles = { 4.4D, 23.56D, 24.45D, 16.1D, 125.25D, 45.3D };
            bool bool1 = true;
            bool bool2 = false;
            // First Methods example
            SumInts(num1, num2);

            //SecondMethod
            DisplayResults("Avg of 5 doubles is: " + AvgValue(double1, double2, double3, double4, double5), false);
            
            // Third Method
            randomSum = RandomInt();
            DisplayResults(string.Format("Method 3: Sum of random ints: {0}", randomSum.ToString()), false);

            //Fourth Method
            bool isDivisibleByTwo = DivByTwo(num1, num2, num3);
            DisplayResults("Method 4: Is sum of 3 ints div by 2: " + isDivisibleByTwo, false);

            //Fifth Method
            FewestChars(firstString, secondString);

            //Sixth Method
            double maxDouble = LargestDouble(doubles);
            DisplayResults(string.Format("Method 6: Largest Double: {0}", maxDouble.ToString()), false);

            //Seventh Method
            int[] intArray = GenerateIntArr();
            DisplayResults("Method 7: Generated Integer Array:", false);
            foreach (int num in intArray)
            {
                DisplayResults(num.ToString(), false);
            }

            //Eighth Method
            bool boolResult = SameBoolValue(bool1, bool2);
            DisplayResults("Method 8: Both booleans have the same value: " + boolResult, false);

            //Ninth Method
            double product = MultiplyIntDouble(num1, double1);
            DisplayResults("Method 9: Product of int and double: " + product, false);



        }

        /// <summary>
        /// Write a method that takes two int and dispalys their sum with descri text
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        private void SumInts(int num1, int num2) 
        {
            // find the sum
            int sum = num1 + num2;
            //display needs to be its own method
            DisplayResults("Method 1: The sum of " + num1  + " + " + num2 + " = " + sum, true);
        
        }

        /// <summary>
        /// Find the average of the 5 doubles and then return average
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        /// <param name="num4"></param>
        /// <param name="num5"></param>
        /// <returns></returns>
        private double AvgValue(double num1, double num2, double num3, double num4, double num5)
        {
            // Declare & Initialize
            const double AvgDenominator = 5.0D;
            // find and return the average of the 5 doubles
            return ((num1 +num2 +num3 +num4 +num5) / AvgDenominator);
        }

        private int RandomInt()
        {
            //Declare & Initialize
            int num1= 0, num2 = 0, sum = 0;
            // get the random numbers
            // c# provides a random class to generate random numbers
            // instantiate random nmber
            // Synta --> ClassName object
            Random rand = new Random();
            //
            //
            num1 = rand.Next(1, 101);
            num2 = rand.Next(1, 101);
            //
            //
            sum = num1 + num2;
            return sum;
        }

        /// <summary>
        /// Displays the string that is sent to the methods
        /// Require descriptive text
        /// Third parameter is to clear the label
        /// </summary>
        /// <param name="descText"></param>
        /// <param name="result"></param>
        private void DisplayResults(string descText, bool clearLabel)
        {
            // only clear the label if the parameter is true
            if (clearLabel)
            {
                lblResults.Text = "";
            }
            //Display the result
            lblResults.Text += string.Format("{0}\n", descText);
        }

        /// <summary>
        /// return bool true or false if the sum of the ints are divisble by 2
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="sum3"></param>
        /// <returns></returns>
        private bool DivByTwo(int num1, int num2, int sum3) 
        {
            // fing the sum
            int sum = num1 + num2 + sum3;
            //Is the sum divisible by 2
            if(sum % 2 == 0)
            {
                return true;
            }
            // If the sum is not sum divisible by 2
            // Return false
            return false;
        }

        private void FewestChars(string string1, string string2)
        {
            // Declare & Initialize
            int countChar1 = 0, countChar2 = 0, pointer = 0;
            // Itreate through the string usinga do while loop
            //exit loop when both strings
            do
            {
                // string1 -> Try & test if char being ponted to is a leeter
                try
                {
                    if (char.IsLetter(string1[pointer]))
                    {
                        // now we know index cotains
                        countChar1++;
                    }
                }
                catch(Exception e)
                {
                    // If we are here then we know string1
                    //We do not want to do anything
                }
                // string2 -> Try & test if char being ponted to is a letter
                try
                {
                    if (char.IsLetter(string2[pointer]))
                    {
                        // now we know index cotains
                        countChar2++;
                    }
                }
                catch (Exception e)
                {
                    // If we are here then we know string2
                    //We do not want to do anything
                }
                //Inc the pointer
                pointer++;

            }
            while ((pointer < string1.Length) || (pointer < string2.Length));

            // Now we have the count of chars
            if(countChar1 < countChar2)
            {
                DisplayResults("Method 5: string 1 has fewer letters", false);
            }
            else if(countChar2 < countChar1) 
            {
                DisplayResults("Method 5: string 2 has fewer letters", false);
            }
            else
            {
                DisplayResults("Method 5: Both strings have the same number of letters", false);
            }
        }

        private double LargestDouble(double[] arrDoubles) 
        {
            // Declare & Initialize
            int arrPointer = 0;
            double valueAtIndex = 0D;
            double biggestDouble = 0D;
            //Iterate through array using while loop
            while(arrPointer < arrDoubles.Length)
            {
                //read double from array
                valueAtIndex = arrDoubles[arrPointer];

                //now test the double 
                //if the value we just read
                // In biggstDouble - replace with valuatindex
                if(valueAtIndex > biggestDouble)
                {
                    //we just found a larger double
                    biggestDouble = valueAtIndex;
                }
                // Inc the pointer 
                arrPointer++;
                //Show how arrDoubles[arrPointer] would do same
            }

            // all done so return the biggest double
            return biggestDouble;
        }

        /// <summary>
        /// generates and returns an array of ten integer values
        /// </summary>
        /// <returns></returns>
        private int[] GenerateIntArr()
        {
            int[] numbers = new int[10];
            Random rand = new Random();
            int index = 0;

            while (index < numbers.Length)
            {
                numbers[index] = rand.Next(1, 101);
                index++;
            }

            return numbers;
        }

        /// <summary>
        /// takes two bool variables and returns true if they have the same value, false otherwise.
        /// </summary>
        /// <param name="bool1"></param>
        /// <param name="bool2"></param>
        /// <returns></returns>
        private bool SameBoolValue(bool bool1, bool bool2)
        {
            if(bool1 == bool2)
            {
                return true; 
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private double MultiplyIntDouble(int num1, double num2)
        {
            return num1 * num2;
        }

    }
}
