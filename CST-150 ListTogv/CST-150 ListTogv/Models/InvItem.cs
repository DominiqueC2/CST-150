using System;
using System.Collections.Generic;
using System.Text;

namespace CST_150_ListTogv.Models
{
    /// <summary>
    /// Model vClass that will structure
    /// all my inventory items.
    /// </summary>
    public class InvItem
    {
        // Define the properties
        public string Type { get; set; }
        public string Color { get; set; }
        public int Qty { get; set; }

        // <summary>
        /// Model bClass Parameterized Constructor
        /// </summary>
        /// <param name="type"></param>
        /// <param name="color"></param>
        /// <param name="qty"></param>
        public InvItem(string type, string color, int qty)
        {
            //Constructor is initilizing the properties
            Type = type;
            Color = color;
            Qty = qty;
        }


    }

}


