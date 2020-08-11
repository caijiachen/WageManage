using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;

namespace 工资管理系统.Controllers
{
    public class RoleController : Controller
    {
        MoneyBLL bll = new MoneyBLL();
        // GET: Role
        public ActionResult Index()
        {
            List<Roles> list = bll.SelectAllRoles();
            ViewBag.personnellist1 = bll.SelectAllPersonnel1();
            ViewBag.personnellist = bll.SelectAllPersonnel();
            return View(list);
        }
        [HttpPost]
        public ActionResult Add(Roles roles)
        {
            int result = bll.AddAllRoles(roles);
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
            int result = bll.DeleteAllRoles(id);
            if (result != 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}