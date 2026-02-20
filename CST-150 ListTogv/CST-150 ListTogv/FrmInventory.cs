using CST_150_ListTogv.BusinessLayer;
using CST_150_ListTogv.Models;


namespace CST_150_ListTogv
{
    public partial class FrmInventory : Form
    {
        //Create the class level object
        // This is called an inventory
        //This is our master inventory object that MUST
        // always contain the most update-to-date inventory
        List<InvItem> invItems = new List<InvItem>();
        // List that will hold all  items found for search
        List<InvItem> invSearch = new List<InvItem>();

        // Properties
        private int SelectedGridIndex { get; set; }

        public FrmInventory()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Populate the grid
        /// use this event handler
        /// control to list of Objects.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopulateGrid_LoadEventHandler(object sender, EventArgs e)
        {
            //Instantiate the business class and get all the inventory items
            // fom the text file.
            Inventory readInv = new Inventory();
            invItems = readInv.ReadInventory(invItems);

            // After the list has been populated, set the dataSource Property
            // of the DataGrid control to the list.
            gvInv.DataSource = null;
            gvInv.DataSource = invItems;

            //what if we do not
            // let's Iterate through the header
            // and change the header names.
            foreach (DataGridViewColumn column in gvInv.Columns)
            {
                //Switch statement to change header text
                // column.index start
                switch (column.Index)
                {
                    case 0:
                        column.HeaderText = "Bunny Type";
                        break;
                    case 1:
                        column.HeaderText = "Bunny Color";
                        break;
                    case 2:
                        column.HeaderText = "Quantity";
                        // Number Format with nothing to the right
                        column.DefaultCellStyle.Format = "N0";
                        // All numbers should be right
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    default:
                        // Show a messsage
                        MessageBox.Show("Invalid column was trying to be accessed!");
                        //C# requires a closing break
                        break;
                }
            }
        }

        /// <summary>
        /// Event handler to manage click events of Data Grid View 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView_ClickEventHandler(object sender, EventArgs e)
        {
            // Get the selected row
            SelectedGridIndex = gvInv.CurrentRow.Index;
            // Now we also know the index into the List
        }

        /// <summary>
        /// Event handler to manage button to increment Quantity
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnIncQty_ClickEventHandler(object sender, EventArgs e)
        {
            //Make sure the logic is not in presentation
            // inc qty in Inventory class
            // Instantiate the inventory class 
            Inventory incQty = new Inventory();
            // Invoke this method to inc qty 
            invItems = incQty.IncQtyValue(invItems, SelectedGridIndex);
            // Since the list 
            //refresh the data
            // Since we hav already bound the List
            gvInv.Refresh();
        }

        /// <summary>
        /// Delete an item from Inventory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //We already know the selected row which is the index
            // Make sure we remove the item from the master inventory
            invItems.RemoveAt(SelectedGridIndex);
            // We have to be careful when deleting item
            // will get n out of range exception since
            // is bound to the initial number of rows
            // therefore we can not just refresh the data grid view 
            // reset the datasource by clearing it out and setting it to null
            gvInv.DataSource = null;
            // laststep is to bind the new data back to the data grid
            gvInv.DataSource = invItems;
            // key--> nvItems still has the master inventory!!!!
        }

        /// <summary>
        /// Search Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Our goal is to read from the textbox and search the 
            // list in the type column for a match. if there is
            // a match or multiple matches then we show the match
            // in the gridview on the secondary form
            string searchFor = txtSearch.Text;
            // Since the searching is logic - we need to do this
            //in the business Layer
            Inventory businessLayer = new Inventory();
            // Search for the match and put result in the search list
            invSearch = businessLayer.SearchItem(invItems, invSearch, searchFor);
            // Send this invSearch over to the secondary form to be displayed
            // make sure to setup the secondary form now....
            FrmSecondary frmSecondary = new FrmSecondary(invSearch);
            // now to show the form
            // Notive .show() method
            // YOu can click on the parent form.
            // ShowDialog() shows the form modally ,
            // go to the parent form 
            frmSecondary.ShowDialog();

        }
    }
}
