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
    public partial class Sud : Form
    {
        private string opstina; public string Opstina { get { return opstina; } set { opstina = value; } }
        private List<Sudjenje> sudjenja = new List<Sudjenje>(); 

        public Sud()
        {
            InitializeComponent();
        }
        public Sud(string opst)
        {
            InitializeComponent();
            this.opstina = opst;
           // this.popuniListu(); 
        }
        private void popuniListu()
        {
            Procedura p = new Procedura();
            List<Procedura> procedure = p.vratiProcedure(textBoxImeSuda.Text, opstina);
            foreach (Procedura pp in procedure)
            {
                listBoxProcedure.Items.Add(pp.ProceduraId);
            }
        }
        private void buttonKazna_Click(object sender, EventArgs e)
        {
            Procedura pp  = new Procedura();
            pp.ucitaj(listBoxProcedure.SelectedItem.ToString());
            Prestup p =null;
             if(pp.KategorijaPrekrsaja =="0")
             {
                 p = new Prekrsaj();
                 p.ucitaj(pp.PrestupId);
             }
             else if(pp.KategorijaPrekrsaja == "1")
             {
                    p = new PrivredniPrestup();
                     p.ucitaj(pp.PrestupId);
             }
             else if(pp.KategorijaPrekrsaja =="2")
             {
                 p = new KrivicnoDelo();
                 p.ucitaj(pp.PrestupId);
             }
            Kazna kazna = new Kazna();
            kazna.Ime = textBoxNazivKazne.Text;
            kazna.Iznos = textBoxIznos.Text;
            kazna.RokPlacanja = dateTimePickerRokPlacanja.Value;
            kazna.Placeno = (checkBoxPlaceno.Checked)?true:false;
            if (p.PocinilacFiliPLice)
                kazna.PocinilacId = "FizickoLice:" + kazna.PrestupId;
            else
                kazna.PocinilacId = "PravnoLice:" + kazna.PrestupId;
            if(p.vratiBroj() == 0)
            {
                kazna.PrestupId = "Prekrsaj:" + p.PrestupId;   
            }
            else if(p.vratiBroj() == 1)
            {
                kazna.PrestupId = "PrivredniPrestup:" + p.PrestupId;
            }

            else
            {
                kazna.PrestupId = "KrivicnoDelo:" + p.PrestupId;
            }
            kazna.dodajKaznu();
            if (p.PocinilacFiliPLice)
            {
                PravnoLice pr = new PravnoLice();
                pr.dodajUListuKazni(kazna.KaznaId,p.PocinilacId);
            }
            else
            {
                FizickoLice pr = new FizickoLice();
                pr.dodajUListuKazni(kazna.KaznaId, p.PocinilacId);
            }
            pp.izbaciIzSuda(opstina);
            pp.prebaciUObradjene(opstina);
            this.refresh();
            this.zatvoriKaznu();
            this.ocistiNakonKazne();
        }
        private void ocistiNakonKazne()
        {
            textBoxNovoImeSuda.Text = "";
            textBoxImeSudjije.Text = "";
            richTextBoxOpt.Text = "";
            textBoxNazivKazne.Text = "";
            textBoxIznos.Text = "";
        }

        private void buttonTrazi_Click(object sender, EventArgs e)
        {
            this.refresh();
            this.zatvoriKaznu();
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            Procedura pp  = new Procedura();
            pp.ucitaj(listBoxProcedure.SelectedItem.ToString());
            if(textBoxNovoImeSuda.Text.CompareTo(pp.ImeSuda) != 0)
            {
                pp.izbaciIzSuda(opstina);
                pp.ImeSudije = textBoxImeSudjije.Text;
                pp.ImeSuda = textBoxNovoImeSuda.Text;
                pp.ubaciUSud(opstina);
                pp.sacuvaj();
                this.refresh();
            }
           
        }

        private void listBoxProcedure_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProcedure.SelectedIndex >= 0)
            {
                Procedura p = new Procedura();
                p.ucitaj(listBoxProcedure.SelectedItem.ToString());
                textBoxNovoImeSuda.Text = p.ImeSuda;
                textBoxImeSudjije.Text = p.ImeSudije;
                Optuznica opt = new Optuznica();
                 opt.ucitaj(p.OptuznicaId);
                 richTextBoxOpt.Text = opt.Text;
                this.otvoriKaznu();
            }
            else
            {
                MessageBox.Show("Morate selektovati nesto.");
            }
        }
        private void refresh()
        {
            listBoxProcedure.Items.Clear();
            Procedura p = new Procedura();
            List<Procedura> procedure = p.vratiProcedure(textBoxImeSuda.Text, opstina);
            foreach (Procedura pp in procedure)
            {
                listBoxProcedure.Items.Add(pp.ProceduraId);
            }
        }

        private void buttonDodajRociste_Click(object sender, EventArgs e)
        {
            Procedura pp = new Procedura();
            if (listBoxProcedure.SelectedIndex >= 0)
            {
                pp.ucitaj(listBoxProcedure.SelectedItem.ToString());
                DodajZapisnik dodaZap = new DodajZapisnik(pp);
                dodaZap.Show();
            }
            else
            { MessageBox.Show("Obelezite prvo proceduru za koju dodajete ročiste."); }
        }

        private void buttonTraziZap_Click(object sender, EventArgs e)
        {
            listBoxProcedureZap.Items.Clear();
            Procedura p = new Procedura();
            List<Procedura> procedure = p.vratiProcedure(textBoxImeSud.Text, opstina);
            foreach (Procedura pp in procedure)
            {
                listBoxProcedureZap.Items.Add(pp.ProceduraId);
            }
        }

        private void listBoxProcedureZap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProcedureZap.SelectedIndex >= 0)
            {
                listBoxZapisnici.Items.Clear();
                Sudjenje s = new Sudjenje();
                sudjenja = s.ucitajSudjenja(listBoxProcedureZap.SelectedItem.ToString());
                foreach(Sudjenje ss in sudjenja)
                {
                    listBoxZapisnici.Items.Add(ss.DatumSudjenja.ToString());
                }
            }
        }

        private void listBoxZapisnici_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxZapisnici.SelectedIndex >= 0)
            {
                foreach (Sudjenje ss in sudjenja)
                {
                    if (ss.DatumSudjenja.ToString().CompareTo(listBoxZapisnici.SelectedItem.ToString()) == 0)
                    {
                        richTextBoxZapisnik.Text = ss.Zapisnik;
                    }

                }
            }
        }

        private void buttonOslobodi_Click(object sender, EventArgs e)
        {
            Procedura pp = new Procedura();
            if (listBoxProcedure.SelectedIndex >= 0)
            {
                pp.ucitaj(listBoxProcedure.SelectedItem.ToString());
                pp.izbaciIzSuda(opstina);
                pp.prebaciUObradjene(opstina);
            }
        }
        private void otvoriKaznu()
        {
            labelNazivKazne.Visible = true;
            textBoxNazivKazne.Visible = true;
            labelRokPlacanja.Visible = true;
            dateTimePickerRokPlacanja.Visible = true;
            labelIznos.Visible = true;
            textBoxIznos.Visible = true;
            buttonKazna.Visible = true;
            checkBoxPlaceno.Visible = true;

        }
        private void zatvoriKaznu()
        {
            labelNazivKazne.Visible = false;
            textBoxNazivKazne.Visible = false;
            labelRokPlacanja.Visible = false;
            dateTimePickerRokPlacanja.Visible = false;
            labelIznos.Visible = false;
            textBoxIznos.Visible = false;
            buttonKazna.Visible = false;
            checkBoxPlaceno.Visible = false;
        }
    }
}
