using System;
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
    public partial class ÇOCUK_KİTAPLARI : Form
    {
        public ÇOCUK_KİTAPLARI()
        {
            InitializeComponent();
        }

        private void btındon_Click(object sender, EventArgs e)
        {
            this.Hide();
            liste f1 = new liste();
            f1.Show();
        }
    }
}
