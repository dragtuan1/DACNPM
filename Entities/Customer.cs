using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACNPM.Entities
{
    [Table("CUSTOMER")]
    public class Customer
    {
        [Key]
        public int ID_Customer { get; set; }
        public string Customer_Address { get; set; }
        public string CMND { get; set; }
        public string Customer_Name { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
        public Customer()
        {
            this.Contracts = new HashSet<Contract>();
        }
    }
}
