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
    public class AttendanceSetController : Controller
    {
        MoneyBLL bll = new MoneyBLL();
        // GET: AttendanceSet
        public ActionResult Index()
        {
            List<AttendanceSet> list = bll.SelectAllAttendanceSet();
            return View(list);
        }
        [HttpPost]
        public ActionResult Add(AttendanceSet attendanceSet)
        {
            int result = bll.AddAllAttendanceSet(attendanceSet);
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
        [HttpPost]
        public JsonResult EditAjax(int id)
        {
            AttendanceSet list = bll.SelectAttendanceSet(id);
            //JsonSerializerSettings jsset = new JsonSerializerSettings();
            //jsset.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            //string ret = JsonConvert.SerializeObject(list,jsset);

            return Json(list);

        }
        [HttpPost]
        public ActionResult Edit(AttendanceSet attendanceSet)
        {
            int result = bll.EditAttendanceSet(attendanceSet);
            if (result != 0)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("EditAjax");
        }
        public ActionResult Delete(int id)
        {
            int result = bll.DeleteAllAttendanceSet(id);
            if (result != 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}