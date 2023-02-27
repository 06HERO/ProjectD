using Microsoft.AspNetCore.Mvc;
using play2.Models;

namespace play2.Controllers
{
    public class 經銷門市Controller : Controller
    {
        public IActionResult 門市清單()
        {
            return View();
        }
    }
}
