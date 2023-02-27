using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace play2.Controllers
{ 


    public class Ctsupplier
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; } = null!;
        public string TaxIDNumber { get; set; } = null!;
        public string PrincipalMan { get; set; } = null!;
        public string CapitalAmount { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string SwiftCode { get; set; } = null!;
        public string Account { get; set; } = null!;
        public string BankName { get; set; } = null!;
        public string Grade { get; set; } = null!;
        public string Cooperation { get; set; } = null!;
        //public CtSwiftCode swiftcode { get; set; } = null!;
    }


    public class CtSwiftCode
    {
        public int ID { get; set; }
        public string SwiftCode { get; set; } = null!;
        public string BankName { get; set; } = null!;

    }


}
