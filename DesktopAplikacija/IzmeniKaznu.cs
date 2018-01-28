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
    public partial class IzmeniKaznu : Form
    {

        private Kazna kazna;
        public IzmeniKaznu()
        {
            InitializeComponent();
        }
        public IzmeniKaznu(Kazna kaz)
        {
            InitializeComponent();
            kazna = kaz;
            textBoxIme.Text = kaz.Ime;
            textBoxIznos.Text = kaz.Iznos;
            dateTimePicker1.Value = kaz.RokPlacanja;
            checkBoxPlaceno.Checked = kaz.Placeno;
        }
        
        private void buttonSacuvaj_Click(object sender, EventArgs e)
        {
            kazna.Ime = textBoxIme.Text;
            kazna.Iznos = textBoxIznos.Text;
            kazna.RokPlacanja = dateTimePicker1.Value;
            kazna.Placeno = checkBoxPlaceno.Checked;
            kazna.azuriraj();
            this.Close();
        }
    }
}
