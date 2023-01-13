using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.domain
{
    [Table("type_room", Schema = "public")]
    public class TypeRoom
    {
        [Key]
        [Column("id", TypeName = "int")]
        public int id { get; set; }


        [Column("name", TypeName = "varchar")]
        [Required]

        public string name { get; set; }

        [Column("description", TypeName = "varchar")]
        [Required]

        public string description { get; set; }
    }
}
