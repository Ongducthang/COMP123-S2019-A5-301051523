using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_A5_301051523
{
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printFormProduct.PrintAction = PrintAction.PrintToPreview;
            printFormProduct.Print();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
