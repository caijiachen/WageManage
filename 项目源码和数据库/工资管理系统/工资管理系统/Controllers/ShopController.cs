using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;
using Newtonsoft.Json;

namespace 工资管理系统.Controllers
{
    public class ShopController : Controller
    {
        MoneyBLL bll = new MoneyBLL();
        // GET: Shop
        public ActionResult Index()
        {
            List<Shop> list = bll.SelectAllShop();
            ViewBag.personnellist1 = bll.SelectAllPersonnel1();
            ViewBag.personnellist = bll.SelectAllPersonnel();
            return View(list);
        }
        [HttpPost]
        public ActionResult Add(Shop shop)
        {
            int result = bll.AddAllShop(shop);
            if (result != 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                Response.Write("出现错误");
                return View();
            }
        }
        [HttpPost]
        public JsonResult EditAjax(int id)
        {
            Shop list = bll.SelectShop(id);
            //JsonSerializerSettings jsset = new JsonSerializerSettings();
            //jsset.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            //string ret = JsonConvert.SerializeObject(list,jsset);

            return Json(list);

        }
        [HttpPost]
        public ActionResult Edit(Shop shop)
        {
            int result = bll.EditShop(shop);
            if (result != 0)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("EditAjax");
        }
        public ActionResult Delete(int id)
        {
            int result = bll.DeleteAllShop(id);
            if (result != 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}