using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DACNPM.Entities
{
    [Table("EMPLOYEE")]
    public class Employee
    {
        [Key]
        public int ID_Employee { get; set; }
        public string Name_Employee { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int ID_Account { get; set; }
        [ForeignKey("ID_Account")]
        public virtual Account Account { get; set; }
        public virtual ICollection<MN_Salary> MN_Salaries { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
        public Employee()
        {
            this.MN_Salaries = new HashSet<MN_Salary>();
            this.Contracts = new HashSet<Contract>();
        }
    }
}
