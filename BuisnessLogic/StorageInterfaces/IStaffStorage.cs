using BuisnessLogic.BindingModels;
using BuisnessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic.StorageInterfaces
{
    public interface IStaffStorage
    {
        List<StaffViewModel> GetFullList();
        List<StaffViewModel> GetFilteredList(StaffBindingModel model);
        StaffViewModel GetElement(StaffBindingModel model);
        void Insert(StaffBindingModel model);
        void Update(StaffBindingModel model);
        void Delete(StaffBindingModel model);
    }
}
