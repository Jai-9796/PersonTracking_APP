using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonTracking
{
    public partial class PositionList : Form
    {
        public PositionList()
        {
            InitializeComponent();
        }

        private void txtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDelete_Click(object sender, EventArgs e)
        {

        }

        private void txtUpdate_Click(object sender, EventArgs e)
        {

        }

        private void txtAdd_Click(object sender, EventArgs e)
        {
            frmposition frmposition = new frmposition();
            this.Hide(); 
            frmposition.ShowDialog();
            this.Visible = true;    
        }
    }
}
