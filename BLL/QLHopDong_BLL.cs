using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACNPM.BLL
{
    public class QLHopDong_BLL
    {
        private DACNPM db;
        private static QLHopDong_BLL _Instance;
        public static QLHopDong_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLHopDong_BLL();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        private QLHopDong_BLL()
        {
            db = new DACNPM();
        }

        public bool addHopDong_BLL(int id_employee, int id_customer,
                                    DateTime date_borrow, DateTime date_return, int total_bill, bool contract_state)
        {
            try
            {
                Entities.Contract contract = new Entities.Contract
                {
                    ID_Employee = id_employee,
                    ID_Customer = id_customer,
                    Date_Borrow = date_borrow,
                    Date_Return = date_return,
                    Total_Bill = total_bill,
                    Contract_State = contract_state
                };

                db.Contracts.Add(contract);
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;

            }
        }

        public int addDetailHopDong_BLL(int idHopDong, String BienSo)
        {
            try
            {
                Entities.Contract contract = BLL.QLHopDong_BLL.Instance.getHopDongByID_BLL(idHopDong);
                Entities.Vehicle vehicle = db.Vehicles.Where(p => p.License_Plate == BienSo).FirstOrDefault();

                if(contract.Date_Return > DateTime.Now)
                {
                    Entities.Detail_Contract detail = new Entities.Detail_Contract
                    {
                        ID_Contract = idHopDong,
                        ID_Vehicle = vehicle.ID_Vehicle,
                        Total_Price = vehicle.Price,
                        Date_Make_Contract = DateTime.Now
                    };

                    vehicle.Vehicle_State = true;

                    db.Detail_Contracts.Add(detail);



                    contract.Total_Bill = contract.Total_Bill + detail.Total_Price;

                    db.SaveChanges();


                    return 1;
                }
                {
                    return 2;
                }

               
            }
            catch
            {
                return 3;
            }
        }

        internal object getAcountByUserName_BLL(object username)
        {
            throw new NotImplementedException();
        }

        public Entities.Account getAcountByUserName_BLL(String name)
        {
            return db.Accounts.Where(p => p.Username == name).FirstOrDefault();
        }

        public Entities.Customer getCustomerByCMND_BLL(String cmnd)
        {
            return db.Customers.Where(p => p.CMND == cmnd).FirstOrDefault();
        }

        public Object getHopDong_BLL()
        {
            var hopDong = db.Contracts.Select(p => new { p.ID_Contract, p.Customer.Customer_Name, p.Employee.Name_Employee, p.Date_Borrow, p.Date_Return, p.Total_Bill });
            return hopDong.ToList();
        }

        public Object getHopDongBySTD_BLL(String sdt)
        {
            var hopDong = db.Contracts.Where(p => p.Customer.Phone == sdt).Select(p => new { p.ID_Contract, p.Customer.Customer_Name, p.Employee.Name_Employee, p.Date_Borrow, p.Date_Return, p.Total_Bill });
            return hopDong.ToList();
        }

        public Object getHopDongByName_BLL(String name)
        {
            var hopdong = db.Contracts.Where(p => p.Customer.Customer_Name.Contains(name))
                .Select(p => new { p.ID_Contract, p.Customer.Customer_Name, p.Employee.Name_Employee, p.Date_Borrow, p.Date_Return, p.Total_Bill })
                .ToList();
            return hopdong;
        }

        public bool UpdateHopDong_BLL(int id, DateTime borrow, DateTime retun)
        {
            try
            {
                if(retun > DateTime.Now)
                {
                    Entities.Contract contract = db.Contracts.Where(p => p.ID_Contract == id).FirstOrDefault();
                    contract.Date_Borrow = borrow;
                    contract.Date_Return = retun;
                    db.SaveChanges();
                    return true;
                } else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }

        }

        public Entities.Contract getHopDongByID_BLL(int id)
        {
            return db.Contracts.Where(p => p.ID_Contract == id).FirstOrDefault();
        }

        public void deleteHopDongByID(int id)
        {
            Entities.Contract contract = db.Contracts.Where(p => p.ID_Contract == id).FirstOrDefault();
            db.Contracts.Remove(contract);
            db.SaveChanges();
        }

        public Object getAllDetailHoaDon(int idHopDong)
        {
            var detailHoaDon = db.Detail_Contracts.Where(p => p.Contract.ID_Contract == idHopDong)
                                .Select(p => new { p.ID_Detail_Contract, p.ID_Contract, p.Vehicle.License_Plate, p.Vehicle.Price});
            return detailHoaDon.ToList();
        }

        public void deleteDetailHopDongByBienSo_BLL(int id)
        {
            Entities.Detail_Contract contract = db.Detail_Contracts.Where(p => p.ID_Detail_Contract == id).FirstOrDefault();

            contract.Contract.Total_Bill = contract.Contract.Total_Bill - contract.Vehicle.Price;

            db.Detail_Contracts.Remove(contract);

            db.SaveChanges();
        }

        public List<Entities.Type_Vehicle> getAllTypeVehicle()
        {
            return db.Type_Vehicles.ToList();
        }

        public List<Entities.Vehicle> getVehicleByState_BLL(int ID_TypeVehicle)
        {
            var list = db.Vehicles.Where(p => p.ID_Type_Vehicle == ID_TypeVehicle && p.Vehicle_State == false).ToList();
            return list;
        }
    }

}
