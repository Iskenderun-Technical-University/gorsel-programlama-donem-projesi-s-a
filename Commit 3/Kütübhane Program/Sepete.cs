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
                string[] counter = new string[4] { Program.romanlar.label19.Text, Program.psikolojik.label21.Text, Program.cocukkitap.label19.Text, Program.tarih.label20.Text };
                Program.romanlar.label19.Text = (Convert.ToInt32(counter[0]) - 1).ToString();
                Program.psikolojik.label21.Text = (Convert.ToInt32(counter[1]) - 1).ToString();
                Program.cocukkitap.label19.Text = (Convert.ToInt32(counter[2]) - 1).ToString();
                Program.tarih.label20.Text = (Convert.ToInt32(counter[3]) - 1).ToString();
            }
            catch
            {
                MessageBox.Show("En az bir kitap secin!");
            }
        }
    }
}
