using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseImplement.Models
{
    public class Payment
    {
        public int Id { get; set; }
        [Required]
        public decimal Sum { get; set; }
        public decimal Remains { get; set; }
        [ForeignKey("RepairId")]
        public int RepairId { get; set; }
        public Repair Repair { get; set; }
        public DateTime Date { get; set; }
    }
}
