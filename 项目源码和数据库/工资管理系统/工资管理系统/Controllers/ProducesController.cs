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
    public class ProducesController : Controller
    {
        MoneyBLL bll = new MoneyBLL();
        // GET: Produces
        public ActionResult Index()
        {
            List<Personnel> list = bll.SelectAllPersonnellist();
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
            return View(list);
        }
        [HttpPost]
        public ActionResult Add(Pay pay)
        {

            int result = bll.AddAllPay(pay);
            if (result != 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                Response.Write("出现错误");
                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public ActionResult AddRemarks(Pay pay)
        {

            int result = bll.AddAllRemarks(pay);
            if (result != 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                Response.Write("出现错误");
                return RedirectToAction("Index");
            }
        }
        public ActionResult Genxin()
        {
            bll.AddAllGX();
            bll.EditAll1();
            bll.EditAll2();
            bll.EditAll3();
            return RedirectToAction("Index");
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