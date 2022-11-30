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
    public partial class ROMANLAR : Form
    {
        public ROMANLAR()
        {
            InitializeComponent();
        }

        private void ROMANLAR_VisibleChanged(object sender, EventArgs e)
        {
            label19.Text = Program.adet.ToString();
        }

        private void btındon_Click(object sender, EventArgs e)
        {
            Program.romanlar.Hide();
        }

        // Kitap 1 Sayac 
        public int[] a = { 0, 0, 0, 0 };
        private void button1_Click_1(object sender, EventArgs e)
        {
            a[0]++;
            label11.Text = Convert.ToString(a[0]);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(a[0] > 0)
            {
                a[0]--;
                label11.Text = Convert.ToString(a[0]);
            }
        }

        // Kitap 2 Sayac 
        private void button4_Click(object sender, EventArgs e)
        {
            a[1]++;
            label12.Text = Convert.ToString(a[1]);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (a[1] > 0)
            {
                a[1]--;
                label12.Text = Convert.ToString(a[1]);
            }
        }

        // Kitap 3 Sayac
        private void button6_Click(object sender, EventArgs e)
        {
            a[2]++;
            label15.Text = Convert.ToString(a[2]);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (a[2] > 0)
            {
                a[2]--;
                label15.Text = Convert.ToString(a[2]);
            }
        }

        // Kitap 4 Sayac
        private void button8_Click(object sender, EventArgs e)
        {
            a[3]++;
            label16.Text = Convert.ToString(a[3]);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (a[3] > 0)
            {
                a[3]--;
                label16.Text = Convert.ToString(a[3]);
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Program.adet += Int32.Parse(label11.Text);
            label19.Text = Program.adet.ToString();
            a[0] = 0;
            label11.Text = a[0].ToString();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Program.adet += Int32.Parse(label12.Text);
            label19.Text = Program.adet.ToString();
            a[1] = 0;
            label12.Text = a[1].ToString();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            Program.adet += Int32.Parse(label15.Text);
            label19.Text = Program.adet.ToString();
            a[2] = 0;
            label15.Text = a[2].ToString();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            Program.adet += Int32.Parse(label16.Text);
            label19.Text = Program.adet.ToString();
            a[3] = 0;
            label16.Text = a[3].ToString();
        }
    }
}
