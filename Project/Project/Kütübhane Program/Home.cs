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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if(panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRom_Click(object sender, EventArgs e)
        {
            Program.romanlar.Show();
        }

        private void btncoc_Click(object sender, EventArgs e)
        {
            Program.cocukkitap.Show();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            Program.tarih.Show();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            Program.psikolojik.Show();
        }
    }
}
