using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using play2.Controllers.BackEndControllers.controller16;
using play2.EFModels;
using play2.Models;

namespace play2.Controllers
{
    public class 關於Controller : Controller
    {
        private readonly Play2Context _context;
        public 關於Controller( Play2Context context)
        {
            _context = context;
        
        }

        public IActionResult 公司沿革()
        {      
            return View();
        }

        public IActionResult 重大新聞()
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

        public IActionResult NewsDetail(int? id)
        {
         
            var news = _context.TNews.FirstOrDefault(t => t.FNewsId == id);




            return View(news);
        }


    }
}
