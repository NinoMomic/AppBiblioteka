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
    public partial class Korisnici : Form
    {
        public Korisnici()
        {
            InitializeComponent();
        }
    }

    class KlasaKorisnici
    {
        public string IDKorisnika, Ime, Prezime, Adresa, BrojTelefona;

        public KlasaKorisnici(string IDKorisnika, string Ime, string Prezime, string Adresa, string BrojTelefona)
        {
            this.IDKorisnika = IDKorisnika;
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.Adresa = Adresa;
            this.BrojTelefona = BrojTelefona;
        }

        public string idKorisnika { get => IDKorisnika; set => IDKorisnika = value; }
        public string ime { get => Ime; set => Ime = value; }
        public string prezime { get => Prezime; set => Prezime = value; }
        public string adresa { get => Adresa; set => Adresa = value; }
        public string brojTelefona { get => BrojTelefona; set => BrojTelefona = value; }


    }
}
