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
    public partial class liste : Form
    {
        public liste()
        {
            InitializeComponent();
        }

        private void btnCik_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAna_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hfo = new Home();
            hfo.Show();
        }

        private void btnKitap_Click(object sender, EventArgs e)
        {

            this.Hide();
               
            KiTAPLAR frm2 = new KiTAPLAR();
            frm2.ShowDialog();
        }
    }
}
