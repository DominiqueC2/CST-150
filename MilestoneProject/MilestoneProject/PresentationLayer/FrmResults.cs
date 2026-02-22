using MilestoneProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilestoneProject.PresentationLayer
{
    public partial class FrmResults : Form
    {
        public FrmResults(List<InvItem> results)
        {
            InitializeComponent();
            gvResult.DataSource = results;

            // format cost column
            gvResult.Columns["Cost"].DefaultCellStyle.Format = "C2";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
