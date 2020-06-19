using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public bool AddNV_DAL(Customer ctm)
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
        public object GetALL_CTM()
        {
            DACNPM DB = new DACNPM();
            var List = DB.Customers.Select(p => new { p.ID_Customer, p.Customer_Name, p.Customer_Address, p.CMND, p.Phone }) ;
            return List.ToList();
        }
    }
}
