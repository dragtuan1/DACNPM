using DACNPM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACNPM
{
    public class BLL_QLTaiKhoan
    {
        private static BLL_QLTaiKhoan _Instance;
        public static BLL_QLTaiKhoan Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLTaiKhoan();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        private BLL_QLTaiKhoan()
        {
        }

        public Employee GetNVBY_ID_BLL(int ID_NV)
        {

            DACNPM DB = new DACNPM();
            Employee e1 = DB.Employees.Where(p => p.ID_Employee == ID_NV).FirstOrDefault();
            return e1;
        }
        public Account GetACC_ByUserName(string username)
        {
            DACNPM DB = new DACNPM();
            Account acc = DB.Accounts.Where(p => p.Username == username).FirstOrDefault();
            return acc;
        }
        public List<Account> GetACC_ByUserNameandPass(string username,string pass)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(pass);
            //mang ket qua 
            byte[] hash = new MD5CryptoServiceProvider().ComputeHash(temp);

            String hashpass = "";

            foreach (byte i in hash)
            {
                hashpass += i;
            }

            DACNPM DB = new DACNPM();
            var list = DB.Accounts.Where(p => p.Username == username && p.UserPassword == hashpass).ToList();
            return list;
        }
        public bool UpdateIn4_BLL(int ID, string TK, string Ten, string SDT, string MK, string Email)
        {
            try
            {
                DACNPM DB = new DACNPM();
                Account acc = DB.Accounts.Where(p => p.Username == TK).FirstOrDefault();
                acc.UserPassword = MK;
                Employee e = DB.Employees.Where(p => p.ID_Employee == ID).FirstOrDefault();
                e.Name_Employee = Ten;
                e.Phone = SDT;
                e.Email = Email;
                DB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return true;
                throw;
            }

        }
    }
}
