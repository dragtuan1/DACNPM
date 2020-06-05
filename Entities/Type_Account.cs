using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACNPM.Entities
{
    [Table("TYPE_ACCOUNT")]
    public class Type_Account
    {
        [Key]
        public int ID_Type_Account { get; set; }
        public string Name_Type { get; set; }
        public DateTime Day_Update { get; set; }
        public int Salary { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        public Type_Account()
        {
            this.Accounts = new HashSet<Account>();
        }
    }
}
