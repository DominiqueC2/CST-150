using CST_150_ListTogv.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CST_150_ListTogv
{
    public partial class FrmSecondary : Form
    {
        //class level list
        List<InvItem> mySearch = new List<InvItem>();

        /// <summary>
        /// Parameterized Constructor
        /// Since this class is public we have to
        /// make InvItems.cs a public class so
        /// </summary>
        /// <param name="invSearch"></param>
        public FrmSecondary(List<InvItem> invSearch)
        {
            InitializeComponent();
            this.mySearch = invSearch;
        }

        /// <summary>
        /// When the form is loaded populate the grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSecondary_Load(object sender, EventArgs e)
        {
            gvSearchResults.DataSource = this.mySearch;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Clase the Form
            this.Close();
        }
    }
}
