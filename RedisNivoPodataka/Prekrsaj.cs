using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisNivoPodataka
{
    public class Prekrsaj : Prestup 
    {
       
        public Prekrsaj(String prestupIdP, String nazivPrestupaP,String adresaP,
                        DateTime datumPrestupaP, String opisPrestupaP,
                        String pocinilacIdP, bool pocinilacFiliPLiceP, String opstinaPrestupaP)
            : base(prestupIdP, nazivPrestupaP,adresaP, datumPrestupaP, opisPrestupaP,
                                pocinilacIdP, pocinilacFiliPLiceP, opstinaPrestupaP)
        {
            
        }
        public Prekrsaj()
        {

        }
        public override bool dodajPrestup()
        {
            try 
            {                
                redis.Incr("prekrsajId");
                long prestupId = Int64.Parse(redis.GetValue("prekrsajId").ToString());
                this.PrestupId = prestupId.ToString();
                redis.SetEntryInHash("Prekrsaj:" + prestupId.ToString(), "nazivPrestupa", this.nazivPrestupa);
                redis.SetEntryInHash("Prekrsaj:" + prestupId.ToString(), "adresa", this.adresa);
                redis.SetEntryInHash("Prekrsaj:" + prestupId.ToString(), "datumPrestupa", this.datumPrestupa.ToString());
                redis.SetEntryInHash("Prekrsaj:" + prestupId.ToString(), "opisPrestupa", this.opisPrestupa);
                redis.SetEntryInHash("Prekrsaj:" + prestupId.ToString(), "pocinilacId", this.pocinilacId);
                redis.SetEntryInHash("Prekrsaj:" + prestupId.ToString(), "pocinilacFiliPLice", this.pocinilacFiliPLice.ToString());
                redis.SetEntryInHash("Prekrsaj:" + prestupId.ToString(), "opstinaPrestupa", this.opstinaPrestupa);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
        public override void azurirajPrestup()
        {
            try
            {
                redis.SetEntryInHash("Prekrsaj:" + prestupId.ToString(), "nazivPrestupa", this.nazivPrestupa);
                redis.SetEntryInHash("Prekrsaj:" + prestupId.ToString(), "adresa", this.adresa);
                redis.SetEntryInHash("Prekrsaj:" + prestupId.ToString(), "datumPrestupa", this.datumPrestupa.ToString());
                redis.SetEntryInHash("Prekrsaj:" + prestupId.ToString(), "opisPrestupa", this.opisPrestupa);
                redis.SetEntryInHash("Prekrsaj:" + prestupId.ToString(), "pocinilacId", this.pocinilacId);
                redis.SetEntryInHash("Prekrsaj:" + prestupId.ToString(), "pocinilacFiliPLice", this.pocinilacFiliPLice.ToString());
                redis.SetEntryInHash("Prekrsaj:" + prestupId.ToString(), "opstinaPrestupa", this.opstinaPrestupa);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public override void dodajUOpstinu(string opstinaId, string prekrsajId)
        {
            try 
            {
                redis.AddItemToList(opstinaId, prekrsajId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public override bool ucitaj(string id)
        {
            var hash = redis.GetAllEntriesFromHash("Prekrsaj:" + id);
            if (hash.Count != 0)
            {
                this.prestupId = id;
                this.nazivPrestupa = hash["nazivPrestupa"];
                this.adresa = hash["adresa"];
                this.datumPrestupa = DateTime.Parse(hash["datumPrestupa"]);
                this.opisPrestupa = hash["opisPrestupa"];
                this.pocinilacId = hash["pocinilacId"]; ;
                this.pocinilacFiliPLice = bool.Parse(hash["pocinilacFiliPLice"]);
                this.opstinaPrestupa = hash["opstinaPrestupa"];
                return true;
            }
            else
                return false;
        }
        public List<Prekrsaj> ucitajIzOpstine(string opstina)
        {
            List<Prekrsaj> ret = new List<Prekrsaj>();
            List<string> ids = new List<string>();
            try
            {
                ids = redis.GetAllItemsFromList("Prekrsaj:" + opstina);
                foreach (string s in ids)
                {
                    
                        Prekrsaj p = new Prekrsaj();
                        p.ucitaj(s);
                        ret.Add(p);
                    
                }
                return ret;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ret;
        }
        public override int vratiBroj()
        {
            return 0;
        }
        public override void izbaci()
        {
            redis.RemoveItemFromList("Prekrsaj:" + this.opstinaPrestupa, this.prestupId);
        }
        public override void prebaci()
        {
            redis.AddItemToList("Tuzilac:Prekrsaj:"+this.opstinaPrestupa, this.prestupId);
        }
        public override void izbaciZaTuzioca()
        {
            redis.RemoveItemFromList("Tuzilac:Prekrsaj:" + this.opstinaPrestupa, this.prestupId);
        }
        public List<Prekrsaj> ucitajZaTuzioca(string opstina)
        {
            List<Prekrsaj> ret = new List<Prekrsaj>();
            List<string> ids = new List<string>();
            try
            {
                ids = redis.GetAllItemsFromList("Tuzilac:Prekrsaj:" + opstina);
                foreach (string s in ids)
                {

                    Prekrsaj p = new Prekrsaj();
                    p.ucitaj(s);
                    ret.Add(p);

                }
                return ret;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ret;
        }
    }
}
