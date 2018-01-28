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
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();
        }
        //obrada klika na dugme Prijavi, provera postojanja korisnika u bazi. Ukoliko
        // postoji otvara se novi prozor prema svojim privilegijama
        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            if(this.proveriPolja())
            {
                PrijavaNivoPodataka prijava = new PrijavaNivoPodataka();
               
               prijava.pronadji(textBoxKorisnickoIme.Text, textBoxLozinka.Text);
                if (prijava.Opstina == null)
                {
                    MessageBox.Show("Uneli ste pogresne podatke");
                    this.obrisiTekst();
                }
                else
                { // otvaranje odgovarajuceg prozora prema privilegijama
                    if(radioButtonUnos.Checked && prijava.Privilegija.CompareTo("0") == 0)
                    {
                        DodavanjePrestupa dodavanjePrestupa = new DodavanjePrestupa();
                        dodavanjePrestupa.Show();
                    }
                    else if (radioButtonInspektorat.Checked && prijava.Privilegija.CompareTo("1") == 0)
                    {
                        Inspektorat inspektorat = new Inspektorat(prijava.Opstina);
                        inspektorat.Show();
                    }
                    else if (radioButtonSud.Checked && prijava.Privilegija.CompareTo("3") == 0)
                    {
                        Sud sud = new Sud(prijava.Opstina);
                        sud.Show();
                    }
                    else if (radioButtonTuzilac.Checked && prijava.Privilegija.CompareTo("2") == 0)
                    {
                        Tuzilac tuzilac = new Tuzilac(prijava.Opstina);
                        tuzilac.Show();
                    }
                    else
                    {
                        MessageBox.Show("Oznacili ste pogresnu privilegiju.");
                        this.obrisiTekst();
                    }
                }
            }
        }
        //proverava da li su sva polja potrebna za prijavljivanje popunjena
        //ukoliko nisu pojavljuje se odgovarajuce obavestenje
        private bool proveriPolja()
        {
            if (textBoxKorisnickoIme.Text == "")
            {
                MessageBox.Show("Unesite korisničko ime!!!");
                return false;
            }
            else if (textBoxLozinka.Text == "")
            {
                MessageBox.Show("Unesite lozinku!!!");
                return false;
            }
            else if (radioButtonInspektorat.Checked == false && radioButtonSud.Checked == false &&
                radioButtonTuzilac.Checked == false && radioButtonUnos.Checked == false)
            {
                MessageBox.Show("Označite radno mesto!!!");
                return false;
            }
            else
                return true;
        }
        //brise tekst iz tekst polja za unos
        private void obrisiTekst()
        { 
            textBoxKorisnickoIme.Text = "";
            textBoxLozinka.Text = "";
        }
    }
}
