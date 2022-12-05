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
            Program.adet += Convert.ToInt32(label11.Text);
            label19.Text = Program.adet.ToString();
            bool found =false;
            int x, i;
            for ( i=0; i<Program.sepete.Grid.RowCount; i++)
            {
                if (Convert.ToInt32(Program.sepete.Grid[0, i].Value) == 1)
                {
                    found = true;
                    break;
                } 
            }
            if (found)
            {
                x = Convert.ToInt32(Program.sepete.Grid[3, i].Value);
                x += Convert.ToInt32(label11.Text);
                Program.sepete.Grid[3, i].Value = x;
                Program.sepete.Grid[4, i].Value = x * 45;
            }
            else
            {
                Program.sepete.Grid.Rows.Add(1, label1.Text, 45, Convert.ToInt32(label11.Text), Convert.ToInt32(label11.Text) * 45);
            }
            a[0] = 0;
            label11.Text = a[0].ToString();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Program.adet += Int32.Parse(label12.Text);
            label19.Text = Program.adet.ToString();

            Program.sepete.Grid.Rows.Add(2, label2.Text, 50, Int32.Parse(label12.Text), Int32.Parse(label12.Text) * 50);

            a[1] = 0;
            label12.Text = a[1].ToString();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            Program.adet += Int32.Parse(label15.Text);
            label19.Text = Program.adet.ToString();

            Program.sepete.Grid.Rows.Add(3, label5.Text, 64, Int32.Parse(label15.Text), Int32.Parse(label15.Text) * 45);

            a[2] = 0;
            label15.Text = a[2].ToString();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            Program.adet += Int32.Parse(label16.Text);
            label19.Text = Program.adet.ToString();

            Program.sepete.Grid.Rows.Add(4, label6.Text, 72, Int32.Parse(label16.Text), Int32.Parse(label16.Text) * 72);

            a[3] = 0;
            label16.Text = a[3].ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Program.sepete.Show();
        }
    }
}
