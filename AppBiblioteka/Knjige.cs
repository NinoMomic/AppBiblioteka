using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBiblioteka.Forme
{
    public partial class Knjige : Form
    {
        public Knjige()
        {
            InitializeComponent();
        }
    }

    class KlasaKnjige
    {
        int IDKnjige, Kolicina;
        string Autor, Naziv, Izdavac;

        public KlasaKnjige(string Autor, string Naziv, string Izdavac, int IDKnjige, int Kolicina)
        {
            this.IDKnjige = IDKnjige;
            this.Kolicina = Kolicina;
            this.Autor = Autor;
            this.Naziv = Naziv;
            this.Izdavac = Izdavac;
        }

        public int idKnijge { get => IDKnjige ; set => IDKnjige = value; }
        public int kolicina { get => Kolicina; set => Kolicina = value; }
        public string autor { get => Autor; set => Autor = value; }
        public string naziv { get => Naziv; set => Naziv = value; }
        public string izdavac { get => Izdavac; set => Izdavac = value; }


    }
}
