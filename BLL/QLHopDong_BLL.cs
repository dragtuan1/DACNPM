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
    }

}
