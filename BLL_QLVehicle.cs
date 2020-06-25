using DACNPM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACNPM
{
    public class BLL_QLVehicle
    {
        private static BLL_QLVehicle _Instance;
        public static BLL_QLVehicle Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLVehicle();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        private BLL_QLVehicle()
        {
        }
        public bool AddNV_BLL(Vehicle vehicle)
        {
            try
            {
                DACNPM DB = new DACNPM();
                DB.Vehicles.Add(vehicle);
                DB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public object GetALL_Vehicle()
        {
            DACNPM DB = new DACNPM();
            var List = DB.Vehicles.Select(p => new { p.ID_Vehicle, p.License_Plate, p.Price, p.Type_Vehicle.Name_Type, p.Type_Vehicle.Amount_Seat });
            return List.ToList();
        }
        public bool DelNV_BLL(List<int> List_ID)
        {
            try
            {
                DACNPM DB = new DACNPM();
                foreach (Vehicle i in DB.Vehicles)
                {
                    foreach (int j in List_ID.ToArray())
                    {
                        if (i.ID_Vehicle == j)
                        {
                            DB.Vehicles.Remove(i);
                        }
                    }
                }
                DB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateNV_BLL(Vehicle vehicle)
        {
            try
            {
                DACNPM DB = new DACNPM();
                Vehicle v = DB.Vehicles.Where(p => p.ID_Vehicle == vehicle.ID_Vehicle).FirstOrDefault();
                v.License_Plate = vehicle.License_Plate;
                DB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public object SearchKH_BLL(string StrSeach)
        {
            DACNPM DB = new DACNPM();
            var List = DB.Customers.Where(c => c.CMND.Contains(StrSeach) || c.Customer_Address.Contains(StrSeach) || c.Customer_Name.Contains(StrSeach) || c.Phone.Contains(StrSeach))
                       .Select(c => new { c.ID_Customer, c.Customer_Name, c.Customer_Address, c.CMND, c.Phone });
            return List.ToList();
        }
    }
}
