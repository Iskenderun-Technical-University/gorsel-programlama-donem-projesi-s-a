﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütübhane_Program
{
    public partial class Tarih : Form
    {
        public Tarih()
        {
            InitializeComponent();
        }

        private void btındon_Click(object sender, EventArgs e)
        {
            this.Hide();
            liste f3 = new liste();
            f3.Show();
        }
    }
}
