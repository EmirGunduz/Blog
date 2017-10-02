using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogKatman.Controllers
{
    public class SharedController : Controller
    {
        // GET: Shared
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult _Menu()
        {
            var enUstKategoriler = new KategoriRepo().GetAll().Where(x => x.UstKategoriID == null).ToList();
            return View(enUstKategoriler);
        }
    }
}