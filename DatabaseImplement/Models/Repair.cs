using BuisnessLogic.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseImplement.Models
{
    public class Repair
    {
        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        [Required]
        public int Sum { get; set; }
        public int WorkId { get; set; }
        public int? ClientId { get; set; }
        public int? EmployeeId { get; set; }
        public RepairStatus Status {get; set;}
        [ForeignKey("EmployeeId")]
        public Employee? Employee { get; set; }
        [ForeignKey("WorkId")]
        public Work Work { get; set; }
        public Client Client{ get; set; }
        public List<Payment> Payments { get; set; }
    }
}
