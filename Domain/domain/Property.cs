using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.domain
{
    [Table("property", Schema = "public")]
    public class Property
    {
        [Key]
        [Column("id", TypeName = "int")]
        public int id { get; set; }

        [Column("type_property_id", TypeName = "int")]
        [Required] 
        public int type_property_id { get; set; }

        [Column("technical_specifi", TypeName = "varchar")]
        [Required]
        public string technical_specifi { get; set; }

        [Column("description", TypeName = "varchar")]
        [Required]
        public string description { get; set; }

        [Column("room_id", TypeName = "int")]
        [Required]
        public int room_id { get; set; }






    }
}
