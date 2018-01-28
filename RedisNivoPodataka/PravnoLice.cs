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
    public class PravnoLice
    {
        readonly RedisClient redis = new RedisClient(Config.SingleHost);
        private string PIB; public string pib { get { return PIB; } set { PIB = value; } }
        private string naziv; public string Naziv { get { return naziv; } set { naziv = value; } }
        private string adresa; public string Adresa { get { return adresa; } set { adresa = value; } }
        private string telefon; public string Telefon { get { return telefon; } set { telefon = value; } }
        public PravnoLice()
        {
        }
        //konstruktor za Pravno lice
        public PravnoLice(string PIBP, string nazivP, string adresaP, string telefonP)
        {
            this.PIB = PIBP;
            this.naziv = nazivP;
            this.adresa = adresaP;
            this.telefon = telefonP;
        }
        //proverava da li postoji u baz, true postoji, false ne postoji
        public bool proveri(String liceId)
        {
            try
            {
                var hash = redis.GetAllEntriesFromHash("PravnoLice:" + liceId);
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
        public bool dodaj()
        {
            try
            {
                redis.SetEntryInHash("PravnoLice:" + this.PIB, "naziv", this.naziv);
                redis.SetEntryInHash("PravnoLice:" + this.PIB, "adresa", this.adresa);
                redis.SetEntryInHash("PravnoLice:" + this.PIB, "telefon", this.telefon);
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
        public List<string> vratiPrekrsaje()
        {
            List<string> ret = redis.GetAllItemsFromList("ListaPrekrsaja:" + this.pib);
            return ret;
        }
        public List<string> vratiKrivicnaDela()
        {
            List<string> ret = redis.GetAllItemsFromList("ListaKrivicnihDela:" + this.pib);
            return ret;
        }
        public List<string> vratiPrivrednePrestupe()
        {
            List<string> ret = redis.GetAllItemsFromList("ListaPrivrednihPrestupa:" + this.pib);
            return ret;
        }
        public void dodajUListuPrekrsaja(string prekrsajId, string pravLiceId)
        {
            try
            {
                redis.AddItemToList("ListaPrekrsaja:" + pravLiceId, prekrsajId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void dodajUListuPrivrednihPrestupa(string prekrsajId, string pravLiceId)
        {
            try
            {
                redis.AddItemToList("ListaPrivrednihPrestupa:" + pravLiceId, prekrsajId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void dodajUListuKrivicnihDela(string prekrsajId, string pravLiceId)
        {
            try
            {
                redis.AddItemToList("ListaKrivicnihDela:" + pravLiceId, prekrsajId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public bool ucitaj(string id)
        {
            try
            {
                var hash = redis.GetAllEntriesFromHash("PravnoLice:" + id);
                if (hash.Count != 0)
                {
                    this.pib = id;
                    this.adresa = hash["adresa"];
                    this.telefon = hash["telefon"];
                    this.naziv = hash["naziv"];
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                
            }
            return false; 
        }
        public void dodajUListuKazni(string kaznaId, string pravLiceId)
        {
            try
            {
                redis.AddItemToList("ListaKazni:" + pravLiceId, kaznaId);
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
                ret = redis.GetAllItemsFromList("ListaKazni:" + this.pib);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ret;
        }
    }

}
