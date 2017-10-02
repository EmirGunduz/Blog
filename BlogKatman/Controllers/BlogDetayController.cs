using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogKatman.Controllers
{
    public class BlogDetayController : Controller
    {
        // GET: BlogDetay
        public ActionResult Index(int id)
        {
            return View(new BlogRepo().GetByID(id));
        }
    }
}