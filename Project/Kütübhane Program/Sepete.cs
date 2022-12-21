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
    public partial class Sepete : Form
    {
        public Sepete()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Program.sepete.Hide();
        }

        private void Sepete_VisibleChanged(object sender, EventArgs e)
        {
            Program.sepete.Grid.ClearSelection();
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int adet = Convert.ToInt32(Grid[3, Grid.SelectedRows[0].Index].Value);
                int fiyat = Convert.ToInt32(Grid[2, Grid.SelectedRows[0].Index].Value);
                if (adet > 1)
                {
                    Grid[3, Grid.SelectedRows[0].Index].Value = --adet;
                    Grid[4, Grid.SelectedRows[0].Index].Value = adet * fiyat;
                }
                else
                {
                    Grid.Rows.RemoveAt(Grid.SelectedRows[0].Index);
                    Grid.ClearSelection();
                }
                label2.Text = (Convert.ToInt32(label2.Text) - fiyat).ToString();
                --Program.adet;
                Program.romanlar.label19.Text = Program.adet.ToString();
                Program.psikolojik.label21.Text = Program.adet.ToString();
                Program.cocukkitap.label19.Text = Program.adet.ToString();
                Program.tarih.label20.Text = Program.adet.ToString();
            }
            catch
            {
                MessageBox.Show("En az bir kitap secin!");
            }
        }
    }
}
