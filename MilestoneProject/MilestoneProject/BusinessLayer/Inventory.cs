using MilestoneProject.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MilestoneProject.BusinessLayer
{
    internal class Inventory
    {
        public List<InvItem> items = new List<InvItem>();


        private string filePath = @"Data\Inventory.txt";


        //A constructor runs automatically
        public Inventory()
        {
            LoadInventoryFromFile();
        }

        public void LoadInventoryFromFile()
        {
            items.Clear();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length == 5)
                    {
                        string desc = parts[0].Trim();
                        int qty = int.Parse(parts[1].Trim());
                        decimal cost = decimal.Parse(parts[2].Trim());
                        string type = parts[3].Trim();
                        string rarity = parts[4].Trim();

                        items.Add(new InvItem(desc, qty, cost, type, rarity));
                    }
                }
            }
        }


        /// <summary>
        ///  increases the inventory quantity
        /// </summary>
        /// <param name="selectedindex"></param>
        public void IncrementInventory(int selectedindex)
        {
            if (selectedindex >= 0 && selectedindex < items.Count)
            {
                items[selectedindex].Quantity++; 
            }

        }

        /// <summary>
        /// Decrease the Inventory quantity
        /// </summary>
        /// <param name="selectedindex"></param>
        public void DecrementInventory(int selectedindex)
        {
            if (selectedindex >= 0 && selectedindex < items.Count && items[selectedindex].Quantity > 0)
            {
                items[selectedindex].Quantity--;
            } 
        }


        /// <summary>
        /// updated inventory file 
        /// </summary>
        public void SaveInventoryToFile()
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (InvItem item in items)
                {
                    writer.WriteLine($"{item.Description},{item.Quantity},{item.Cost},{item.Type},{item.Rarity}");
                }
            }
        }

        /// <summary>
        /// Add item to the list
        /// </summary>
        /// <param name="desc"></param>
        /// <param name="qty"></param>
        /// <param name="cost"></param>
        /// <param name="type"></param>
        /// <param name="rarity"></param>
        public void AddItem(string desc, int qty, decimal cost, string type, string rarity)
        {
            items.Add(new InvItem(desc, qty, cost, desc, rarity));
            SaveInventoryToFile(); 
        }

        /// <summary>
        /// Delete selected item
        /// </summary>
        /// <param name="index"></param>
        public void DeleteItem(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                items.RemoveAt(index);
                SaveInventoryToFile();
            }
        }

    }
}


