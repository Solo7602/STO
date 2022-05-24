using BuisnessLogic.BindingModels;
using BuisnessLogic.BuisnessLogicInterfaces;
using BuisnessLogic.StorageInterfaces;
using BuisnessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic.BuisnessLogic
{
    public class EmployeeLogic : IEmployeeLogic
    {
        private readonly IEmployeeStorage _employeeStorage;
        public EmployeeLogic(IEmployeeStorage employeeStorage)
        {
            _employeeStorage = employeeStorage;
        }
        public List<EmployeeViewModel> Read(EmployeeBindingModel model)
        {
            if (model == null)
            {
                return _employeeStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<EmployeeViewModel> { _employeeStorage.GetElement(model)
};
            }
            return _employeeStorage.GetFilteredList(model);
        }

        public EmployeeViewModel Check(EmployeeBindingModel model)
        {
           return _employeeStorage.GetElement(model);
        }
        public void CreateOrUpdate(EmployeeBindingModel model)
        {
            var element = _employeeStorage.GetElement(new EmployeeBindingModel
            {
                EmployeeName = model.EmployeeName,
                EmployeeSurname = model.EmployeeSurname,
                EmployeeMiddlename = model.EmployeeMiddlename,
                EmployeePhoneNumber = model.EmployeePhoneNumber,
                EmployeePassword = model.EmployeePassword,
                EmployeePrize = model.EmployeePrize
            }) ;
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть сотрудник с такими данными");
            }
            if (model.Id.HasValue)
            {
                _employeeStorage.Update(model);
            }
            else
            {
                _employeeStorage.Insert(model);
            }
        }
        public void Delete(EmployeeBindingModel model)
        {
            var element = _employeeStorage.GetElement(new EmployeeBindingModel
            {
                Id =
           model.Id
            });
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            _employeeStorage.Delete(model);
        }
    }
}
