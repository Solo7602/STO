using BuisnessLogic.BindingModels;
using BuisnessLogic.ViewModels;
using System.Collections.Generic;

namespace BuisnessLogic.BuisnessLogicInterfaces
{
    public interface IRepairLogic
    {
        List<RepairViewModel> Read(RepairBindingModel model);
        void CreateOrUpdate(RepairBindingModel model);
        void Delete(RepairBindingModel model);
    }
}
