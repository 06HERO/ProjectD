using System.ComponentModel;
using play2.EFModels;

namespace play2.ViewModels
{
    public class CpurchasecreatViewModel
    {
        public IEnumerable<TSupplier> TSupplier { get; set; }
        public IEnumerable<TStockAmount> TStockAmount { get; set; }
        public IEnumerable<TStockroom> TStockroom { get; set; }
        public IEnumerable<TPurchaseDetail> TPurchaseDetail { get; set; }
        public IEnumerable<TPurchaseOrder> TPurchaseOrder { get; set; }
        public IEnumerable<TCommodity> TCommodity { get; set; }


    }
}
