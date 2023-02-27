using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using play2.EFModels;
using play2.ViewModels;

namespace play2.Controllers.BackEndControllers.controller16
{

    public class ProductController : Controller
    {
        private readonly Play2Context _context;
        private readonly ILogger<ProductController> _logger;
        private IWebHostEnvironment _eviroment;

        public ProductController(ILogger<ProductController> logger, Play2Context context, IWebHostEnvironment eviroment)
        {
            _context = context;
            _logger = logger;
            _eviroment = eviroment;
        }


        public IActionResult List()
        {
            var datas = _context.View商品完整資訊s;
            return View(datas);
        }

        public IActionResult ConsoleEdit(CProductViewModel prod)
        {
            TCommodity console = _context.TCommodities.FirstOrDefault(t => t.CommodityId == prod.CommodityId);
            try
            {

                if (console != null)
                {
                    if (prod.photo != null)
                    {
                        if (console.PhotoPath != null)
                        {
                            string oldpath = _eviroment.WebRootPath + "/ProductImages/" + console.PhotoPath;
                            if (System.IO.File.Exists(oldpath))
                                System.IO.File.Delete(oldpath);
                        }

                        string photoName = Guid.NewGuid().ToString() + ".jpg";
                        string path = _eviroment.WebRootPath + "/ProductImages/" + photoName;
                        console.PhotoPath = photoName;

                        using (var filestream = new FileStream(path, FileMode.Create))
                        {
                            prod.photo.CopyTo(filestream);
                        }
                    }

                    console.CommodityName = prod.CommodityName;
                    console.Price = prod.Price;
                    _context.SaveChanges();
                }
                THostDatum oldcondata = _context.THostData.FirstOrDefault(t => t.CommodityId == prod.CommodityId);
                if (oldcondata != null)
                {
                    _context.THostData.Remove(oldcondata);
                    _context.SaveChanges();
                }
                THostDatum condata = new THostDatum();

                condata.CommodityId = prod.CommodityId;
                condata.HostColor = prod.HostColor;
                condata.HostStation = prod.HostStation;
                condata.HostHss = prod.HostHss;
                _context.THostData.Add(condata);
                _context.SaveChanges();

                System.Threading.Thread.Sleep(1500);

                return RedirectToAction("Edit");
            }
            catch (Exception ex)
            {
                return Content(ex.ToString());
            }
        }


        public IActionResult Edit(int? id)
        {
            View商品完整資訊 prod = new View商品完整資訊();
            try
            {

                if (id != null)
                {
                    prod = _context.View商品完整資訊s.FirstOrDefault(t => t.CommodityId == id);
                    if (prod != null)
                    {
                        CProductViewModel vm = new CProductViewModel();
                        vm.Categories = prod.Categories;
                        vm.CommodityId = prod.CommodityId;
                        vm.CommodityName = prod.CommodityName;
                        vm.Price = prod.Price;
                        vm.ReleaseDate = prod.ReleaseDate;
                        vm.GameStation = prod.GameStation;
                        vm.PlayNumber = prod.PlayNumber;
                        vm.PegiRating = prod.PegiRating;
                        vm.OfficialWebsite = prod.OfficialWebsite;
                        vm.Developer = prod.Developer;
                        vm.Publisher = prod.Publisher;
                        vm.Agent = prod.Agent;
                        vm.Profile = prod.Profile;
                        vm.HostColor = prod.HostColor;
                        vm.HostStation = prod.HostStation;
                        vm.HostHss = prod.HostHss;
                        vm.PhotoPath = prod.PhotoPath;
                        var a = _context.TTagComms.Where(t => t.CommodityId == id).ToList();
                        if (a != null)
                            vm.TagComms = a;

     

                        return View(vm);

                        //return View(prod);

                    }
                }
                return RedirectToAction("list");
            }
            catch (Exception ex)
            {
                return Content(ex.ToString());
            }
        }
        [HttpPost]
        public IActionResult Edit(CProductViewModel prod, int[] TagId1)
        {
            TCommodity com = _context.TCommodities.FirstOrDefault(t => t.CommodityId == prod.CommodityId);
            try
            {

                if (com != null)
                {
                    if (prod.photo != null)
                    {
                        if (com.PhotoPath != null)
                        {
                            string oldpath = _eviroment.WebRootPath + "/ProductImages/" + com.PhotoPath;
                            if (System.IO.File.Exists(oldpath))
                                System.IO.File.Delete(oldpath);
                        }

                        string photoName = Guid.NewGuid().ToString() + ".jpg";
                        string path = _eviroment.WebRootPath + "/ProductImages/" + photoName;
                        com.PhotoPath = photoName;

                        using (var filestream = new FileStream(path, FileMode.Create))
                        {
                            prod.photo.CopyTo(filestream);
                        }
                    }

                    com.CommodityName = prod.CommodityName;
                    com.Price = prod.Price;
                    _context.SaveChanges();

                    TGameDatum gd = _context.TGameData.FirstOrDefault(t => t.CommodityId == prod.CommodityId);


                    gd.GameType = prod.GameType;
                    gd.ReleaseDate = prod.ReleaseDate;
                    gd.PlayNumber = prod.PlayNumber;
                    gd.PegiRating = prod.PegiRating;
                    gd.Developer = prod.Developer;
                    gd.Publisher = prod.Publisher;
                    gd.Agent = prod.Agent;
                    gd.OfficialWebsite = prod.OfficialWebsite;
                    gd.Profile = prod.Profile;
                    _context.SaveChanges();

                    var otag = _context.TTagComms.Where(t => t.CommodityId == prod.CommodityId).ToList();
                    foreach (var item in otag)
                    {
                        _context.TTagComms.Remove(item);
                        _context.SaveChanges();
                    }

                    TTagComm tag = new TTagComm();
                    foreach (var item in TagId1)
                    {
                        tag.CommodityId = prod.CommodityId;
                        tag.TagId = item;
                        _context.TTagComms.Add(tag);
                        _context.SaveChanges();
                    }
                }
                System.Threading.Thread.Sleep(1500);

                return Redirect("/product/Edit/"+prod.CommodityId);
            }
            catch (Exception ex)
            {
                return Content(ex.ToString());
            }
        }


        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateGame(CProductViewModel prod, int[] TagId1)
        {
            TCommodity com = new TCommodity();
            try
            {

                if (prod.photo != null)
                {
                    string photoName = Guid.NewGuid().ToString() + ".jpg";
                    string path = _eviroment.WebRootPath + "/ProductImages/" + photoName;
                    com.PhotoPath = photoName;
                    using (var filestream = new FileStream(path, FileMode.Create))
                    {
                        prod.photo.CopyTo(filestream);
                    }
                }
                com.Categories = "g";
                com.CommodityName = prod.CommodityName;
                com.Price = prod.Price;
                com.IsShelves = "n";

                TGameDatum gd = new TGameDatum();
                gd.GameStation = prod.GameStation;
                gd.GameType = prod.GameType;
                gd.ReleaseDate = prod.ReleaseDate;
                gd.PlayNumber = prod.PlayNumber;
                gd.PegiRating = prod.PegiRating;
                gd.Developer = prod.Developer;
                gd.Publisher = prod.Publisher;
                gd.Agent = prod.Agent;
                gd.OfficialWebsite = prod.OfficialWebsite;
                gd.Profile = prod.Profile;

                com.TGameData.Add(gd);
                //_context.TGameData.Add(gd);
                foreach (var item in TagId1)
                {
                    TTagComm tag = new TTagComm();
                    tag.TagId = item;
                    com.TTagComms.Add(tag);
                }
                _context.TCommodities.Add(com);
                _context.SaveChanges();
                System.Threading.Thread.Sleep(1500);
                return RedirectToAction("List");
            }
            catch (Exception ex)
            {
                return Content(ex.ToString());
            }
        }

