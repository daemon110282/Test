using Mvc45;
using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc45.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // .net 4.5
            using (MyDatabase1Entities ent = new MyDatabase1Entities())
            {
                var q = ent.Event.Where(e => e.City.Where(c => c.Id.Equals(2)).Any());
                Debug.Write(q.ToString());
                var e1 = q.ToList();
                q = ent.Event.Where(e => e.City.Where(c => c.Id.Equals(2)).Count() > 0);
                Debug.Write(q.ToString());
                var e2 = q.ToList();
                q= from e in ent.Event
                         from c in e.City
                         where c.Id.Equals(2)
                         select e;
                Debug.Write(q.ToString());
                var e3 = q.ToList();

            }
            return View();
        }
    }
}
