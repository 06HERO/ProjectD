using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;


namespace play2.Controllers { 
    public class Ctrepair
    {
        public int ID { get; set; }
        public string publisher { get; set; } = null!;
        public string extention { get; set; } = null!;
        public string describe { get; set; } = null!;
        public string registerdate { get; set; } = null!;
        public string MISprocesser { get; set; } = null!;
        public string MISresponse { get; set; } = null!;
        public string closeOrpending { get; set; } = null!;
        public string closedate { get; set; } = null!;

    }
}
