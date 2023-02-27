using Microsoft.AspNetCore.Mvc;
using play2.Models;
using play2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;
//using System.Web.Mvc;
using play2.EFModels;
using System.Collections;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using System.Net.Mail;
using play2.Methods;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using NuGet.Protocol.Plugins;

namespace play2.Controllers
{
    public class Controller23Controller : Controller
    {
        private readonly ILogger<Controller23Controller> logger;
        private readonly Play2Context db;

        public Controller23Controller(ILogger<Controller23Controller> logger, Play2Context db)
        {
            this.logger = logger;
            this.db = db;
        }
        //---------------------------------------前台客服---------------------------------------

        public ActionResult serviceINP()
        {
            return View("Index");
        }


        [HttpPost]
        public ActionResult serviceINP(TService s)
        {
            TService ts = new TService();
            if (ts != null)
            {
                //ts.Id = s.Id;
                ts.Name = s.Name;
                ts.Email = s.Email;
                ts.Question = s.Question;
                //ts.Answer = s.Answer;
                db.SaveChanges();
            }

            return Json("Index");
        }



        //---------------------------------------後台客服---------------------------------------

        //清單
        public ActionResult service()
        {
            var datas = db.TServices;
            return View(datas);

        }


        //寄信功能
        public ActionResult serviceRES(int? id)
        {
            TService ts = db.TServices.FirstOrDefault(t => t.Id == id);
            return View(ts);

        }

        [HttpPost]

        public ActionResult serviceRES(TService s)
        {
            TService ts = db.TServices.FirstOrDefault(t => t.Id == s.Id);

            try
            {
                if (ts != null)
                {
                    ts.Id = s.Id;
                    ts.Name = s.Name;
                    ts.Email = s.Email;
                    ts.Question = s.Question;
                    ts.Answer = s.Answer;
                    db.SaveChanges();
                    System.Threading.Thread.Sleep(1500);
                    new CMails().send客服回應(ts.Email, ts.Answer);

                }

                return View("serviceRES");

            }
            catch (NullReferenceException e)
            {
                return Content(e.ToString());
            }

            //return RedirectToAction("pgErOfBackEnd", "special");


        }

        public ActionResult creditnoteList() 
        {
            return View();
        }




        //---------------------------------------供應商CRUD---------------------------------------

        public ActionResult supplierList()
        {
            List<Ctsupplier> datas = (new Ctsupplierfactory()).getAll();
            return View(datas);

        }



        public ActionResult supplierEdit(int? id)
        {

            if (id != null)
            {
                Ctsupplier s = (new Ctsupplierfactory()).getById((int)id);
                if (id != null)
                System.Threading.Thread.Sleep(1500);

                return View(s);
            }
            System.Threading.Thread.Sleep(1500);
            return RedirectToAction("supplierList");

        }

        [HttpPost] //要傳回到畫面上的方法

        public ActionResult supplierEdit(Ctsupplier s) //不想new就傳入參數
        {
            (new Ctsupplierfactory()).update(s); //偷雞摸狗法:不想一個個把值傳回去，就把畫面的name設成欄位名稱相同
            System.Threading.Thread.Sleep(1500);

            return RedirectToAction("supplierList");
        }



        public ActionResult supplierDelete(int? id)
        {
            if (id != null)
                new Ctsupplierfactory().delete((int)id);
            return RedirectToAction("supplierList");
        }



        public ActionResult supplierCreate()
        {
            return View();
        }

        public ActionResult supplierSave()
        {
            Ctsupplier s = new Ctsupplier();
            //CtSwiftCode c = new CtSwiftCode();
            s.TaxIDNumber = Request.Form["TaxIDNumber"]; //統編
            s.SupplierName = Request.Form["SupplierName"];
            s.Phone = Request.Form["Phone"];
            s.SwiftCode = Request.Form["SwiftCode"];
            s.PrincipalMan = Request.Form["PrincipalMan"];
            s.BankName = Request.Form["BankName"];
            s.Account = Request.Form["Account"];
            s.Grade = Request.Form["Grade"];
            s.CapitalAmount = Request.Form["CapitalAmount"];

            (new Ctsupplierfactory()).create(s);

            return RedirectToAction("supplierList");
        }

