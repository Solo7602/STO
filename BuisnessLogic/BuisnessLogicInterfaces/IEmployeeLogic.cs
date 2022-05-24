using BuisnessLogic.BindingModels;
using BuisnessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BuisnessLogic.BuisnessLogicInterfaces
{
    public interface IEmployeeLogic
    {
        List<EmployeeViewModel> Read(EmployeeBindingModel model);
        EmployeeViewModel Check(EmployeeBindingModel model);
        void CreateOrUpdate(EmployeeBindingModel model);
        void Delete(EmployeeBindingModel model);
    }
}
