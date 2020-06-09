using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACNPM.Entities
{
    [Table("DETAIL_CONTRACT")]
    public class Detail_Contract
    {
        [Key]
        public int ID_Detail_Contract { get; set; }
        public int ID_Contract { get; set; }
        public int ID_Vehicle { get; set; }
        public int Total_Price { get; set; }
        public DateTime Date_Make_Contract { get; set; }
    }
}
