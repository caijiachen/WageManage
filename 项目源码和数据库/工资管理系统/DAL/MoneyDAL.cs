using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace DAL
{
    public class MoneyDAL
    {
        MoneyManageEntities2 db = new MoneyManageEntities2();
        public List<Personnel> Select(string Name)
        {
            return db.Personnel.ToList().OrderBy(p => p.ID).Where(p =>p.Name.Contains(Name)).ToList();
        }
        //didi
        public List<Subsidynotes> SelectSubnot(string Name)
        {
            return db.Subsidynotes.ToList().OrderBy(p => p.ID).Where(p => p.Personnel.Name.Contains(Name)).ToList();
        }
        public Personnel Sel(int id)
        {
            db.Configuration.LazyLoadingEnabled = false;
            Personnel heroes = db.Personnel.Find(id);
            return heroes;
        }
        public Attendance SelectCounts(int id)
        {
            db.Configuration.LazyLoadingEnabled = false;
            Attendance heroes = db.Attendance.Find(id);
            return heroes;
        }
        
        public Personnel Selyg(int PersonnelID)
        {
            Personnel personnel = db.Personnel.SingleOrDefault(p=>p.ID==PersonnelID);
            return personnel;
        }
        public List<Pay> Selpy(int PersonnelID)
        {
            List<Pay> personnel = db.Pay.Where(p => p.PersonnelID == PersonnelID).ToList();
            return personnel;
        }
        public Prize SelP(int id)
        {
            db.Configuration.LazyLoadingEnabled = false;
            Prize prize = db.Prize.Find(id);
            return prize;
        }
        public Subsidy SelSub(int id)
        {
            db.Configuration.LazyLoadingEnabled = false;
            Subsidy subsidy = db.Subsidy.Find(id);
            return subsidy;
        }
        public Shop SelS(int id)
        {
            db.Configuration.LazyLoadingEnabled = false;
            Shop heroes = db.Shop.Find(id);
            return heroes;
        }
        public AttendanceSet SelAds(int id)
        {
            db.Configuration.LazyLoadingEnabled = false;
            AttendanceSet attendanceSet = db.AttendanceSet.Find(id);
            return attendanceSet;
        }
        public List<Personnel> SelectPersonnel()
        {
            List<Personnel> personnels = db.Personnel.ToList();
            return personnels;
        }
        public List<Personnel> SelectPersonnellist(int pageIndex, int pageSize, string Name)
        {
            List<Personnel> personnels = db.Personnel.OrderBy(p => p.ID)
                .Where(p =>  (Name == "" || p.Name.Contains(Name)))
                .Skip((pageIndex - 1) * pageSize).Take(pageSize)
                .ToList();
            return personnels;
        }
        
        public List<Subsidy> Selectsubsidy()
        {
            List<Subsidy> subsidy = db.Subsidy.ToList();
            return subsidy;
        }
        public List<AttendanceSet> SelAttendanceSet()
        {
            List<AttendanceSet> attendanceSet = db.AttendanceSet.ToList();

            return attendanceSet;
        }
        public List<Prize> Selectprize()
        {
            List<Prize> prize = db.Prize.ToList();
            return prize;
        }
        public int Edit(Personnel psl)
        {
            db.Entry(psl).State = System.Data.Entity.EntityState.Modified;
            int result = db.SaveChanges();
            return result;
        }
        public int EditC(Attendance attendance)
        {
            db.Entry(attendance).State = System.Data.Entity.EntityState.Modified;
            int result = db.SaveChanges();
            return result;
        }
        
        public Personnel Editpwd(int ID)
        {
            Personnel psl = db.Personnel.SingleOrDefault(p => p.ID == ID);
            return psl;
        }
        
        public int EditP(Prize pri)
        {
            db.Entry(pri).State = System.Data.Entity.EntityState.Modified;
            int result = db.SaveChanges();
            return result;
        }
        public int EditSub(Subsidy subsidy)
        {
            db.Entry(subsidy).State = System.Data.Entity.EntityState.Modified;
            int result = db.SaveChanges();
            return result;
        }
        public int EditS(Shop shop)
        {
            db.Entry(shop).State = System.Data.Entity.EntityState.Modified;
            int result = db.SaveChanges();
            return result;
        }
        public int SelCounts(string Name)
        {
            int result = db.Personnel.OrderBy(p => p.ID)
                .Where(p => (Name == "" || p.Name.Contains(Name)))
                .Count();
            return result;
        }
        
        public int EditAds(AttendanceSet attendanceSet)
        {
            db.Entry(attendanceSet).State = System.Data.Entity.EntityState.Modified;
            int result = db.SaveChanges();
            return result;
        }
        public List<Attendances> EditAts()
        {
            List<Attendances> attendances = db.Attendances.ToList();
            foreach (var item in attendances)
            {
                item.AttendanceStates = 1;
            }
            db.SaveChanges();
            return attendances;
        }
        public List<Subsidynotes> EditA1()
        {
            List<Subsidynotes> subsidynotes = db.Subsidynotes.ToList();
            foreach (var item in subsidynotes)
            {
                Subsidynotes subsidynotes1 = db.Subsidynotes.Find(item.ID);
                db.Subsidynotes.Remove(subsidynotes1);
                db.SaveChanges();
            }
            return subsidynotes;
        }
        public List<Attendance> EditA2()
        {
            List<Attendance> attendance = db.Attendance.ToList();
            foreach (var item in attendance)
            {
                Attendance attendance1 = db.Attendance.Find(item.ID);
                db.Attendance.Remove(attendance1);
                db.SaveChanges();
            }
            return attendance;
        }
        public List<GetPrize> EditA3()
        {
            List<GetPrize> getPrize = db.GetPrize.ToList();
            foreach (var item in getPrize)
            {
                GetPrize getPrize1 = db.GetPrize.Find(item.ID);
                db.GetPrize.Remove(getPrize1);
                db.SaveChanges();
            }
            return getPrize;
        }
        public List<Ranks> SelRank()
        {
            List<Ranks> rank = db.Ranks.ToList();

            return rank;
        }
        public List<Attendances> SelAttendances()
        {
            List<Attendances> attendances = db.Attendances.ToList();

            return attendances;
        }
        
            public List<GetPrize> SelGetPrize()
        {
            List<GetPrize> rank = db.GetPrize.ToList();

            return rank;
        }
        public List<Attendance> SelAttendance()
        {
            List<Attendance> rank = db.Attendance.ToList();

            return rank;
        }
        
        public List<Roles> SelRole()
        {
            List<Roles> roles = db.Roles.ToList();

            return roles;
        }
        public List<Subsidynotes> SelSubsidynotes()
        {
            List<Subsidynotes> subsidynotes = db.Subsidynotes.ToList();

            return subsidynotes;
        }
        public List<GetPrize> SelGetPrize(string Name)
        {

            return db.GetPrize.ToList().OrderBy(p => p.ID).Where(p => p.Personnel.Name.Contains(Name)).ToList();
        }
        //public List<Pays> SelPays(string Name)
        //{

        //    return db.Pays.ToList().OrderBy(p => p.ID).Where(p => p.Personnel.Name.Contains(Name)).ToList();
        //}
        public List<Personnel> SelPersonnellist()
        {

            return db.Personnel.ToList();
        }
        
        public List<Department> SelDepartment()
        {
            List<Department> departments = db.Department.ToList();
            return departments;
        }
        public Attendances Kq(int ID)
        {
            var id= db.Attendances.SingleOrDefault(p => p.ID == ID).PersonnelID;
            db.Personnel.SingleOrDefault(p => p.ID == id).States = 1;
            Attendances attendances = db.Attendances.Find(ID);
            var a = DateTime.Now;
            var d = a.Hour;
            if (d > 9)
            {
                attendances.AttendanceStates = 3;
            }
            else
            {
                attendances.AttendanceStates = 2;
            }
            db.SaveChanges();
            return attendances;
        }
        public List<SelectListItem> SelRank1()
        {

            List<SelectListItem> list = db.Ranks.Select(p => new SelectListItem()
            {
                Text = p.RankName,
            Value = p.ID.ToString()

            }).ToList();

            return list;
        }
        public List<SelectListItem> SelPersonnel2()
        {

            List<SelectListItem> list = db.Personnel.Select(p => new SelectListItem()
            {
                Text = "在职中",
                Value = p.ID.ToString()

            }).ToList();

            return list;
        }
        
        public List<SelectListItem> SelRole1()
        {

            List<SelectListItem> list = db.Roles.Select(p => new SelectListItem()
            {
                Text = p.RoleName,
                Value = p.ID.ToString()

            }).ToList();

            return list;
        }
        public List<SelectListItem> SelDepartment1()
        {

            List<SelectListItem> list = db.Department.Select(p => new SelectListItem()
            {
                Text = p.DepartmentName,
                Value = p.ID.ToString()

            }).ToList();

            return list;
        }
        public List<SelectListItem> SelShop1()
        {

            List<SelectListItem> list = db.Shop.Select(p => new SelectListItem()
            {
                Text = p.ShopName,
                Value = p.ID.ToString()

            }).ToList();

            return list;
        }
        public List<SelectListItem> SelAttendanceSet1()
        {

            List<SelectListItem> list = db.AttendanceSet.Select(p => new SelectListItem()
            {
                Text = p.AttendanceName,
                Value = p.ID.ToString()

            }).ToList();

            return list;
        }
        public List<SelectListItem> SelPersonnel1()
        {

            List<SelectListItem> list = db.Personnel.Select(p => new SelectListItem()
            {
                Text = p.Name,
                Value = p.ID.ToString()

            }).ToList();

            return list;
        }
        public List<SelectListItem> SelSubsidy1()
        {

            List<SelectListItem> list = db.Subsidy.Select(p => new SelectListItem()
            {
                Text = p.SubsidyName,
                Value = p.ID.ToString()

            }).ToList();

            return list;
        }
        public List<SelectListItem> SelPrize1()
        {

            List<SelectListItem> list = db.Prize.Select(p => new SelectListItem()
            {
                Text = p.PrizeName,
                Value = p.ID.ToString()

            }).ToList();

            return list;
        }
        public List<Shop> SelShop()
        {
            List<Shop> shops = db.Shop.ToList();
            return shops;
        }
        public List<Prize> SelPrize()
        {
            List<Prize> prize = db.Prize.ToList();
            return prize;
        }
        public List<Subsidy> SelSubsidy()
        {
            List<Subsidy> subsidy = db.Subsidy.ToList();
            return subsidy;
        }
        public List<Roles> SelRoles()
        {
            List<Roles> roles = db.Roles.ToList();
            return roles;
        }
        public List<Attendance> SelAttendance(string Name)
        {
            return db.Attendance.ToList().OrderBy(p => p.ID).Where(p => p.Personnel.Name.Contains(Name)).ToList();
        }
        public Attendances SelAttendances(int PersonnelID)
        {
            return db.Attendances.FirstOrDefault(p => p.PersonnelID == PersonnelID );
        }
        public int AddPersonnel(Personnel personnel)
        {
            Attendances attendances = new Attendances();
            attendances.PersonnelID = personnel.ID;
            attendances.AttendanceStates = 1;
            db.Attendances.Add(attendances);
            db.Personnel.Add(personnel);
            int result = db.SaveChanges();
            return result;
        }
        public int AddRemarks(Pay pay)
        {
            db.Pay.Add(pay);
            int result = db.SaveChanges();
            return result;
        }
        
        public int AddPay(Pay pay)
        {
            decimal? aa = 0;
            int b = 0;
            int c = 0;
            double d = 0;
            double e = 0;
            var psl= db.Personnel.ToList();
            var atd = db.Attendance.ToList();
            var ssn = db.Subsidynotes.ToList();
            var gpe = db.GetPrize.ToList();
            var rank = db.Ranks.ToList();
            foreach (var item in psl)
            {
                var quan = db.Attendance.SingleOrDefault(p => p.PersonnelID == item.ID);
                if (quan == null)
                    {
                        aa += db.Prize.SingleOrDefault(p=>p.PrizeName=="全勤奖").PayDeductionDefault;
                    }
                pay.PersonnelID = item.ID;
                pay.PersonnelName = item.Name;
                pay.ShopName = item.Shop.ShopName;
                pay.RankName = item.Ranks.RankName;
                pay.PayDate = DateTime.Now;
                pay.Basepay = item.Ranks.Basepay;
                foreach(var item1 in atd.Where(p => p.PersonnelID == item.ID))
                {
                    b -= int.Parse(item1.AttendanceSet.PayDeduction.ToString()) * int.Parse(item1.Counts.ToString());
                }
                pay.AttendanceDebits = b;
                foreach(var item1 in ssn.Where(p => p.PersonnelID == item.ID))
                    {
                    c += int.Parse(item1.SubsidyDefault.ToString());
                }
                pay.SubMoney = c;
                foreach(var item1 in gpe.Where(p => p.PersonnelID == item.ID))
                    {
                    aa += item1.Moneys;
                }
                pay.PrizeMoney =  aa;
                foreach(var item1 in rank.Where(p => p.ID == item.RankID))
                    {
                    d += double.Parse((item1.Basepay + aa + c).ToString());
                }
                pay.Payables = int.Parse(d.ToString());
                foreach(var item1 in rank.Where(p => p.ID == item.RankID))
                    {
                    e += double.Parse((item1.Basepay + aa + c + b).ToString());
                }
                pay.Paidwages = int.Parse(e.ToString());
                pay.Remarks = "加油";
                db.Pay.Add(pay);
                db.SaveChanges();
                aa = 0;
                b = 0;
                c = 0; 
                d = 0; 
                e = 0;
            }
                int result =db.SaveChanges(); 
                return result;
        }
        public int AddAttendances(Attendances Attendances)
        {
            db.Attendances.Add(Attendances);
            int result = db.SaveChanges();
            return result;
        }
        
        public int AddShop(Shop shop)
        {
            db.Shop.Add(shop);
            int result = db.SaveChanges();
            return result;
        }
        public int AddPrize(Prize prize)
        {
            db.Prize.Add(prize);
            int result = db.SaveChanges();
            return result;
        }
        public int AddSubsidy(Subsidy subsidy)
        {
            db.Subsidy.Add(subsidy);
            int result = db.SaveChanges();
            return result;
        }

        public int AddSubsidynotes(Subsidynotes subsidynotes)
        {
            
            
            subsidynotes.SubsidyDefault = db.Subsidy.SingleOrDefault(p => p.ID == subsidynotes.SubsidyID).SubsidyDefault;
            db.Subsidynotes.Add(subsidynotes);
            int result = db.SaveChanges();
            return result;
        }
        public int AddGetPrize(GetPrize getPrize)
        {
            getPrize.Moneys = db.Prize.SingleOrDefault(p => p.ID == getPrize.PrizeID).PayDeductionDefault;
            db.GetPrize.Add(getPrize);
            int result = db.SaveChanges();
            return result;
            
        }

        public int AddAttendance(Attendance attendance)
        {
            var a = db.Attendance.SingleOrDefault(p => p.PersonnelID == attendance.PersonnelID&& p.AttendanceSetID == attendance.AttendanceSetID);
            if (a != null)
            {
                db.Attendance.SingleOrDefault(p=>p.PersonnelID==attendance.PersonnelID&&p.AttendanceSetID==attendance.AttendanceSetID).Counts += 1;
                db.Attendance.SingleOrDefault(p => p.PersonnelID == attendance.PersonnelID && p.AttendanceSetID == attendance.AttendanceSetID).Dates= DateTime.Now;
                db.SaveChanges();
            } else
            {
                db.Attendance.Add(attendance);
                db.SaveChanges();
             }

            var b = db.Attendance.SingleOrDefault(p => p.PersonnelID == attendance.PersonnelID && p.AttendanceSetID == attendance.AttendanceSetID);
            if (a != null)
            {
                db.Attendances.SingleOrDefault(p => p.PersonnelID == a.PersonnelID).AttendanceStates = 4;
            }
            else
            {
                db.Attendances.SingleOrDefault(p => p.PersonnelID == b.PersonnelID).AttendanceStates = 3;
            }
            //var a = db.Attendance.SingleOrDefault(p=>p.PersonnelID==2);
            //var a = db.Attendance.Find(attendance.PersonnelID==1);
            int result = db.SaveChanges();
            return result;
        }
        
            public int AddGX()
            {
                var a = db.Attendances.ToList();
                foreach (var item in a)
                {
                    item.AttendanceStates = 1;
                }
                int result= db.SaveChanges();
                return result;
                    
            }

            public int AddYJKQ(Attendance attendance)
        {
            var zui = db.Personnel.ToList();
            var aa = db.Attendance.ToList();
            var bb = db.Attendances.ToList();
            foreach (var item in bb.Where(p=>p.AttendanceStates==1||p.AttendanceStates==3))
            {
                if (item.AttendanceStates == 1)
                {
                    var aaa = db.Personnel.Where(p => p.ID == item.PersonnelID).ToList();
                    foreach (var item1 in aaa)
                    {
                        var a = db.Attendance.SingleOrDefault(p => p.PersonnelID == item.PersonnelID && p.AttendanceSetID == 2);
                        if (a != null)
                        {
                            a.Counts += 1;
                            //db.Attendance.SingleOrDefault(p => p.PersonnelID == item.PersonnelID && p.AttendanceSetID == item1.AttendanceSetID).Counts += 1;
                            db.SaveChanges();
                        }
                        else
                        {
                            attendance.Counts = 1;
                            attendance.PersonnelID = item1.ID;
                            attendance.AttendanceSetID = 2;
                            attendance.Dates= DateTime.Now;
                            foreach (var item3 in bb)
                            {
                                item.AttendanceStates = 4;
                            }
                            db.Attendance.Add(attendance);
                            db.SaveChanges();
                        }

                        var b = db.Attendance.SingleOrDefault(p => p.PersonnelID == attendance.PersonnelID && p.AttendanceSetID == attendance.AttendanceSetID);
                        if (a != null)
                        {
                            db.Attendances.SingleOrDefault(p => p.PersonnelID == a.PersonnelID).AttendanceStates = 4;
                        }
                        //else
                        //{
                        //    db.Attendances.SingleOrDefault(p => p.PersonnelID == b.PersonnelID).AttendanceStates = 3;
                        //}

                    }
                    
                }
                if (item.AttendanceStates == 3)
                {
                    var aaa = db.Personnel.Where(p => p.ID == item.PersonnelID).ToList();
                    foreach (var item1 in aaa)
                    {
                        var a = db.Attendance.SingleOrDefault(p => p.PersonnelID == item.PersonnelID && p.AttendanceSetID == 1);
                        if (a != null)
                        {
                            a.Counts += 1;
                            //db.Attendance.SingleOrDefault(p => p.PersonnelID == item.PersonnelID && p.AttendanceSetID == item1.AttendanceSetID).Counts += 1;
                            db.SaveChanges();
                        }
                        else
                        {
                            attendance.Counts = 1;
                            attendance.PersonnelID = item1.ID;
                            attendance.AttendanceSetID = 1;
                            attendance.Dates = DateTime.Now;
                            foreach (var item3 in bb)
                            {
                                item.AttendanceStates = 4;
                            }
                            db.Attendance.Add(attendance);
                            db.SaveChanges();
                        }

                        var b = db.Attendance.SingleOrDefault(p => p.PersonnelID == attendance.PersonnelID && p.AttendanceSetID == attendance.AttendanceSetID);
                        if (a != null)
                        {
                            db.Attendances.SingleOrDefault(p => p.PersonnelID == a.PersonnelID).AttendanceStates = 4;
                        }
                        //else
                        //{
                        //    db.Attendances.SingleOrDefault(p => p.PersonnelID == b.PersonnelID).AttendanceStates = 3;
                        //}

                    }

                }
            }
            
            int result = db.SaveChanges();
            return result;
        }
        
        public int AddRank(Ranks rank)
        {
            db.Ranks.Add(rank);
            int result = db.SaveChanges();
            return result;
        }
        public int AddDepartment(Department department)
        {
            db.Department.Add(department);
            int result = db.SaveChanges();
            return result;
        }
        public int AddRoles(Roles roles)
        {
            db.Roles.Add(roles);
            int result = db.SaveChanges();
            return result;
        }
        public int AddAttendanceSet(AttendanceSet attendanceSet)
        {
            db.AttendanceSet.Add(attendanceSet);
            int result = db.SaveChanges();
            return result;
        }
        public int DeletePersonnel(int id)
        {

            Attendances attendances = db.Attendances.SingleOrDefault(p => p.PersonnelID == id);
            Personnel personnel = db.Personnel.Find(id);
            db.Attendances.Remove(attendances);
            db.Personnel.Remove(personnel);
            int result = db.SaveChanges();
            return result;
        }
        public int DeleteShop(int id)
        {
            Shop shop = db.Shop.Find(id);
            db.Shop.Remove(shop);
            int result = db.SaveChanges();
            return result;
        }
        public int DeletePrize(int id)
        {
            Prize prize = db.Prize.Find(id);
            db.Prize.Remove(prize);
            int result = db.SaveChanges();
            return result;
        }
        public int DeleteSubsidy(int id)
        {
            Subsidy subsidy = db.Subsidy.Find(id);
            db.Subsidy.Remove(subsidy);
            int result = db.SaveChanges();
            return result;
        }
        public int DeleteAttendance(int id)
        {
            Attendance attendance = db.Attendance.Find(id);
            db.Attendance.Remove(attendance);
            int result = db.SaveChanges();
            return result;
        }
        public int DeleteSubsidynotes(int id)
        {
            Subsidynotes subsidynotes = db.Subsidynotes.Find(id);
            db.Subsidynotes.Remove(subsidynotes);
            int result = db.SaveChanges();
            return result;
        }
        public int DeleteGetPrize(int id)
        {
            GetPrize getPrize = db.GetPrize.Find(id);
            db.GetPrize.Remove(getPrize);
            int result = db.SaveChanges();
            return result;
        }
        public int DeleteRank(int id)
        {
            Ranks rank = db.Ranks.Find(id);
            db.Ranks.Remove(rank);
            int result = db.SaveChanges();
            return result;
        }
        public int DeleteDepartment(int id)
        {
            Department department = db.Department.Find(id);
            db.Department.Remove(department);
            int result = db.SaveChanges();
            return result;
        }
        public int DeleteRoles(int id)
        {
            Roles roles = db.Roles.Find(id);
            db.Roles.Remove(roles);
            int result = db.SaveChanges();
            return result;
        }
        public int DeleteAttendanceSet(int id)
        {
            AttendanceSet attendanceSet = db.AttendanceSet.Find(id);
            db.AttendanceSet.Remove(attendanceSet);
            int result = db.SaveChanges();
            return result;
        }
    }
}
