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
    public partial class Tuzilac : Form
    {
        private string opstina; public string Opstina { get { return opstina; } set { opstina = value; } }
        private Prestup trenutniPrestup; public Prestup TrenutniPrestup { get { return trenutniPrestup; }
            set { trenutniPrestup = value; }
        }
        public Tuzilac()
        {
            InitializeComponent();
            this.popuniPolja();
        }
        public Tuzilac(string opstinaP)
        {
            InitializeComponent();
            this.opstina = opstinaP;
            this.popuniPolja();
        }

        private void buttonOtvori_Click(object sender, EventArgs e)
        {
            if (!(listBoxKrivicnaDela.SelectedIndex >= 0 && listBoxPrekrsaji.SelectedIndex >= 0
                && listBoxPrivredniPrestupi.SelectedIndex >= 0))
            {
                if (listBoxPrekrsaji.SelectedIndex >= 0)
                {
                    string item = listBoxPrekrsaji.SelectedItem.ToString();
                    char[] niz = new char[1];
                    niz[0] = ':';
                    string[] items = item.Split(niz);
                    listBoxPrekrsaji.ClearSelected();
                    Prekrsaj prek = new Prekrsaj();
                    PrivredniPrestup prekPr = new PrivredniPrestup();
                    if (prek.ucitaj(items[0]))
                    {
                        textBoxAdresaPrestupa.Text = prek.Adresa;
                        dateTimePicker1.Value = prek.DatumPrestupa;
                        richTextBoxOpisPrestupa.Text = prek.OpisPrestupa;
                        this.trenutniPrestup = prek;
                    }

                }
                else if (listBoxPrivredniPrestupi.SelectedIndex >= 0)
                {
                    string item = listBoxPrivredniPrestupi.SelectedItem.ToString();
                    char[] niz = new char[1];
                    niz[0] = ':';
                    string[] items = item.Split(niz);
                    PrivredniPrestup prekPr = new PrivredniPrestup();
                    if (prekPr.ucitaj(items[0]))
                    {
                        textBoxAdresaPrestupa.Text = prekPr.Adresa;
                        dateTimePicker1.Value = prekPr.DatumPrestupa;
                        richTextBoxOpisPrestupa.Text = prekPr.OpisPrestupa;
                        this.trenutniPrestup = prekPr;
                    }
                }
                else if (listBoxKrivicnaDela.SelectedIndex >= 0)
                {
                    string item = listBoxKrivicnaDela.SelectedItem.ToString();
                    char[] niz = new char[1];
                    niz[0] = ':';
                    string[] items = item.Split(niz);
                    KrivicnoDelo krDelo = new KrivicnoDelo();
                    if (krDelo.ucitaj(items[0]))
                    {
                        textBoxAdresaPrestupa.Text = krDelo.Adresa;
                        dateTimePicker1.Value = krDelo.DatumPrestupa;
                        richTextBoxOpisPrestupa.Text = krDelo.OpisPrestupa;
                        this.trenutniPrestup = krDelo;
                    }
                }
                listBoxKrivicnaDela.ClearSelected();
                listBoxPrivredniPrestupi.ClearSelected();
                popuniPolja();
            }
            else
            { MessageBox.Show("Morate selektovati nesto."); }
        }
        private void popuniPolja()
        {
            listBoxKrivicnaDela.Items.Clear();
            listBoxPrekrsaji.Items.Clear();
            listBoxPrivredniPrestupi.Items.Clear();
            List<Prekrsaj> prekrsaji = new List<Prekrsaj>();
            Prekrsaj prek = new Prekrsaj();
            prekrsaji = prek.ucitajZaTuzioca(this.opstina);
            foreach (Prekrsaj p in prekrsaji)
            {
                listBoxPrekrsaji.Items.Add(p.PrestupId + ":" + p.NazivPrestupa);
            }
            List<PrivredniPrestup> privPres = new List<PrivredniPrestup>();
            PrivredniPrestup priv = new PrivredniPrestup();
            privPres = priv.ucitajZaTuzioca(this.opstina);
            foreach (PrivredniPrestup p in privPres)
            {
                listBoxPrivredniPrestupi.Items.Add(p.PrestupId + ":" + p.NazivPrestupa);
            }
            List<KrivicnoDelo> krivDel = new List<KrivicnoDelo>();
            KrivicnoDelo delo = new KrivicnoDelo();
            krivDel = delo.ucitajZaTuzioca(this.opstina);
            foreach (KrivicnoDelo p in krivDel)
            {
                listBoxKrivicnaDela.Items.Add(p.PrestupId + ":" + p.NazivPrestupa);
            }
        }

        private void buttonPocinioc_Click(object sender, EventArgs e)
        {
            if(trenutniPrestup.PocinilacFiliPLice)
            {

            }
            else
            {

            }
        }

        private void buttonPokreniProceduru_Click_1(object sender, EventArgs e)
        {
            Optuznica opt = new Optuznica(richTextBoxOptuznica.Text, null);
            opt.sacuvaj();
            Procedura proc = new Procedura(null,textBoxImeSudije.Text,textBoxImeSud.Text,trenutniPrestup.PrestupId,opt.OptuznicaId,trenutniPrestup.vratiBroj().ToString());
            proc.sacuvaj();
            proc.ubaciUSud(trenutniPrestup.OpstinaPrestupa);
            trenutniPrestup.izbaciZaTuzioca();
            this.popuniPolja();
            this.Ocisti();
        }
        private void Ocisti()
        {
            textBoxAdresaPrestupa.Text = "";
            richTextBoxOpisPrestupa.Text = "";
            textBoxImeSud.Text = "";
            textBoxImeSudije.Text = "";
            richTextBoxOptuznica.Text = "";

        }
        private void buttonTrazi_Click(object sender, EventArgs e)
        {
            listBoxProcedure.Items.Clear();
            Procedura p = new Procedura();
            List<Procedura> procedure = p.vratiProcedure(textBoxImeSuda.Text, opstina);
            foreach (Procedura pp in procedure)
            {
                listBoxProcedure.Items.Add(pp.ProceduraId);
            }
        }

        private void listBoxProcedure_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProcedure.SelectedIndex >= 0)
            {
                Procedura p = new Procedura();
                p.ucitaj(listBoxProcedure.SelectedItem.ToString());
                Optuznica o = new Optuznica();
                o.ucitaj(p.OptuznicaId);
                richTextBoxPromenaOptuznice.Text = o.Text;
            }
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            Procedura p = new Procedura();
            p.ucitaj(listBoxProcedure.SelectedItem.ToString());
            Optuznica o = new Optuznica();
            o.ucitaj(p.OptuznicaId);
            o.Text = richTextBoxPromenaOptuznice.Text;
            o.azuriraj();
        }

        private void listBoxPrekrsaji_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxKrivicnaDela.ClearSelected();
            listBoxPrivredniPrestupi.ClearSelected();
        }

        private void listBoxPrivredniPrestupi_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxKrivicnaDela.ClearSelected();
            listBoxPrekrsaji.ClearSelected();
        }

        private void listBoxKrivicnaDela_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxPrivredniPrestupi.ClearSelected();
            listBoxPrekrsaji.ClearSelected();
        }
    }
}
