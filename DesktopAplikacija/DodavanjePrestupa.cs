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
    public partial class DodavanjePrestupa : Form
    {
        public string opstina { get; set; }
        public DodavanjePrestupa()
        {
            InitializeComponent();
        }
        public DodavanjePrestupa(string opstinaP)
        {
            InitializeComponent();
            this.opstina = opstinaP;
        }
            //--------------Dodaj tab-----------------
        private void buttonSacuvajPrestup_Click(object sender, EventArgs e)
        {
            if(this.proveriPoljaZaUnos()) //provera polja za unos
            {  
               if(radioButtonFizickoLice.Checked) // provera na koga se odnosi prestup
               {
                    if(proveriEntitet(textBoxPocinilacId.Text,true)) 
                    {
                        if (radioButtonPrekrsaj.Checked)
                        { //dodajemo prekrsaj
                            Prestup prekrsaj = new Prekrsaj(null,textBoxNazivPrestupa.Text, textBoxAdresaPrestupa.Text,dateTimePickerDatumPrestupa.Value,
                                richTextBoxOpisPrestupa.Text,textBoxPocinilacId.Text,true,textBoxOpstina.Text);
                            prekrsaj.dodajPrestup();
                            prekrsaj.dodajUOpstinu("Prekrsaj:" + textBoxOpstina.Text, prekrsaj.PrestupId);
                            FizickoLice fizickoLice = new FizickoLice();
                            if (!fizickoLice.proveriListu(prekrsaj.PrestupId, "ListaPrekrsaja:" + textBoxPocinilacId.Text))
                                fizickoLice.dodajUListuPrekrsaja(prekrsaj.PrestupId, textBoxPocinilacId.Text);
                        }
                        else if (radioButtonPrivredniPrekrsaj.Checked)
                        { 
                            MessageBox.Show("Fizicko lice ne moze da bude odgovorno za privredni prekrsaj!!!");
                        }
                        else if (radioButtonKrivicnoDelo.Checked)
                        { //dodajemo krivicno delo
                            Prestup prekrsaj = new KrivicnoDelo(null, textBoxNazivPrestupa.Text, textBoxAdresaPrestupa.Text, dateTimePickerDatumPrestupa.Value,
                                richTextBoxOpisPrestupa.Text, textBoxPocinilacId.Text, true, textBoxOpstina.Text);
                            prekrsaj.dodajPrestup();
                            prekrsaj.dodajUOpstinu("KrivicnoDelo:" + textBoxOpstina.Text, prekrsaj.PrestupId);
                            FizickoLice fizickoLice = new FizickoLice();
                            if (!fizickoLice.proveriListu(prekrsaj.PrestupId, "ListaKrivicnihDela:" + textBoxPocinilacId.Text))
                                fizickoLice.dodajUListuKrivicnihDela(prekrsaj.PrestupId, textBoxPocinilacId.Text);
                        }
                        this.ObrisiSve();
                    }
                    else //ako ne postoji pitanje da li zeli da ga kreira
                    {
                        if (MessageBox.Show("Fizičko lice ne postoji. Da li želite da ga dodate?", " Police",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        { //ne zeli da doda                            
                            return;
                        }
                        else //otvaranje forme za dodavanje fizickog lica,parametar je id pocinioca (u ovom slucaju JMBG)
                        {
                            DodajFizickoLice dodajFizickoLice = new DodajFizickoLice(textBoxPocinilacId.Text);
                            dodajFizickoLice.Show();
                        }
                    }
                    
               }
               else if(radioButtonPravnoLice.Checked)
               {
                   if (proveriEntitet(textBoxPocinilacId.Text, false))
                   {
                       if (radioButtonPrekrsaj.Checked)
                       { //dodajemo prekrsaj
                           Prestup prekrsaj = new Prekrsaj(null, textBoxNazivPrestupa.Text, textBoxAdresaPrestupa.Text, dateTimePickerDatumPrestupa.Value,
                                richTextBoxOpisPrestupa.Text, textBoxPocinilacId.Text, false, textBoxOpstina.Text);
                           prekrsaj.dodajPrestup();
                           prekrsaj.dodajUOpstinu("Prekrsaj:" + textBoxOpstina.Text, prekrsaj.PrestupId);
                           PravnoLice pravnoLice = new PravnoLice();
                           if (!pravnoLice.proveriListu(prekrsaj.PrestupId, "ListaPrekrsaja:" + textBoxPocinilacId.Text))
                               pravnoLice.dodajUListuPrekrsaja(prekrsaj.PrestupId, textBoxPocinilacId.Text);
                       }
                       else if (radioButtonPrivredniPrekrsaj.Checked)
                       { //dodajemo privredni prekrsaj
                           Prestup prekrsaj = new PrivredniPrestup(null, textBoxNazivPrestupa.Text, textBoxAdresaPrestupa.Text, dateTimePickerDatumPrestupa.Value,
                                richTextBoxOpisPrestupa.Text, textBoxPocinilacId.Text, false, textBoxOpstina.Text);
                           prekrsaj.dodajPrestup();
                           PravnoLice pravnoLice = new PravnoLice();
                           prekrsaj.dodajUOpstinu("PrivredniPrestup:" + textBoxOpstina.Text, prekrsaj.PrestupId);
                           if (!pravnoLice.proveriListu(prekrsaj.PrestupId, "ListaPrivrednihPrestupa:" + textBoxPocinilacId.Text))
                               pravnoLice.dodajUListuPrivrednihPrestupa(prekrsaj.PrestupId, textBoxPocinilacId.Text);
                       }
                       else if (radioButtonKrivicnoDelo.Checked)
                       { //dodajemo krivicno delo
                           Prestup prekrsaj = new KrivicnoDelo(null, textBoxNazivPrestupa.Text, textBoxAdresaPrestupa.Text, dateTimePickerDatumPrestupa.Value,
                                richTextBoxOpisPrestupa.Text, textBoxPocinilacId.Text, false, textBoxOpstina.Text);
                           prekrsaj.dodajPrestup();
                           PravnoLice pravnoLice = new PravnoLice();
                           prekrsaj.dodajUOpstinu("KrivicnoDelo:" + textBoxOpstina.Text, prekrsaj.PrestupId);
                           if (!pravnoLice.proveriListu(prekrsaj.PrestupId, "ListaKrivicnihDela:" + textBoxPocinilacId.Text))
                               pravnoLice.dodajUListuKrivicnihDela(prekrsaj.PrestupId, textBoxPocinilacId.Text);
                       }
                       this.ObrisiSve();
                   }
                   else //ako ne postoji pitanje da li zeli da ga kreira
                   {
                       if (MessageBox.Show("Pravno lice ne postoji. Da li želite da ga dodate?", " Police",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                       { //ne zeli da doda

                           return;
                       }
                       else //otvaranje forme za dodavanje pravnog lica
                       {
                           dodajPravnoLice dodPravnoLice = new dodajPravnoLice(textBoxPocinilacId.Text);
                           dodPravnoLice.Show();
                       }
                   }
                   
               }
            }
            
        }
        private void ObrisiSve()
        {
            textBoxAdresaPrestupa.Text = "";
            textBoxNazivPrestupa.Text = "";
            textBoxOpstina.Text = "";
            textBoxPocinilacId.Text = "";
            richTextBoxOpisPrestupa.Text = "";
            radioButtonFizickoLice.Checked = false;
            radioButtonPravnoLice.Checked = false;
            radioButtonPrekrsaj.Checked = false;
            radioButtonKrivicnoDelo.Checked = false;
            radioButtonPrivredniPrekrsaj.Checked = false;
        }
        //proverava da li su sva polja popunjena i njihovu korektnost
        private bool proveriPoljaZaUnos()
        {
            if(textBoxNazivPrestupa.Text == "")
            { MessageBox.Show("Upišite naziv prestupa!!!"); return false; }
            else if (textBoxAdresaPrestupa.Text == "")
            { MessageBox.Show("Upišite adresu prestupa!!!"); return false; }
            else if (textBoxOpstina.Text == "")
            { MessageBox.Show("Upišite opštinu prestupa!!!"); return false; }
            else if (textBoxPocinilacId.Text == "")
            { MessageBox.Show("Upišite idenifikaciju počinioca prestupa!!!"); return false; }
            else if (richTextBoxOpisPrestupa.Text == "")
            { MessageBox.Show("Dodajte opis prestupa!!!"); return false; }
            else if (!radioButtonFizickoLice.Checked && !radioButtonPravnoLice.Checked)
            { MessageBox.Show("Dodajte kategoriju počinioca prestupa!!!"); return false; }
            else if (!radioButtonPrekrsaj.Checked && !radioButtonPrivredniPrekrsaj.Checked && !radioButtonKrivicnoDelo.Checked)
            { MessageBox.Show("Dodajte kategoriju prestupa!!!"); return false; }
            else if (!proveriBroj(textBoxPocinilacId.Text))
            { MessageBox.Show("Identifikacija mora biti broj!!!"); return false; }
            else
                return true;
        }
        //proverava korektnost unetog broja
        private bool proveriBroj(String textP)
        {   
            long broj;
            bool rezultat = Int64.TryParse(textP, out broj);
            if (rezultat)
                return true;
            return false;
        }
        //provera postojanja pravnog ili fizickog lica, vraca true ako postoji
        private bool proveriEntitet(String textB,bool FP) //fizicko true; pravno false
        {
            if (FP)
            {
                FizickoLice fizickoLice = new FizickoLice();
                if (fizickoLice.proveri(textB)) //true postoji, false ne postoji
                    return true;
                else
                    return false;
            }
            else
            {
                PravnoLice pravnoLice = new PravnoLice();
                if (pravnoLice.proveri(textB)) //true postoji, false ne postoji
                    return true;
                else
                    return false;
            }
        }
        private void dodajPrestup()
        {
            if (radioButtonPrekrsaj.Checked)
            { //dodajemo prekrsaj

            }
            else if (radioButtonPrivredniPrekrsaj.Checked)
            { //dodajemo privredni prekrsaj

            }
            else if (radioButtonKrivicnoDelo.Checked)
            { //dodajemo krivicno delo

            }
        }
        //------------------Prikaz tab-----------------------------
        private void buttonPrikazi_Click(object sender, EventArgs e)
        {
          if(proveriBroj(textBoxId.Text))
            {
                if(radioButtonFizickoL.Checked)
                {

                   FizickoLice fizickoLice = new FizickoLice();
                   if (fizickoLice.proveri(textBoxId.Text))
                   {
                       if (fizickoLice.ucitaj(textBoxId.Text))
                       {
                           this.zatvoriPravna();
                           this.otvoriFizicka();
                           textBoxIme.Text = fizickoLice.Ime;
                           textBoxNacionalnost.Text = fizickoLice.Nacionalnost;
                           textBoxTelefon.Text = fizickoLice.Telefon;
                           textBoxPrezime.Text = fizickoLice.Prezime;
                           textBoxAdresa.Text = fizickoLice.Adresa;
                           dateTimePickerDatumRodjenja.Value = fizickoLice.DatumRodjenja;
                           Prestupi.Items.Clear();
                           NeplaceneKazne.Items.Clear();
                           List<string> prestupi = new List<string>();
                           prestupi = fizickoLice.vratiPrekrsaje();
                           foreach(string s in prestupi)
                           {
                               Prekrsaj pre = new Prekrsaj();
                               pre.ucitaj(s);
                               Prestupi.Items.Add(pre.PrestupId + ":" + pre.NazivPrestupa);
                           }
                           prestupi = fizickoLice.vratiKrivicnaDela();
                           foreach (string s in prestupi)
                           {
                               KrivicnoDelo pre = new KrivicnoDelo();
                               pre.ucitaj(s);
                               Prestupi.Items.Add(pre.PrestupId + ":" + pre.NazivPrestupa);
                           }
                           List<string> kazne = new List<string>();
                           kazne = fizickoLice.vratiKazne();
                           foreach (string s in kazne)
                           {
                               Kazna kaz = new Kazna();
                               kaz.ucitaj(s);
                               if(!kaz.Placeno)
                                   NeplaceneKazne.Items.Add(kaz.KaznaId + ":" + kaz.Ime);
                           }
                       }
                       else
                       { MessageBox.Show("Doslo je do greske prilikom ucitavanja."); }
                   }
                   else
                   { MessageBox.Show("Ne postoji trazena osoba."); }
                }
                else if(radioButtonPravnoL.Checked)
                {
                  PravnoLice pravnoLice = new PravnoLice();
                  if (pravnoLice.proveri(textBoxId.Text))
                  {
                      if (pravnoLice.ucitaj(textBoxId.Text))
                      {
                          this.zatvoriFizicka();
                          this.otvoriPravna();
                          textBoxTelefonP.Text = pravnoLice.Telefon;
                          textBoxNaziv.Text = pravnoLice.Naziv;
                          textBoxAdresaP.Text = pravnoLice.Adresa;
                          Prestupi.Items.Clear();
                          NeplaceneKazne.Items.Clear();
                         List<string> prestupi= new List<string>();
                          prestupi = pravnoLice.vratiPrekrsaje();
                          foreach (string s in prestupi)
                          {
                              Prekrsaj pre = new Prekrsaj();
                              pre.ucitaj(s);
                              Prestupi.Items.Add(pre.PrestupId + ":" + pre.NazivPrestupa);
                          }
                          prestupi = pravnoLice.vratiKrivicnaDela();
                          foreach (string s in prestupi)
                          {
                              KrivicnoDelo pre = new KrivicnoDelo();
                              pre.ucitaj(s);
                              Prestupi.Items.Add(pre.PrestupId + ":" + pre.NazivPrestupa);
                          }
                          prestupi = pravnoLice.vratiPrivrednePrestupe();
                          foreach (string s in prestupi)
                          {
                              PrivredniPrestup pre = new PrivredniPrestup();
                              pre.ucitaj(s);
                              Prestupi.Items.Add(pre.PrestupId + ":" + pre.NazivPrestupa);
                          }
                          
                           List<string> kazne = new List<string>();
                           kazne = pravnoLice.vratiKazne();
                           foreach (string s in kazne)
                           {
                               Kazna kaz = new Kazna();
                               kaz.ucitaj(s);
                               if(!kaz.Placeno)
                                   NeplaceneKazne.Items.Add(kaz.KaznaId + ":" + kaz.Ime);
                           }
                      }
                  }
                  else
                  { MessageBox.Show("Ne postoji trazeno pravno lice."); }
                }
                else
                { MessageBox.Show("Obelezite entitet!!!"); }
            }
            else
            { MessageBox.Show("Identifikacija mora biti broj!!!"); }
        }
        private void zatvoriPravna()
        {
            textBoxAdresaP.Visible = false;
            textBoxNaziv.Visible = false;
            textBoxTelefonP.Visible = false;
            labelAdresaP.Visible = false;
            labelNaziv.Visible = false;
            labelTelefonP.Visible = false;
        }
        private void otvoriPravna()
        {
            textBoxAdresaP.Visible = true;
            textBoxNaziv.Visible = true;
            textBoxTelefonP.Visible = true;
            labelAdresaP.Visible = true;
            labelNaziv.Visible = true;
            labelTelefonP.Visible = true;           
        }
        private void zatvoriFizicka()
        {
            textBoxTelefon.Visible = false;
            textBoxNacionalnost.Visible = false;
            textBoxIme.Visible = false;
            textBoxAdresa.Visible = false;
            textBoxPrezime.Visible = false;
            dateTimePickerDatumRodjenja.Visible = false;
            labelAdresa.Visible = false;
            labelDatumRodjenj.Visible = false;
            labelnacionaklnost.Visible = false;
            labelIme.Visible = false;
            labelPrezime.Visible = false;
            labelTelefon.Visible = false;
        }
        private void otvoriFizicka()
        {
            textBoxTelefon.Visible = true;
            textBoxNacionalnost.Visible = true;
            textBoxIme.Visible = true;
            textBoxAdresa.Visible = true;
            textBoxPrezime.Visible = true;
            dateTimePickerDatumRodjenja.Visible = true;
            labelAdresa.Visible = true;
            labelDatumRodjenj.Visible = true;
            labelnacionaklnost.Visible = true;
            labelIme.Visible = true;
            labelPrezime.Visible = true;
            labelTelefon.Visible = true;
        }

        private void NeplaceneKazne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(NeplaceneKazne.SelectedItem != null)
            {
                string item = NeplaceneKazne.SelectedItem.ToString();
                char[] niz = new char[1];
                niz[0] = ':';
                string[] items = item.Split(niz);
                Kazna kaz = new Kazna();
                kaz.ucitaj(items[0]);
                IzmeniKaznu forma = new IzmeniKaznu(kaz);
                forma.Show();
            }
        }

        
    }
}
