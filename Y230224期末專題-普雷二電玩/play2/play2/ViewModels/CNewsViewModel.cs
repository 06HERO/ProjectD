using System.ComponentModel;
using play2.EFModels;

namespace play2.ViewModels
{
    public class CNewsViewModel
    {
        private TNews _news;
        private TNewsType _newstype;

        public CNewsViewModel()
        {
            _news = new TNews();
            _newstype = new TNewsType();
        }

        public TNews news
        {
            get { return _news; }
            set { _news = value; }
        }

        public TNewsType newstype
        {
            get { return _newstype; }
            set { _newstype = value; }
        }

        public int FNewsId
        {
            get { return _news.FNewsId; }
            set { _news.FNewsId = value; }
        }
        public DateTime? FNewsDate
        {
            get { return _news.FNewsDate; }
            set { _news.FNewsDate = value; }
        }
        [DisplayName("新聞分類")]
        public int? FNewsType
        {
            get { return _news.FNewsType; }
            set { _news.FNewsType = value; }
        }
        [DisplayName("新聞分類")]
        public string? FNewsTypeName
        {
            get { return _newstype.FNewsTypeName; }
            set { _newstype.FNewsTypeName = value; }
        }
        [DisplayName("圖片路徑")]
        public string? FNewsPhotoPath
        {
            get { return _news.FNewsPhotoPath; }
            set { _news.FNewsPhotoPath = value; }
        }
        [DisplayName("新聞標題")]
        public string? FNewsTitle
        {
            get { return _news.FNewsTitle; }
            set { _news.FNewsTitle = value; }
        }
        [DisplayName("新聞內容")]
        public string? FNewsContent
        {
            get { return _news.FNewsContent; }
            set { _news.FNewsContent = value; }
        }

        public IFormFile photo { get; set; }

    }
}
