using Assignment3_M.Nasir.Models;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment3_M.Nasir.Controllers
{
    public class TransactionController : Controller
    {
        private ApplicationDbContext _context;
        public TransactionController()
        {
            this._context = new ApplicationDbContext();
        }
        // GET: Transaction
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            return View();
        }
        [Route("Transaction/Deposit")]
        public ActionResult Deposit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ConfirmDeposit(Transaction t)
        {
            var acc = _context.CheckingAccounts.Single(c => c.Id == 1);
            var amount = t.Amount;
            acc.Balance = acc.Balance + amount;
            _context.SaveChanges();

            return RedirectToAction("Index", "CheckingAccount");
        }
        [Route("Transaction/Withdraw")]
        public ActionResult Withdraw()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ConfirmWithdraw(Transaction t)
        {
            var acc = _context.CheckingAccounts.Single(c => c.Id == 1);
            var amount = t.Amount;
            acc.Balance = acc.Balance - amount;
            _context.SaveChanges();

            return RedirectToAction("Index", "CheckingAccount");
        }

        public ActionResult QuickCash(Transaction t)
        {
            var acc = _context.CheckingAccounts.Single(c => c.Id == 1);
            acc.Balance = acc.Balance - 100;
            _context.SaveChanges();
            return RedirectToAction("Index", "CheckingAccount");
        }
        [Route("Transaction/Inquiry")]
        public ActionResult Inquiry(Transaction t)
        {
            var acc = _context.CheckingAccounts.Single(c => c.Id == 1);
            acc.Balance = acc.Balance;
            return View(acc);
        }


    }
}