using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountMicroservice.Models
{
    public class Depositwithdraw
    {
        public int AccountID { get; set; }
        public string Message { get; set; }
        public double Balance { get; set; }
    }
}
