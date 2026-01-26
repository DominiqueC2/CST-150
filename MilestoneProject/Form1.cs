/*
 * Dominique Canada
 * CST-150
 * 01/25/2026
 * Milestone 3
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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


        // Displays inventory loaded from the text file when the button is clicked
        private void BtnDisplayInt_Click(object sender, EventArgs e)
        {
            string[] description = new string[10];
            int[] quantity = new int[10];
            decimal[] costs = new decimal[10];
            string[] itemTypes = new string[10];
            string[] rarity = new string[10];

            string filePath = @"Data\Inventory.txt";

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    int index = 0;
                    string line;

                    while ((line = reader.ReadLine()) != null && index < 10)
                    {
                        string[] parts = line.Split(',');

                        description[index] = parts[0];
                        quantity[index] = int.Parse(parts[1]);
                        costs[index] = decimal.Parse(parts[2]);
                        itemTypes[index] = parts[3];
                        rarity[index] = parts[4];

                        index++;
                    }
                }



                quantity[0]++;

                lblDesc1.Text = description[0];
                lblQty1.Text = quantity[0].ToString();
                lblCost1.Text = "$" + costs[0].ToString("0.00");
                lblType1.Text = itemTypes[0];
                lblRar1.Text = rarity[0];

                lblDesc2.Text = description[1];
                lblQty2.Text = quantity[1].ToString();
                lblCost2.Text = "$" + costs[1].ToString("0.00");
                lblType2.Text = itemTypes[1];
                lblRar2.Text = rarity[1];

                lblDesc3.Text = description[2];
                lblQty3.Text = quantity[2].ToString();
                lblCost3.Text = "$" + costs[2].ToString("0.00");
                lblType3.Text = itemTypes[2];
                lblRar3.Text = rarity[2];

                lblDesc4.Text = description[3];
                lblQty4.Text = quantity[3].ToString();
                lblCost4.Text = "$" + costs[3].ToString("0.00");
                lblType4.Text = itemTypes[3];
                lblRar4.Text = rarity[3];

                lblDesc5.Text = description[4];
                lblQty5.Text = quantity[4].ToString();
                lblCost5.Text = "$" + costs[4].ToString("0.00");
                lblType5.Text = itemTypes[4];
                lblRar5.Text = rarity[4];

                lblDesc6.Text = description[5];
                lblQty6.Text = quantity[5].ToString();
                lblCost6.Text = "$" + costs[5].ToString("0.00");
                lblType6.Text = itemTypes[5];
                lblRar6.Text = rarity[5];

                lblDesc7.Text = description[6];
                lblQty7.Text = quantity[6].ToString();
                lblCost7.Text = "$" + costs[6].ToString("0.00");
                lblType7.Text = itemTypes[6];
                lblRar7.Text = rarity[6];

                lblDesc8.Text = description[7];
                lblQty8.Text = quantity[7].ToString();
                lblCost8.Text = "$" + costs[7].ToString("0.00");
                lblType8.Text = itemTypes[7];
                lblRar8.Text = rarity[7];

                lblDesc9.Text = description[8];
                lblQty9.Text = quantity[8].ToString();
                lblCost9.Text = "$" + costs[8].ToString("0.00");
                lblType9.Text = itemTypes[8];
                lblRar9.Text = rarity[8];

                lblDesc10.Text = description[9];
                lblQty10.Text = quantity[9].ToString();
                lblCost10.Text = "$" + costs[9].ToString("0.00");
                lblType10.Text = itemTypes[9];
                lblRar10.Text = rarity[9];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory file.");
            }
        }
    }
}
