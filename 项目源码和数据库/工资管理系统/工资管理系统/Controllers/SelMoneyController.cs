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
    public class SelMoneyController : Controller
    {
        MoneyBLL bll = new MoneyBLL();
        // GET: SelMoney
        public ActionResult Index(int PersonnelID)
        {
            List<Pay> list = bll.SelectAllPay(PersonnelID);
            
            return View(list);
        }
    }
}