/*
 * Dominique Canada
 * CST-150
 * 02/15/2026
 * Milestone 6
 */
using MilestoneProject.BusinessLayer;
using MilestoneProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MilestoneProject
{
    public partial class AdventureShop : Form
    {
        Inventory shopInventory = new Inventory();


        public AdventureShop()
        {
            InitializeComponent();
        }


        string filePath = @"Data\Inventory.txt";


        // Displays inventory loaded from the text file when the button is clicked
        private void BtnDisplayInt_Click(object sender, EventArgs e)
        {
            if (gvInventory.Columns["Cost"] != null)
            {
                gvInventory.Columns["Cost"].DefaultCellStyle.Format = "C2";
            }
            shopInventory.LoadInventoryFromFile();

            //Doesn't generated blank columns
            //gvInventory.AutoGenerateColumns = false;
            gvInventory.DataSource = null;
            gvInventory.DataSource = shopInventory.items;

            if (gvInventory.Columns["Cost"] != null)
            {
                gvInventory.Columns["Cost"].DefaultCellStyle.Format = "C2";
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            // MAking sure user select a row
            if (gvInventory.CurrentCell == null)
            {
                MessageBox.Show("Please select an inventory item first.");
                return; 
            }

            int index = gvInventory.CurrentCell.RowIndex; 
            shopInventory.IncrementInventory(index);

            gvInventory.DataSource = null;
            gvInventory.DataSource = shopInventory.items;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // validation
                if (txtDesc.Text == "" || txtQty.Text == "" || txtCost.Text == ""
                    || txtType.Text == "" || txtRarity.Text == "")
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                string desc = txtDesc.Text;
                int qty = int.Parse(txtQty.Text);
                decimal cost = decimal.Parse(txtCost.Text);
                string type = txtType.Text;
                string rarity = txtRarity.Text;

                //Stop negative numbers
                if (qty < 0 || cost < 0)
                {
                    MessageBox.Show("Quantity and cost must be positive numbers.");
                    return;
                }

                // add item
                shopInventory.AddItem(desc, qty, cost, type, rarity);

                // refresh grid
                gvInventory.DataSource = null;
                gvInventory.DataSource = shopInventory.items;

                // clear boxes
                txtDesc.Clear();
                txtQty.Clear();
                txtCost.Clear();
                txtType.Clear();
                txtRarity.Clear();
            }
            catch
            {
                MessageBox.Show("Enter valid numbers for Quantity and Cost. \n(ex: Quantity: 5 \nCost: 67.00)");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvInventory.SelectedRows.Count > 0)
            {
                int rowIndex = gvInventory.SelectedRows[0].Index;

                shopInventory.DeleteItem(rowIndex);

                // refresh grid
                gvInventory.DataSource = null;
                gvInventory.DataSource = shopInventory.items;
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            // Making sure user select a row
            if (gvInventory.CurrentCell == null)
            {
                MessageBox.Show("Please select an inventory item first.");
                return; 
            }

            // get selected row
            int index = gvInventory.CurrentCell.RowIndex; 
            shopInventory.DecrementInventory(index);

            gvInventory.DataSource = null;
            gvInventory.DataSource = shopInventory.items;
        }
    }
}
