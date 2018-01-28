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
    public partial class dodajPravnoLice : Form
    {
        public dodajPravnoLice()
        {
            InitializeComponent();
        }
        public dodajPravnoLice(String pib)
        {
            InitializeComponent();
            textBoxPIB.Text = pib;
        }
        private void buttonSacuvaj_Click(object sender, EventArgs e)
        {
             if(this.proveriPolja())
            {
                PravnoLice pravnoLice = new PravnoLice(textBoxPIB.Text, textBoxNaziv.Text, textBoxAdresa.Text, textBoxTelefon.Text);
                if(pravnoLice.dodaj())
                {
                    MessageBox.Show("Uspesno ste dodali pravno lice.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Doslo je do greske prilikom pokusaja unosa, molimo ponovo pokusajte!!!");     
                }
            }
        }
        private bool proveriPolja()
        {
            if (textBoxPIB.Text == "")
            { MessageBox.Show("Unesite PIB!!!"); return false; }
            else if (textBoxNaziv.Text == "")
            { MessageBox.Show("Unesite naziv pravnog lica!!!"); return false; }
            else if (textBoxTelefon.Text == "")
            { MessageBox.Show("Unesite telefon!!!"); return false; }
            else if (textBoxAdresa.Text == "")
            { MessageBox.Show("Unesite adresu"); return false; }
            else if (!proveriBroj(textBoxPIB.Text))
            { MessageBox.Show("PIB mora biti broj"); return false; }
            else
                return true;
        }
        private bool proveriBroj(String textP)
        {
            long broj;
            bool rezultat = Int64.TryParse(textP, out broj);
            if (rezultat)
                return true;
            return false;
        }

        private void dodajPravnoLice_Load(object sender, EventArgs e)
        {

        }
    }
}
