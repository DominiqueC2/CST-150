/*
 * Dominique Canada
 * CST-150
 * Activity 1
 * 01/10/2026
 */
namespace CST_150_Activity_1
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            // Hide the weight on mars labels
            lblMars.Visible = false;
            lblMarsWeight.Visible = false;
        }
        /// <summary>
        /// Click Event for Convert Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertButtonClickEvent(object sender, EventArgs e)
        {
            //Declare and Initialize
            decimal earthWeight = 0.0M;
            decimal finalValue = 0.0M;
            decimal gravAccEarth = 9.81M;
            decimal gravAccMars = 3.711M;

            // Read in the earth weight
            earthWeight = Convert.ToDecimal(txtEarthWeight.Text);
            
            //Calculate the final value
            finalValue = (earthWeight / gravAccEarth) * gravAccMars;

            //Display the results
            //use string.format to format the string and show only 2 decimal places.
            //This is a string argument
            lblMarsWeight.Text = string.Format("{0:.##} lbs", finalValue);

            //make sure to show the mars value and label
            lblMarsWeight.Visible = true;
            lblMars.Visible = true;


        }
    }
}
