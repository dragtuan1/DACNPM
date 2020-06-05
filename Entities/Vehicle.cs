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
        public int Vehicle_State { get; set; }
    }
}
