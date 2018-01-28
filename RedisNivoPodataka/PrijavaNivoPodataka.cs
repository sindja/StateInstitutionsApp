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
    //provera naloga u bazi
    public class PrijavaNivoPodataka
    {
        readonly RedisClient redis = new RedisClient(Config.SingleHost);
        private String opstina; public String Opstina { get { return opstina; } set { opstina = value; } }
        private String privilegija; public String Privilegija { get { return privilegija; } set { privilegija = value; } }
       //proverava da li u bazi postoji nalog
        public void pronadji(String korisnickoIme, String Lozinka)
        {
           // PrijavaNivoPodataka p = new PrijavaNivoPodataka;
            this.opstina = null;
            this.privilegija = null;
            try
            {
                var hash = redis.GetAllEntriesFromHash(korisnickoIme);
                if(hash.Count != 0)
                {
                    if (Lozinka.CompareTo(hash["lozinka"]) == 0)
                    {
                        this.opstina = hash["opstina"];
                        this.privilegija = hash["privilegije"];
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
