using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lotforussr.Models
{
    public class History
    {
        public int Id { get; set; }
      
        public int bid { get; set; }
    }
    public class Historyforuser : History
    {
        public string bidlot { get; set; }

       
    }
    public class Historyforlot : History
    {
        public string bidusername { get; set; }
      
    }
}
