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
    public class Kazna
    {
        protected readonly RedisClient redis = new RedisClient(Config.SingleHost);
        private string ime; public string Ime { get { return ime; } set { ime = value; } }
        private string kaznaId; public string KaznaId { get { return kaznaId; } set { kaznaId = value; } }
        private string iznos; public string Iznos { get { return iznos; } set { iznos = value; } }
        private DateTime rokPlacanja; public DateTime RokPlacanja { get { return rokPlacanja; } set { rokPlacanja = value; } }
        private string pocinilacId; public string PocinilacId { get { return pocinilacId; } set { pocinilacId = value; } }
        private string prestupId; public string PrestupId { get { return prestupId; } set { prestupId = value; } }
        private bool placeno; public bool Placeno { get { return placeno; } set { placeno = value; } }
        //prestup id oblika npr Preksraj:broj
        public Kazna()
        {

        }
        public Kazna(string imeP, string kaznaIdP, string iznosP, DateTime rokPlacanjaP, 
                       string pocinilacIdP, string prestupIdP, bool placenoP)
        {
            this.ime = imeP;
            this.kaznaId = kaznaIdP;
            this.iznos = iznosP;
            this.rokPlacanja = rokPlacanjaP;
            this.pocinilacId = pocinilacIdP;
            this.prestupId = prestupIdP;
            this.placeno = placenoP;
        }
        public bool dodajKaznu()
        {
            try
            {
                redis.Incr("kaznaId");
                long kaznaId = Int64.Parse(redis.GetValue("kaznaId").ToString());
                this.kaznaId = kaznaId.ToString();
                redis.SetEntryInHash("Kazna:" + kaznaId.ToString(), "ime", this.ime);
                redis.SetEntryInHash("Kazna:" + kaznaId.ToString(), "rokPlacanja", this.rokPlacanja.ToString());
                redis.SetEntryInHash("Kazna:" + kaznaId.ToString(), "iznos", this.iznos);
                redis.SetEntryInHash("Kazna:" + kaznaId.ToString(), "pocinilacId", this.pocinilacId);
                redis.SetEntryInHash("Kazna:" + kaznaId.ToString(), "prestupId", this.prestupId);
                redis.SetEntryInHash("Kazna:" + kaznaId.ToString(), "placeno", this.placeno.ToString());
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
        public void azuriraj()
        {
            try
            {
                redis.SetEntryInHash("Kazna:" + kaznaId.ToString(), "ime", this.ime);
                redis.SetEntryInHash("Kazna:" + kaznaId.ToString(), "rokPlacanja", this.rokPlacanja.ToString());
                redis.SetEntryInHash("Kazna:" + kaznaId.ToString(), "iznos", this.iznos);
                redis.SetEntryInHash("Kazna:" + kaznaId.ToString(), "pocinilacId", this.pocinilacId);
                redis.SetEntryInHash("Kazna:" + kaznaId.ToString(), "prestupId", this.prestupId);
                redis.SetEntryInHash("Kazna:" + kaznaId.ToString(), "placeno", this.placeno.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void ucitaj(string id)
        {
            try
            {
                var hash = redis.GetAllEntriesFromHash("Kazna:" + id);
                if (hash.Count != 0)
                {
                    this.kaznaId = id;
                    this.ime = hash["ime"];
                    this.rokPlacanja = DateTime.Parse(hash["rokPlacanja"]);
                    this.iznos = hash["iznos"];
                    this.pocinilacId = hash["pocinilacId"];
                    this.prestupId = hash["prestupId"];
                    this.placeno = bool.Parse(hash["placeno"]);
           
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
