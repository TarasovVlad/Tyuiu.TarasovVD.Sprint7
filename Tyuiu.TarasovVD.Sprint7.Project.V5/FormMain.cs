﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.TarasovVD.Sprint7.Project.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormInstrument formIns = new FormInstrument();
            formIns.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonHelp_TVD_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_TVD.ToolTipTitle = "Справка";
        }

        private void buttonInstrument_TVD_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_TVD.ToolTipTitle = "Перейти";
        }
    }
}
