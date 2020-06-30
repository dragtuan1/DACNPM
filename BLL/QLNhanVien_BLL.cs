using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACNPM.BLL
{
    public class QLNhanVien_BLL
    {
        private DACNPM db;
        private static QLNhanVien_BLL _Instance;
        public static QLNhanVien_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLNhanVien_BLL();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        private QLNhanVien_BLL()
        {
            db = new DACNPM();
        }

        public object getEmployees_BLL()
        {
            var list = db.Employees.Select(p => new { p.ID_Employee, p.Account.Username, p.Name_Employee, p.Account.Type_Account.Name_Type, p.Email, p.Phone, p.Account.Type_Account.Salary });
            return list.ToList();
        }
        public List<Entities.Type_Account> getTypeAcounts_BLL()
        {
            return db.Type_Accounts.ToList();
        }
        public Entities.Account getAccountByID_BLL(int ID)
        {
            return (db.Accounts.Where(p => p.Type_Account.ID_Type_Account == ID).FirstOrDefault());
        }
        public Entities.Account getAccountByUsername_BLL(string username)
        {
            return (db.Accounts.Where(p => p.Username == username).FirstOrDefault());
        }
        public Entities.Employee getNhanVienByID_BLL(int id)
        {
            return db.Employees.Where(p => p.ID_Employee == id).FirstOrDefault();
        }
        public bool AddNV_BLL(Entities.Account acc, Entities.Employee emp)
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
                foreach (Entities.Employee i in db.Employees)
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
        public bool UpdateNV_BLL(Entities.Account acc, Entities.Employee emp)
        {
            try
            {
                Entities.Account a = getAccountByID_BLL(Convert.ToInt32(acc.ID_Type_Account.ToString()));
                a.UserPassword = acc.UserPassword;
                a.ID_Type_Account = acc.ID_Type_Account;
                Entities.Employee e = getNhanVienByID_BLL(Convert.ToInt32(emp.ID_Employee.ToString()));
                e.Name_Employee = emp.Name_Employee;
                e.Email = emp.Email;
                e.Phone = emp.Phone;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public object SearchNV_BLL(string StrSearch)
        {
            var list = db.Employees.Where(p => p.Account.Username.Contains(StrSearch) || p.Name_Employee.Contains(StrSearch)
                || p.Email.Contains(StrSearch) || p.Phone.Contains(StrSearch))
                .Select(p => new { p.ID_Employee, p.Account.Username, p.Account.UserPassword, p.Name_Employee, p.Account.Type_Account.Name_Type, p.Email, p.Phone, p.Account.Type_Account.Salary });
            return list.ToList();
        }
    }
}
