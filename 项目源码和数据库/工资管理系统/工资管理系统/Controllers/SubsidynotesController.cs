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
    public class SubsidynotesController : Controller
    {
        MoneyBLL bll = new MoneyBLL();
        // GET: Subidynotes
        public ActionResult Index(string Name="")
        {
            List<Subsidynotes> list = bll.SelectAllSubsidynotes(Name);
            ViewBag.personnellist = bll.SelectAllPersonnel();
            ViewBag.subsidylist = bll.SelectAllsubsidy();
            //List<Personnel> list = bll.SelectAllPer(Name);
            //ViewBag.Subsidynoteslist = bll.SelectAllSubsidynotes();
            ViewBag.personnellist1 = bll.SelectAllPersonnel1();
            ViewBag.subsidylist1 = bll.SelectAllSubsidy1();
            ViewBag.jsq = DateTime.Now;
            return View(list);
        }
        [HttpPost]
        public ActionResult Add(Subsidynotes subsidynotes)
        {
            int result = bll.AddAllSubsidynotes(subsidynotes);
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
            int result = bll.DeleteAllSubsidynotes(id);
            if (result != 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}