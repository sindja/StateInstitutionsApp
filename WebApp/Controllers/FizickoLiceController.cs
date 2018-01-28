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
    public class FizickoLiceController : Controller
    {
        //
        // GET: /FizickoLice/

        public ActionResult Start()
        {
            return View("FizickoLice");
        }
        public ActionResult GetFizickoLice(FormCollection collection)
        {
            if (Request.Form["textIme"].CompareTo("") != 0 &&
                Request.Form["textPrezime"].CompareTo("") != 0 &&
                Request.Form["textJMBG"].CompareTo("") != 0)
            {
                FizickoLice fizLice = new FizickoLice();
                if (fizLice.ucitaj(Request.Form["textJMBG"]))
                {
                    List<string> retVrednost = new List<string>();
                    List<string> kazne = new List<string>();
                    kazne = fizLice.vratiKazne();
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
                    return View("FizickoLiceRezultat", retVrednost);
                }
                else
                    return View("FizickoLice");
            }
            else
             return View("FizickoLice");
        }

    }
}
