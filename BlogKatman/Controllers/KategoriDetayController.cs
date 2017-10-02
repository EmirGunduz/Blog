using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogKatman.Controllers
{
    public class KategoriDetayController : Controller
    {
        // GET: KategoriDetay
        public ActionResult Index(int id)
        {
            return View(new KategoriRepo().GetByID(id));
        }
    }
}