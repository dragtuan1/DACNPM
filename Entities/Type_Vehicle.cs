using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACNPM.Entities
{
    [Table("TYPE_VEHICLE")]
    public class Type_Vehicle
    {
        [Key]
        public int ID_Type_Vehicle { get; set; }
        public string Name_Type { get; set; }
        public int Amount_Seat { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
        public Type_Vehicle()
        {
            this.Vehicles = new HashSet<Vehicle>();
        }
    }
}
