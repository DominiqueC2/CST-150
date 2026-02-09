using System;
using System.Collections.Generic;
using System.Text;

namespace CST_150DogClass.BusinessLayer
{
    internal class Dog
    {
        // Define the properties
        public string Name { get; set; }
        public double NeckRad { get; set; }
        public  string Color { get; set; }
        public double Weight { get; set; }
        public bool Sit {  get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Dog()
        {
            // Initialize the properties
            Name = "";
            NeckRad = 0.00D;
            Color = "";
            Weight = 0.00D;
            Sit = false;
        }

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="neckRad"></param>
        /// <param name="color"></param>
        /// <param name="weight"></param>
        /// <param name="sit"></param>
        public Dog(string name, double neckRad, string color, double weight, bool sit)
        {
            // Main purpose of constructor is to initialize the properties
            Name = name;
            NeckRad = neckRad;
            Color = color;
            Weight = weight;
            Sit = sit;
        }


        public double CalCircumference()
        {
            // Declare & Initialize
            const double cmConversion = 2.5D;
            double circumference = 0.0D;

            // Since NeckRad is at class level
            // Property inside this method.
            // Conversion from raduis to circumference (2*pi*r)
            circumference = 2 * Math.PI * NeckRad;
            //then convert
            return (circumference * cmConversion);

        }

        /// <summary>
        /// Convert Weight pounds to kilograms
        /// </summary>
        /// <returns></returns>
        public double CalWeight()
        {
            // Declare & Initialize
            const double kgConversion = 0.453592D;
            // Convert
            return(Weight * kgConversion);
        }
    }
}
