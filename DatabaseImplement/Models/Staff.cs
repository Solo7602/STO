using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseImplement.Models
{
    public class Staff
    {
        public int Id { get; set; }
        [Required]
        public string StaffName { get; set; }
        [Required]
        public int StaffPrice { get; set; }
        public virtual Staff Employees { get; set; }
    }
}
