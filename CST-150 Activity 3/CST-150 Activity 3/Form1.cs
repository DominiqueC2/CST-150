/*
 * Dominique Canada
 * CST-150
 * Activity 3
 * 01/24/2026
 */
namespace CST_150_Activity_3
{
    public partial class FrmMain : Form
    {
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
        }

        /// <summary>
        /// Click event Handler to read the file 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReadFile_Click(object sender, EventArgs e)
        {
            // declare and initialize
            string txtFile = "";
            string dirLocation = "";
            const int PadSpace = 20;
            string header1 = "Type", header2 = "Color", header3 = "QTY";
            string headerLine1 = "----", headerLine2 = "-----", headerLine3 = "---";

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
                string[] lines = File.ReadAllLines(txtFile);

                //populate a label
                //make sure the label is cleared
                lblResults.Text = "";
                //Add header
                lblResults.Text = string.Format("{0}{1}{2}\n", header1.PadRight(PadSpace), header2.PadRight(PadSpace), header3.PadRight(PadSpace));
                lblResults.Text += string.Format("{0}{1}{2}\n", headerLine1.PadRight(PadSpace), headerLine2.PadRight(PadSpace), headerLine3.PadRight(PadSpace));
                foreach (string line in lines)
                {
                    //split each line
                    string[] inventoryList = line.Split(", ");
                    //Iterate through each element
                    // using a for loop instea
                    for(int i = 0; i < inventoryList.Length; i++)
                    {
                        //Display each element
                        lblResults.Text += inventoryList[i].PadRight(PadSpace);
                    } 
                    //need a new line 
                    lblResults.Text += "\n";
                }
                //male sure label is visible
                lblResults.Visible = true;
            }


        }
    }
}
