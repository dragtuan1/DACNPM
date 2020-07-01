using DACNPM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACNPM.BLL
{
    public class QLXe_BLL
    {
        private DACNPM db;
        private static QLXe_BLL _Instance;
        public static QLXe_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLXe_BLL();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        private QLXe_BLL()
        {
            db = new DACNPM();
        }
        public List<Entities.Type_Vehicle> getTypeVehiCle_BLL()
        {
            return db.Type_Vehicles.ToList();
        }
        public object getVehicles_BLL()
        {
            var query = db.Vehicles.Select(p => new { p.ID_Vehicle, p.License_Plate, p.Driver.Name_Driver, p.Type_Vehicle.Name_Type, p.Type_Vehicle.Amount_Seat, p.Price,p.Vehicle_State });
            return query.ToList();
        }
        public Entities.Vehicle getVehicleByID_BLL(int ID)
        {
            return db.Vehicles.Where(p => p.ID_Vehicle == ID).FirstOrDefault();
        }
        public Entities.Vehicle getVehicleByNameDriver_BLL(string nameDriver)
        {
            return db.Vehicles.Where(p => p.Driver.Name_Driver == nameDriver).FirstOrDefault();
        }
        public Entities.Vehicle getVehicleByDriver_BLL(string nameDriver)
        {
            return db.Vehicles.Where(p => p.Driver.Name_Driver == nameDriver).FirstOrDefault();
        }
        public List<Entities.Driver> GetDrivers_BLL()
        {
            return db.Drivers.ToList();
        }
        public Entities.Driver getDriverByID_BLL(int ID)
        {
            return db.Drivers.Where(p => p.ID_Driver == ID).FirstOrDefault();
        }
        public bool AddVehicle_BLL(Entities.Vehicle veh)
        {
            try
            {
                db.Vehicles.Add(veh);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DelVehicle_BLL(List<int> List_ID)
        {
            try
            {
                foreach (Entities.Vehicle i in db.Vehicles)
                {
                    foreach (int j in List_ID.ToArray())
                    {
                        if (i.ID_Vehicle == j)
                        {
                            db.Vehicles.Remove(i);
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
        public bool UpdateVehicle_BLL(Entities.Vehicle veh)
        {
            try
            {    
                Entities.Vehicle v = getVehicleByID_BLL(Convert.ToInt32(veh.ID_Vehicle.ToString()));
                v.License_Plate = veh.License_Plate;
                v.ID_Type_Vehicle = veh.ID_Type_Vehicle;
                v.ID_Driver = veh.ID_Driver;
                v.Price = veh.Price;
                v.Vehicle_State = veh.Vehicle_State;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public object SearchVehicle_BLL(string StrSearch)
        {
            var list = db.Vehicles.Where(p => p.License_Plate.Contains(StrSearch) || p.Price.ToString() == StrSearch
                                            || p.Driver.Name_Driver.Contains(StrSearch) || p.Type_Vehicle.Name_Type.Contains(StrSearch))
                .Select(p => new { p.ID_Vehicle, p.License_Plate, p.Driver.Name_Driver, p.Type_Vehicle.Name_Type, p.Type_Vehicle.Amount_Seat, p.Price, p.Vehicle_State });
            return list.ToList();
        }
        public bool CheckVehiCel_BLL(Vehicle vhc)
        {
            DACNPM DB = new DACNPM();
            var List = DB.Vehicles.Where(p => p.License_Plate == vhc.License_Plate);
            if(List.Count() != 0 )
            {   
                
                MessageBox.Show("Đã tồn tại xe này");
                return false;
            }    
            return true;
        }
    }
}
