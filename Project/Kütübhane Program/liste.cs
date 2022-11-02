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
    public partial class liste : Form
    {
        public liste()
        {
            InitializeComponent();
        }

        private void btnCik_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAna_Click(object sender, EventArgs e)
        {
           
        }

        private void btnKitap_Click(object sender, EventArgs e)
        {

            
        }

        private void liste_Load(object sender, EventArgs e)
        {
            
               

        }

        private void btnAna_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnKitap_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btncik_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            
            Home fr2 = new Home();
            fr2.Show();
            this.Close();
        }

        private void btnbaslat_Click(object sender, EventArgs e)
        {
            this.Hide();
            ROMANLAR fr3 = new ROMANLAR();
            fr3.Show();
          
        }

        private void btncoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            ÇOCUK_KİTAPLARI fr4 = new ÇOCUK_KİTAPLARI();
            fr4.Show();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tarih fr5 = new Tarih();
            fr5.Show();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Psikolojik f6 = new Psikolojik();
            f6.Show();
        }
    }
}
