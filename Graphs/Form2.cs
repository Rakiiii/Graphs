using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphs
{
    public partial class FrmError : Form
    {
        public FrmError()
        {
            InitializeComponent();
            lblError.Text = "Error" +
                "Choose txt file";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
