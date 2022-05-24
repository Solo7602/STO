using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BuisnessLogic.ViewModels
{
    public class EmployeeViewModel
    {
        public int? Id { get; set; }
        [DisplayName("Имя сотрудника")]
        public string EmployeeName { get; set; }
        [DisplayName("Фамилия сотрудника")]
        public string EmployeeSurname { get; set; }
        [DisplayName("Отчество Сотрудника")]
        public string EmployeeMiddlename { get; set; }
        [DisplayName("Телефон стордника")]
        public string EmployeePhoneNumber { get; set; }
        public string EmployeePassword { get; set; }   
        [DisplayName("Добавка к окладу")]
        public decimal EmployeePrize { get; set; }
    }
}