        //---------------------------------------進貨單CRUD---------------------------------------

        //總表
        public ActionResult purchaseList()
        {

            List<CtPurchaseEdit> datas = (new Ctpurchasefactory()).getpurchaseList();
            return View(datas);
        }


        //總表用單號查詢
        public ActionResult purchaseListbyID(int? id)
        {
            if (id != null)
            {
                List<CtPurchaseEdit> datas = (new Ctpurchasefactory()).getBypurchaseID((int)id);
                if (id != null)
                    return View(datas);
            }
            return RedirectToAction("purchaseList");

        }



        //總表用供應商查詢
        public ActionResult purchaseListbySupplier(int id)
        {
            //string name = Request.Form["name"];
            //ViewBag.K = name;
            if (id != null)
            {
                List<CtPurchaseEdit> datas = (new Ctpurchasefactory()).getBySupplierID(id);
                if (id != null)
                    return View(datas);
            }
            return RedirectToAction("purchaseList");

        }


        //總表用日期查詢
        public ActionResult purchaseListbyDate(string? date1, string? date2)
        {
            if (date1 != null && date2 != null)
            {
                List<CtPurchaseEdit> datas = (new Ctpurchasefactory()).getBypurchaseDate(date1, date2);
                if (date1 != null && date2 != null)
                    return View(datas);
            }
            return RedirectToAction("purchaseList");
        }



        //明細
        public ActionResult purchaseEdit(int? id)
        {
            if (id != null)
            {
                List<CtPurchaseEdit> datas = (new Ctpurchasefactory()).getpurchaseEdit((int)id);
                if (id != null)
                    return View(datas);
            }
            return RedirectToAction("purchaseList");

        }

        //編輯明細
        public ActionResult purchaseEditEdit(int? id, int? commodityId)
        {
            TPurchaseDetail pd = db.TPurchaseDetails.FirstOrDefault(t => t.PurOrderId == id && t.CommodityId == commodityId);
            return View(pd);
        }


        [HttpPost]
        public ActionResult purchaseEditEdit(TPurchaseDetail p, int oldCommodityId)
        {
            TPurchaseDetail pd = db.TPurchaseDetails.FirstOrDefault(t => t.PurOrderId == p.PurOrderId && t.CommodityId == oldCommodityId);

            db.TPurchaseDetails.Remove(pd);
            TPurchaseDetail tpd = new TPurchaseDetail();
            if (p != null)
            {
                tpd.CommodityId = p.CommodityId;
                tpd.PurOrderId = pd.PurOrderId;
                tpd.UnitPrice = p.UnitPrice;
                tpd.Qty = p.Qty;
                db.TPurchaseDetails.Add(tpd);

                db.SaveChanges();
            }
            System.Threading.Thread.Sleep(1500);

            return RedirectToAction("purchaseList");
        }




        //刪除明細
        public ActionResult purchaseDelete(int? id , int?commodityId)
        {
            if (id != null)
            {
                TPurchaseDetail pd = db.TPurchaseDetails.FirstOrDefault(t => t.PurOrderId == id && t.CommodityId == commodityId);
                if (pd != null)
                {
                    db.TPurchaseDetails.Remove(pd);
                    db.SaveChanges();
                }
            }
            System.Threading.Thread.Sleep(1500);

            return RedirectToAction("purchaseDeleteview");
        }

        //刪除後頁面
        public ActionResult purchaseDeleteview()
        { return View(); }



