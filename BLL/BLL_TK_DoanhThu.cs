using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DACNPM.Entities;

namespace DACNPM
{
    class BLL_TK_DoanhThu
    {
        private static BLL_TK_DoanhThu _Instance;
        public static BLL_TK_DoanhThu Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_TK_DoanhThu();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        private BLL_TK_DoanhThu()
        {
        }
        public TK_DoanhThu GetLuong12Thang(DateTime year)
        {
            TK_DoanhThu ListTien = new TK_DoanhThu();
            DACNPM DB = new DACNPM();
            var ListCtr = DB.Contracts.Where(c => c.Date_Borrow.Year == year.Year).Select(p => p).ToList();
            ListTien.Thang1  = ListCtr.Where(c=> c.Date_Borrow.Month == 1).Select(c => c.Total_Bill).Sum();
            ListTien.Thang2 = ListCtr.Where(c => c.Date_Borrow.Month == 2).Select(c => c.Total_Bill).Sum();
            ListTien.Thang3 = ListCtr.Where(c => c.Date_Borrow.Month == 3).Select(c => c.Total_Bill).Sum();
            ListTien.Thang4 = ListCtr.Where(c => c.Date_Borrow.Month == 4).Select(c => c.Total_Bill).Sum();
            ListTien.Thang5 = ListCtr.Where(c => c.Date_Borrow.Month == 5).Select(c => c.Total_Bill).Sum();
            ListTien.Thang6 = ListCtr.Where(c => c.Date_Borrow.Month == 6).Select(c => c.Total_Bill).Sum();
            ListTien.Thang7 = ListCtr.Where(c => c.Date_Borrow.Month == 7).Select(c => c.Total_Bill).Sum();
            ListTien.Thang8 = ListCtr.Where(c => c.Date_Borrow.Month == 8).Select(c => c.Total_Bill).Sum();
            ListTien.Thang9 = ListCtr.Where(c => c.Date_Borrow.Month == 9).Select(c => c.Total_Bill).Sum();
            ListTien.Thang10 = ListCtr.Where(c => c.Date_Borrow.Month == 10).Select(c => c.Total_Bill).Sum();
            ListTien.Thang11 = ListCtr.Where(c => c.Date_Borrow.Month == 11).Select(c => c.Total_Bill).Sum();
            ListTien.Thang12 = ListCtr.Where(c => c.Date_Borrow.Month == 12).Select(c => c.Total_Bill).Sum();
            return ListTien;
        }
        public bool  BLL_FindYear(DateTime Year)
        {
            DACNPM DB = new DACNPM();
            var ListCtr = DB.Contracts.Where(c => c.Date_Borrow.Year == Year.Year).Select(p => p).ToList();
            if (ListCtr.Count > 0)
                return true;
            return false;
        }
    }
}
