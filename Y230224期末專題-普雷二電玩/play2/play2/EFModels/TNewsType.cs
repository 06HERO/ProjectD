using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class TNewsType
    {
        public TNewsType()
        {
            TNews = new HashSet<TNews>();
        }

        public int FNewsTypeId { get; set; }
        public string? FNewsTypeName { get; set; }

        public virtual ICollection<TNews> TNews { get; set; }
    }
}
