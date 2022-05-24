using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseImplement.Models
{
    public class Work
    {
        public int Id { get; set; }
        [Required]
        public string WorkName { get; set; }
        [Required]
        public int WorkPrice { get; set; }
        public virtual List<Repair> Repairs { get; set; }
    }
}
