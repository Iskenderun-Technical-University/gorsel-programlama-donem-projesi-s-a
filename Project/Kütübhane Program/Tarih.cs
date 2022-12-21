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
    public partial class Tarih : Form
    {
        public Tarih()
        {
            InitializeComponent();
        }

        private void btındon_Click(object sender, EventArgs e)
        {
            Program.tarih.Hide();
        }

        private void Tarih_VisibleChanged(object sender, EventArgs e)
        {
            label20.Text = Program.adet.ToString();
        }

        // Kitap 1 Sayac
        public int[] a = { 0, 0, 0, 0 };
        private void button4_Click(object sender, EventArgs e)
        {
            a[0]++;
            label16.Text = a[0].ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if(a[0] > 0)
            {
                a[0]--;
                label16.Text = a[0].ToString();
            }
        }

        // Kitap 2 Sayac
        private void button2_Click(object sender, EventArgs e)
        {
            a[1]++;
            label17.Text = a[1].ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (a[1] > 0)
            {
                a[1]--;
                label17.Text = a[1].ToString();
            }
        }

        // Kitap 3 Sayac
        private void button8_Click(object sender, EventArgs e)
        {
            a[2]++;
            label19.Text = a[2].ToString();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (a[2] > 0)
            {
                a[2]--;
                label19.Text = a[2].ToString();
            }
        }

        // Kitap 4 Sayac
        private void button6_Click(object sender, EventArgs e)
        {
            a[3]++;
            label18.Text = a[3].ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (a[3] > 0)
            {
                a[3]--;
                label18.Text = a[3].ToString();
            }
        }


        public string[] kitap;


        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            kitap = new string[5] { "1", label4.Text, "54", label16.Text, (54 * Convert.ToInt32(label16.Text)).ToString() };
            Program.adet += Int32.Parse(label16.Text);
            label20.Text = Program.adet.ToString();
            a[0] = 0;
            label16.Text = a[0].ToString();
            label22.Text = (Convert.ToInt32(label22.Text) + 1).ToString();
        }
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            kitap = new string[5] { "2", label3.Text, "62", label17.Text, (62 * Convert.ToInt32(label17.Text)).ToString() };
            Program.adet += Int32.Parse(label17.Text);
            label20.Text = Program.adet.ToString();
            a[0] = 0;
            label17.Text = a[0].ToString();
            label22.Text = (Convert.ToInt32(label22.Text) + 1).ToString();
        }
        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            kitap = new string[5] { "3", label6.Text, "65", label19.Text, (65 * Convert.ToInt32(label19.Text)).ToString() };
            Program.adet += Int32.Parse(label19.Text);
            label20.Text = Program.adet.ToString();
            a[0] = 0;
            label19.Text = a[0].ToString();
            label22.Text = (Convert.ToInt32(label22.Text) + 1).ToString();
        }
        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            kitap = new string[5] { "4", label8.Text, "60", label18.Text, (60 * Convert.ToInt32(label18.Text)).ToString() };
            Program.adet += Int32.Parse(label18.Text);
            label20.Text = Program.adet.ToString();
            a[0] = 0;
            label18.Text = a[0].ToString();
            label22.Text = (Convert.ToInt32(label22.Text) + 1).ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Program.sepete.Show();
        }

        private void label22_TextChanged(object sender, EventArgs e)
        {
            int i, adet;
            bool exist = false;
            for (i = 0; i < Program.sepete.Grid.RowCount; i++)
            {
                if (Convert.ToInt32(Program.sepete.Grid[0, i].Value) == Convert.ToInt32(kitap[0]))
                {
                    exist = true;
                    break;
                }
            }
            if (exist)
            {
                adet = Convert.ToInt32(Program.sepete.Grid[3, i].Value) + Convert.ToInt32(kitap[3]);
                Program.sepete.Grid[3, i].Value = adet;
                Program.sepete.Grid[4, i].Value = adet * Convert.ToInt32(kitap[2]);
            }
            else
            {
                Program.sepete.Grid.Rows.Add(kitap[0], kitap[1], kitap[2], kitap[3], kitap[4]);
            }
            Program.sepete.label2.Text = (Convert.ToInt32(Program.sepete.label2.Text) + Convert.ToInt32(kitap[4])).ToString();
        }
    }
}
