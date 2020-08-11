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
    public class PersonnelController : Controller
    {
        MoneyBLL bll = new MoneyBLL();
        // GET: Personnel
        public ActionResult Index(int pageIndex = 1, int pageSize = 5, string Name = "")
        {
            int totalRows = bll.SelectCounts(Name);
            double totalPages = Math.Ceiling(totalRows * 1.00 / pageSize);
            List<Personnel> list = bll.SelectAllPersonnellist(pageIndex, pageSize, Name);
            ViewBag.ranklist = bll.SelectAllRank();
            ViewBag.rolelist = bll.SelectAllRole();
            ViewBag.departmentlist = bll.SelectAllDepartment();
            ViewBag.shoplist = bll.SelectAllShop();
            //ViewBag.personnellist2 = bll.SelectAllPersonnel2();
            ViewBag.ranklist1 = bll.SelectAllRank1();
            ViewBag.rolelist1 = bll.SelectAllRole1();
            ViewBag.departmentlist1 = bll.SelectAllDepartment1();
            ViewBag.shoplist1 = bll.SelectAllShop1();
            //List<SelectListItem> list1 = bll.AddAllPersonnel();
            ViewBag.totalPages = totalPages;
            ViewBag.pageIndex = pageIndex;
            ViewBag.Name = Name;
            ViewBag.pageSize = pageSize;
            return View(list);
        }
        //public ActionResult Edit(int id)
        //{
        //    Personnel list = bll.SelectPersonnel(id);
        //    ViewBag.User = list;
        //    return View();
        //}
        [HttpPost]
        public JsonResult EditAjax(int id)
        {
            Personnel list = bll.SelectPersonnel(id);
            //JsonSerializerSettings jsset = new JsonSerializerSettings();
            //jsset.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            //string ret = JsonConvert.SerializeObject(list,jsset);
            
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
        [HttpPost]
        public ActionResult Add(Personnel personnel)
        {
            
            int result = bll.AddAllPersonnel(personnel);
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
            int result = bll.DeleteAllPersonnel(id);
            if (result != 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}