using Microsoft.AspNetCore.Mvc;
using play2.EFModels;
using System;
using play2.ViewModels;
using System.Data;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Microsoft.AspNetCore.Authorization;


namespace play2.Controllers.BackEndControllers.controller16
{

    public class NewsController : Controller
    {
        private IWebHostEnvironment _eviroment;
        private readonly Play2Context _context;
        private readonly ILogger<NewsController> _logger;

        public NewsController(ILogger<NewsController> logger, Play2Context context, IWebHostEnvironment p)
        {
            _context = context;
            _logger = logger;
            _eviroment = p;
        }


        public IActionResult NewsList()
        {
            IEnumerable<TNews> nwes = _context.TNews.AsQueryable().OrderByDescending(news => news.FNewsDate);

            List<TNews> list = new List<TNews>();

            foreach (var d in nwes)
            {
                TNews v = new TNews();
                v = d;
                list.Add(v);
            }
            return View(list);
        }
        public IActionResult CreateNews()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CreateNews(CNewsViewModel _news)
        {
            TNews news = new TNews();
            try
            {

                if (_news.photo != null)
                {
                    string photoName = Guid.NewGuid().ToString() + ".jpg";
                    string path = _eviroment.WebRootPath + "/NewsImages/" + photoName;


                    news.FNewsPhotoPath = photoName;
                    using (var filestream = new FileStream(path, FileMode.Create))
                    {
                        _news.photo.CopyTo(filestream);
                    }
                }

                news.FNewsType = _news.FNewsType;
                news.FNewsDate = DateTime.Now;
                news.FNewsTitle = _news.FNewsTitle;
                news.FNewsContent = _news.FNewsContent;
                _context.TNews.Add(news);
                _context.SaveChanges();

                return RedirectToAction("NewsList");
            }
            catch (Exception ex)
            {
                return Content(ex.ToString());
            }
        }


        public IActionResult EditNews(int? id)
        {
            TNews vm = new TNews();
            CNewsViewModel data = new CNewsViewModel();
            try
            {

                vm = _context.TNews.FirstOrDefault(t => t.FNewsId == id);
                data.FNewsId = vm.FNewsId;
                data.FNewsType = vm.FNewsType;
                data.FNewsDate = vm.FNewsDate;
                data.FNewsTitle = vm.FNewsTitle;
                data.FNewsContent = vm.FNewsContent;
                data.FNewsPhotoPath = vm.FNewsPhotoPath;

                return View(data);
            }
            catch (Exception ex)
            {
                return Content(ex.ToString());
            }
        }
        [HttpPost]
        public IActionResult EditNews(CNewsViewModel _news)
        {

            TNews vm = _context.TNews.FirstOrDefault(t => t.FNewsId == _news.FNewsId);
            try
            {

                if (vm != null)
                {
                    if (_news.photo != null)
                    {
                        if (vm.FNewsPhotoPath != null)
                        {
                            string oldpath = _eviroment.WebRootPath + "/NewsImages/" + vm.FNewsPhotoPath;
                            if (System.IO.File.Exists(oldpath))
                                System.IO.File.Delete(oldpath);
                        }

                        string photoName = Guid.NewGuid().ToString() + ".jpg";
                        string path = _eviroment.WebRootPath + "/NewsImages/" + photoName;

                        vm.FNewsPhotoPath = photoName;

                        using (var filestream = new FileStream(path, FileMode.Create))
                        {
                            _news.photo.CopyTo(filestream);
                        }
                    }
                    vm.FNewsType = _news.FNewsType;
                    vm.FNewsTitle = _news.FNewsTitle;
                    vm.FNewsContent = _news.FNewsContent;
                    _context.SaveChanges();
                }
                return RedirectToAction("NewsList");
            }
            catch (Exception ex)
            {
                return Content(ex.ToString());
            }
        }

        public IActionResult DeleteNews(int? id)
        {
            var data = _context.TNews.FirstOrDefault(t => t.FNewsId == id);
            try
            {

                if (data != null)
                {
                    _context.TNews.Remove(data);
                    _context.SaveChanges();
                }
                return RedirectToAction("NewsList");
            }
            catch (Exception ex)
            {
                return Content(ex.ToString());
            }
        }

        public IActionResult NewsSearch(string? keyword)
        {
            try
            {

                if (keyword != null)
                {
                    var news = _context.TNews.Where(s => s.FNewsId.ToString().Contains(keyword) || s.FNewsTitle.Contains(keyword) || s.FNewsContent.Contains(keyword)).OrderByDescending(news => news.FNewsDate);
                    return Json(news);
                }
                var allnwes = _context.TNews.OrderByDescending(news => news.FNewsDate);
                return Json(allnwes);
            }
            catch (Exception ex)
            {
                return Content(ex.ToString());
            }
        }



        public IActionResult CompanyInfo(int? id)
        {
            return View();
        }



    }
}
