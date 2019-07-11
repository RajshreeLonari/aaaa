using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testGetApiData
{
  public  class RETSaveResponse
    {
        public string coord { get; set; }
        public string weather { get; set; }
       // public string base { get; set; }
        public string main { get; set; }
        public string wind { get; set; }
        public string rain { get; set; }
        public string clouds { get; set; }
        public string dt { get; set; }
        public string sys { get; set; }
        public string timezone { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string cod { get; set; }
    }
}
