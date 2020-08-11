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
    public class GetPrizeController : Controller
    {
        MoneyBLL bll = new MoneyBLL();
        // GET: GetPrize
        public ActionResult Index(string Name = "")
        {
            List<GetPrize> list = bll.SelectAllGetPrize(Name);
            ViewBag.personnellist = bll.SelectAllPersonnel();
            ViewBag.personnellist1 = bll.SelectAllPersonnel1();
            ViewBag.prizelist = bll.SelectAllprize();
            ViewBag.prizelist1 = bll.SelectAllPrize1();
            ViewBag.jsq = DateTime.Now;
            return View(list);
        }
        [HttpPost]
        public ActionResult Add(GetPrize getPrize)
        {
            int result = bll.AddAllGetPrize(getPrize);
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

        public ActionResult Delete(int id)
        {
            int result = bll.DeleteAllGetPrize(id);
            if (result != 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}