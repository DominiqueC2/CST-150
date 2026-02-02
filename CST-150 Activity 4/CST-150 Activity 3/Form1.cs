/*
 * Dominique Canada
 * CST-150
 * Activity 4
 * 01/31/2026
 */
namespace CST_150_Activity_3
{
    public partial class FrmMain : Form
    {
        // Declare & Initialize
        // clas level Variable Scope
        string[] lines; //Only declare the array
        string txtFile = "";





        /// <summary>
        /// Class Constructor
        /// this method is the first method to get invoked
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
            //Set the properties
            //Define the intital directroy
            selectFileDialog.InitialDirectory = Application.StartupPath + @"Data";
            //set the title 
            selectFileDialog.Title = "Browse Txt Files";
            //DefaultExt is only used when "All files" 
            //from the filter box
            //by the user
            selectFileDialog.DefaultExt = "txt";
            selectFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            //when the form is initialized
            // and lblSelectedFile are not visible
            lblResults.Visible = false;
            lblSelectedFile.Visible = false;

            // Makesure the combobox is not visible
            cmbSelectRow.Visible = false;
            lblSelectRow.Visible = false;
        }

        /// <summary>
        /// Click event Handler to read the file 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReadFile_Click(object sender, EventArgs e)
        {
            // declare and initialize
            string dirLocation = "";
            
            // use this int to dynamically populate the combobox
            int numberRows = 1;

            //once the buttton is click
            if (this.selectFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Read in the text file
                txtFile = this.selectFileDialog.FileName;
                //show the selected file
                dirLocation = Path.GetFullPath(selectFileDialog.FileName);
                // Show the selected file and path
                lblSelectedFile.Text = txtFile;
                lblSelectedFile.Visible = true;

                //Read all the lines
                lines = File.ReadAllLines(txtFile);

                //populate a label
                //make sure the label is cleared
                lblResults.Text = "";
                // Display the Header
                DisplayHeader();

                //Make sure to clear out combobox
                cmbSelectRow.Items.Clear();

                foreach (string line in lines)
                {
                    // Dynamically Populate the combobox
                    cmbSelectRow.Items.Add(numberRows);
                    //Inc to next row
                    numberRows++;

                    //split each line
                    string[] inventoryList = line.Split(", ");
                    //Iterate through each element
                    // using a for loop instea
                    for (int i = 0; i < inventoryList.Length; i++)
                    {
                        //Call the method to convert to lowercase
                        ConvertLowerCase(inventoryList[i]);
                    }
                    //need a new line 
                    lblResults.Text += "\n";
                }
                //male sure label is visible
                lblResults.Visible = true;
                // Since the combobox is populated turn visible to true
                cmbSelectRow.Visible = true;
                lblSelectRow.Visible = true;
            }


        }
        //-----------------------------------------------------------------------
        // first Method
        //-----------------------------------------------------------------------

        /// <summary>
        /// Convert input string to all lower case characters
        /// Then send the results to be displayed
        /// </summary>
        /// <param name="textToConvert"></param>

        private void ConvertLowerCase(string textToConvert)
        {
            // Convert all text to lowercase
            ResultsToLabel(textToConvert.ToLower());
        }

        ///<summary>
        /// Print results to label
        /// </summary>
        /// <param name="Results"></param>
        /// 
        private void ResultsToLabel(string results)
        {
            // declare and initialize constant
            const int Padspace = 20;
            // display each element using proper spcing
            lblResults.Text += results.PadRight(Padspace);
        }

       /// <summary>
       /// When the ComboBox drop down closes trigger this method
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void SelectRowToInc(object sender, EventArgs e)
        {
            // Declare & Initialize
            int rowSelected = -1;
            int qtyValue = -1;

            // Get the selected index of the combobox
            //-1 means no value was seleted
            rowSelected = cmbSelectRow.SelectedIndex;

            // Only inc a qty if a row was selected
            if (rowSelected >= 0) 
            {
                // get the qty
                qtyValue = GetQty(lines, rowSelected);

                // now we can inc the qty and store it back to the file
                IncDisplayQty(lines, rowSelected, qtyValue, txtFile);
                DisplayedInv();


            }

        }

        private int GetQty(string[] lines, int selectedRow) 
        {
            // Declare & Initialize
            int qty = -1; // this way we know if there was an error
            // iterate through the array until the selected row is ound
            //since we know the exact number of times to iterate through the arry
            // Which loop is the best one to use?
            for (int x = 0; x < lines.Length; x++) 
            {
                // now only pull out the row
                if (x == selectedRow) 
                {
                    string[] invRow = lines[x].Split(", ");
                    // Now pull out the qty
                    // use exception handling to parse string to int
                    try 
                    { 
                        //Convert sring represention
                        //signed integer
                        qty = int.Parse(invRow[2].Trim());
                        return qty;
                    }
                    catch (FormatException e)
                    {
                        // show an exception message
                        lblResults.Text = e.Message;
                    }
                
                }
            
            }
            // If there any exceptions return -1
            return qty;

        }

        /// <summary>
        /// Inc qty value, build the string for file, save to file
        /// </summary>
        /// <param name="lines"></param>
        /// <param name="invRowToUpdate"></param>
        /// <param name="qty"></param>
        /// <param name="txtFile"></param>
        private void IncDisplayQty(string[] lines, int invRowToUpdate, int qty, string txtFile)
        {
            // Declare & Initialize
            string updateLine = "";

            // first inc qty
            qty++;

            //now we need to update the qty in the array
            // first e need to split up the row
            string[] invRow = lines[invRowToUpdate].Split(",");
            // then we can update the element int array
            invRow[2] = qty.ToString();
            // we need to build the string to store the lines array
            updateLine = invRow[0].Trim() + ", " + invRow[1].Trim() + ", " + invRow[2].Trim();
            // Now udate the line array
            lines[invRowToUpdate] = updateLine;
            // no update the text file
            File.WriteAllLines(txtFile, lines);

        }

        /// <summary>
        /// display the entire inventory
        /// </summary>
        private void DisplayedInv() 
        {
            // first to clear out the label
            lblResults.Text = "";
            //then display header
            DisplayHeader();
            //iterate through the inventory
            foreach (string line in lines) 
            {
                // split each line into an array of elements
                string[] inventoryList = line.Split(", ");
                //lterate through each element in the array
                // using a for loop instead of foreach loop
                for (int i = 0; i < inventoryList.Length; i++) 
                {
                    // send to display
                    ResultsToLabel(inventoryList[i]);
                }
                // need a new line after each Iteration to show next line
                lblResults.Text += "\n";
            }
        }

        /// <summary>
        /// Display inventory header
        /// </summary>
        private void DisplayHeader() 
        {
            const int PadSpace = 20;
            string header1 = "Type", header2 = "Color", header3 = "QTY";
            string headerLine1 = "----", headerLine2 = "-----", headerLine3 = "---";

            // Add in header
            lblResults.Text = string.Format("{0}{1}{2}\n", header1.PadRight(PadSpace), header2.PadRight(PadSpace), header3.PadRight(PadSpace));
            lblResults.Text += string.Format("{0}{1}{2}\n", headerLine1.PadRight(PadSpace), headerLine2.PadRight(PadSpace), headerLine3.PadRight(PadSpace));
        }
    }
}
