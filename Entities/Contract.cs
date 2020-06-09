using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACNPM.Entities
{
    [Table("CONTRACT")]
    public class Contract
    {
        [Key]
        public int ID_Contract { get; set; }
        public int ID_Employee { get; set; } 
        public int ID_Customer { get; set; }
        public DateTime Date_Borrow { get; set; }
        public DateTime Date_Return { get; set; }
        public int Total_Bill { get; set; }
        public bool Contract_State { get; set; }

        [ForeignKey("ID_Employee")]
        public virtual Employee Employee { get; set; }
    }
}
