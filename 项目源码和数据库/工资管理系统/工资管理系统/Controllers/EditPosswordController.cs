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
    public class EditPosswordController : Controller
    {
        MoneyBLL bll = new MoneyBLL();
        // GET: EditPossword
        public ActionResult Index(int ID)
        {
            ViewBag.psl = bll.EditPossword(ID);
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Personnel psl)
        {
            int result = bll.EditPersonnel(psl);
            if (result != 0)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index","Home");
        }

    }
}