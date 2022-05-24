using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BuisnessLogic.ViewModels
{
    public class StaffViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название должности")]
        public string StaffName { get; set; }
        [DisplayName("Оклад")]
        public int StaffPrice { get; set; }
    }
}
