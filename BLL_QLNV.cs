using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DACNPM.Entities;


namespace DACNPM
{
    public class BLL_QLNV
    {
        private DACNPM db;
        private static BLL_QLNV _Instance;
        public static BLL_QLNV Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLNV();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        private BLL_QLNV()
        {
            db = new DACNPM();
        }

        public Object getEmployees_BLL()
        {
            var list = db.Employees.Select(p => new { p.ID_Employee, p.Account.Username, p.Name_Employee,p.Account.Type_Account.Name_Type, p.Email, p.Phone, p.Account.Type_Account.Salary });
            return list.ToList();
        }
        public List<Type_Account> getTypeAcounts_BLL()
        {
            return db.Type_Accounts.ToList();
        }
        public Account getAccountByID_BLL(int ID)
        {
            return (db.Accounts.Where(p => p.Type_Account.ID_Type_Account == ID).ToList())[0];
        }
        public Employee getNhanVienByID_BLL(int id)
        {
            return db.Employees.Where(p => p.ID_Employee == id).FirstOrDefault();
        }
        public bool AddNV_BLL(Account acc,Employee emp)
        {
            try
            {
                db.Accounts.Add(acc);
                db.Employees.Add(emp);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DelNV_BLL(List<int> List_ID)
        {
            try
            {
                foreach (Employee i in db.Employees)
                {
                    foreach (int j in List_ID.ToArray())
                    {
                        if (i.ID_Employee == j)
                        {
                            db.Employees.Remove(i);
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
    }
}
