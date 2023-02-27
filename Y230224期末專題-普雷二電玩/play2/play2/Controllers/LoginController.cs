using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using play2.EFModels;
using play2.Methods;
using play2.Models;
using play2.ViewModels;
using System.Security.Claims;

namespace play2.Controllers
{   
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> logger;
        private readonly Play2Context db;

        public LoginController(ILogger<LoginController> logger, Play2Context db)
        {
            this.logger = logger;
            this.db = db;
        }   

    
        [HttpPost]
        public IActionResult Login(CLoginViewModel vm)
        {
            System.Threading.Thread.Sleep(1200);
            if (HttpContext.Session.Keys.Contains(CDictionary.sekey_Login))
                return Content("isLogin");
            if (vm.txtLoginEmail == null || vm.txtLoginPW == null)
                return Content("n");
            if (!db.TMembers.Any(t => t.LoginEmail == vm.txtLoginEmail.ToLower()))
                return Content("noRegister");
            var user = db.TMembers.FirstOrDefault(t => t.LoginEmail == vm.txtLoginEmail.ToLower() && t.LoginPw == vm.txtLoginPW);
            if (user != null)
            {                
                if (user.IsCheck == -1)
                {
                    return Content("Suspens");
                }
                if (user.MemberType == "Regu")
                {
                    if (user.IsCheck == 0)
                    {
                        HttpContext.Session.SetString(CDictionary.sekey_Verify, user.MemberId);
                        return Content("noReguverify");
                    }
                    else
                    {
                        HttpContext.Session.Remove(CDictionary.sekey_Verify);
                        HttpContext.Session.SetString(CDictionary.sekey_Login, user.MemberId);
                        HttpContext.Session.SetString(CDictionary.sekey_LoginType, "Regu");
                        return Content("success");
                    }
                }
                else if (user.MemberType == "Comp")
                {
                    if (user.IsCheck == 0)
                    {
                        HttpContext.Session.SetString(CDictionary.sekey_Verify, user.MemberId);
                        return Content("noComverify");
                    }
                    else if (user.IsCheck == -1)
                    {
                        return Content("Suspens");
                    }
                    else if (user.IsCheck == 2)
                    {
                        HttpContext.Session.SetString(CDictionary.sekey_Verify, user.MemberId);
                        return Content("noCompFileverify");
                    }
                    else if (user.IsCheck == 3)
                        return Content("waitToCheck");
                    else if (user.IsCheck == 4)
                    {
                        HttpContext.Session.SetString(CDictionary.sekey_Verify, user.MemberId);
                        return Content("reToCheck");
                    }
                    else
                    {
                        HttpContext.Session.Remove(CDictionary.sekey_Verify);
                        HttpContext.Session.SetString(CDictionary.sekey_Login, user.MemberId);
                        HttpContext.Session.SetString(CDictionary.sekey_LoginType, "Comp");
                        return Content("success");
                    }
                }
                else if (user.MemberType == "Emp")
                {
                    HttpContext.Session.Remove(CDictionary.sekey_Verify);
                    HttpContext.Session.SetString(CDictionary.sekey_EmpLoginCheck,"isCheck");
                    return Content("isEmpLogin");
                }
            }
            return Content("f");
        }
       
        public  IActionResult Logout()
        {            
            HttpContext.Session.Remove(CDictionary.sekey_EmpLoginCheck);
            HttpContext.Session.Remove(CDictionary.sekey_EmpAdmin);
            HttpContext.Session.Remove(CDictionary.sekey_EmpLoginID);
            HttpContext.Session.Remove(CDictionary.sekey_Login);
            HttpContext.Session.Remove(CDictionary.sekey_LoginType);
            return RedirectToAction("Index","Home");
        }
 
        public IActionResult ForgotPW()
        {         
            return View();
        }
        [HttpPost]
        public IActionResult MailCode(string email)
        {
            var user = db.TMembers.FirstOrDefault(t => t.LoginEmail == email.ToLower());
            if(user == null)
                return Content("noemail");
            string code = (new CgetCode()).get六位驗證碼();
            HttpContext.Session.SetString(CDictionary.sekey_CheckCode, code);
            db.SaveChanges();
            HttpContext.Session.SetString(CDictionary.sekey_ForgotPW, user.MemberId);
            (new CMails()).send驗證信(email, code);
            return Content("mailcode");
        }

        [HttpPost]
        public IActionResult CheckCode(string Code)
        {
            if (!HttpContext.Session.Keys.Contains(CDictionary.sekey_ForgotPW) || string.IsNullOrEmpty(Code)
                || !HttpContext.Session.Keys.Contains(CDictionary.sekey_CheckCode))
                return Content("err");
            string memberid = HttpContext.Session.GetString(CDictionary.sekey_ForgotPW);
            string code = HttpContext.Session.GetString(CDictionary.sekey_CheckCode);
            var user = db.TMembers.FirstOrDefault(t => t.MemberId == memberid);
            if (code == Code.ToUpper())
            {
                user.IsCheck = 1;
                HttpContext.Session.Remove(CDictionary.sekey_CheckCode);
                db.SaveChanges();
                HttpContext.Session.SetString(CDictionary.sekey_CheckPW, "ISCHECKED");
                return Content("success");
            }
            return Content("f");
        }
           
        public IActionResult ChangePW()
        {       
            string? check = HttpContext.Session.GetString(CDictionary.sekey_CheckPW);
            string? ID = HttpContext.Session.GetString(CDictionary.sekey_ForgotPW);
            if (check != "ISCHECKED" || ID == null)
            {
                return RedirectToAction("Index","Home");
            }
            return View();
        }
        [HttpPost]
        public IActionResult ChangePW(string PW)
        {
            string? check= HttpContext.Session.GetString(CDictionary.sekey_CheckPW);
            string? ID= HttpContext.Session.GetString(CDictionary.sekey_ForgotPW);
            if (check != "ISCHECKED" || ID == null)
            {
                return Content("failconnect");
            }
            if (!string.IsNullOrEmpty(PW))
            {
                var user = db.TMembers.FirstOrDefault(t => t.MemberId == ID);
                user.LoginPw=PW;
                db.SaveChanges();
                HttpContext.Session.Remove(CDictionary.sekey_CheckPW);
                HttpContext.Session.Remove(CDictionary.sekey_ForgotPW);
                HttpContext.Session.SetString(CDictionary.sekey_Login, user.MemberId);
                
                return Content("success");
            }
            return Content("n");
        }
    }
}
