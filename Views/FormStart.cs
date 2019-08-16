using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// ===============================
// AUTHOR       : Duc-Thang ONG
// CREATE DATE  : 31-Jul-2019
// PURPOSE      : This is StartForm showing options to go to other pages
// ===============================
namespace COMP123_S2019_A5_301051523.Views
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is event handler when ButtonToFormSelect clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonToFormSelect_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.formSelect.Show();
        }

        /// <summary>
        /// This is event handler when Button Product Info clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.formProductInfo.Show();
        }

        /// <summary>
        /// This is event handler when Button Quit clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
