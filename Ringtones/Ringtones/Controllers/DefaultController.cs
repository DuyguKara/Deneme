using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Ringtones.Models.Entity;

namespace Ringtones.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        Context c = new Context();
        public ActionResult Index()
        {
            var result = c.Ringtones.ToList();  
            return View(result);
        }
       
    }
}