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
    public class Procedura
    {
        protected readonly RedisClient redis = new RedisClient(Config.SingleHost);
        private String proceduraId; public String ProceduraId { get { return proceduraId; } set { proceduraId = value; } }
        private String imeSudije; public String ImeSudije { get { return imeSudije; } set { imeSudije = value; } }
        private String imeSuda; public String ImeSuda { get { return imeSuda; } set { imeSuda = value; } }
        private String prestupId; public String PrestupId { get { return prestupId; } set { prestupId = value; } }
        private String optuznicaId; public String OptuznicaId { get { return optuznicaId; } set { optuznicaId = value; } }
        private String kategorijaPrekrsaja;
        public String KategorijaPrekrsaja { get { return kategorijaPrekrsaja; } set { kategorijaPrekrsaja = value; }
        }
        public Procedura()
        {

        }
        public Procedura(string proceduraIdP,string imeSudijeP,string imeSudaP,string prestupIdP,string optuznicaIdP, string katePrek)
        {
            this.optuznicaId = optuznicaIdP;
            this.imeSudije = imeSudijeP;
            this.imeSuda = imeSudaP;
            this.prestupId = prestupIdP;
            this.proceduraId = proceduraIdP;
            this.kategorijaPrekrsaja = katePrek;
        }
        public void sacuvaj()
        {
            try
            {
                redis.Incr("proceduraId");
                long proceduraID = Int64.Parse(redis.GetValue("proceduraId").ToString());
                this.proceduraId = proceduraID.ToString();
                redis.SetEntryInHash("Procedura:" + this.proceduraId, "optuznicaId", this.optuznicaId);
                redis.SetEntryInHash("Procedura:" + this.proceduraId, "imeSudije", this.imeSudije);
                redis.SetEntryInHash("Procedura:" + this.proceduraId, "imeSuda", this.imeSuda);
                redis.SetEntryInHash("Procedura:" + this.proceduraId, "prestupId", this.prestupId);
                redis.SetEntryInHash("Procedura:" + this.proceduraId, "kategorijaPrekrsaja", this.kategorijaPrekrsaja);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void azuriraj()
        {
            try
            {
                redis.SetEntryInHash("Procedura:" + this.proceduraId, "optuznicaId", this.optuznicaId);
                redis.SetEntryInHash("Procedura:" + this.proceduraId, "imeSudije", this.imeSudije);
                redis.SetEntryInHash("Procedura:" + this.proceduraId, "imeSuda", this.imeSuda);
                redis.SetEntryInHash("Procedura:" + this.proceduraId, "prestupId", this.prestupId);
                redis.SetEntryInHash("Procedura:" + this.proceduraId, "kategorijaPrekrsaja", this.kategorijaPrekrsaja);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void ubaciUSud(string opstina)
        {
            redis.AddItemToList(opstina +":"+ this.ImeSuda, this.proceduraId);
        }
        public void izbaciIzSuda(string opstina)
        {
            redis.RemoveItemFromList(opstina + ":" + this.ImeSuda, this.proceduraId);
        }
        public void prebaciUObradjene(string opstina)
        {
            redis.RemoveItemFromList("ObradjeneProcedure:"+opstina , this.proceduraId);
        }
        public List<Procedura> vratiProcedure(string ImeSudaP, string opstinaP)
        {
            List<string> proc = new List<string>();
            List<Procedura> ret = new List<Procedura>();
            try
            {
                proc = redis.GetAllItemsFromList(opstinaP + ":" + ImeSudaP);
                foreach(string s in proc)
                {
                    Procedura p = new Procedura();
                    p.ucitaj(s);
                    ret.Add(p);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ret;
        }
        public void ucitaj(string id)
        {
            try
            {
                var hash = redis.GetAllEntriesFromHash("Procedura:" + id);
                if (hash.Count != 0)
                {
                    this.proceduraId = id;
                    this.kategorijaPrekrsaja = hash["kategorijaPrekrsaja"];
                    this.prestupId = hash["prestupId"];
                    this.imeSuda = hash["imeSuda"];
                    this.imeSudije = hash["imeSudije"];
                    this.optuznicaId = hash["optuznicaId"];
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return; 
        }
        public void dodajZapisnik(string zapisnikId)
        {
            redis.AddItemToList("ListaSudjenja:" + this.proceduraId, zapisnikId);
        }
    }
}
