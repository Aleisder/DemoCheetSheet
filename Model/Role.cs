using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Model
{
    [Table("Role")]
    class Role
    {
        [Key]
        public int Id { get; set; }
        [Column("role")]
        public string? Name { get; set; }
    }
}
