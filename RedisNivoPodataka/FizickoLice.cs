using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Text;
using ServiceStack.Redis;
using System.Runtime.Serialization;
namespace RedisNivoPodataka
{
    public class FizickoLice
    {
        readonly RedisClient redis = new RedisClient(Config.SingleHost);
        private string JMBG;  public string jmbg{ get { return JMBG; } set { JMBG = value; }}
        private string ime;   public string Ime{get { return ime; }set { ime = value; }  }
        private string prezime; public string Prezime { get { return prezime; } set { prezime = value; } }
        private string adresa; public string Adresa { get { return adresa; } set { adresa = value; } }
        private string telefon; public string Telefon { get { return telefon; } set { telefon = value; } }
        private DateTime datumRodjenja; public DateTime DatumRodjenja { get { return datumRodjenja; } set { datumRodjenja = value; } }
        private string nacionalnost; public string Nacionalnost { get { return nacionalnost; } set { nacionalnost = value; } }

        public FizickoLice()
        {
        }
        public FizickoLice(string JMBGP, string imeP, string prezimeP, string adresaP, string telefonP,
                           DateTime datumRodjenjaP, string nacionalnostP)
        {
            this.JMBG = JMBGP;
            this.ime = imeP;
            this.prezime = prezimeP;
            this.adresa = adresaP;
            this.telefon = telefonP;
            this.nacionalnost = nacionalnostP;
            this.datumRodjenja = datumRodjenjaP;
        }
        //provera da li postoji u bazi vec fizicko lice
        public bool proveri(string liceId)
        {
            try
            {
                var hash = redis.GetAllEntriesFromHash("FizickoLice:" + liceId);
                if (hash.Count == 0)
                {
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }

        //dodavanje novog fizickog lica
        public bool dodaj()
        {
            try
            {
                redis.SetEntryInHash("FizickoLice:" + this.JMBG, "ime", this.ime);
                redis.SetEntryInHash("FizickoLice:" + this.JMBG, "prezime", this.prezime);
                redis.SetEntryInHash("FizickoLice:" + this.JMBG, "adresa", this.adresa);
                redis.SetEntryInHash("FizickoLice:" + this.JMBG, "telefon", this.telefon);
                redis.SetEntryInHash("FizickoLice:" + this.JMBG, "datumRodjenja", this.datumRodjenja.ToString());
                redis.SetEntryInHash("FizickoLice:" + this.JMBG, "nacionalnost", this.nacionalnost);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
        public bool proveriListu(string prestupId, string listId)
        {
            List<string> p = redis.GetAllItemsFromList(listId);
            foreach (string s in p)
            {
                if (s.Equals(prestupId))
                    return true;
            }
            return false;
        }
        public void dodajUListuPrekrsaja(string prekrsajId, string fizLiceId)
        {
            try
            {
                redis.AddItemToList("ListaPrekrsaja:" + fizLiceId, prekrsajId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void dodajUListuKrivicnihDela(string krivicnoDeloId, string fizLiceId)
        {
            try
            {
                redis.AddItemToList("ListaKrivicnihDela:" + fizLiceId, krivicnoDeloId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public List<string> vratiPrekrsaje()
        {
            List<string> ret = redis.GetAllItemsFromList("ListaPrekrsaja:" + this.jmbg);
            return ret;
        }
        public List<string> vratiKrivicnaDela()
        {
            List<string> ret = redis.GetAllItemsFromList("ListaKrivicnihDela:" + this.jmbg);
            return ret;
        }
        public bool ucitaj(string id)
        {
            try
            {
                var hash = redis.GetAllEntriesFromHash("FizickoLice:" + id);
                if(hash.Count != 0)
                {
                    this.jmbg = id;
                    this.adresa = hash["adresa"];
                    this.datumRodjenja = DateTime.Parse(hash["datumRodjenja"]);
                    this.telefon = hash["telefon"];
                    this.prezime = hash["prezime"]; ;
                    this.ime = hash["ime"];
                    this.nacionalnost = hash["nacionalnost"];
                    return true;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
        public List<string> ucitajPrekrsaje(string id)
        {
            List<string> ret = new List<string>();
            try
            {                
                ret = redis.GetAllItemsFromList("ListaPrekrsaja:"+id);                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ret;
        }
        public void dodajUListuKazni(string kaznaId, string fizLiceId)
        {
            try
            {
                redis.AddItemToList("ListaKazni:" + fizLiceId, kaznaId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public List<string> vratiKazne()
        {
            List<string> ret = new List<string>();
            try
            {
               ret = redis.GetAllItemsFromList("ListaKazni:" + this.jmbg);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ret;
        }
    }
}
