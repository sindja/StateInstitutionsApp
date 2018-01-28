using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Web.Http;
using RedisNivoPodataka;
namespace WebApp.Controllers
{
    public class PravnoLiceController : Controller
    {
        //
        // GET: /PravnoLice/

        public ActionResult Start()
        {
            return View("PravnoLice");
        }
        public ActionResult GetPravnoLice(FormCollection collection)
        {
            if (Request.Form["textIme"].CompareTo("") != 0 &&
                Request.Form["textPIB"].CompareTo("") != 0)
            {
                PravnoLice pravLice = new PravnoLice();
                if (pravLice.ucitaj(Request.Form["textPIB"]))
                {
                    List<string> retVrednost = new List<string>();
                    List<string> kazne = new List<string>();
                    kazne = pravLice.vratiKazne();
                    foreach (string s in kazne)
                    {
                        Kazna k = new Kazna();
                        k.ucitaj(s);
                        if (!k.Placeno)
                        {
                            string rV = k.Ime + "," + k.RokPlacanja + "," + k.Iznos + ",";
                            retVrednost.Add(rV);
                        }
                    }
                    return View("PravnoLiceRezultat", retVrednost);
                }
                else
                    return View("PravnoLice");
            }
            else
                return View("PravnoLice");
        }

    }
}
