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
    public partial class KiTAPLAR : Form
    {
        public KiTAPLAR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            konular fr3 = new konular();
            fr3.Show();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
