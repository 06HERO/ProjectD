using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NuGet.Protocol;
using play2.EFModels;
using play2.Models;

namespace play2.Controllers
{
    public class CommodityController : Controller
    {

        private readonly ILogger<CommodityController> logger;
        private readonly Play2Context db;

        public CommodityController(ILogger<CommodityController> logger, Play2Context db)
        {
            this.logger = logger;
            this.db = db;
        }

        public IActionResult ProList(int? id)
        {
            var datas = db.View商品完整資訊s.Select(x=>x);
            if (id == 1)
            {
                datas = db.View商品完整資訊s.Where(x => x.GameStation == "PC" || x.GameStation == "XBOX");
            }else if (id == 2)
            {
                datas = db.View商品完整資訊s.Where(x => x.GameStation == "PS5" || x.GameStation == "PS4");
            }else if (id == 3)
            {
                datas = db.View商品完整資訊s.Where(x => x.GameStation == "NS" );
            }
            
            
            return View(datas);
        }
        public IActionResult ProList_tagID(int? id)
        {
            if (id == null)
            {
                RedirectToAction("ProList");
            }
            var datas = db.View商品tagids.Where(x => x.TagId == id);
            return View(datas);
        }

        public IActionResult Details(int? id)
        {
            if(id == null)
            {
                return View("ProList");
            }
            var datas = db.View商品完整資訊s.FirstOrDefault(t => t.CommodityId == id);
            
            return View(datas);            
        }

        public IActionResult GameType()
        {
            var datas = db.TTagLists;
            return Json(datas);
        }
        //相似的遊戲類型
        public IActionResult similargames()
        {
            var datas = db.View商品tagids;
            return Json(datas);
        }

        public IActionResult CartEndorNot()
        {
            string CartEndorNet = "fail";
            if (!HttpContext.Session.Keys.Contains(CDictionary.sekey_Product_Catt_Order_End))
            {
                return Content(CartEndorNet);
            }
            CartEndorNet = HttpContext.Session.GetString(CDictionary.sekey_Product_Catt_Order_End);
            HttpContext.Session.Remove(CDictionary.sekey_Product_Catt_Order_End);
            
            return Content(CartEndorNet);
        }
    }
}
