using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        
        public ActionResult Index()
        {
            // .net 4
            using (MyDatabase1Entities ent = new MyDatabase1Entities())
            {            
            
                var q = ent.Event.Where(e => e.City.Any(c => c.Id.Equals(2)));
                Debug.Write(q.ToString());

                var e1 = q.ToList();
                q = ent.Event.Where(e => e.City.Where(c => c.Id.Equals(2)).Count() > 0);
                Debug.Write(q.ToString());
                var e2 = q.ToList();

                q = from e in ent.Event
                    from c in e.City
                    from l in e.Lect
                    where c.Id.Equals(2) && l.id.Equals(3)
                    select e;

                Debug.Write(q.ToString());
                var e3 = q.ToList();

                int cid = 2, lid = 3;
                q = ent.Event;
                if (cid != 0)
                {
                    q = from e in q
                        from c in e.City
                        where c.Id.Equals(2)
                        select e;
                }
                if (lid != 0)
                {
                    q = from e in q
                        from l in e.Lect
                        where l.id.Equals(3)
                        select e;
                }
                Debug.Write(q.ToString());
                var e4 = q.ToList();

            }
            return View();
        }

    }
}
