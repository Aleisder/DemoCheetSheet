using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Model
{
    [Table("Invoice")]
    internal class Invoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("start_date",TypeName = "date")]
        public DateOnly StartDate { get; set; }
        public string? Device {  get; set; }

        public Invoice(int id, DateOnly startDate, string device)
        {
            Id = id;
            StartDate = startDate;
            Device = device;
        }

        public Invoice(DateOnly startDate, string device)
        {
            Id = 0;
            StartDate = startDate;
            Device = device;
        }
    }
}
