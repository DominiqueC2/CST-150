using CST_150_ListTogv.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CST_150_ListTogv.BusinessLayer
{
    internal class Inventory
    {
        // the Purpose of the class isto readthe txt file into a list
        //Then pass the list to the FrmInventory.cs.

        /// <summary>
        /// Read the inventory txt file and return a list of type InvItems class
        /// </summary>
        /// <param name="invItems"></param>
        /// <returns></returns>
        public List<InvItem> ReadInventory(List<InvItem> invItems)
        {
            // Enter the location of the file to open
            string dirLoc = Application.StartupPath + "Data\\Topic6.txt";

            //Open the file ith "using"
            // The main goal to use "using" is to manage resources nd release all he
            //resources automatically when done. (garbage Collector)
            using (var str = File.OpenText(dirLoc)) 
            {
                //Iterate through the text file one line at a time
                foreach (string line in File.ReadLines(dirLoc, Encoding.UTF8))
                {
                    // Split up the line
                    string[] rowData = line.Split(",");
                    //Now we can add the line to our list<invitem>
                    // which is our class model.
                    invItems.Add(new InvItem(rowData[0].ToString().Trim(),
                        rowData[1].ToString().Trim(), Convert.ToInt32(rowData[2])));
                }
            }
            // Return the list
            return invItems;
        }

        /// <summary>
        /// Inc inventory in the list and then return the updated list
        /// </summary>
        /// <param name="invItems"></param>
        /// <param name="selectedRowIndex"></param>
        /// <returns></returns>
        public List<InvItem> IncQtyValue(List<InvItem> invItems, int selectedRowIndex)
        {
            //Increment the quantity value using the Property name
            int updatedQty = ++invItems[selectedRowIndex].Qty;

            //then put the value back into the list
            invItems[selectedRowIndex].Qty = updatedQty;

            // return the list
            return invItems;
        }
    }
}
