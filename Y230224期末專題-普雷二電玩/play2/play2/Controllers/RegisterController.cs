using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using play2.EFModels;
using play2.Methods;
using play2.Models;
using play2.ViewModels;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text.Json;
using System.Runtime.Serialization.Formatters;

namespace play2.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ILogger<RegisterController> logger;
        private readonly Play2Context db;
        private readonly IWebHostEnvironment Evr;

        public RegisterController(ILogger<RegisterController> logger, Play2Context db , IWebHostEnvironment Evr)
        {
            this.logger = logger;
            this.db = db;
            this.Evr = Evr;
        }


        public IActionResult ChooseType()
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.sekey_Login))
                return RedirectToAction("Index", "Home");
            return View();
        }
        public IActionResult CreReguMem()
        {          
            return View();
        }
        [HttpPost]
        public IActionResult CreReguMem(CreateReguMemberViewModel vm)
        {
            if (vm.LoginEmail == null || vm.LoginPw == null || vm.CheckPw == null
                || vm.MemberName == null || vm.Phone == null || vm.PersonalNumber==null)
                return Content("n");
            else
            {
                var checkmail = db.TMembers.Any(t => t.LoginEmail == vm.LoginEmail);
                var checkpid=db.TRegularMembers.Any(t=>t.PersonalNumber == vm.PersonalNumber);
                if (checkmail)
                    return Content("f");
                else if(checkpid)
                    return Content("i");              
                string ID = (new CMemberID(db)).RegularID(vm.PersonalNumber);               
                var m = new TMember
                {      
                    MemberId=ID,
                    LoginEmail = vm.LoginEmail.ToLower().Trim(),
                    LoginPw = vm.LoginPw.Trim(),
                    MemberType = "Regu",
                    IsCheck = 0                 
                };
                db.TMembers.Add(m);

                var rem = new TRegularMember()
                {
                    MemberId = ID,
                    MemberName = vm.MemberName,
                    PersonalNumber=vm.PersonalNumber,
                    Phone = vm.Phone
                };

                db.TRegularMembers.Add(rem);
                db.SaveChanges();
                HttpContext.Session.SetString(CDictionary.sekey_Verify,ID);                

                return Content("y");
            }
        }
        public IActionResult CreCompMem()
        {        
            return View();
        }
        [HttpPost]
        public IActionResult CreCompMem(CreateCompMemberViewModel vm)
        {
            if (vm.LoginEmail == null || vm.LoginPw == null || vm.CheckPw == null ||
                vm.CompanyName == null || vm.PrincipalMan == null || vm.TaxIdnumber == null ||
                vm.Phone==null || vm.Addrest==null)
                return Content("n");
            else
            {
                var checkmail = db.TMembers.Any(t => t.LoginEmail == vm.LoginEmail);
                var checktid = db.TCompanyMembers.Any(t => t.TaxIdnumber == vm.TaxIdnumber);
                if (checkmail)
                    return Content("f");
                else if (checktid)
                    return Content("i");               
                string ID = (new CMemberID(db)).CompanyID(vm.TaxIdnumber);
                var m = new TMember
                {
                    MemberId = ID,
                    LoginEmail = vm.LoginEmail.ToLower().Trim(),
                    LoginPw = vm.LoginPw.Trim(),
                    MemberType = "Comp",
                    IsCheck = 0                   
                };
                db.TMembers.Add(m);

                var com = new TCompanyMember()
                {
                    MemberId = ID,
                    CompanyName = vm.CompanyName,
                    PrincipalMan = vm.PrincipalMan,
                    TaxIdnumber=vm.TaxIdnumber,
                    Phone = vm.Phone,
                    Addrest=vm.Addrest,
                    SwiftCode=vm.SwiftCode,
                    BankAccount=vm.BankAccount
                };

                db.TCompanyMembers.Add(com);
                db.SaveChanges();
                HttpContext.Session.SetString(CDictionary.sekey_Verify, ID);               

                return Content("y");
            }
        }
        public IActionResult SwiftCodes()
        {
            var datas = db.TSwiftCodes.Select(e => new
            {
                SwiftCode=e.SwiftCode,
                BankName=e.BankName,
                SwiftName=e.SwiftCode+" "+e.BankName
            });
            return Json(datas);
        }


        public IActionResult Verify()
        {
            if (!HttpContext.Session.Keys.Contains(CDictionary.sekey_Verify))
                return RedirectToAction("Index","Home");
            string memberid = HttpContext.Session.GetString(CDictionary.sekey_Verify);
            var user = db.TMembers.FirstOrDefault(t => t.MemberId == memberid);
            if (user == null)
                return RedirectToAction("Index", "Home");
            string email = user.LoginEmail;
            string code = (new CgetCode()).get六位驗證碼();
            HttpContext.Session.SetString(CDictionary.sekey_CheckCode, code);
            db.SaveChanges();          
            (new CMails()).send驗證信(email, code);
            
            return View();
        }
        [HttpPost]
        public IActionResult Verify(CLoginViewModel vm)
        {
            if (!HttpContext.Session.Keys.Contains(CDictionary.sekey_Verify)
                ||!HttpContext.Session.Keys.Contains(CDictionary.sekey_CheckCode))
                return Content("err");
            string id = HttpContext.Session.GetString(CDictionary.sekey_Verify);
            string code= HttpContext.Session.GetString(CDictionary.sekey_CheckCode);
            var data = db.TMembers.FirstOrDefault(t => t.MemberId == id);
            if (code == vm.txtCheckCode.ToUpper())
            {
                data.IsCheck = 1;
                HttpContext.Session.Remove(CDictionary.sekey_CheckCode);
                db.SaveChanges();
                HttpContext.Session.Remove(CDictionary.sekey_Verify);
                HttpContext.Session.SetString(CDictionary.sekey_Login,id);
                HttpContext.Session.SetString(CDictionary.sekey_LoginType, "Regu");
                return Content("y");
            }
            return Content("n");
        }

        public IActionResult CompVerify()
        {
            if (!HttpContext.Session.Keys.Contains(CDictionary.sekey_Verify))
                return RedirectToAction("Index", "Home");
            string memberid = HttpContext.Session.GetString(CDictionary.sekey_Verify);
            var user = db.TMembers.FirstOrDefault(t => t.MemberId == memberid);
            if (user == null)
                return RedirectToAction("Index", "Home");
            string email = user.LoginEmail;
            string code = (new CgetCode()).get六位驗證碼();
            HttpContext.Session.SetString(CDictionary.sekey_CheckCode, code);
            db.SaveChanges();
            (new CMails()).send驗證信(email, code);

            return View();
        }
        [HttpPost]
        public IActionResult CompVerify(CLoginViewModel vm)
        {
            if (!HttpContext.Session.Keys.Contains(CDictionary.sekey_Verify)
              || !HttpContext.Session.Keys.Contains(CDictionary.sekey_CheckCode))
                return Content("err");
            string id = HttpContext.Session.GetString(CDictionary.sekey_Verify);
            string code = HttpContext.Session.GetString(CDictionary.sekey_CheckCode);
            var data = db.TMembers.FirstOrDefault(t => t.MemberId == id);
            if (code == vm.txtCheckCode.ToUpper())
            {
                data.IsCheck = 2;
                HttpContext.Session.Remove(CDictionary.sekey_CheckCode);
                db.SaveChanges();               
                return Content("y");
            }
            return Content("n");
        }
        public IActionResult CompFileVerify()
        {
            if (!HttpContext.Session.Keys.Contains(CDictionary.sekey_Verify))
                return RedirectToAction("Index", "Home");
            string memberid = HttpContext.Session.GetString(CDictionary.sekey_Verify);
            var user = db.TMembers.FirstOrDefault(t => t.MemberId == memberid);
            if (user == null)
                return RedirectToAction("Index", "Home");
            if (user.IsCheck != 2 && user.IsCheck !=4)
                return RedirectToAction("CompVerify", "Register");
            else if(user.IsCheck == 1)
                return RedirectToAction("Index", "Home");          
            return View();
        }
        [HttpPost]
        public IActionResult CompFileVerify(IFormFile file)
        {
            if (!HttpContext.Session.Keys.Contains(CDictionary.sekey_Verify))
                return Content("err");
            string id = HttpContext.Session.GetString(CDictionary.sekey_Verify);
            var user = db.TMembers.FirstOrDefault(t => t.MemberId == id);
            var data = db.TCompanyMembers.FirstOrDefault(t => t.MemberId == id);
            
            if (file==null)
                return Content("n");
            //判斷是否為pdf檔
            string type=file.ContentType;
            if (type != "application/pdf")
                return Content("nopdf");
            //如果有一樣的檔案就刪除
            if (data.FilePath != null)
            {
                string olddatapath = Path.Combine(Evr.WebRootPath, "NewCompMemberFile", data.FilePath);
                if (System.IO.File.Exists(olddatapath))
                    System.IO.File.Delete(olddatapath);
            }
            //檔案上傳，資料庫更新
            string fileName = id + ".pdf";
            string path = Path.Combine(Evr.WebRootPath, "NewCompMemberFile", fileName);
            using (var filesStream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(filesStream);
            }
            data.FilePath = fileName;
            user.IsCheck = 3;
            db.SaveChanges();

            (new CMails()).send靜待註冊(user.LoginEmail);
            HttpContext.Session.Remove(CDictionary.sekey_Verify);
            return Content("success");
        }


    }
}
