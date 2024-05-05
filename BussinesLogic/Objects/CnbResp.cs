using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Objects
{

    public class CnbResp
    {
        public DateTime ValidDate { get; set; }

        public List<ActValues> ActValues { get; set; }
    }

    public class ActValues
    {
        public string Country { get; set; }
        public string Currency { get; set; }
        public int Quantity { get; set; }
        public string Code { get; set; }
        public decimal Rate { get; set; }
    }
}