        public IActionResult CreateConsole(CProductViewModel prod)
        {
            TCommodity com = new TCommodity();
            try
            {

                if (prod.photo != null)
                {
                    string photoName = Guid.NewGuid().ToString() + ".jpg";
                    string path = _eviroment.WebRootPath + "/ProductImages/" + photoName;
                    com.PhotoPath = photoName;
                    using (var filestream = new FileStream(path, FileMode.Create))
                    {
                        prod.photo.CopyTo(filestream);
                    }
                }
              
                com.Categories = "c";
                com.CommodityName = prod.CommodityName;
                com.Price = prod.Price;
                com.IsShelves = "n";
                _context.TCommodities.Add(com);
                _context.SaveChanges();

                THostDatum condata = new THostDatum();
                condata.HostColor = prod.HostColor;
                condata.HostStation = prod.HostStation;
                condata.HostHss = prod.HostHss;

                com.THostData.Add(condata);
                _context.SaveChanges();

                System.Threading.Thread.Sleep(1500);
                return RedirectToAction("List");
            }
            catch (Exception ex)
            {
                string exerror = "~/home/error?errormessage=";
                if (ex.InnerException != null)
                {
                   exerror += ex.Message.ToString();
                }

                return Redirect(  exerror);
            }
        }
        public IActionResult OnShelves(string items)
        {
            try
            {

                if (items != null)
                {
                    Array arritems = items.Split(",");
                    foreach (var item in arritems)
                    {
                        TCommodity data = _context.TCommodities.FirstOrDefault(s => s.CommodityId == Convert.ToInt32(item));
                        data.IsShelves = "y";
                    }
                    _context.SaveChanges();
                    return Content("已上架");
                }
                else
                    return Content("請選擇商品");
            }
            catch (Exception ex)
            {
                return Content(ex.ToString());
            }
        }
        public IActionResult OffShelves(string items)
        {
            try
            {

                if (items != null)
                {
                    Array arritems = items.Split(",");
                    foreach (var item in arritems)
                    {
                        TCommodity data = _context.TCommodities.FirstOrDefault(s => s.CommodityId == Convert.ToInt32(item));
                        data.IsShelves = "n";
                    }

                    _context.SaveChanges();
                    return Content("已下架");
                }
                else
                    return Content("請選擇商品");
            }
            catch (Exception ex)
            {
                return Content(ex.ToString());
            }
        }

        public IActionResult search(string? keyword)
        {
            try
            {

                if (keyword != null)
                {
                    var items = _context.View商品完整資訊s.Where(s => s.CommodityId.ToString().Contains(keyword) || s.CommodityName.Contains(keyword));
                    return Json(items);
                }
                var allitems = _context.View商品完整資訊s;
                return Json(allitems);
            }
            catch (Exception ex)
            {
                return Content(ex.ToString());
            }
        }



    }
}
