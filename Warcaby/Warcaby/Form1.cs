﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warcaby
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            ucMainMenu.Visible = true;
            ucNewGame.Visible = false;
            ucOptions.Visible = false;
        }
    }
}
