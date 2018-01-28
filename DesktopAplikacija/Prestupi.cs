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
    public partial class Prestupi : Form
    {
        public Prestup prestup { get; set; }
        public Inspektorat insp { get; set; }
        private int prestupZnak;
        public Prestupi()
        {
            InitializeComponent();
        }
        public Prestupi(Prestup p,Inspektorat i)
        {
            InitializeComponent();
            prestup = p;
            insp = i;
            prestupZnak = p.vratiBroj();
            this.popuniPolja();
        }

        private void buttonKazni_Click(object sender, EventArgs e)
        {
            otvoriZaKaznu();           
            /*Kazna kazna = new Kazna();
            kazna.Ime = textBoxNazivKazne.Text;
            kazna.Iznos = textBoxIznos.Text;
            kazna.RokPlacanja = dateTimePickerRokPlacanja.Value;
            kazna.Placeno = (checkBoxPlaceno.Checked) ? true : false;
            if (prestup.PocinilacFiliPLice)
                kazna.PocinilacId = "FizickoLice:" + kazna.PrestupId;
            else
                kazna.PocinilacId = "PravnoLice:" + kazna.PrestupId;
            if (prestup.vratiBroj() == 0)
            {
                kazna.PrestupId = "Prekrsaj:" + prestup.PrestupId;
            }
            else if (prestup.vratiBroj() == 1)
            {
                kazna.PrestupId = "PrivredniPrestup:" + prestup.PrestupId;
            }
            kazna.dodajKaznu();
            if (prestup.PocinilacFiliPLice)
            {
                PravnoLice pr = new PravnoLice();
                pr.dodajUListuKazni(kazna.KaznaId, prestup.PocinilacId);
            }
            else
            {
                FizickoLice pr = new FizickoLice();
                pr.dodajUListuKazni(kazna.KaznaId, prestup.PocinilacId);
            }*/
        }
        private void otvoriZaKaznu()
        {
            labelIznos.Visible = true;
            labelRokPlacanja.Visible = true;
            labelNazivKazne.Visible = true;
            textBoxIznos.Visible = true;
            textBoxNazivKazne.Visible = true;
            dateTimePickerRokPlacanja.Visible = true;
            checkBoxPlaceno.Visible = true;
            buttonSacuvaj.Visible = true;
        }
        private void zatvoriZaKaznu()
        {
            labelIznos.Visible = false;
            labelRokPlacanja.Visible = false;
            labelNazivKazne.Visible = false;
            textBoxIznos.Visible = false;
            textBoxNazivKazne.Visible = false;
            dateTimePickerRokPlacanja.Visible = false;
            checkBoxPlaceno.Visible = false;
            buttonSacuvaj.Visible = false;
        }
        //popunjavanje polja prilikom otvaranja prozora podacima o zeljenom prestupu
        private void popuniPolja()
        {
            textBoxNazivPrestupa.Text = prestup.NazivPrestupa;
            textBoxAdresa.Text = prestup.Adresa;
            textBoxOpstinaPrestupa.Text = prestup.OpstinaPrestupa;
            dateTimePicker1.Value = prestup.DatumPrestupa;
            richTextBox1.Text = prestup.OpisPrestupa;
        }
        //yatvaranje prozora
        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            prestup.NazivPrestupa = textBoxNazivPrestupa.Text;
            prestup.OpisPrestupa = richTextBox1.Text;
            prestup.DatumPrestupa = dateTimePicker1.Value;
            prestup.Adresa = textBoxAdresa.Text;
            prestup.OpstinaPrestupa = textBoxOpstinaPrestupa.Text;
            prestup.azurirajPrestup();
            insp.otvoriPolicijski();
            this.Close();
        }

        private void buttonSacuvaj_Click(object sender, EventArgs e)
        {
            Kazna kazna = new Kazna();
            kazna.Ime = textBoxNazivKazne.Text;
            kazna.Iznos = textBoxIznos.Text;
            kazna.RokPlacanja = dateTimePickerRokPlacanja.Value;
            kazna.Placeno = (checkBoxPlaceno.Checked)?true:false;
            if (prestup.PocinilacFiliPLice)
                kazna.PocinilacId = "FizickoLice:" + prestup.PrestupId;
            else
                kazna.PocinilacId = "PravnoLice:" + prestup.PrestupId;
            if(prestupZnak == 0)
            {
                kazna.PrestupId = "Prekrsaj:" + prestup.PrestupId;   
            }
            else if(prestupZnak == 1)
            {
                kazna.PrestupId = "PrivredniPrestup:" + prestup.PrestupId;
            }

            else
            {
                kazna.PrestupId = "KrivicnoDelo:" + prestup.PrestupId;
            }
            kazna.dodajKaznu();
            if (prestup.PocinilacFiliPLice)
            {
                PravnoLice p = new PravnoLice();
                p.dodajUListuKazni(kazna.KaznaId,prestup.PocinilacId);
            }
            else
            {
                FizickoLice p = new FizickoLice();
                p.dodajUListuKazni(kazna.KaznaId, prestup.PocinilacId);
            }
            prestup.izbaci();
            insp.otvoriPolicijski();
            this.Close();
        }

        private void buttonProsledi_Click(object sender, EventArgs e)
        {
            prestup.izbaci();
            prestup.prebaci();
            insp.otvoriPolicijski();
            this.Close();
        }

    }
}
