namespace CST_150Dice
{
    public partial class DiceSim : Form
    {

        public DiceSim()
        {
            InitializeComponent();
        }

        private void btnDiceRoll_Click(object sender, EventArgs e)
        {
            //Instantiate our Dice class
            Dice dice = new Dice();


            // Declare & Initialize
            int roll1 = dice.Roll();
            int roll2 = dice.Roll();


            // Show images for die 1
            diePic1.Image = Image.FromFile("Die" + roll1 + ".bmp");

            // Show images for die 2
            diePic2.Image = Image.FromFile("Die" + roll2 + ".bmp");
        }
    }
}
