using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.domain
{
    [Table("room", Schema = "public")]
    public class Room
    {
        [Key]
        [Column("id", TypeName ="int")]

        public int id { get; set; }

        [Column("type_room_id", TypeName = "int")]
        [Required]
        public int type_room_id { get; set; }
    }
}
