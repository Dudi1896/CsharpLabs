﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is a Message Box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void goTeam_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Good Bye");
        }
    }
}
