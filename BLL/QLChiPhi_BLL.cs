using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACNPM.BLL
{
    public class QLChiPhi_BLL
    {
        private DACNPM db;

        private static QLChiPhi_BLL _Instance;

        public static QLChiPhi_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLChiPhi_BLL();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        public QLChiPhi_BLL()
        {
            db = new DACNPM();
        }

        public List<Entities.Type_Vehicle> getTypeVehiCle_BLL()
        {
            return db.Type_Vehicles.ToList();
        }

        public Object getVehicles_BLL()
        {
            var query = db.Vehicles.Select(p => new {p.ID_Vehicle, p.Driver.Name_Driver, p.Type_Vehicle.Name_Type, p.Type_Vehicle.Amount_Seat, p.Price });
             return query.ToList();
        }

        public Entities.Vehicle getVehicleByID_BLL(int ID)
        {
            return (db.Vehicles.Where(p => p.Type_Vehicle.ID_Type_Vehicle == ID).ToList())[0];
        }

        public bool UpdatePhiXeByIDXe_BLL(int id, int Price)
        {
            try
            {
                Entities.Vehicle vehicle = db.Vehicles.Where(p => p.ID_Vehicle == id).FirstOrDefault();
                vehicle.Price = Price;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public Object getNhanVien_BLL()
        {
            var NhanViens = db.Employees.Select(p => new { p.ID_Employee, p.Name_Employee, p.Account.Type_Account.Name_Type, p.Account.Type_Account.Salary });
            return NhanViens.ToList();
        }

        public Entities.Employee getNhanVienByID_BLL(int id)
        {
            return db.Employees.Where(p => p.ID_Employee == id).FirstOrDefault();
        }

        public List<Entities.Type_Account> getTypeAcounts_BLL()
        {
            return db.Type_Accounts.ToList();
        }

        public int TongTienByIDNhanVien_BLL(int id)
        {
            DateTime date = DateTime.Now;

            int year = date.Year;
            int month = date.Month;
            int day = date.Day;

            int tien = 0;

            Entities.Employee employee = db.Employees.Where(p => p.ID_Employee == id).FirstOrDefault();
            foreach(Entities.MN_Salary i in employee.MN_Salaries)
            {
                if(i.Month_Work.Year == year && i.Month_Work.Month == month)
                {
                    tien = day * employee.Account.Type_Account.Salary + i.Total_Contract * 50000;
                }
            }
            return tien;
        }
    }
}
