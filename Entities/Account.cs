using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACNPM.Entities
{
    [Table("ACCOUNT")]
    public class Account
    {
        [Key]
        public int ID_Account { get; set; }
        public string Username { get; set; }
        public string UserPassword { get; set; }
        public int ID_Type_Account { get; set; }

        [ForeignKey("ID_Type_Account")]
        public virtual Type_Account Type_Account { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public Account()
        {
            this.Employees = new HashSet<Employee>();
        }
    }
}
