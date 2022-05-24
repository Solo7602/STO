using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic.BindingModels
{
    public class EmployeeBindingModel
    {
        public int? Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public string EmployeeMiddlename { get; set; }
        public string EmployeePhoneNumber { get; set; }
        public string EmployeePassword { get; set; }
        public decimal? EmployeePrize { get; set; }

    }
}
