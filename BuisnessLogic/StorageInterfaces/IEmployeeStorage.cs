using BuisnessLogic.BindingModels;
using BuisnessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic.StorageInterfaces
{
    public interface IEmployeeStorage
    {
        List<EmployeeViewModel> GetFullList();
        List<EmployeeViewModel> GetFilteredList(EmployeeBindingModel model);
        EmployeeViewModel GetElement(EmployeeBindingModel model);
        void Insert(EmployeeBindingModel model);
        void Update(EmployeeBindingModel model);
        void Delete(EmployeeBindingModel model);
    }
}
