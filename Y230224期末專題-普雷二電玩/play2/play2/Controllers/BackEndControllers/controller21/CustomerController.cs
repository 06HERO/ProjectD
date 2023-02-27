using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using play2.Controllers.BackEndControllers;
using play2.EFModels;
using play2.Methods;
using play2.Models;
using System.Data;
using System.Drawing.Printing;

namespace play2.Controllers
{

    public class CustomerController : Controller
    {
        private readonly ILogger<CustomerController> logger;
        private readonly Play2Context db;
        private readonly IWebHostEnvironment evr;

        public CustomerController(ILogger<CustomerController> logger, Play2Context db, IWebHostEnvironment evr)
        {
            this.logger = logger;
            this.db = db;
            this.evr = evr;
        }

        public IActionResult ReguList(int? id)
        {
            var datas = db.View一般會員資料表s.OrderByDescending(t => t.MemberId);
            if (id != null)
            {              
                datas = db.View一般會員資料表s.Where(t=>t.IsCheck==id).OrderByDescending(t => t.MemberId);
            }
            ViewBag.Option = id;
            return View(datas);
        }

        [HttpPost]
        public IActionResult ReguDetail(string? id)
        {
            var data = db.View一般會員詳細資料s.Where(t => t.MemberId == id);
            return View(data);
        }
        [HttpPost]
        public IActionResult ReguCancel(string MemberId, string LoginEmail)
        {
            try
            {
                var data = db.TMembers.Where(t => t.MemberId == MemberId).FirstOrDefault();
                var reg = db.TRegularMembers.Where(t => t.MemberId == MemberId).FirstOrDefault();
                db.TRegularMembers.Remove(reg);
                db.TMembers.Remove(data);
                db.SaveChanges();
                (new CMails()).send刪除帳號(LoginEmail);
                return Content("ok");
            }
            catch(Exception ex)
            {
                return Content("fail");
            }
        }


        public IActionResult CompList(int? id)
        {
            var datas = db.View經銷商會員資料表s.OrderByDescending(t => t.MemberId);
            if (id == null)
            {
                datas = db.View經銷商會員資料表s.OrderByDescending(t => t.MemberId);
            }
            else if (id == 0)
            {
                datas = db.View經銷商會員資料表s.Where(t => t.IsCheck == 0 || t.IsCheck == 2).OrderByDescending(t => t.MemberId);
            }
            else
            {
                datas = db.View經銷商會員資料表s.Where(t => t.IsCheck == id).OrderByDescending(t => t.MemberId);
            }
            ViewBag.Option = id;
            return View(datas);      
        }
        [HttpPost]
        public IActionResult CompDetail(string? id)
        {
            var data = db.View經銷商會員資料表s.FirstOrDefault(t => t.MemberId == id);
            return View(data);
        }
        [HttpPost]
        public IActionResult CompEdit(View經銷商會員資料表 cm)
        {
            var data = db.TCompanyMembers.FirstOrDefault(t => t.MemberId == cm.MemberId);
            if (data != null)
            {
                data.Credits = cm.Credits;
                data.CreditLevel = cm.CreditLevel;
                data.Notes = cm.Notes;
                db.SaveChanges();
            }      
            return RedirectToAction("CompList");
        }
        [HttpPost]
        public IActionResult PassWa(View經銷商會員資料表 cm)
        {
            var data = db.TMembers.FirstOrDefault(t => t.MemberId == cm.MemberId);
            data.IsCheck = 1;
            (new CMails()).send認證通過(cm.LoginEmail);
            db.SaveChanges();        
            return Content("ok");
        }
        [HttpPost]
        public IActionResult FailWa(View經銷商會員資料表 cm)
        {
            var data = db.TMembers.FirstOrDefault(t => t.MemberId == cm.MemberId);
            data.IsCheck = 4;
            (new CMails()).send認證未通過(cm.LoginEmail);
            db.SaveChanges();
            return Content("ok");
        }
        [HttpPost]
        public IActionResult Suspens(string MemberId, string LoginEmail,string Notes)
        {
            var data = db.TMembers.FirstOrDefault(t => t.MemberId == MemberId&&t.LoginEmail== LoginEmail);
            data.IsCheck = -1;
            db.SaveChanges();
            (new CMails()).send取消資格(LoginEmail, Notes);
            return Content("ok");
        }
        [HttpPost]
        public IActionResult CompCancel(View經銷商會員資料表 cm)
        {
            var data = db.TMembers.Where(t => t.MemberId == cm.MemberId).FirstOrDefault();
            var com = db.TCompanyMembers.Where(t => t.MemberId == data.MemberId).FirstOrDefault();
            if (com.FilePath != null)
            {
                string olddatapath = Path.Combine(evr.WebRootPath, "NewCompMemberFile", com.FilePath);
                if (System.IO.File.Exists(olddatapath))
                    System.IO.File.Delete(olddatapath);
            }
            db.TCompanyMembers.Remove(com);
            db.TMembers.Remove(data);
            db.SaveChanges();
            (new CMails()).send刪除帳號(cm.LoginEmail);
            return Content("ok");
        }
        [HttpPost]
        public IActionResult Back(string MemberId, string LoginEmail)
        {
            var data = db.TMembers.Where(t => t.MemberId == MemberId).FirstOrDefault();
            data.IsCheck = 1;
            db.SaveChanges();
            (new CMails()).send還原帳號(LoginEmail);
            return Content("ok");
        }

    }
}
