using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilestoneProject.Models
{
    internal class InvItem
    {
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Cost { get; set; }
        public string Type { get; set; }
        public string Rarity { get; set; }

        //Constructor
        public InvItem(string desc, int qty, decimal cost, string type, string rarity)
        {
            Description = desc;
            Quantity = qty;
            Cost = cost;
            Type = type;
            Rarity = rarity;
        }
    }
}

