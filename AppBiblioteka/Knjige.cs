using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Xml;
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

        private void btnUnesiKnjigu_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("knjige.xml");
            XmlElement root = doc.DocumentElement;

            XmlNodeList elemList = doc.GetElementsByTagName("knjiga");
            KlasaKnjige novaKnjiga = new KlasaKnjige(txtBoxAutor.Text, txtBoxNaslov.Text, txtBoxIzdavac.Text, txtBoxIDKnjige.Text, Convert.ToInt32(txtBoxKolicina.Text));
            novaKnjiga.IDKnjige = Convert.ToString(Convert.ToInt32(elemList[elemList.Count - 1].Attributes[0].Value) + 1);

            if (txtBoxIDKnjige.Text != "")
            {
                for (int j = 0; j < elemList.Count; j++)
                {
                    if (elemList[j].Attributes[0].Value == txtBoxIDKnjige.Text)
                    {
                        MessageBox.Show("ID je iskorišten!");
                        goto skip;
                    }
                    else
                    {
                        novaKnjiga.IDKnjige = txtBoxIDKnjige.Text;
                    }
                }
            }
            if(novaKnjiga.Kolicina == 1)
            {
                XmlElement noviElement = doc.CreateElement("knjiga");
                noviElement.SetAttribute("id",Convert.ToString(Convert.ToInt32(novaKnjiga.IDKnjige)));
                noviElement.SetAttribute("naslov", novaKnjiga.Naslov);
                noviElement.SetAttribute("autor", novaKnjiga.Autor);
                noviElement.SetAttribute("izdavač", novaKnjiga.Izdavac);
                root.AppendChild(noviElement);
                doc.Save("knjige.xml");
            }
            else
            {
                int IDGeneric = Convert.ToInt32(novaKnjiga.IDKnjige);
                for(int i = 0; i < novaKnjiga.Kolicina; i++)
                {
                    XmlElement noviElement = doc.CreateElement("knjiga");
                    noviElement.SetAttribute("id", Convert.ToString(Convert.ToInt32(IDGeneric)));
                    noviElement.SetAttribute("naslov", novaKnjiga.Naslov);
                    noviElement.SetAttribute("autor", novaKnjiga.Autor);
                    noviElement.SetAttribute("izdavač", novaKnjiga.Izdavac);
                    root.AppendChild(noviElement);
                    doc.Save("knjige.xml");
                    IDGeneric++;
                }
            }
        skip:;
        }
    }

    class KlasaKnjige
    {
        public int Kolicina;
        public string Autor, Naslov, Izdavac, IDKnjige;

        public KlasaKnjige(string Autor, string Naslov, string Izdavac, string IDKnjige, int Kolicina)
        {
            this.IDKnjige = IDKnjige;
            this.Kolicina = Kolicina;
            this.Autor = Autor;
            this.Naslov = Naslov;
            this.Izdavac = Izdavac;
        }

        public string idKnijge { get => IDKnjige ; set => IDKnjige = value; }
        public int kolicina { get => Kolicina; set => Kolicina = value; }
        public string autor { get => Autor; set => Autor = value; }
        public string naslov { get => Naslov; set => Naslov = value; }
        public string izdavac { get => Izdavac; set => Izdavac = value; }


    }
}
