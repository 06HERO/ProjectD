using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using play2.EFModels;
using play2.Models;
using play2.ViewModels;
using System.Diagnostics;
using System.Text.Json;

namespace play2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly Play2Context _context;

        public HomeController(ILogger<HomeController> logger, Play2Context context)
        {
            this.logger = logger;   
            _context = context;

        }

        public IActionResult Index()
        {         
            return View();
        }       

        public IActionResult Privacy()
        {         
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {          
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult search(string? keyword)
        {
            try
            {
               
                    var items = _context.TCommodities.Where(s => s.CommodityName.Contains(keyword));

                    return Json(items);
              
            }
            catch (Exception ex)
            {
                return Content(ex.ToString());
            }
        }



    }


}
