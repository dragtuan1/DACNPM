using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACNPM.BLL
{
    public class QLTaiXe_BLL
    {
        private DACNPM db;

        private static QLTaiXe_BLL _Instance;

        public static QLTaiXe_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLTaiXe_BLL();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        public QLTaiXe_BLL()
        {
            db = new DACNPM();
        }

        public object getAllTaiXe_BLL()
        {
            var taixes = db.Drivers.Select(p => new { p.ID_Driver, p.Name_Driver, p.Driver_Address, p.Phone, p.CMND, p.License });
            return taixes.ToList();
        }

        public bool addTaiXe(Entities.Driver driver)
        {
            try
            {
                db.Drivers.Add(driver);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public bool updateTaiXe_BLL(Entities.Driver driver)
        {
            try
            {
                Entities.Driver dr = db.Drivers.Where(p => p.ID_Driver == driver.ID_Driver).FirstOrDefault();
                dr.Name_Driver = driver.Name_Driver;
                dr.Driver_Address = driver.Driver_Address;
                dr.CMND = driver.CMND;
                dr.Phone = driver.Phone;
                dr.License = driver.License;
                dr.Driver_State = driver.Driver_State;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public bool deleteTaiXeByID_BLL(List<int> List_ID)
        {
            try
            {
                foreach (Entities.Driver i in db.Drivers)
                {
                    foreach (int j in List_ID.ToArray())
                    {
                        if (i.ID_Driver == j)
                        {
                            db.Drivers.Remove(i);
                        }
                    }
                }
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public object searchTaiXebyName_BLL(string ten)
        {
            return db.Drivers.Where(p => p.Name_Driver.Contains(ten)).Select(p => new { p.ID_Driver, p.Name_Driver, p.Driver_Address, p.Phone, p.CMND, p.License }).ToList();

        }

        public object searchTaiXebyCMND_BLL(string cmnd)
        {
            return db.Drivers.Where(p => p.CMND == cmnd).Select(p => new { p.ID_Driver, p.Name_Driver, p.Driver_Address, p.Phone, p.CMND, p.License }).ToList();
        }
        public object SearchKH_BLL(string StrSeach)
        {
            DACNPM DB = new DACNPM();
            var List = DB.Drivers.Where(c => c.CMND.Contains(StrSeach) || c.Name_Driver.Contains(StrSeach) )
                       .Select(c => new { c.ID_Driver, c.CMND, c.Driver_Address, c.Name_Driver, c.Phone });
            
            return List.ToList();
        }
        public bool CheckIn4_TaiXe_BLL(Entities.Driver driver)
        {

            try
            {
                var list = db.Drivers.Where(p => p.Phone == driver.Phone).ToList();
                if (list.Count() != 0)
                {
                    MessageBox.Show("Đã tồn tại số điện thoại này");
                    return false; // Trùng số điện thoại

                }
                var list1 = db.Drivers.Where(p => p.CMND == driver.CMND).ToList();
                if (list1.Count() != 0)
                {
                    MessageBox.Show("Đã tồn tại số CMND này");
                    return false; // Trung cmnd
                }
                var list2 = db.Drivers.Where(p => p.License == driver.License).ToList();
                if (list2.Count() != 0)
                {
                    MessageBox.Show("Đã tồn tại số bằng lái xe này");
                    return false; // Trung cmnd
                }
                if (driver.Phone.Length > 11)
                {
                    MessageBox.Show("Số Điện Thoại Vượt Quá 11 Số");
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return true; // hợp lệ
        }
    }
}
