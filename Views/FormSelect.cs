using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_A5_301051523
{
    public partial class FormSelect : Form
    {
        public FormSelect()
        {
            InitializeComponent();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.formProductInfo.Show();
        }
    }
}