        //新增
        public ActionResult purchaseCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult purchaseCreate(List<CPurchaseViewModel> vm)
        {
            //下面是進貨單新增
            TPurchaseOrder order = new TPurchaseOrder();
            order.SupplierId=vm[0].SupplierId;
            order.StockroomId=vm[0].StockroomId;
            order.PurchaseDate = vm[0].PurchaseDate;
          
            order.LogisticsCost = vm[0].LogisticsCost;
            order.Notes = vm[0].Notes;
            //下面是進貨單明細的新增
            TPurchaseDetail detail = null;
            TStockAmount stock = null;
            foreach (var item in vm)
            {
                if (item.CommodityId != 0)
                {
                    detail= new TPurchaseDetail();
                    detail.CommodityId = item.CommodityId;
                    detail.UnitPrice = item.UnitPrice;
                    detail.Qty = item.Qty;                   
                    order.TPurchaseDetails.Add(detail);
                    //下面是庫存的新增
                    if(!db.TStockAmounts.Any(t=>t.StockroomId==vm[0].StockroomId && t.CommodityId == item.CommodityId))
                    {
                        stock = new TStockAmount();
                        stock.CommodityId = item.CommodityId;
                        stock.StockroomId = vm[0].StockroomId;
                        stock.StockQty = item.Qty;
                        db.TStockAmounts.Add(stock);
                    }
                    else
                    foreach(var itemstock in db.TStockAmounts.Where(t=>t.StockroomId== vm[0].StockroomId))
                    {
                       if(itemstock.CommodityId == item.CommodityId)                        
                            itemstock.StockQty+= item.Qty;                       
                    }
                }
            }
          
            db.TPurchaseOrders.Add(order);        

            db.SaveChanges();
            System.Threading.Thread.Sleep(1500);
            return View();
        }

        public ActionResult Suppliersearchname(string? name)
        {
            if (name != null)
            {

                var datas = db.TSuppliers.Where(t => t.SupplierName.Contains(name)).Select(t => new { t.SupplierId, t.SupplierName, t.TaxIdnumber, t.Phone, t.PrincipalMan, t.SwiftCode, t.BankName, t.Account, t.CapitalAmount, t.Grade });
                return Json(datas);
            }
            return NoContent();

        }

        public ActionResult PurchaseListsearchnum(int? num)
        {
            if (num != null)
            {

                var datas = db.View進貨單s.Where(t => t.進貨單號==num).Select(t => new { t.進貨單號, t.進貨日期, t.供應商名稱, t.小計, t.倉庫別, t.備註 });
                return Json(datas);
            }
            return NoContent();
        }



        public ActionResult LoadSupplier()
        {
            var datas = db.TSuppliers.Select(t => new { t.SupplierId, t.SupplierName });
            return Json(datas);
        }

        public ActionResult LoadService()
        {
            var datas = db.TServices.Select(t => new { t.Id, t.Answer });
            return Json(datas);
        }



        public ActionResult LoadStock()
        {
            var datas=db.TStockrooms.Select(t =>new { t.StockroomId, t.Stockroom});
            return Json(datas);
        }
        [HttpPost]
        public ActionResult GetCommudityName(int? id) 
        {
            string name = "n";
          if(id == null)
                return NoContent();
          var data=db.TCommodities.FirstOrDefault(t=>t.CommodityId == id);
           if(data!= null)
                name=data.CommodityName;
            return Content(name);
        }
        [HttpPost]
        public ActionResult SearchId(string? name)
        {
            if (name != null)
            {
                var datas = db.TCommodities.Where(t => t.CommodityName.Contains(name))
                    .Select(t => new {t.CommodityId,t.CommodityName});
                if (datas != null)
                    return Json(datas);
            }
            return NoContent();               
        }




        //---------------------------------------維修報錯---------------------------------------
        public ActionResult repair()
        {
            return View();
        }

        public ActionResult repairList()
        {
            List<Ctrepair> datas = (new Ctrepairfactory()).getAll();
            return View(datas);
        }


        public ActionResult repairSave()
        {
            Ctrepair p = new Ctrepair();
            p.publisher = Request.Form["publisher"];
            p.extention = Request.Form["extention"];
            p.describe = Request.Form["describe"];
            p.registerdate = DateTime.Now.ToString("yyyyMMdd");
            p.closeOrpending = "N";
            (new Ctrepairfactory()).create(p);
            
            
            return RedirectToAction("repair");
        }


        //---------------------------------------POWER BI---------------------------------------
        public IActionResult cost() // 進貨管理
        {
            return PartialView();
        }

        public IActionResult revenue() //銷貨管理
        {
            return PartialView();
        }
    
        public IActionResult grossprofit() //毛利分析
        {
            return PartialView();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
