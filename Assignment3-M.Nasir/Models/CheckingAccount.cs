using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment3_M.Nasir.Models
{
    public class CheckingAccount
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string AccountNumber { get; set; }       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Balance { get; set; }
    }
}