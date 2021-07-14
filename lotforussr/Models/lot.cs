using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lotforussr.Models
{
    public class lot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Initialprice { get; set; }
        public int? Finalprice { get; set; }
        public bool isbid { get; set; }
        public List<History> History { get; set; }
        public int UserId { get; set; }
        public User User { get; set;  }
    }
}
