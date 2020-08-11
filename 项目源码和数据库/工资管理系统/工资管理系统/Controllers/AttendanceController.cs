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
    public class AttendanceController : Controller
    {
        MoneyBLL bll = new MoneyBLL();
        // GET: Attendance
        public ActionResult Index(string Name = "")
        {
            List<Attendance> list = bll.SelectAllAttendance(Name);
            ViewBag.personnellist = bll.SelectAllPersonnel();
            ViewBag.personnellist1 = bll.SelectAllPersonnel1();
            ViewBag.attendanceSetlist = bll.SelectAllAttendanceSet();
            ViewBag.attendanceSetlist1 = bll.SelectAllAttendanceSet1();
            ViewBag.attendanceslist = bll.SelectAllAttendances();
            ViewBag.jsq= DateTime.Now;
            return View(list);
        }
        [HttpPost]
        public ActionResult Add(Attendance attendance)
        {
            int result = bll.AddAllAttendance(attendance);
            if (result != 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public ActionResult Delete(int id)
        {
            int result = bll.DeleteAllAttendance(id);
            if (result != 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Gengxin()
        {
            var result = bll.EditAllAttendances();
            return RedirectToAction("Index");
        }
        public ActionResult YJKQ(Attendance attendance)
        {
            var result = bll.AddAllYJKQ(attendance);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public JsonResult EditAjax(int id)
        {
            Attendance list = bll.SelectAttendanceCounts(id);
            //JsonSerializerSettings jsset = new JsonSerializerSettings();
            //jsset.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            //string ret = JsonConvert.SerializeObject(list,jsset);

            return Json(list);

        }
        [HttpPost]
        public ActionResult EditC(Attendance attendance)
        {
            int result = bll.EditCounts(attendance);
            if (result != 0)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("EditAjax");
        }

    }
}