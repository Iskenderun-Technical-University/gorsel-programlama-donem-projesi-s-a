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

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
       
            //MessageBox.Show(Program.sepete.Grid[4, 1].Value.ToString());
            int toplam=0;
            for( int i=0; i<Program.sepete.Grid.RowCount; i++)
            {
                toplam += Int32.Parse(Program.sepete.Grid[4, i].Value.ToString());
            }
            MessageBox.Show(toplam.ToString());
        }
    }
}
