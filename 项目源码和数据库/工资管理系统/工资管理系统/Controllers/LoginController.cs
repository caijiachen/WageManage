using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace 工资管理系统.Controllers
{
    public class LoginController : Controller
    {
        MoneyManageEntities2 db = new MoneyManageEntities2();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Personnel personnel)
        {
                Personnel yg = db.Personnel.SingleOrDefault(p => p.Name == personnel.Name && p.Pwd == personnel.Pwd );
                Session["yg"] = yg;
                if (!string.IsNullOrEmpty(yg.Roles.RoleName))
                {
                return RedirectToAction("Index2", "Home");
                }
                else
                {
                    return Content("账号、密码输入错误！");
                }


        }
    }
}