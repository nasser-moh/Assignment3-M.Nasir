using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment3_M.Nasir.Controllers
{
    public class CheckingAccountController : Controller
    {
        // GET: CheckingAccount
        [Route("CheckingAccount/Index")]
        public ActionResult Index()
        {
            return View();
        }
    }
}