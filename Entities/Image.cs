using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACNPM.Entities
{
    public class Image
    {
        [Key]
        public int ID_Image { get; set; }
        public int ID_Vehicle { get; set; }
        public byte[] Image_Vehicle { get; set; }
        [ForeignKey("ID_Vehicle")]
        public virtual Vehicle Vehicle { get; set; }
    }
}
