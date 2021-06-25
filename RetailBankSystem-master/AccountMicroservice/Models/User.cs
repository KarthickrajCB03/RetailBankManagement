using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountMicroservice.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string Password { get; set; }
        public string Roles { get; set; }
    }
}
