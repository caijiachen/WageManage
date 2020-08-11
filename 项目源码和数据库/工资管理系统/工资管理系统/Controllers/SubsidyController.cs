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
    public class SubsidyController : Controller
    {
        MoneyBLL bll = new MoneyBLL();
        // GET: Subsidy
        public ActionResult Index()
        {
            List<Subsidy> list = bll.SelectAllSubsidy();
            ViewBag.personnellist1 = bll.SelectAllPersonnel1();
            ViewBag.personnellist = bll.SelectAllPersonnel();
            return View(list);
        }
        [HttpPost]
        public ActionResult Add(Subsidy subsidy)
        {
            int result = bll.AddAllSubsidy(subsidy);
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
            Subsidy list = bll.SelectSubsidy(id);
            //JsonSerializerSettings jsset = new JsonSerializerSettings();
            //jsset.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            //string ret = JsonConvert.SerializeObject(list,jsset);

            return Json(list);

        }
        [HttpPost]
        public ActionResult Edit(Subsidy subsidy)
        {
            int result = bll.EditSubsidy(subsidy);
            if (result != 0)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("EditAjax");
        }
        public ActionResult Delete(int id)
        {
            int result = bll.DeleteAllSubsidy(id);
            if (result != 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}