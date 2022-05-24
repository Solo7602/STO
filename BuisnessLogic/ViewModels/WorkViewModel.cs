using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BuisnessLogic.ViewModels
{
    public class WorkViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название работы")]
        public string WorkName { get; set; }
        [DisplayName("Стоимость работы")]
        public int WorkPrice { get; set; }
    }
}
