﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_A5_301051523.Views
{
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
        }

        private void TimerSplash_Tick(object sender, EventArgs e)
        {
            timerSplash.Enabled = false;
            Program.formStart.Show();
            this.Hide();
        }

        private void FormSplash_Load(object sender, EventArgs e)
        {
            timerSplash.Enabled = true;
        }
    }
}
