// ===============================
// AUTHOR       : Duc-Thang ONG
// CREATE DATE  : 31-Jul-2019
// PURPOSE      : Multi-form project for purchasing computers
// ===============================
// Change History: 
// 31-07: Created forms
// 01-08: Created Timer for Form splash as welcome page
// 02-08: Created form transition buttons and their function
//==================================
using COMP123_S2019_A5_301051523.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP123_S2019_A5_301051523.Models;
using System.Windows.Forms;

namespace COMP123_S2019_A5_301051523
{
    public static class Program
    {
        public static FormOrder formOrder;
        public static FormSelect formSelect;
        public static FormProductInfo formProductInfo;
        public static FormStart formStart;
        public static FormAbout formAbout;
        public static FormSplash formSplash;
        public static Product product;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            formOrder = new FormOrder();
            formSelect = new FormSelect();
            formProductInfo = new FormProductInfo();
            formStart = new FormStart();
            formAbout = new FormAbout();
            formSplash = new FormSplash();
            product = new Product();
            Application.Run(formSplash);
        }
    }
}
