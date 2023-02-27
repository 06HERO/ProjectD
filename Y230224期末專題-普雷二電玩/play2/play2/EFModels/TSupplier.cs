using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class TSupplier
    {
        public TSupplier()
        {
            TPurchaseOrders = new HashSet<TPurchaseOrder>();
        }

        public int SupplierId { get; set; }
        public string? SupplierName { get; set; }
        public string? TaxIdnumber { get; set; }
        public string? PrincipalMan { get; set; }
        public string? CapitalAmount { get; set; }
        public string? Phone { get; set; }
        public string? SwiftCode { get; set; }
        public string? BankName { get; set; }
        public string? Account { get; set; }
        public string? Grade { get; set; }
        public string? Cooperation { get; set; }

        public virtual ICollection<TPurchaseOrder> TPurchaseOrders { get; set; }
    }
}
