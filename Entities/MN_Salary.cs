using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACNPM.Entities
{
    [Table("MN_SALARY")]
    public class MN_Salary
    {
        [Key]
        public int ID_Salary { get; set; }
        public int ID_Employee { get; set; }
        public int Total_Time { get; set; }
        public DateTime Month_Work { get; set; }
        public int Salary { get; set; }
        public int Total_Contract { get; set; }
    }
}
