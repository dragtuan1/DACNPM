using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACNPM.Entities
{
    [Table("DRIVER")]
    public class Driver
    {
        [Key]
        public int ID_Driver { get; set; }
        public string Driver_Address { get; set; }
        public string CMND { get; set; }
        public string Name_Driver { get; set; }
        public string Phone { get; set; }
        public string License { get; set; }
        public bool Driver_State { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
        public Driver()
        {
            this.Vehicles = new HashSet<Vehicle>();
        }
        public override string ToString()
        {
            return CMND;
        }
    }
}
