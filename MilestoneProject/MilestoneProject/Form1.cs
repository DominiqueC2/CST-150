/*
 * Dominique Canada
 * CST-150
 * 01/20/2026
 * Milestone 2
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilestoneProject
{
    public partial class AdventureShop : Form
    {
        public AdventureShop()
        {
            InitializeComponent();
        }


        // Displays the hard-coded inventory when the button is clicked
        private void BtnDisplayInt_Click(object sender, EventArgs e)
        {
            lblDesc1.Text = "Health Potion";
            lblQty1.Text = "10";
            lblCost1.Text = "$5.00";
            lblType1.Text = "Potion";
            lblRar1.Text = "Common";

            lblDesc2.Text = "Mana Potion";
            lblQty2.Text = "8";
            lblCost2.Text = "$6.00";
            lblType2.Text = "Potion";
            lblRar2.Text = "Common";

            lblDesc3.Text = "Iron Sword";
            lblQty3.Text = "3";
            lblCost3.Text = "$25.00";
            lblType3.Text = "Weapon";
            lblRar3.Text = "Uncommon";

            lblDesc4.Text = "Helmet";
            lblQty4.Text = "5";
            lblCost4.Text = "$20.00";
            lblType4.Text = "Armor";
            lblRar4.Text = "Common";

            lblDesc5.Text = "Chainmail";
            lblQty5.Text = "4";
            lblCost5.Text = "$15.00";
            lblType5.Text = "Armor";
            lblRar5.Text = "Uncommon";

            lblDesc6.Text = "Chocolate Cake";
            lblQty6.Text = "7";
            lblCost6.Text = "$35.00";
            lblType6.Text = "Food";
            lblRar6.Text = "Epic";

            lblDesc7.Text = "Easter Egg";
            lblQty7.Text = "3";
            lblCost7.Text = "$5.00";
            lblType7.Text = "Food";
            lblRar7.Text = "Rare";

            lblDesc8.Text = "Diamond Hoe";
            lblQty8.Text = "3";
            lblCost8.Text = "$100.00";
            lblType8.Text = "Tool";
            lblRar8.Text = "Epic";

            lblDesc9.Text = "Netherite Pickaxe";
            lblQty9.Text = "2";
            lblCost9.Text = "$75.00";
            lblType9.Text = "Tool";
            lblRar9.Text = "Legendary";

            lblDesc10.Text = "Holy Bible";
            lblQty10.Text = "9";
            lblCost10.Text = "$10.00";
            lblType10.Text = "Weapon";
            lblRar10.Text = "Legendary";



        }
    }
}
