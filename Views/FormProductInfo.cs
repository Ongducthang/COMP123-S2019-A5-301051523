using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// ===============================
// AUTHOR       : Duc-Thang ONG
// CREATE DATE  : 31-Jul-2019
// PURPOSE      : This is Product Info Form showing selected computer from the Select Form
// ===============================
namespace COMP123_S2019_A5_301051523.Views
{
    public partial class FormProductInfo : Form
    {
        public FormProductInfo()
        {
            InitializeComponent();
        }

        //Event handler to load data from selected computer in previous form
         private void FormProductInfo_Activated(object sender, EventArgs e)
        {
            var product = Program.product;
            LabelProductIDData.Text = product.productID.ToString();
            LabelConditionData.Text = product.condition;
            LabelCostData.Text = product.cost.ToString();
            //Product Info
            LabelPlatformData.Text = product.platform;
            LabelBrandData.Text = product.manufacturer;
            LabelOSData.Text = product.OS;
            LabelModelData.Text = product.model;
            //Tech specs
            LabelRAMData.Text = product.RAM_size;
            LabelHDDData.Text = product.HDD_size;
            LabelCPUBrandData.Text = product.CPU_brand;
            LabelCPUNumberData.Text = product.CPU_number;
            LabelCPUTypeData.Text = product.CPU_type;
            LabelCPUSpeedData.Text = product.CPU_speed;
            LabelGPUTypeData.Text = product.GPU_Type;
        }

        /// <summary>
        /// Event handler for OpenToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //configure the file dialog
            OpenFileDialogProductInfo.FileName = "ProductInfo.txt";
            OpenFileDialogProductInfo.InitialDirectory = Directory.GetCurrentDirectory();
            OpenFileDialogProductInfo.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            //open the file dialog
            var result = OpenFileDialogProductInfo.ShowDialog();

            if (result != DialogResult.Cancel)
            {   //Open the stream for reading
                using (StreamReader inputStream = new StreamReader(File.Open(OpenFileDialogProductInfo.FileName, FileMode.Open)))
                    try

                    {
                        var product = Program.product;
                        //Read from the file
                        (product.productID) = short.Parse(inputStream.ReadLine());
                        (product.condition) = inputStream.ReadLine();
                        (product.cost) = decimal.Parse(inputStream.ReadLine());
                        //Product Info
                        (product.platform) = inputStream.ReadLine();
                        (product.manufacturer) = inputStream.ReadLine();
                        (product.OS) = inputStream.ReadLine();
                        (product.model) = inputStream.ReadLine();
                        //Tech Specs
                        (product.RAM_size) = inputStream.ReadLine();
                        (product.HDD_size) = inputStream.ReadLine();
                        (product.CPU_brand) = inputStream.ReadLine();
                        (product.CPU_number) = inputStream.ReadLine();
                        (product.CPU_type) = inputStream.ReadLine();
                        (product.CPU_speed) = inputStream.ReadLine();
                        (product.GPU_Type) = inputStream.ReadLine();
                        //Clean up
                        inputStream.Close();
                        inputStream.Dispose();
                        ButtonNext_Click(sender ,e);
                    }

                    catch (IOException exception)
                    {
                        Debug.WriteLine("Error: " + exception.Message);
                        MessageBox.Show("Error: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

            }

        }

        /// <summary>
        /// Event handler for SaveToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //configure the file dialog
            SaveFileDialogProductInfo.FileName = "ProductInfo.txt";
            SaveFileDialogProductInfo.InitialDirectory = Directory.GetCurrentDirectory();
            SaveFileDialogProductInfo.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            //open the file dialog
            var result = SaveFileDialogProductInfo.ShowDialog();

            //save the file
            if (result != DialogResult.Cancel)
            {
                var product = Program.product;
                using (StreamWriter outputStream = new StreamWriter(File.Open(SaveFileDialogProductInfo.FileName,FileMode.Create)))
                {
                    outputStream.WriteLine(product.productID);
                    outputStream.WriteLine(product.condition);
                    outputStream.WriteLine(product.cost);
                    //Product info
                    outputStream.WriteLine(product.platform);
                    outputStream.WriteLine(product.manufacturer);
                    outputStream.WriteLine(product.OS);
                    outputStream.WriteLine(product.model);
                    //Tech specs
                    outputStream.WriteLine(product.RAM_size);
                    outputStream.WriteLine(product.HDD_size);
                    outputStream.WriteLine(product.CPU_brand);
                    outputStream.WriteLine(product.CPU_number);
                    outputStream.WriteLine(product.CPU_type);
                    outputStream.WriteLine(product.CPU_speed);
                    outputStream.WriteLine(product.GPU_Type);

                    //Clean up
                    outputStream.Close();
                    outputStream.Dispose();
                }
            }

            
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
        /// this is the event handler when ButtonNext clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.formOrder.Show();
        }

        /// <summary>
        /// This is event handler for Next Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSelectAnotherProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.formSelect.Show();
        }
    }
}
