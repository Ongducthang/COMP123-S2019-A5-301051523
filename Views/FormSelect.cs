using COMP123_S2019_A5_301051523.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// ===============================
// AUTHOR       : Duc-Thang ONG
// CREATE DATE  : 31-Jul-2019
// PURPOSE      : This is Select Form showing computers retrieved from database
// ===============================
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
        /// <summary>
        /// This is the event handler when ButtonCancel clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is event handler when ButtonNext clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.formProductInfo.Show();
        }
        /// <summary>
        /// This is the load event to load data from local database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSelect_Load(object sender, EventArgs e)
        {
            using (var db = new DollarComputersContext())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();    
            }
        }
        /// <summary>
        /// this is event handler when row selected in the dataGridViewProduct
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewProduct_SelectionChanged(object sender, EventArgs e)
        {
            LabelYourSelectionData.Text = dataGridViewProductSelectedItem();
        }

        public string dataGridViewProductSelectedItem()
        {
            var rowIndex = dataGridViewProduct.CurrentCell.RowIndex;
            var currentRow = dataGridViewProduct.Rows[rowIndex];
            var cost = currentRow.Cells[1].Value.ToString();
            var manufacturer = currentRow.Cells[2].Value.ToString();
            var model = currentRow.Cells[3].Value.ToString();
            string outputString = $"{manufacturer} {model} ${cost:F2}";
            return outputString;
        }
    }
}
