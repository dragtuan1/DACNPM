using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DACNPM.Entities
{
    [Table("VEHICLE")]
    public class Vehicle
    {
        [Key]
        public int ID_Vehicle { get; set; }
        public string License_Plate { get; set; }
        public int Price { get; set; }
        public int ID_Type_Vehicle { get; set; }
        public int ID_Driver { get; set; }
        public bool Vehicle_State { get; set; }
        public virtual ICollection<Detail_Contract> Detail_Contracts { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        [ForeignKey("ID_Driver")]
        public virtual Driver Driver { get; set; }
        [ForeignKey("ID_Type_Vehicle")]
        public virtual Type_Vehicle Type_Vehicle { get; set; }

        public Vehicle()
        {
            this.Detail_Contracts = new HashSet<Detail_Contract>();
            this.Images = new HashSet<Image>();
        }

        public override string ToString()
        {
            return License_Plate;
        }

    }
}
