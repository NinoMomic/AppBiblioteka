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

        private void btnPopisKnjige_Click(object sender, EventArgs e)
        {
            PopisKnjige novaForma4 = new PopisKnjige();
            novaForma4.Show();
        }

        private void btnKorisniciPopis_Click(object sender, EventArgs e)
        {
            PopisKorisnici novaForma5 = new PopisKorisnici();
            novaForma5.Show();
        }

        private void btnPopisEvidencija_Click(object sender, EventArgs e)
        {
            PovjestEvidencija novaForma6 = new PovjestEvidencija();
            novaForma6.Show();
        }

        private void btnObrisiKnjige_Click(object sender, EventArgs e)
        {
            ObrisiKnjige novaForma7 = new ObrisiKnjige();
            novaForma7.Show();
        }

        private void btnObrisiKorisnici_Click(object sender, EventArgs e)
        {
            ObrisiKorisnici novaForma8 = new ObrisiKorisnici();
            novaForma8.Show();
        }

        private void btnObrišiEvidencija_Click(object sender, EventArgs e)
        {
            ObrisiEvidencija novaForma9 = new ObrisiEvidencija();
            novaForma9.Show();
        }
    }
}
