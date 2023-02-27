using Microsoft.AspNetCore.Mvc;
using play2.EFModels;
using play2.Methods;
using play2.Models;
using play2.ViewModels;

namespace play2.Controllers
{
    public class MemberCenterController : Controller
    {
        private readonly ILogger<MemberCenterController> logger;
        private readonly Play2Context db;

        public MemberCenterController(ILogger<MemberCenterController> logger, Play2Context db)
        {
            this.logger = logger;
            this.db = db;
        }

        public IActionResult MemberData()
        {
            if (!HttpContext.Session.Keys.Contains(CDictionary.sekey_Login))
                return RedirectToAction("ChooseType", "Register");
            string type = HttpContext.Session.GetString(CDictionary.sekey_LoginType);
            if (type == "Regu")
                return RedirectToAction("RegularData");
            else if(type == "Comp")
                return RedirectToAction("CompanyData");        
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult ChangePW(string LoginPw,string CheckPw)
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.sekey_Login))
            {
                if (LoginPw != CheckPw)
                    return Content("fail");
                string memberid= HttpContext.Session.GetString(CDictionary.sekey_Login);
                var data = db.TMembers.FirstOrDefault(t => t.MemberId == memberid);
                data.LoginPw = CheckPw;
                db.SaveChanges();
                return Content("success");
            }
            return NoContent();
        }
        [HttpPost]
        public IActionResult EditMemberData(List<View一般會員詳細資料> vm)
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.sekey_Login))
            {
                try
                {
                    string memberid = HttpContext.Session.GetString(CDictionary.sekey_Login);
                    var data = db.TMembers.FirstOrDefault(t => t.MemberId == memberid);
                    //以下是修改地址
                    if (vm[0].Addrest != null)
                    {
                        var addrest1 = db.TRegularMemberAddrests.ToList().Where(t => t.MemberId == memberid).ElementAtOrDefault(0);
                        if (addrest1 != null)
                            addrest1.Addrest = vm[0].Addrest;
                        else
                        {
                            TRegularMemberAddrest ad1 = new TRegularMemberAddrest()
                            {
                                MemberId = memberid,
                                Addrest = vm[0].Addrest
                            };
                            db.TRegularMemberAddrests.Add(ad1);
                        }
                        if (vm[1].Addrest != null)
                        {
                            var addrest2 = db.TRegularMemberAddrests.ToList().Where(t => t.MemberId == memberid).ElementAtOrDefault(1);
                            if (addrest2 != null)
                                addrest2.Addrest = vm[1].Addrest;
                            else
                            {
                                TRegularMemberAddrest ad2 = new TRegularMemberAddrest()
                                {
                                    MemberId = memberid,
                                    Addrest = vm[1].Addrest
                                };
                                db.TRegularMemberAddrests.Add(ad2);
                            }
                        }
                        if (vm[2].Addrest != null)
                        {
                            var addrest3 = db.TRegularMemberAddrests.ToList().Where(t => t.MemberId == memberid).ElementAtOrDefault(2);
                            if (addrest3 != null)
                                addrest3.Addrest = vm[2].Addrest;
                            else
                            {
                                TRegularMemberAddrest ad3 = new TRegularMemberAddrest()
                                {
                                    MemberId = memberid,
                                    Addrest = vm[2].Addrest
                                };
                                db.TRegularMemberAddrests.Add(ad3);
                            }
                        }
                    }
                    //以下是修改銀行帳戶
                    if (vm[0].SwiftCode != null && vm[0].BankAccount != null)
                    {
                        var swiftcode1 = db.TRegularMemberBankAccounts.ToList().Where(t => t.MemberId == memberid).ElementAtOrDefault(0);
                        if (swiftcode1 != null)
                        {
                            swiftcode1.SwiftCode = vm[0].SwiftCode;
                            swiftcode1.BankAccount = vm[0].BankAccount;
                        }
                        else
                        {
                            TRegularMemberBankAccount bankacc1 = new TRegularMemberBankAccount()
                            {
                                MemberId = memberid,
                                SwiftCode = vm[0].SwiftCode,
                                BankAccount = vm[0].BankAccount
                            };
                            db.TRegularMemberBankAccounts.Add(bankacc1);
                        }
                    }
                    if (vm[1].SwiftCode != null && vm[1].BankAccount != null)
                    {
                        var swiftcode2 = db.TRegularMemberBankAccounts.ToList().Where(t => t.MemberId == memberid).ElementAtOrDefault(1);
                        if (swiftcode2 != null)
                        {
                            swiftcode2.SwiftCode = vm[1].SwiftCode;
                            swiftcode2.BankAccount = vm[1].BankAccount;
                        }
                        else
                        {
                            TRegularMemberBankAccount bankacc2 = new TRegularMemberBankAccount()
                            {
                                MemberId = memberid,
                                SwiftCode = vm[1].SwiftCode,
                                BankAccount = vm[1].BankAccount
                            };
                            db.TRegularMemberBankAccounts.Add(bankacc2);
                        }
                    }
                    if (vm[2].SwiftCode != null && vm[2].BankAccount != null)
                    {
                        var swiftcode3 = db.TRegularMemberBankAccounts.ToList().Where(t => t.MemberId == memberid).ElementAtOrDefault(2);
                        if (swiftcode3 != null)
                        {
                            swiftcode3.SwiftCode = vm[2].SwiftCode;
                            swiftcode3.BankAccount = vm[2].BankAccount;
                        }
                        else
                        {
                            TRegularMemberBankAccount bankacc3 = new TRegularMemberBankAccount()
                            {
                                MemberId = memberid,
                                SwiftCode = vm[2].SwiftCode,
                                BankAccount = vm[2].BankAccount
                            };
                            db.TRegularMemberBankAccounts.Add(bankacc3);
                        }
                    }
                    db.SaveChanges();
                    return Content("success");
                }
                catch
                {
                    return NoContent();
                }
            }
            return NoContent();
        }

        public IActionResult RegularData()
        {
            if (!HttpContext.Session.Keys.Contains(CDictionary.sekey_Login))
                return RedirectToAction("ChooseType", "Register");

            string memberid = HttpContext.Session.GetString(CDictionary.sekey_Login);
            var memberdatas = db.View一般會員詳細資料s.Where(t => t.MemberId == memberid);
            return View(memberdatas);
        }
        public IActionResult CompanyData()
        {
            if (!HttpContext.Session.Keys.Contains(CDictionary.sekey_Login))
                return RedirectToAction("ChooseType", "Register");

            string memberid = HttpContext.Session.GetString(CDictionary.sekey_Login);
            var memberdatas = db.View經銷商會員資料表s.FirstOrDefault(t => t.MemberId == memberid);
            return View(memberdatas);        
        }


        public IActionResult MemberOrder()
        {
            if (!HttpContext.Session.Keys.Contains(CDictionary.sekey_Login))
                return RedirectToAction("ChooseType", "Register");

            string memberid = HttpContext.Session.GetString(CDictionary.sekey_Login);
            var datas = db.View訂單完整資訊s.Where(t => t.MemberId == memberid).OrderByDescending(t => t.OrderDate);
            return View(datas);
        }

        public IActionResult MemberOrderDetail(int? id)
        {
            if (!HttpContext.Session.Keys.Contains(CDictionary.sekey_Login))
                return RedirectToAction("ChooseType", "Register");
            if (id == null)
                return RedirectToAction("MemberOrder");

            var datas = db.View訂單明細品名對照s.Where(t => t.DelOrderId == id);
    
            return View(datas);
        }
        [HttpPost]
        public IActionResult CancelOrder(int? id,string note)
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.sekey_Login))
            {               
                string memberid = HttpContext.Session.GetString(CDictionary.sekey_Login);
                var data = db.TDeliveryOrders.FirstOrDefault(t =>t.DelOrderId==id&& t.MemberId == memberid);
                if (data != null)
                {                     
                    if(data.Notes!=null)
                        data.Notes+= "<br/><h5>退貨原因：</h5>" + note;
                    else
                        data.Notes = "<h5>退貨原因：</h5>" + note;
                    data.OrderStateId = 6;
                    db.SaveChanges();
                    return Content("success");
                }                
            }
            return NoContent();
        }
        [HttpPost]
        public IActionResult PayOrder(int? id)
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.sekey_Login))
            {
                string memberid = HttpContext.Session.GetString(CDictionary.sekey_Login);
                var data = db.TDeliveryOrders.FirstOrDefault(t => t.DelOrderId == id && t.MemberId == memberid);
                if (data != null)
                {
                    data.PayDate = DateTime.Now;
                    data.Ispay = "y";
                    db.SaveChanges();
                    return Content("success");
                }
            }
            return NoContent();
        }




    }
}
