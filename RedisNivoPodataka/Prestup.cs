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
    public abstract class Prestup
    {
        protected readonly RedisClient redis = new RedisClient(Config.SingleHost);
        protected String prestupId; public String PrestupId { get { return prestupId; } set { prestupId = value; } }
        protected String nazivPrestupa; public String NazivPrestupa { get { return nazivPrestupa; } set { nazivPrestupa = value; } }
        protected String adresa; public String Adresa { get { return adresa; } set { adresa = value; } }
        protected String opstinaPrestupa; public String OpstinaPrestupa { get { return opstinaPrestupa; } set { opstinaPrestupa = value; } }
        protected DateTime datumPrestupa; public DateTime DatumPrestupa { get { return datumPrestupa; } set { datumPrestupa = value; } }
        protected String opisPrestupa; public String OpisPrestupa { get { return opisPrestupa; } set { opisPrestupa = value; } }
        protected String pocinilacId; public String PocinilacId { get { return pocinilacId; } set { pocinilacId = value; } }
        protected bool pocinilacFiliPLice; public bool PocinilacFiliPLice { get { return pocinilacFiliPLice; } set { pocinilacFiliPLice = value; } } //  1 fizicko lice- 0 pravno lice
        //default konsturktor za Prestup
        public Prestup()
        {
        }
        //konstruktor za Prestup
        public Prestup(String prestupIdP,String nazivprestupaP, String adresaP, DateTime datumPrestupaP, String opisPrestupaP, 
                        String pocinilacIdP, bool pocinilacFiliPLiceP, String opstinaPrestupaP)
        {
            this.prestupId = prestupIdP;
            this.nazivPrestupa = nazivprestupaP;
            this.adresa = adresaP;
            this.datumPrestupa = datumPrestupaP;
            this.opisPrestupa = opisPrestupaP;            
            this.pocinilacId = pocinilacIdP;
            this.pocinilacFiliPLice = pocinilacFiliPLiceP;
            this.opstinaPrestupa = opstinaPrestupaP;
        }
        public abstract bool dodajPrestup();
        public abstract void azurirajPrestup();
        public abstract void dodajUOpstinu(string text, string prestupId);
        public abstract int  vratiBroj();
        public abstract void izbaci();
        public abstract void prebaci();
        public abstract bool ucitaj(string id);
        public abstract void izbaciZaTuzioca();
    }
}
