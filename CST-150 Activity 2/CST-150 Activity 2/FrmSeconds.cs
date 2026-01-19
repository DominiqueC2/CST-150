/*
 * Dominique Canada
 * CST-150 
 * Activity 2
 * 01/16/2026
 * Converts seconds into minutes, hours, or days.
*/
namespace CST_150_Activity_2
{
    /// <summary>
    /// Constructor
    /// </summary>
    public partial class FrmSeconds : Form
    {
        public FrmSeconds()
        {
            InitializeComponent();
            // Make sure the label is notvisible
            lblResults.Visible = false;
        }

        /// <summary>
        /// Event Handler to Evaluate Seconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManageSecondsEventHandler(object sender, EventArgs e)
        {
            //Declare and Intialize
            int seconds = 0;     //Declare the value user entered in seconds
            // Working with Constants in C#
            const int SecondsInMinutes = 60;
            const int SecondsInHours = 3600;
            const int SecondsInDays = 86400;
            // Define flags

            // Make sure the label is not visible
            lblResults.Visible = false;
            lblResults.ForeColor = Color.Black;

            // Test to determine if integer was entered correctly by user
            // if try to parse string to int is successful contine else show message to user
            if (int.TryParse(txtUserEntry.Text, out seconds))
            {
                if (seconds >= SecondsInMinutes)
                {
                    //
                    //
                    lblResults.Text = string.Format("There are {0:#,#} minute(s) in {1:#,#} seconds.\n", seconds / SecondsInMinutes, seconds);
                    lblResults.Visible = true;
                }
                else
                {
                    lblResults.Text = "Please enter an integer larger than 59.";
                    lblResults.ForeColor = Color.Red;
                    lblResults.Visible = true;

                }
                if (seconds >= SecondsInHours)
                {
                    lblResults.Text += string.Format("There are {0:#,#} hours in {1:#,#} seconds.\n", seconds / SecondsInHours, seconds);

                    if (seconds >= SecondsInDays)
                    {
                        lblResults.Text += string.Format("There are {0:#,#} days in {1:#,#} seconds.\n", seconds / SecondsInDays, seconds);
                    }

                }
            }
            else
            {//This is the code block that be executed if the user did not put an int in
                lblResults.Text = "Please enter an int to continue...";
                lblResults.ForeColor = Color.Red;
                lblResults.Visible = true;
            }

        }
    }
}
