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
    public class PrizeController : Controller
    {
        MoneyBLL bll = new MoneyBLL();
        // GET: Prize
        public ActionResult Index()
        {
            List<Prize> list = bll.SelectAllPrize();
            ViewBag.personnellist1 = bll.SelectAllPersonnel1();
            ViewBag.personnellist = bll.SelectAllPersonnel();
            return View(list);
        }
        [HttpPost]
        public ActionResult Add(Prize prize)
        {
            int result = bll.AddAllPrize(prize);
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
            Prize list = bll.SelectPrize(id);
            //JsonSerializerSettings jsset = new JsonSerializerSettings();
            //jsset.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            //string ret = JsonConvert.SerializeObject(list,jsset);

            return Json(list);

        }
        [HttpPost]
        public ActionResult Edit(Prize prize)
        {
            int result = bll.EditPrize(prize);
            if (result != 0)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("EditAjax");
        }
        public ActionResult Delete(int id)
        {
            int result = bll.DeleteAllPrize(id);
            if (result != 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}