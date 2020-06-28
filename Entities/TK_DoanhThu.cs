using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACNPM.Entities
{
    class TK_DoanhThu
    {
       public int Thang1 { get; set; }
       public int Thang2 { get; set; }
        public int Thang3 { get; set; }
        public int Thang4 { get; set; }
        public int Thang5 { get; set; }
        public int Thang6 { get; set; }
        public int Thang7 { get; set; }
        public int Thang8 { get; set; }
        public int Thang9 { get; set; }
        public int Thang10 { get; set; }
        public int Thang11 { get; set; }
        public int Thang12 { get; set; }


        public int TinhTong()
        {
            return this.Thang1 + this.Thang2 + Thang3 + Thang4 + Thang5 + Thang6 + Thang7 + Thang8 + Thang9 + Thang10 + Thang11 + Thang12;
        }

    }
}
