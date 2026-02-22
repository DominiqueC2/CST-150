/*
 * Dominique Canada
 * CST-150
 * 02/15/2026
 * Milestone 6
 */
using MilestoneProject.BusinessLayer;
using MilestoneProject.Models;
using MilestoneProject.PresentationLayer;
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


        private void AdventureShop_Load(object sender, EventArgs e)
        {
            //sorting optio in the dropdown menu
            cmbSort.Items.Add("A-Z");
            cmbSort.Items.Add("Z-A");
            cmbSort.Items.Add("Qty Low to High");
            cmbSort.Items.Add("Qty High to Low");

        }

        // Displays inventory loaded from the text file when the button is clicked
        private void BtnDisplayInt_Click(object sender, EventArgs e)
        {

            shopInventory.LoadInventoryFromFile();

            // refresh grid
            RefreshGrid();
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

            // refresh grid
            RefreshGrid();
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
                RefreshGrid();

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
                RefreshGrid();
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

            // refresh grid
            RefreshGrid();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string name = txtSearch.Text;

            var results = shopInventory.SearchItems(name);

            FrmResults resultsForm = new FrmResults(results);
            resultsForm.Show();
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSort = cmbSort.SelectedItem.ToString();

            var sortedList = shopInventory.SortItems(selectedSort);

            gvInventory.DataSource = null;
            gvInventory.DataSource = sortedList;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvInventory.CurrentCell == null)
            {
                MessageBox.Show("Please select an item to edit.");
                return;
            }

            try
            {
                InvItem selectedItem = (InvItem)gvInventory.CurrentRow.DataBoundItem;

                selectedItem.Description = edDesc.Text;
                selectedItem.Quantity = int.Parse(edQty.Text);
                selectedItem.Cost = decimal.Parse(edCost.Text);
                selectedItem.Type = edType.Text;
                selectedItem.Rarity = edRarity.Text;

                shopInventory.SaveInventoryToFile();

                RefreshGrid();

                edDesc.Clear();
                edQty.Clear();
                edCost.Clear();
                edType.Clear();
                edRarity.Clear();
            }
            catch
            {
                MessageBox.Show("Enter valid values for Quantity and Cost.");
            }
        }

        private void gvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                edDesc.Text = gvInventory.Rows[e.RowIndex].Cells[0].Value.ToString();
                edQty.Text = gvInventory.Rows[e.RowIndex].Cells[1].Value.ToString();
                edCost.Text = gvInventory.Rows[e.RowIndex].Cells[2].Value.ToString();
                edType.Text = gvInventory.Rows[e.RowIndex].Cells[3].Value.ToString();
                edRarity.Text = gvInventory.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }
        private void RefreshGrid()
        {
            gvInventory.DataSource = null;
            gvInventory.DataSource = shopInventory.items;

            if (gvInventory.Columns["Cost"] != null)
            {
                gvInventory.Columns["Cost"].DefaultCellStyle.Format = "C2";
            }

        }

    }
}
