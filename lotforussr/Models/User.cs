using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lotforussr.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool isreg { get; set; }
        public List<lot> Lots { get; set; }
        public List<History> Histories { get; set; }







    }
}
