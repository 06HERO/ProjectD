using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class TTagList
    {
        public TTagList()
        {
            TTagComms = new HashSet<TTagComm>();
        }

        public int TagId { get; set; }
        public string? TagName { get; set; }

        public virtual ICollection<TTagComm> TTagComms { get; set; }
    }
}
