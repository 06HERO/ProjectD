using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using play2.EFModels;
using play2.Methods;
using play2.Models;
using play2.ViewModels;
using System.Text.Json;

namespace play2.Controllers
{
    public class CartController : Controller
    {
        private readonly ILogger<CartController> logger;
        private readonly Play2Context db;

        public CartController(ILogger<CartController> logger, Play2Context db)
        {
            this.logger = logger;
            this.db = db;
        }
        //購物車
        //資料從商品側匯入
        public IActionResult AddtoCart(int? id, int? count)
        {
            View商品完整資訊 pro_info = db.View商品完整資訊s.FirstOrDefault(x => x.CommodityId == id);
            if (pro_info == null)
            {
                return RedirectToAction("ProList", "Commodity");
            }
            List<CShoppingCart_item> cart = null;
            string json_txt = "";
            if (HttpContext.Session.Keys.Contains(CDictionary.sekey_Product_Cart_Add))
            {
                //判斷有無資料，有則取資料
                json_txt = HttpContext.Session.GetString(CDictionary.sekey_Product_Cart_Add);
                cart = JsonSerializer.Deserialize<List<CShoppingCart_item>>(json_txt);
            }
            else
            {
                //沒有則建立資料
                cart = new List<CShoppingCart_item>();//建立新資料
            }

            int index = cart.FindIndex(m => m.CommodityId.Equals(id));
            CShoppingCart_item x = new CShoppingCart_item();
            if (count == null)
            {
                count = 1;
            }

            if (index != -1)
            {
                cart[index].qty = cart[index].qty + (int)count;
                
            }
            else
            {
                x.CommodityId = pro_info.CommodityId;
                x.qty = (int)count;
                x.price = (decimal)pro_info.Price * x.qty;
                x.product = pro_info;
                cart.Add(x);
            }

            json_txt = JsonSerializer.Serialize(cart);
            HttpContext.Session.SetString(CDictionary.sekey_Product_Cart_Add, json_txt);

            return NoContent();
        }
                
