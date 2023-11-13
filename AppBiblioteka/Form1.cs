using AppBiblioteka.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBiblioteka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnosKnjige_Click(object sender, EventArgs e)
        {
            Knjige novaForma = new Knjige();
            novaForma.Show();
        }

        private void btnUnosKorisnici_Click(object sender, EventArgs e)
        {
            Korisnici novaForma2 = new Korisnici();
            novaForma2.Show();
        }

        private void btnUnosEvidencija_Click(object sender, EventArgs e)
        {
            Evidencija novaForma3 = new Evidencija();
            novaForma3.Show();
        }
    }
}
