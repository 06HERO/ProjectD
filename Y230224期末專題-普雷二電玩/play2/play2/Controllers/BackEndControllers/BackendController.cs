using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using play2.Models;
using System.Diagnostics;

namespace play2.Controllers.BackEndControllers
{
    [Authorize]
    public class BackendController : Controller
    {
        private readonly ILogger<BackendController> _logger;

        public BackendController(ILogger<BackendController> logger)
        {
            _logger = logger;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Insufficient()
        {
            return View();
        }

        //-------------------這裡是 !! 後台管理系統 !! --------------------


        //-------------------基礎設施--------------------


        public IActionResult personData()  //個人資料維護
        {
            return PartialView();
        }


        public IActionResult userEdit() //使用者編輯維護
        {
            return PartialView();
        }

        public IActionResult newsPublisher() //公司資訊發布管理
        {
            return PartialView();
        }

        public IActionResult productEdit() //商品上架管理
        {
            return PartialView();
        }

        //--------------------採購進貨--------------------
        public IActionResult vendorEdit() //廠商維護系統
        {
            return PartialView();
        }

        public IActionResult purchaseEdit() //進貨單維護查詢
        {
            return PartialView();
        }


        //--------------------銷售出貨--------------------
        public IActionResult customerEdit() // 顧客維護系統
        {
            return PartialView();
        }

        public IActionResult ordersEdit() //出貨單維護查詢
        {
            return PartialView();
        }

        public IActionResult refundEdit()  //退貨折讓維護查詢
        {
            return PartialView();
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
    }
}
