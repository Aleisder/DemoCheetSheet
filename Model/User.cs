using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Model
{
    [Table("User")]
    class User
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        [Column("role_id")]
        public int RoleId { get; set; }
        [ForeignKey("RoleId")]
        public Role Role { get; set; }

        public User(int id, string name, Role role)
        {
            Id = id;
            Name = name;
            Role = role;
        }

        public User()
        {

        }
    }
}
