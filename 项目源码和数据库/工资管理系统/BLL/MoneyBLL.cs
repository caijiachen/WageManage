using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using DAL;
using Models;

namespace BLL
{
    public class MoneyBLL
    {
        MoneyDAL dal = new MoneyDAL();
        public List<Personnel> SelectAllPer(string Name)
        {
            return dal.Select(Name);

        }
        //didi
        public List<Subsidynotes> SelectAllSubsidynotes(string Name)
        {
            return dal.SelectSubnot(Name);

        }
        public List<AttendanceSet> SelectAllAttendanceSet()
        {
            return dal.SelAttendanceSet();
        }
        public Personnel SelectPersonnel(int id)
        {
            return dal.Sel(id);
        }
        public Attendance SelectAttendanceCounts(int id)
        {
            return dal.SelectCounts(id);
        }
        public Personnel SelectygPersonnel(int PersonnelID)
        {
            return dal.Selyg(PersonnelID);
        }
        public List<Pay> SelectAllPay(int PersonnelID)
        {
            return dal.Selpy(PersonnelID);
        }
        public Prize SelectPrize(int id)
        {
            return dal.SelP(id);
        }
        public Subsidy SelectSubsidy(int id)
        {
            return dal.SelSub(id);
        }
        public Shop SelectShop(int id)
        {
            return dal.SelS(id);
        }
        public AttendanceSet SelectAttendanceSet(int id)
        {
            return dal.SelAds(id);
        }
        public List<Personnel> SelectAllPersonnel()
        {
            return dal.SelectPersonnel();
        }
        public List<Personnel> SelectAllPersonnellist(int pageIndex , int pageSize , string Name)
        {
            return dal.SelectPersonnellist(pageIndex, pageSize, Name);
        }
        public List<Subsidy> SelectAllsubsidy()
        {
            return dal.Selectsubsidy();
        }
        public List<Prize> SelectAllprize()
        {
            return dal.Selectprize();
        }
        public int EditPersonnel(Personnel psl)
        {
            return dal.Edit(psl);
        }
        public int EditCounts(Attendance attendance)
        {
            return dal.EditC(attendance);
        }
        
        public Personnel EditPossword(int ID)
        {
            return dal.Editpwd(ID);
        }
        public int EditPrize(Prize pri)
        {
            return dal.EditP(pri);
        }
        public int EditSubsidy(Subsidy subsidy)
        {
            return dal.EditSub(subsidy);
        }
        public int EditShop(Shop shop)
        {
            return dal.EditS(shop);
        }
        public int SelectCounts(string Name)
        {
            return dal.SelCounts(Name);
        }
        
        public int EditAttendanceSet(AttendanceSet attendanceSet)
        {
            return dal.EditAds(attendanceSet);
        }
        public List<Attendances> EditAllAttendances()
        {
            return dal.EditAts();
        }
        public List<Subsidynotes> EditAll1()
        {
            return dal.EditA1();
        }
        public List<Attendance> EditAll2()
        {
            return dal.EditA2();
        }
        public List<GetPrize> EditAll3()
        {
            return dal.EditA3();
        }
        public List<Roles> SelectAllRole()
        {
            return dal.SelRole();
        }
        public List<Ranks> SelectAllRank()
        {
            return dal.SelRank();
        }
        public List<Attendances> SelectAllAttendances()
        {
            return dal.SelAttendances();
        }
        
        public List<GetPrize> SelectAllGetPrize()
        {
            return dal.SelGetPrize();
        }
        public List<Attendance> SelectAllAttendance()
        {
            return dal.SelAttendance();
        }
        
