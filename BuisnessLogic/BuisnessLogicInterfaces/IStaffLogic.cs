using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessLogic.ViewModels;
using BuisnessLogic.BindingModels;

namespace BuisnessLogic.BuisnessLogicInterfaces
{
    public interface IStaffLogic
    {
        List<StaffViewModel> Read(StaffBindingModel model);
        void CreateOrUpdate(StaffBindingModel model);
        void Delete(StaffBindingModel model);
    }
}
