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
    public class AttendancesController : Controller
    {
        MoneyBLL bll = new MoneyBLL();
        // GET: Attendances
        public ActionResult Index(int PersonnelID)
        {
            
            Personnel list = bll.SelectygPersonnel(PersonnelID);
            ViewBag.attendanceslist = bll.SelectAllAttendances();
            return View(list);
        }
        public ActionResult Kaoqin(int ID)
        {
            var a = bll.Kaoqin(ID);
            return RedirectToAction("Index",new {a.PersonnelID });
        }
    }
}