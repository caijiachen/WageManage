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
    public class DeriveController : Controller
    {
        MoneyBLL bll = new MoneyBLL();
        // GET: Derive
        
        public ActionResult Index(int pageIndex = 1, int pageSize = 5, string Name = "")
        {
            int totalRows = bll.SelectCounts(Name);
            double totalPages = Math.Ceiling(totalRows * 1.00 / pageSize);
            List<Personnel> list = bll.SelectAllPersonnellist(pageIndex, pageSize, Name);
            //员工
            ViewBag.personnellist = bll.SelectAllPersonnel();
            ViewBag.personnellist1 = bll.SelectAllPersonnel1();
            //店铺名称
            ViewBag.shoplist = bll.SelectAllShop();
            ViewBag.shoplist1 = bll.SelectAllShop1();
            //等级+基本工资
            ViewBag.ranklist = bll.SelectAllRank();
            ViewBag.ranklist1 = bll.SelectAllRank1();

            ViewBag.getprizelist = bll.SelectAllGetPrize();
            ViewBag.attendancelist = bll.SelectAllAttendance();
            //ViewBag.getprizelist1 = bll.SelectAllGetPrize1();
            ViewBag.subsidynoteslist = bll.SelectAllSubsidynotes();
            ViewBag.jsq = DateTime.Now;
            ViewBag.totalPages = totalPages;
            ViewBag.pageIndex = pageIndex;
            ViewBag.Name = Name;
            ViewBag.pageSize = pageSize;
            return View(list);
        }
        [HttpPost]
        public JsonResult EditAjax(int id)
        {
            Personnel list = bll.SelectPersonnel(id);

            return Json(list);

        }
        [HttpPost]
        public ActionResult Edit(Personnel psl)
        {
            int result = bll.EditPersonnel(psl);
            if (result != 0)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("EditAjax");
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