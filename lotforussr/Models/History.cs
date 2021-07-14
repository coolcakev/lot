using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lotforussr.Models
{
    public class History
    {
        public int Id { get; set; }
        public int LotId { get; set; }
        public string bidusername { get; set; }
      

        public int bid { get; set; }

        public lot Lot { get; set; }
        public User Userforbid { get; set; }
    }
}
