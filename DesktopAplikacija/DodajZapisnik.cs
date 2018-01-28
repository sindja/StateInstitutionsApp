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
    public partial class DodajZapisnik : Form
    {
        private Procedura proceduraTmp;
        public Procedura ProceduraTmp
        {
            get { return proceduraTmp; }
            set { proceduraTmp = value; }
        }
        public DodajZapisnik()
        {
            InitializeComponent();
        }
        public DodajZapisnik(Procedura pp)
        {
            InitializeComponent();
            this.proceduraTmp = pp;
        }
        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            Sudjenje sudjenje = new Sudjenje(null, richTextBox1.Text, dateTimePicker1.Value);
            sudjenje.sacuvaj();
            proceduraTmp.dodajZapisnik(sudjenje.SudjenjeId);
            this.Close();
        }
    }
}
