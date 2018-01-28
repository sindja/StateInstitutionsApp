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
    public class KrivicnoDelo : Prestup
    {
        public KrivicnoDelo(String prestupIdP, String nazivPrestupaP, String adresaP, DateTime datumPrestupaP, String opisPrestupaP,
                        String pocinilacIdP, bool pocinilacFiliPLiceP, String opstinaPrestupaP)
            : base(prestupIdP, nazivPrestupaP,adresaP, datumPrestupaP, opisPrestupaP, pocinilacIdP, pocinilacFiliPLiceP, opstinaPrestupaP)
        {
            
        }
        public KrivicnoDelo()
        {

        }
        public override bool dodajPrestup()
        {
            try 
            {                
                redis.Incr("krivicnoDeloId");
                long prestupId = Int64.Parse(redis.GetValue("krivicnoDeloId").ToString());
                this.PrestupId = prestupId.ToString();
                redis.SetEntryInHash("KrivicnoDelo:" + prestupId.ToString(), "nazivPrestupa", this.nazivPrestupa);
                redis.SetEntryInHash("KrivicnoDelo:" + prestupId.ToString(), "adresa", this.adresa);
                redis.SetEntryInHash("KrivicnoDelo:" + prestupId.ToString(), "datumPrestupa", this.datumPrestupa.ToString());
                redis.SetEntryInHash("KrivicnoDelo:" + prestupId.ToString(), "opisPrestupa", this.opisPrestupa);
                redis.SetEntryInHash("KrivicnoDelo:" + prestupId.ToString(), "pocinilacId", this.pocinilacId);
                redis.SetEntryInHash("KrivicnoDelo:" + prestupId.ToString(), "pocinilacFiliPLice", this.pocinilacFiliPLice.ToString());
                redis.SetEntryInHash("KrivicnoDelo:" + prestupId.ToString(), "opstinaPrestupa", this.opstinaPrestupa);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
        public override void dodajUOpstinu(string text, string krivicnoDeloid)
        {
            try
            {
                redis.AddItemToList(text, krivicnoDeloid);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public override int vratiBroj()
        {
            return 2;
        }
        public override void izbaci()
        {
            redis.RemoveItemFromList("KrivicnoDelo:" + this.opstinaPrestupa, this.prestupId);
        }
        public override void prebaci()
        {
            redis.AddItemToList("Tuzilac:KrivicnoDelo:" + this.opstinaPrestupa, this.prestupId);
        }
        public override void azurirajPrestup()
        {
            redis.SetEntryInHash("KrivicnoDelo:" + prestupId.ToString(), "nazivPrestupa", this.nazivPrestupa);
            redis.SetEntryInHash("KrivicnoDelo:" + prestupId.ToString(), "adresa", this.adresa);
            redis.SetEntryInHash("KrivicnoDelo:" + prestupId.ToString(), "datumPrestupa", this.datumPrestupa.ToString());
            redis.SetEntryInHash("KrivicnoDelo:" + prestupId.ToString(), "opisPrestupa", this.opisPrestupa);
            redis.SetEntryInHash("KrivicnoDelo:" + prestupId.ToString(), "pocinilacId", this.pocinilacId);
            redis.SetEntryInHash("KrivicnoDelo:" + prestupId.ToString(), "pocinilacFiliPLice", this.pocinilacFiliPLice.ToString());
            redis.SetEntryInHash("KrivicnoDelo:" + prestupId.ToString(), "opstinaPrestupa", this.opstinaPrestupa);
        }
        public override void izbaciZaTuzioca()
        {
           // redis.RemoveItemFromList("Tuzilac:KrivicnoDelo:" + this.opstinaPrestupa, this.prestupId);
            redis.RemoveItemFromList("KrivicnoDelo:" + this.opstinaPrestupa, this.prestupId);
        }
        public List<KrivicnoDelo> ucitajZaTuzioca(string opstina)
        {
            List<KrivicnoDelo> ret = new List<KrivicnoDelo>();
            List<string> ids = new List<string>();
            try
            {
                ids = redis.GetAllItemsFromList("KrivicnoDelo:" + opstina);
                foreach (string s in ids)
                {
                    KrivicnoDelo p = new KrivicnoDelo();
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
        public override bool ucitaj(string id)
        {
            var hash = redis.GetAllEntriesFromHash("KrivicnoDelo:" + id);
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
    }
}
