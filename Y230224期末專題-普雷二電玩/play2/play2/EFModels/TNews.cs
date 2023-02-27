using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class TNews
    {
        public int FNewsId { get; set; }
        public int? FNewsType { get; set; }
        public string? FNewsPhotoPath { get; set; }
        public DateTime? FNewsDate { get; set; }
        public string? FNewsTitle { get; set; }
        public string? FNewsContent { get; set; }

        public virtual TNewsType? FNewsTypeNavigation { get; set; }
    }
}
