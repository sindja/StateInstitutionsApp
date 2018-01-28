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
    public class Sudjenje
    {
        protected readonly RedisClient redis = new RedisClient(Config.SingleHost);
        private DateTime datumSudjenja; public DateTime DatumSudjenja
        {
            get { return datumSudjenja; }
            set { datumSudjenja = value; }
        }
        private string zapisnik;
        public string Zapisnik
        { 
            get { return zapisnik; } 
            set { zapisnik = value; }
        }
        private string sudjenjeId;
        public string SudjenjeId
        {
            get { return sudjenjeId; }
            set { sudjenjeId = value; }

        }
        public Sudjenje()
        {

        }
        public Sudjenje(string id, string zapisnikP, DateTime datum)
        {
            this.sudjenjeId = id;
            this.zapisnik = zapisnikP;
            this.datumSudjenja = datum;
        }
        public void sacuvaj()
        {
            try
            {
                redis.Incr("sudjenjeId");
                long sudjenjeIdd = Int64.Parse(redis.GetValue("sudjenjeId").ToString());
                this.sudjenjeId = sudjenjeIdd.ToString();
                redis.SetEntryInHash("Sudjenje:" + this.sudjenjeId, "zapisnik", this.zapisnik);
                redis.SetEntryInHash("Sudjenje:" + this.sudjenjeId, "datumSudjenja", this.datumSudjenja.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void ucitaj(string id)
        {
            var hash = redis.GetAllEntriesFromHash("Sudjenje:" + id);
            if (hash.Count != 0)
            {
                this.sudjenjeId = id;
                this.zapisnik = hash["zapisnik"];
                this.datumSudjenja = DateTime.Parse(hash["datumSudjenja"]);
            }
        }
        public List<Sudjenje> ucitajSudjenja(string procId)
        {
            List<Sudjenje> ret = new List<Sudjenje>();
            List<string> ids = new List<string>();
            try
            {
                ids = redis.GetAllItemsFromList("ListaSudjenja:" + procId);
                foreach (string s in ids)
                {
                    Sudjenje p = new Sudjenje();
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
