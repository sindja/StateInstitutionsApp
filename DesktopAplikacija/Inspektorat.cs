using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RedisNivoPodataka;
namespace DesktopAplikacija
{
    public partial class Inspektorat : Form
    {
        private string opstina; public string Opstina { get { return opstina; } set { opstina = value; } }
        public List<Prestupi> prestupi;
        public Inspektorat(string opstinaP)
        {
            InitializeComponent();
            this.opstina = opstinaP;
            //if (p)
                otvoriPolicijski();
           /* else
                otvoriInspekcijski();*/
        }

        private void buttonOtvori_Click(object sender, EventArgs e)
        {
            if (!(Prekrsaji.SelectedItem == null && PrivredniPrestupi.SelectedItem == null))
            {
                if (Prekrsaji.SelectedItem != null)
                {
                    string item = Prekrsaji.SelectedItem.ToString();
                    char[] niz = new char[1];
                    niz[0] = ':';
                    string[] items = item.Split(niz);
                    Prekrsaj prek = new Prekrsaj();
                    PrivredniPrestup prekPr = new PrivredniPrestup();
                    Prekrsaji.ClearSelected();
                    if (prek.ucitaj(items[0]))
                    {
                        Prestupi form = new Prestupi(prek, this);
                        form.Show();
                    }
                    
                }
                else if (PrivredniPrestupi.SelectedItem != null)
                {
                    
                    string item = PrivredniPrestupi.SelectedItem.ToString();
                    char[] niz = new char[1];
                    niz[0] = ':';
                    string[] items = item.Split(niz);
                    PrivredniPrestup prekPr = new PrivredniPrestup();
                    PrivredniPrestupi.ClearSelected();
                    if (prekPr.ucitaj(items[0]))
                    {
                        Prestupi form = new Prestupi(prekPr,this);
                        form.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Morate selektovati prestup.");
            }
        }
        public void otvoriPolicijski()
        {
            Prekrsaji.Items.Clear();
            PrivredniPrestupi.Items.Clear();
            List<Prekrsaj>  prekrsaji = new List<Prekrsaj>();
            Prekrsaj prek = new Prekrsaj();
            prekrsaji = prek.ucitajIzOpstine(this.opstina);
            foreach (Prekrsaj p in prekrsaji)
            {
                Prekrsaji.Items.Add(p.PrestupId + ":" + p.NazivPrestupa);
            }
            List<PrivredniPrestup> privPres = new List<PrivredniPrestup>();
            PrivredniPrestup priv = new PrivredniPrestup();
            privPres = priv.ucitajIzOpstine(this.opstina);
            foreach (PrivredniPrestup p in privPres)
            {
                PrivredniPrestupi.Items.Add(p.PrestupId + ":" + p.NazivPrestupa);
            }
        }

        private void Prekrsaji_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrivredniPrestupi.ClearSelected();
        }

        private void PrivredniPrestupi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Prekrsaji.ClearSelected();
        }
    }
}
