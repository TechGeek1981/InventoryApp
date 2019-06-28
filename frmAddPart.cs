using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class frmAddMod : Form
    {
        public frmAddMod()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddPart_Load(object sender, EventArgs e)
        {
            // Set Form text on load
            this.Text = "Acme Inventory - Add / Modify Parts";


        }

        private void RdoOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOutsourced.Checked == true)
            {
                txtCompanyName.Enabled = true;
            }
            else
            {
                txtCompanyName.Enabled = false;
            }
        }

        private void RdoInHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoInHouse.Checked == true)
            {
                txtID.Enabled = true;
            }
            else
            {
                txtID.Enabled = false;
            }
        }
    }
}
