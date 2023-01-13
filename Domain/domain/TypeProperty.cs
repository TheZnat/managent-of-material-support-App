using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.domain
{
    [Table("type_property", Schema = "public")]
    public class TypeProperty
    {
        [Key]
        [Column("id", TypeName = "int")]
        public int id { get; set; }

        [Column("title", TypeName = "varchar")]
        [Required]

        public string title { get; set; }

    }
}
