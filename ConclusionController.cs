using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestRazor.Controllers
{
    public class ConclusionController : Controller
    {
        // GET: Conclusion
        public ActionResult Index()
        {
            List<Int32> amount = new List<Int32> { 25000, 500000, 2500000 };
            Int32 sum = amount.Sum();
            string conclusion;
            if (sum > 10000000)

            {
                conclusion = "You earn too much money";
            }

            else

            {
                conclusion = "You should ask for a salary raise";
            }
            //return View("Index", null, conclusion);
            return View("Index", model : conclusion);
        }
    }
}