        public List<Subsidynotes> SelectAllSubsidynotes()
        {
            return dal.SelSubsidynotes();
        }
        public List<GetPrize> SelectAllGetPrize(string Name)
        {
            return dal.SelGetPrize(Name);
        }
        //public List<Pays> SelectAllPays(string Name)
        //{
        //    return dal.SelPays(Name);
        //}
        public List<Personnel> SelectAllPersonnellist()
        {
            return dal.SelPersonnellist();
        }
        public List<Department> SelectAllDepartment()
        {
            return dal.SelDepartment();
        }
        public Attendances Kaoqin(int ID)
        {
            return dal.Kq(ID);
        }
        public List<SelectListItem> SelectAllRank1()
        {
            return dal.SelRank1();
        }
        public List<SelectListItem> SelectAllPersonnel2()
        {
            return dal.SelPersonnel2();
        }
        public List<SelectListItem> SelectAllPersonnel1()
        {
            return dal.SelPersonnel1();
        }
        public List<SelectListItem> SelectAllSubsidy1()
        {
            return dal.SelSubsidy1();
        }
        public List<SelectListItem> SelectAllPrize1()
        {
            return dal.SelPrize1();
        }
        public List<SelectListItem> SelectAllRole1()
        {
            return dal.SelRole1();
        }
        public List<SelectListItem> SelectAllDepartment1()
        {
            return dal.SelDepartment1();
        }
        public List<SelectListItem> SelectAllShop1()
        {
            return dal.SelShop1();
        }
        public List<SelectListItem> SelectAllAttendanceSet1()
        {
            return dal.SelAttendanceSet1();
        }
        public List<Shop> SelectAllShop()
        {
            return dal.SelShop();
        }
        
        public List<Prize> SelectAllPrize()
        {
            return dal.SelPrize();
        }
        public List<Subsidy> SelectAllSubsidy()
        {
            return dal.SelSubsidy();
        }
        public List<Roles> SelectAllRoles()
        {
            return dal.SelRoles();
        }
        public List<Attendance> SelectAllAttendance(string Name)
        {
            return dal.SelAttendance(Name);
        }
        public Attendances SelectAllAttendances(int PersonnelID)
        {
            return dal.SelAttendances(PersonnelID);
        }
        
        public int AddAllPersonnel(Personnel personnel)
        {
            return dal.AddPersonnel(personnel);
        }
        public int AddAllPay(Pay pay)
        {
            return dal.AddPay(pay);
        }
        public int AddAllRemarks(Pay pay)
        {
            return dal.AddRemarks(pay);
        }
        

        public int AddAllAttendances(Attendances attendances)
        {
            return dal.AddAttendances(attendances);
        }
        
        public int AddAllShop(Shop shop)
        {
            return dal.AddShop(shop);
        }
        public int AddAllPrize(Prize prize)
        {
            return dal.AddPrize(prize);
        }
        public int AddAllSubsidy(Subsidy subsidy)
        {
            return dal.AddSubsidy(subsidy);
        }
        public int AddAllSubsidynotes(Subsidynotes subsidynotes)
        {
            return dal.AddSubsidynotes(subsidynotes);
        }
        public int AddAllGetPrize(GetPrize getPrize)
        {
            return dal.AddGetPrize(getPrize);
        }
        public int AddAllAttendance(Attendance attendance)
        {
            return dal.AddAttendance(attendance);
        }
        public int AddAllYJKQ(Attendance attendance)
        {
            return dal.AddYJKQ(attendance);
        }
        public int AddAllGX()
        {
            return dal.AddGX();
        }
        public int AddAllRank(Ranks rank)
        {
            return dal.AddRank(rank);
        }
        public int AddAllDepartment(Department department)
        {
            return dal.AddDepartment(department);
        }
        public int AddAllRoles(Roles roles)
        {
            return dal.AddRoles(roles);
        }
        public int AddAllAttendanceSet(AttendanceSet attendanceSet)
        {
            return dal.AddAttendanceSet(attendanceSet);
        }
        public int DeleteAllPersonnel(int id)
        {
            return dal.DeletePersonnel(id);
        }
        
        public int DeleteAllShop(int id)
        {
            return dal.DeleteShop(id);
        }
        public int DeleteAllPrize(int id)
        {
            return dal.DeletePrize(id);
        }
        public int DeleteAllSubsidy(int id)
        {
            return dal.DeleteSubsidy(id);
        }
        public int DeleteAllAttendance(int id)
        {
            return dal.DeleteAttendance(id);
        }
        public int DeleteAllSubsidynotes(int id)
        {
            return dal.DeleteSubsidynotes(id);
        }
        public int DeleteAllGetPrize(int id)
        {
            return dal.DeleteGetPrize(id);
        }
        public int DeleteAllRank(int id)
        {
            return dal.DeleteRank(id);
        }
        public int DeleteAllDepartment(int id)
        {
            return dal.DeleteDepartment(id);
        }
        public int DeleteAllRoles(int id)
        {
            return dal.DeleteRoles(id);
        }
        public int DeleteAllAttendanceSet(int id)
        {
            return dal.DeleteAttendanceSet(id);
        }
    }
}
