using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisNivoPodataka
{
    public class PrivredniPrestup : Prestup
    {
        public PrivredniPrestup(String prestupIdP,String nazivPrestupaP, String adresaP, DateTime datumPrestupaP, String opisPrestupaP,
                        String pocinilacIdP, bool pocinilacFiliPLiceP, String opstinaPrestupaP)
            : base(prestupIdP, nazivPrestupaP,adresaP, datumPrestupaP, opisPrestupaP, pocinilacIdP, pocinilacFiliPLiceP, opstinaPrestupaP)
        {
            
        }
        public PrivredniPrestup()
        {

        }
        public override bool dodajPrestup()
        {
            try 
            {                
                redis.Incr("privredniPrestupId");
                long prestupId = Int64.Parse(redis.GetValue("privredniPrestupId").ToString());
                this.PrestupId = prestupId.ToString();
                redis.SetEntryInHash("PrivredniPrestup:" + prestupId.ToString(), "nazivPrestupa", this.nazivPrestupa);
                redis.SetEntryInHash("PrivredniPrestup:" + prestupId.ToString(), "adresa", this.adresa);
                redis.SetEntryInHash("PrivredniPrestup:" + prestupId.ToString(), "datumPrestupa", this.datumPrestupa.ToString());
                redis.SetEntryInHash("PrivredniPrestup:" + prestupId.ToString(), "opisPrestupa", this.opisPrestupa);
                redis.SetEntryInHash("PrivredniPrestup:" + prestupId.ToString(), "pocinilacId", this.pocinilacId);
                redis.SetEntryInHash("PrivredniPrestup:" + prestupId.ToString(), "pocinilacFiliPLice", this.pocinilacFiliPLice.ToString());
                redis.SetEntryInHash("PrivredniPrestup:" + prestupId.ToString(), "opstinaPrestupa", this.opstinaPrestupa);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
        public override void dodajUOpstinu(string opstinaId, string privredniPrestupId)
        {
            try
            {
                redis.AddItemToList(opstinaId, privredniPrestupId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public override bool ucitaj(string id)
        {
            try
            {
                var hash = redis.GetAllEntriesFromHash("PrivredniPrestup:" + id);
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
        public List<PrivredniPrestup> ucitajIzOpstine(string opstina)
        {
            List<PrivredniPrestup> ret = new List<PrivredniPrestup>();
            List<string> ids = new List<string>();
            try
            {
                ids = redis.GetAllItemsFromList("PrivredniPrestup:" + opstina);
                foreach (string s in ids)
                {
                    PrivredniPrestup p = new PrivredniPrestup();
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
            return 1;
        }
        public override void izbaci()
        {
            redis.RemoveItemFromList("PrivredniPrestup:" + this.opstinaPrestupa, this.prestupId);
        }
        public override void prebaci()
        {
            redis.AddItemToList("Tuzilac:PrivredniPrestup:" + this.opstinaPrestupa, this.prestupId);
        }
        public override void izbaciZaTuzioca()
        {
            redis.RemoveItemFromList("Tuzilac:PrivredniPrestup:" + this.opstinaPrestupa, this.prestupId);
        }
        public override void azurirajPrestup()
        {
            redis.SetEntryInHash("PrivredniPrestup:" + prestupId.ToString(), "adresa", this.adresa);
            redis.SetEntryInHash("PrivredniPrestup:" + prestupId.ToString(), "datumPrestupa", this.datumPrestupa.ToString());
            redis.SetEntryInHash("PrivredniPrestup:" + prestupId.ToString(), "opisPrestupa", this.opisPrestupa);
            redis.SetEntryInHash("PrivredniPrestup:" + prestupId.ToString(), "pocinilacId", this.pocinilacId);
            redis.SetEntryInHash("PrivredniPrestup:" + prestupId.ToString(), "pocinilacFiliPLice", this.pocinilacFiliPLice.ToString());
            redis.SetEntryInHash("PrivredniPrestup:" + prestupId.ToString(), "opstinaPrestupa", this.opstinaPrestupa);
               
        }
        public List<PrivredniPrestup> ucitajZaTuzioca(string opstina)
        {
            List<PrivredniPrestup> ret = new List<PrivredniPrestup>();
            List<string> ids = new List<string>();
            try
            {
                ids = redis.GetAllItemsFromList("Tuzilac:PrivredniPrestup:" + opstina);
                foreach (string s in ids)
                {
                    PrivredniPrestup p = new PrivredniPrestup();
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
