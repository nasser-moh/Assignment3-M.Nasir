using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment3_M.Nasir.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int Amount { get; set; }

        public CheckingAccount CheckingAccount;

        public int CheckingAccountId;

    }
}
    