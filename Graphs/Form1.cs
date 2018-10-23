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
    public partial class Form1 : Form
    {
        string path;
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        FrmError frmError = new FrmError();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (fbd.SelectedPath.IndexOf("txt") != -1)
                {
                    path = fbd.SelectedPath;
                }
                else frmError.ShowDialog();
            }
        }
    }
}
