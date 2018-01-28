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
    public partial class DodajFizickoLice : Form
    {
        public DodajFizickoLice()
        {
            InitializeComponent();
        }
        public DodajFizickoLice(String JMBG)
        {
            InitializeComponent();
            textBoxJMBG.Text = JMBG;
        }
        //dodavanje novog fizickog lica
        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if(this.proveriPolja())
            {
                FizickoLice fizickoLice = new FizickoLice(textBoxJMBG.Text, textBoxIme.Text, textBoxPrezime.Text, textBoxAdresa.Text,
                                                            textBoxTelefon.Text, dateTimePickerDatumRodjenja.Value, textBoxNacionalnost.Text);
                if(fizickoLice.dodaj())
                {
                    MessageBox.Show("Uspesno ste dodali fizcko lice.");
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
            if(textBoxJMBG.Text == "")
            { MessageBox.Show("Unesite JMBG!!!"); return false; }
            else if (textBoxIme.Text == "")
            { MessageBox.Show("Unesite ime!!!"); return false; }
            else if (textBoxPrezime.Text == "")
            { MessageBox.Show("Unesite prezime!!!"); return false; }
            else if (textBoxTelefon.Text == "")
            { MessageBox.Show("Unesite telefon!!!"); return false; }
            else if (textBoxAdresa.Text == "")
            { MessageBox.Show("Unesite adresu"); return false; }
            else if (textBoxNacionalnost.Text == "")
            { MessageBox.Show("Unesite nacionalnost!!!"); return false; }
            else if(!proveriBroj(textBoxJMBG.Text))
            { MessageBox.Show("JMBG mora biti broj"); return false; }
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
    }
}
