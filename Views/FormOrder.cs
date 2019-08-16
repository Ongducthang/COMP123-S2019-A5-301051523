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
// ===============================
// AUTHOR       : Duc-Thang ONG
// CREATE DATE  : 31-Jul-2019
// PURPOSE      : This is Order Form for checking out selected computer 
// ===============================
namespace COMP123_S2019_A5_301051523
{
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler when Print Option choosen (to show message of printing)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printFormProduct.PrintAction = PrintAction.PrintToPreview;
            printFormProduct.Print();
            MessageBox.Show("Printing...");
        }

        /// <summary>
        /// This is the event handler when Exit option clicked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This is the event handler when About Option clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.formAbout.ShowDialog();
        }

        /// <summary>
        /// This is the load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormOrder_Activated(object sender, EventArgs e)
        {
            var product = Program.product;
            LabelPriceData.Text = $"{product.cost}";
            LabelTaxData.Text = $"{(product.cost)*(decimal).13}";
            LabelTotalData.Text = $"{product.cost*(decimal)1.13}";

            LabelPlatformData.Text = product.platform;
            LabelBrandData.Text = product.manufacturer;
            LabelConditionData.Text = product.condition;
            LabelModelData.Text = product.model;
            LabelOtherInfoData.Text = product.RAM_size + "\n\n" + product.HDD_size + "\r\r" +  product.CPU_brand + "\r\r" + product.CPU_number + "\r\r" + product.CPU_type + "\r\r" + product.CPU_speed + "\r\r" +  product.GPU_Type;
        }

        /// <summary>
        /// This is event handler when ButtonFinish clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFinish_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for your order! \rYour order will be processed in 7-10 business days","Merci!",MessageBoxButtons.OK);
            Application.Exit();
        }

        /// <summary>
        /// This is event handler when Button Back clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.formProductInfo.Show();
        }
        //
    }
}
