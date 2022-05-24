using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessLogic.ViewModels;
using BuisnessLogic.BindingModels;

namespace BuisnessLogic.BuisnessLogicInterfaces
{
     public interface IWorkLogic
    {
        List<WorkViewModel> Read(WorkBindingModel model);
        void CreateOrUpdate(WorkBindingModel model);
        void Delete(WorkBindingModel model);
    }
}
