using BuisnessLogic.BindingModels;
using BuisnessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic.StorageInterfaces
{
    public interface IWorkStorage
    {
        List<WorkViewModel> GetFullList();
        List<WorkViewModel> GetFilteredList(WorkBindingModel model);
        WorkViewModel GetElement(WorkBindingModel model);
        void Insert(WorkBindingModel model);
        void Update(WorkBindingModel model);
        void Delete(WorkBindingModel model);
    }
}
