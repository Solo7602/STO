using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseImplement.Models
{
    public class Client
    {
        public int? Id { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Middlename { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        [ForeignKey("ClientId")]
        public List<Repair> Repairs { get; set; }
    }
}
