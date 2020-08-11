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
    public class RankController : Controller
    {
        MoneyBLL bll = new MoneyBLL();
        // GET: Rank
        public ActionResult Index()
        {
            List<Ranks> list = bll.SelectAllRank();
            ViewBag.personnellist1 = bll.SelectAllPersonnel1();
            ViewBag.personnellist = bll.SelectAllPersonnel();
            return View(list);
        }
        [HttpPost]
        public ActionResult Add(Ranks rank)
        {
            int result = bll.AddAllRank(rank);
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
            int result = bll.DeleteAllRank(id);
            if (result != 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}