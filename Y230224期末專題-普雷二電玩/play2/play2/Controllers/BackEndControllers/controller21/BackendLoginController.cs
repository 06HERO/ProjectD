using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using play2.EFModels;
using play2.ViewModels;
using play2.Models;
using System.Data;

namespace play2.Controllers.BackEndControllers
{
    public class BackendLoginController : Controller
    {
        private readonly ILogger<BackendLoginController> logger;
        private readonly Play2Context db;

        public BackendLoginController(ILogger<BackendLoginController> logger, Play2Context db)
        {
            this.logger = logger;
            this.db = db;
        }

        public IActionResult Login()
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.sekey_EmpLoginID))
            {
                return RedirectToAction("Index", "Backend");
            }
            return View();
        }
    
        [HttpPost]
        public IActionResult Login(CBackendLoginViewModel login)
        {
            var datas=db.TUsers.FirstOrDefault(t=>t.LoginId==login.txtLoginId&&t.LoginPw==login.txtLoginPw);
            System.Threading.Thread.Sleep(1200);
            if (datas!=null)
            {
                string admin = datas.Admin.ToString();
                HttpContext.Session.SetString(CDictionary.sekey_EmpAdmin, admin);      
                HttpContext.Session.SetString(CDictionary.sekey_EmpLoginID, datas.Users);

                return Content("success");
            }
            return Content("fail");
        }

        public IActionResult Logout()
        {                     
            HttpContext.Session.Remove(CDictionary.sekey_EmpAdmin);
            HttpContext.Session.Remove(CDictionary.sekey_EmpLoginID);
            return RedirectToAction("Index","Backend");
        }

    }
}
