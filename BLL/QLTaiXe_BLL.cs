using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Object getAllTaiXe_BLL()
        {
            var taixes = db.Drivers.Select(p => new { p.ID_Driver, p.Name_Driver, p.Driver_Address, p.Phone, p.CMND, p.License });
            return taixes.ToList();
        }

        public void addTaiXe(String adress, String cmnd, String name, String phone, String banglai, bool state)
        {
            Entities.Driver driver = new Entities.Driver
            {
                Driver_Address = adress,
                CMND = cmnd,
                Name_Driver = name,
                Phone = phone,
                License = banglai,
                Driver_State = state
            };

            db.Drivers.Add(driver);
            db.SaveChanges();
        }

        public void updateTaiXe_BLL(int idTaiXe, String adress, String cmnd, String name, String phone, String banglai, bool state)
        {
            Entities.Driver driver = db.Drivers.Where(p => p.ID_Driver == idTaiXe).FirstOrDefault();
            driver.Name_Driver = name;
            driver.Driver_Address = adress;
            driver.CMND = cmnd;
            driver.Phone = phone;
            driver.License = banglai;
            driver.Driver_State = state;
            db.SaveChanges();
        }

        public void deleteTaiXeByID_BLL(int id)
        {
            Entities.Driver driver = db.Drivers.Where(p => p.ID_Driver == id).FirstOrDefault();
            db.Drivers.Remove(driver);
            db.SaveChanges();
        }

        public Object searchTaiXebyName_BLL(string ten)
        {
            return db.Drivers.Where(p => p.Name_Driver.Contains(ten)).Select(p => new { p.ID_Driver, p.Name_Driver, p.Driver_Address, p.Phone, p.CMND, p.License }).ToList();

        }

        public Object searchTaiXebyCMND_BLL(string cmnd)
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
    }
}
