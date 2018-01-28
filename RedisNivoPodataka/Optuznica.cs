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
    public class Optuznica
    {
        protected readonly RedisClient redis = new RedisClient(Config.SingleHost);
        private string text; public string Text { get { return text; } set { text = value; } }
        private string optuznicaId; public string OptuznicaId { get { return optuznicaId; } set { optuznicaId = value; } }
        public Optuznica()
        {

        }
        public Optuznica(string textP, string optuznicaIdP)
        {
            this.optuznicaId = optuznicaIdP;
            this.text = textP;
        }
        public void sacuvaj()
        {
            try
            {
                redis.Incr("optuznicaId");
                long optuznicaID = Int64.Parse(redis.GetValue("optuznicaId").ToString());
                this.optuznicaId = optuznicaID.ToString();
                redis.SetEntryInHash("Optuznica:" + this.optuznicaId, "text", this.text);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void ucitaj(string id)
        {
            var hash = redis.GetAllEntriesFromHash("Optuznica:" + id);
            if (hash.Count != 0)
            {
                this.optuznicaId = id;
                this.text = hash["text"];
            }
        }
        public void azuriraj()
        {
            try
            {
                redis.SetEntryInHash("Optuznica:" + this.optuznicaId, "text", this.text);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