        //刪除某筆 sesion 資料
        public IActionResult RemoveCartItem(int id)
        {
            View商品完整資訊 pro_info = db.View商品完整資訊s.FirstOrDefault(x => x.CommodityId == id);
            if (pro_info == null)
            {
                return NoContent();
            }
            string cart_txt = HttpContext.Session.GetString(CDictionary.sekey_Product_Cart_Add);
            List<CShoppingCart_item> cart_Items = JsonSerializer.Deserialize<List<CShoppingCart_item>>(cart_txt);

            int index = cart_Items.FindIndex(m => m.CommodityId.Equals(id));
            cart_Items.RemoveAt(index);
            if (cart_Items.Count < 1)
            {
                HttpContext.Session.Remove(CDictionary.sekey_Product_Cart_Add);
                return RedirectToAction("ProList", "Commodity");
            }
            else
            {
                cart_txt = JsonSerializer.Serialize(cart_Items);
                HttpContext.Session.SetString(CDictionary.sekey_Product_Cart_Add, cart_txt);
            }

            return RedirectToAction("CheckCart");
        }
        public IActionResult CheckCart(int? id)//檢查購物車
        {
            //if 認證登入
            //if (!HttpContext.Session.Keys.Contains(CDictionary.sekey_Login))
            //    return RedirectToAction("ChooseType", "Register");

            //防止沒有相關訊息開啟購買頁面
            if (!HttpContext.Session.Keys.Contains(CDictionary.sekey_Product_Cart_Add))
            {
                return RedirectToAction("ProList", "Commodity");
            }
            //取值文字檔
            string cart_txt = HttpContext.Session.GetString(CDictionary.sekey_Product_Cart_Add);
            //轉成 list
            
            List<CShoppingCart_item> cart_List = JsonSerializer.Deserialize<List<CShoppingCart_item>>(cart_txt);
            
           
            //匯入資料
            return View(cart_List);
        }
        [HttpPost]
        public IActionResult CheckCart(CShoppingCart_item p)
        {
            string cart = HttpContext.Session.GetString(CDictionary.sekey_Product_Cart_Add);
            List<CShoppingCart_item> cart_List = JsonSerializer.Deserialize<List<CShoppingCart_item>>(cart);
            //cart_list
            return NoContent();
        }
        //ajax 傳值
        public IActionResult Cart_json()
        {            
            var datas = HttpContext.Session.GetString(CDictionary.sekey_Product_Cart_Add);
            return Json(datas);
        }
        public IActionResult AddtoCart_json(int? id, int? count)
        {
            View商品完整資訊 pro_info = db.View商品完整資訊s.FirstOrDefault(x => x.CommodityId == id);
            if (pro_info == null)
            {
                return Content("no_cart_id");
            }
            List<CShoppingCart_item> cart = null;
            string json_txt = "";
            if (HttpContext.Session.Keys.Contains(CDictionary.sekey_Product_Cart_Add))
            {
                //判斷有無資料，有則取資料
                json_txt = HttpContext.Session.GetString(CDictionary.sekey_Product_Cart_Add);
                cart = JsonSerializer.Deserialize<List<CShoppingCart_item>>(json_txt);
            }
            else
            {
                //沒有則建立資料
                cart = new List<CShoppingCart_item>();//建立新資料
            }

            int index = cart.FindIndex(m => m.CommodityId.Equals(id));
            CShoppingCart_item x = new CShoppingCart_item();
            if (count == null)
            {
                count = 1;
            }

            if (index != -1)
            {
                cart[index].qty = cart[index].qty + (int)count;

            }
            else
            {
                x.CommodityId = pro_info.CommodityId;
                x.qty = (int)count;
                x.price = (decimal)pro_info.Price * x.qty;
                x.product = pro_info;
                cart.Add(x);
            }

            json_txt = JsonSerializer.Serialize(cart);
            HttpContext.Session.SetString(CDictionary.sekey_Product_Cart_Add, json_txt);

            return NoContent();
        }
        //調整購物車數量
        public IActionResult changetoCart_json(int? id, int? count)
        {
            View商品完整資訊 pro_info = db.View商品完整資訊s.FirstOrDefault(x => x.CommodityId == id);
            if (pro_info == null)
            {
                return Content("no_cart_id");
            }
            List<CShoppingCart_item> cart = null;
            string json_txt = "";
            if (HttpContext.Session.Keys.Contains(CDictionary.sekey_Product_Cart_Add))
            {
                //判斷有無資料，有則取資料
                json_txt = HttpContext.Session.GetString(CDictionary.sekey_Product_Cart_Add);
                cart = JsonSerializer.Deserialize<List<CShoppingCart_item>>(json_txt);
            }
            else
            {
                //沒有則建立資料
                cart = new List<CShoppingCart_item>();//建立新資料
            }

            int index = cart.FindIndex(m => m.CommodityId.Equals(id));
            CShoppingCart_item x = new CShoppingCart_item();
            if (count == null||count==0)
            {
                count = 1;
            }

            if (index != -1)
            {
                cart[index].qty = (int)count;

            }
            else
            {
                x.CommodityId = pro_info.CommodityId;
                x.qty = (int)count;
                x.price = (decimal)pro_info.Price * x.qty;
                x.product = pro_info;
                cart.Add(x);
            }

            json_txt = JsonSerializer.Serialize(cart);
            HttpContext.Session.SetString(CDictionary.sekey_Product_Cart_Add, json_txt);

            return NoContent();
        }


