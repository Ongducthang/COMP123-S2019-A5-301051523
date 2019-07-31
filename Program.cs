using COMP123_S2019_A5_301051523.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_A5_301051523
{
    public static class Program
    {
        public static FormOrder formOrder;
        public static FormSelect formSelect;
        public static FormStart formStart;
        public static FormAbout formAbout;
        public static FormSplash formSplash;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            formOrder = new FormOrder();
            formSelect = new FormSelect();
            formSelect = new FormSelect();
            formAbout = new FormAbout();
            formSplash = new FormSplash();
            Application.Run(formSelect);
        }
    }
}
