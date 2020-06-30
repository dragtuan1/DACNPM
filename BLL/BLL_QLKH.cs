using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DACNPM.Entities;

namespace DACNPM
{
    public class BLL_QLKH
    {
        private static BLL_QLKH _Instance;
        public static BLL_QLKH Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLKH();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        private BLL_QLKH()
        {
        }
        public bool AddNV_BLL(Customer ctm)
        {
            try
            {
                DACNPM DB = new DACNPM();
                DB.Customers.Add(ctm);
                DB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Customer> GetALL_CTM()
        {
            DACNPM DB = new DACNPM();
           var list = DB.Customers.Select(p => p);
        //    var List = DB.Customers.Select(p => new { p.ID_Customer, p.Customer_Name, p.Customer_Address, p.CMND, p.Phone }) ;
            return list.ToList();
        }
        public bool DelNV_BLL(List<int> List_ID)
        {
            try
            {
                DACNPM DB = new DACNPM();
                foreach (Customer i in DB.Customers)
                {
                    foreach (int j in List_ID.ToArray())
                    {
                        if (i.ID_Customer == j)
                        {
                            DB.Customers.Remove(i);
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
        public bool UpdateNV_BLL(Customer ctm)
        {
            try
            {
                DACNPM DB = new DACNPM();
                Customer s = DB.Customers.Where(p => p.ID_Customer == ctm.ID_Customer).FirstOrDefault();
                s.Customer_Address = ctm.Customer_Address;
                s.CMND = ctm.CMND;
                s.Customer_Name = ctm.Customer_Name;
                s.Phone = ctm.Phone;
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
            var List =  DB.Customers.Where (c => c.CMND.Contains(StrSeach) || c.Customer_Address.Contains(StrSeach) || c.Customer_Name.Contains(StrSeach) || c.Phone.Contains(StrSeach))
                       .Select (c => new {c.ID_Customer, c.Customer_Name,c.Customer_Address,c.CMND,c.Phone });
            return List.ToList();
        }
        public bool CheckIn4_CTMBLL(Customer cmt)
        {   
            if(cmt.CMND == "" || cmt.Phone == "" || cmt.Customer_Name == "" || cmt.Customer_Address == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đầy đủ thông tin ");
                return false; 
            }
            if(cmt.Phone.Length > 11)
            {
               MessageBox.Show("Số Điện Thoại Vượt Quá 11 Số");
                return false;
            }    
            
            return true;
        }
    }
}
