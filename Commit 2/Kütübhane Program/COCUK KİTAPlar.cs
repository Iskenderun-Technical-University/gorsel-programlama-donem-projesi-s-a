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

        private void ÇOCUK_KİTAPLARI_VisibleChanged(object sender, EventArgs e)
        {
            label19.Text = Program.adet.ToString();
        }

        private void btındon_Click(object sender, EventArgs e)
        {
            Program.cocukkitap.Hide();
        }

        // Kitap 1 Sayac 
        public int[] a = { 0, 0, 0, 0 };

        private void button4_Click(object sender, EventArgs e)
        {
            a[0]++;
            label15.Text = a[0].ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if(a[0] > 0)
            {
                a[0]--;
                label15.Text = a[0].ToString();
            }
        }

        // Kitap 2 Sayac 
        private void button2_Click(object sender, EventArgs e)
        {
            a[1]++;
            label16.Text = a[1].ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (a[1] > 0)
            {
                a[1]--;
                label16.Text = a[1].ToString();
            }
        }

        // Kitap 3 Sayac
        private void button6_Click(object sender, EventArgs e)
        {
            a[2]++;
            label17.Text = a[2].ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (a[2] > 0)
            {
                a[2]--;
                label17.Text = a[2].ToString();
            }
        }

        // Kitap 4 Sayac
        private void button8_Click(object sender, EventArgs e)
        {
            a[3]++;
            label18.Text = a[3].ToString();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (a[3] > 0)
            {
                a[3]--;
                label18.Text = a[3].ToString();
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Program.adet += Int32.Parse(label15.Text);
            label19.Text = Program.adet.ToString();
            a[0] = 0;
            label15.Text = a[0].ToString();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            Program.adet += Int32.Parse(label16.Text);
            label19.Text = Program.adet.ToString();
            a[1] = 0;
            label16.Text = a[1].ToString();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Program.adet += Int32.Parse(label17.Text);
            label19.Text = Program.adet.ToString();
            a[2] = 0;
            label17.Text = a[2].ToString();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            Program.adet += Int32.Parse(label18.Text);
            label19.Text = Program.adet.ToString();
            a[3] = 0;
            label18.Text = a[3].ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Program.sepete.Show();
        }
    }
}
