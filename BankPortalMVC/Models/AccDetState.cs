using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankPortalMVC.Models
{
    public class AccDetState
    {
        [Required]
        public int AccountId { get; set; }
        [Required]
        public int from_date { get; set; }
        [Required]
        public int to_date { get; set; }
    }
}
