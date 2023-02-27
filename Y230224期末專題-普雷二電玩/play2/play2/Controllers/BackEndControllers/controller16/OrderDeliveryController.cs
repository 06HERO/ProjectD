
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using play2.EFModels;
using play2.ViewModels;
using System.Data;
using System.Net.Mail;
using static play2.ViewModels.CCPickItemViewModel;


namespace play2.Controllers.BackEndControllers.controller16
{

    public class OrderDeliveryController : Controller
    {
        private readonly Play2Context _context;
        private readonly ILogger<OrderDeliveryController> _logger;
        private IWebHostEnvironment _eviroment;

        public OrderDeliveryController(ILogger<OrderDeliveryController> logger, Play2Context context, IWebHostEnvironment eviroment)
        {
            _context = context;
            _logger = logger;
            _eviroment = eviroment;
        }
        public IActionResult OrderList()
        {
            var order = _context.View訂單完整資訊s.OrderByDescending(s => s.OrderDate);
            return View(order);
        }

        public IActionResult OrderDetail(int? id)
        {
            COrderDetailViewModel od = new COrderDetailViewModel();
            try
            {
                if (id != null)
                {
                    var order = _context.View訂單完整資訊s.FirstOrDefault(t => t.DelOrderId == id);
                    if (order != null)
                        od.View訂單完整資訊 = order;
                    od.OrderDetails = _context.View訂單明細品名對照s.Where(t => t.DelOrderId == id).ToList();
                    
                    return View(od);
                }
                return RedirectToAction("orderlist");
            }
            catch (Exception ex)
            {
                return Content(ex.ToString());
            }
        }

        public IActionResult SearchByMemberId(String? MemberId)
        {
            var order = _context.View訂單完整資訊s.Where(t => t.MemberId == MemberId).ToList();
            return View(order);
        }






        public IActionResult OrderSearch(string? keyword, int? orderStateId, string? StrDate, string? EndDate, string? StrDate2, string? EndDate2)
        {
            var odders = _context.View訂單完整資訊s.Where(t => t.DelOrderId > 0);
            try
            {
                if (keyword != null)
                    odders = odders.Where(s => s.DelOrderId.ToString().Contains(keyword) || s.ReguPhone.Contains(keyword) || s.ContactPhone.Contains(keyword) || s.CompPhone.Contains(keyword));
                if (orderStateId != null && orderStateId > 0)
                    odders = odders.Where(s => s.OrderStateId == orderStateId);
                if (StrDate != null)
                    odders = odders.Where(s => s.DeliveryDate >= Convert.ToDateTime(StrDate));
                if (EndDate != null)
                    odders = odders.Where(s => s.DeliveryDate <= Convert.ToDateTime(EndDate));
                if (StrDate2 != null)
                    odders = odders.Where(s => s.OrderDate >= Convert.ToDateTime(StrDate2));
                if (EndDate2 != null)
                    odders = odders.Where(s => s.OrderDate <= Convert.ToDateTime(EndDate2));

               odders= odders.OrderByDescending(s => s.OrderDate);
                return Json(odders);
            }
            catch (Exception ex)
            {
                return Content(ex.ToString());
            }
        }

        public IActionResult OrderEdit(COrderDetailViewModel order)
        {
            var data = _context.TDeliveryOrders.FirstOrDefault(t => t.DelOrderId == order.DelOrderId);
            try
            {
                data.ContactMan = order.ContactMan;
                data.ContactPhone = order.ContactPhone;
                data.Adderst = order.Adderst;
                data.Notes = order.Notes;
                data.DeliveryDate = order.DeliveryDate;
                _context.SaveChanges();
                return Content("修改成功");
            }
            catch (Exception ex)
            {
                return Content(ex.ToString());
            }

        }

        public IActionResult CancelDetail(int? DelOrderId, int? CommodityId, int? CancelQty)
        {
            if (DelOrderId == null || CommodityId == null || CancelQty == null)
                return Json("請確認資料完整性");
            try
            {
                var data = _context.TDeliveryDetails.FirstOrDefault(t => t.DelOrderId == DelOrderId && t.CommodityId == CommodityId);
                int cancelqty = 0;
                if (data.CancelQty != null)
                    cancelqty = data.CancelQty.Value;
                if (CancelQty <= 0 || CancelQty > (data.OrderQty - cancelqty))
                    return Json("請確認數量是否正確");

                if (data.CancelQty == null)
                    data.CancelQty = CancelQty;
                else
                    data.CancelQty = cancelqty + CancelQty;

                _context.SaveChanges();
                return Json("退訂成功");
            }
            catch (Exception ex)
            {
                return Json(ex.ToString());
            }
        }

        public IActionResult AcceptOrder(int? DelOrderId)
        {
            try
            {
                var data = _context.TDeliveryOrders.FirstOrDefault(t => t.DelOrderId == DelOrderId);
                if (data.OrderStateId == 1)
                {
                    data.OrderStateId = 2;
                    _context.SaveChanges();
                    return Json("接收訂單");
                }

                return Json("");
            }
            catch (Exception ex)
            {
                return Json(ex.ToString());
            }
        }

        public IActionResult PickDone(int? DelOrderId)
        {
            try
            {

                var od = _context.TDeliveryDetails.Where(t => t.DelOrderId == DelOrderId).ToList();

                foreach (var item in od)
                {
                    if (item.CancelQty == null)
                        item.CancelQty = 0;

                    item.PickQty = item.OrderQty - item.CancelQty;

                    _context.SaveChanges();
                }

                var oder = _context.TDeliveryOrders.FirstOrDefault(t => t.DelOrderId == DelOrderId);
                oder.OrderStateId = 3; _context.SaveChanges();

                return Json("備貨完成");

            }
            catch (Exception ex)
            {
                return Json(ex.ToString());

            }



        }
        public IActionResult DeliveryStart(int? DelOrderId)
        {
            try
            {
                var od = _context.TDeliveryOrders.FirstOrDefault(t => t.DelOrderId == DelOrderId);
                if (od != null)
                {
                    if (od.OrderStateId == 3)
                    {
                        od.OrderStateId = 4;
                        _context.SaveChanges();
                    }
                }

                return Json(" ");

            }
            catch (Exception ex)
            {
                return Json(ex.ToString());

            }
        }

        public IActionResult DeliveryDone(int? DelOrderId)
        {
            try
            {

                var od = _context.TDeliveryOrders.FirstOrDefault(t => t.DelOrderId == DelOrderId);
                if (od != null)
                {
                    if (od.OrderStateId == 4)
                    {
                        od.OrderStateId = 5;
                        _context.SaveChanges();
                    }
                }

                return Json(" ");
            }
            catch (Exception ex)
            {
                return Json(ex.ToString());

            }

        }
        public IActionResult CancelDelivery(int? DelOrderId)
        {
            try
            {
                var od = _context.TDeliveryOrders.FirstOrDefault(t => t.DelOrderId == DelOrderId);
                if (od != null)
                {
                    if (od.OrderStateId <= 4)
                    {
                        od.OrderStateId = 6;
                        _context.SaveChanges();
                    }
                }

                return Json(" ");
            }
            catch (Exception ex)
            {
                return Json(ex.ToString());

            }
        }

    }
}