        public IActionResult CheckoutCart(CShoppingCart_item p)//結帳
        {
            try
            {
                if (!HttpContext.Session.Keys.Contains(CDictionary.sekey_Login))
                    return RedirectToAction("ChooseType", "Register");

                //防止沒有相關訊息開啟購買頁面
                if (!HttpContext.Session.Keys.Contains(CDictionary.sekey_Product_Cart_Add))
                {
                    return RedirectToAction("ProList", "Commodity");
                }
                //取值文字檔
                string cart_txt = HttpContext.Session.GetString(CDictionary.sekey_Product_Cart_Add);
                //轉成 list 
                List<CShoppingCart_item> cart_List = JsonSerializer.Deserialize<List<CShoppingCart_item>>(cart_txt);
                //匯入資料

                decimal sum_price = 0;
                foreach (var item in cart_List)
                {
                    sum_price += item.price * item.qty;

                }
                ViewBag.sum_price = sum_price;
                ViewBag.freight = 0;
                if (sum_price < 1500)
                {

                    sum_price = sum_price + 60;
                    ViewBag.freight = 60;
                }
                ViewBag.OrderMoney = sum_price;

                string memberid = HttpContext.Session.GetString(CDictionary.sekey_Login);

                var data = db.TMembers.FirstOrDefault(x => x.MemberId == memberid);
                CShoppingCart_item member = cart_List[0];

                member.member_id = memberid;
                if (data.MemberType == "Comp")
                {

                    var member_1 = db.View經銷商會員資料表s.FirstOrDefault(x => x.MemberId == memberid);
                    member.member_address = member_1.Addrest;
                    member.member_name = member_1.CompanyName;
                    member.member_phone = member_1.Phone;
                    member.member_email = member_1.LoginEmail;
                    member.member_Bank_num = member_1.SwiftCode;
                    member.member_Card_Num = member_1.BankAccount;
                }
                else if (data.MemberType == "Regu")
                {

                    var member_1 = db.View一般會員詳細資料s.FirstOrDefault(x => x.MemberId == memberid);
                    member.member_address = member_1.Addrest;
                    member.member_name = member_1.MemberName;
                    member.member_phone = member_1.Phone;
                    member.member_email = member_1.LoginEmail;
                    member.member_Bank_num = member_1.SwiftCode;
                    member.member_Card_Num = member_1.BankAccount;
                }


                return View(cart_List);
            }
            catch{ return RedirectToAction("ProList", "Commodity"); }
        }
        
        public IActionResult CreatveOrder(TDeliveryOrder p)
        {
            //防止沒有相關訊息開啟購買頁面
            if (!HttpContext.Session.Keys.Contains(CDictionary.sekey_Product_Cart_Add))
            {
                return RedirectToAction("ProList", "Commodity");
            }
            
            TDeliveryOrder Cart_order = new TDeliveryOrder();
            Cart_order.MemberId = HttpContext.Session.GetString(CDictionary.sekey_Login);
            Cart_order.ContactMan = p.ContactMan;
            Cart_order.ContactPhone = p.ContactPhone;
            Cart_order.Email= p.Email;
            Cart_order.Adderst = p.Adderst;
            Cart_order.SwiftCode = p.SwiftCode;
            Cart_order.Bankaccount = p.Bankaccount.Trim();
            Cart_order.Notes = p.Notes;
            Cart_order.OrderDate = DateTime.Now;
            Cart_order.DeliveryDate = DateTime.Now.AddDays(7);
            //滿 1500 預設免運
            Cart_order.LogisticsMoney = p.LogisticsMoney;
            Cart_order.OrderMoney= p.OrderMoney;
            Cart_order.OrderStateId = 1;
            Cart_order.Ispay = "n";
            if (HttpContext.Session.GetString(CDictionary.sekey_Product_Cart_payend) == "pay_end")
            {
                Cart_order.Ispay = "y";
                Cart_order.PayDate= DateTime.Now;
                HttpContext.Session.Remove(CDictionary.sekey_Product_Cart_payend);
            }else if (!HttpContext.Session.Keys.Contains(CDictionary.sekey_Product_Cart_payend))
            {
                HttpContext.Session.Remove(CDictionary.sekey_Product_Cart_payend);
            }           
            
            
            
            string order_Session= HttpContext.Session.GetString(CDictionary.sekey_Product_Cart_Add);
            List<CShoppingCart_item> order_list= JsonSerializer.Deserialize<List<CShoppingCart_item>>(order_Session);
            TDeliveryDetail order_1 = null;
            
            
            foreach(var item in order_list)
            {                
                order_1= new TDeliveryDetail();
                order_1.CommodityId = item.CommodityId;
                order_1.UnitPrice = item.price;
                order_1.OrderQty= item.qty;
                Cart_order.TDeliveryDetails.Add(order_1);
            }
            db.TDeliveryOrders.Add(Cart_order);
            db.SaveChanges();
            HttpContext.Session.Remove(CDictionary.sekey_Product_Cart_Add);
            new CMails().send訂單成立通知(Cart_order.Email, Cart_order.OrderDate.ToString());

            string json_txt = "Success";
            HttpContext.Session.SetString(CDictionary.sekey_Product_Catt_Order_End, json_txt);

            return RedirectToAction("Prolist","Commodity");
        }

        

    }
}
