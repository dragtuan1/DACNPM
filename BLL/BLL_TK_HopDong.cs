using DACNPM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACNPM
{   
    
    public class BLL_TK_HopDong { 
        private static BLL_TK_HopDong _Instance;
    public static BLL_TK_HopDong Instance
    {
        get
        {
            if (_Instance == null)
            {
                _Instance = new BLL_TK_HopDong();
            }
            return _Instance;
        }
        private set => _Instance = value;
    }
    private BLL_TK_HopDong()
    {
    }   
        public object GetContract_ByTime(DateTime DayStart, DateTime DayEnd)
        {
            DACNPM DB = new DACNPM();
            var List = DB.Detail_Contracts.Where(c => c.Date_Make_Contract > DayStart && c.Date_Make_Contract < DayEnd)
                .Select(p => new { p.Contract.ID_Contract, p.Contract.ID_Customer, p.Contract.ID_Employee, p.Contract.Total_Bill, p.ID_Vehicle, p.Total_Price });
            return List.ToList();          
        }

        public object GetContract_ByStatus(bool Check)
        {
            DACNPM DB = new DACNPM();
            var List = DB.Contracts.Where(c => c.Contract_State == Check);
            return List.ToList();
        }

    }
}
