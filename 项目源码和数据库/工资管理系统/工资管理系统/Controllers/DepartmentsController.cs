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
    public class DepartmentsController : Controller
    {
        MoneyBLL bll = new MoneyBLL();
        // GET: Deparments
        public ActionResult Index()
        {
            List<Department> list = bll.SelectAllDepartment();
            ViewBag.personnellist1 = bll.SelectAllPersonnel1();
            ViewBag.personnellist = bll.SelectAllPersonnel();
            return View(list);
        }
        [HttpPost]
        public ActionResult Add(Department department)
        {
            int result = bll.AddAllDepartment(department);
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
            int result = bll.DeleteAllDepartment(id);
            if (result != 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}