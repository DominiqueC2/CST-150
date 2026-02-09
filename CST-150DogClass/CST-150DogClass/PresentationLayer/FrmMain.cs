/*
 * Dominique Canada
 * CST-150
 * Activity 5
 * 02/06/2026
 */
using CST_150DogClass.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CST_150DogClass.PresentationLayer
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            //error label not visible
            lblErrorMessage.Visible = false;
        }

        private void BtnAddNewDog_ClickEvent(object sender, EventArgs e)
        {
            // Declare & Initialize
            // Flag that tracks if all entries are valid
            bool isValidEntries = true;
            double weight = 0.00D, neckRad = 0.00D, neckCircum = 0.00D;
            //Flags to verify parsing doubbles is true or false
            bool isValid = false;

            //Make sure the error label is not visible
            lblErrorMessage.Visible = false;

            //Instantiate our Uility class so we can use it
            Utility utility = new Utility();

            //-------------------------------------------------
            //Verify all boxes have correct inputs
            //We will be using a uility / Heleper Class to verify inputs
            if (!utility.NotNull(txtName.Text) || !utility.NotNull(txtColor.Text) || (cmbSit.SelectedItem == null))
            {
                isValidEntries = false;
            }
            // now test the text box for valid double nrck size
            (neckRad, isValid) = utility.ValidDouble(txtNeck.Text);
            if (!isValid)
            {
                isValidEntries = false;
            }
            // now test the weight
            (weight, isValid) = utility.ValidDouble(txtWeight.Text);
            if (!isValid) 
            {
                isValidEntries = false;
            }

            //-------------------------------------------------
            // datagrid view with the entry
            // Else display error message.
            if (isValidEntries)
            {
                // If we are here we know we have valid entries
                // so lets populate the datagridview
                Dog dogObject = new Dog(txtName.Text, neckRad, txtColor.Text, weight, utility.ConvertToBool(cmbSit.Text));
                gvShowDogs.Rows.Add(dogObject.Name, dogObject.CalCircumference(), dogObject.Sit, dogObject.CalWeight(), dogObject.Color);

            }
            else
            {
                //If we are here there is a problem with an entry
                //Show the error message
                lblErrorMessage.Visible = true;
            }



            // How do read from cmbbox
            var combobox = cmbSit.SelectedItem;

            //Test our class
            //Instantiate the dog class
            Dog ginger = new Dog("Ginger", 12.24, "Golden Cream", 57.25, false);

            var name = ginger.Name;
            var color = ginger.Color;
        }

        /// <summary>
        /// When the frm lads execute this event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMainLoadEventHandler(object sender, EventArgs e)
        {
            // Set the number of rows to 5 and configure each row
            gvShowDogs.ColumnCount = 5;
            gvShowDogs.Columns[0].Name = "Name";
            gvShowDogs.Columns[1].Name = "Neck Circum";
            gvShowDogs.Columns[2].Name = "Sitting";
            gvShowDogs.Columns[3].Name = "Weight";
            gvShowDogs.Columns[4].Name = "Color";

            // Format number in neck & weight for 2 decimals
            gvShowDogs.Columns[1].DefaultCellStyle.Format = "#.00";
            gvShowDogs.Columns[3].DefaultCellStyle.Format = "#.00";
        }
    }
}
