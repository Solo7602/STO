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
    public class StaffLogic : IStaffLogic
    {
        private readonly IStaffStorage _staffStorage;
        public StaffLogic(IStaffStorage staffStorage)
        {
            _staffStorage = staffStorage;
        }
        public List<StaffViewModel> Read(StaffBindingModel model)
        {
            if (model == null)
            {
                return _staffStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<StaffViewModel> { _staffStorage.GetElement(model)
};
            }
            return _staffStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(StaffBindingModel model)
        {
            var element = _staffStorage.GetElement(new StaffBindingModel
            {
                StaffName = model.StaffName,
                StaffPrice = model.StaffPrice
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть сотрудник с такими данными");
            }
            if (model.Id.HasValue)
            {
                _staffStorage.Update(model);
            }
            else
            {
                _staffStorage.Insert(model);
            }
        }
        public void Delete(StaffBindingModel model)
        {
            var element = _staffStorage.GetElement(new StaffBindingModel
            {
                Id =
           model.Id
            });
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            _staffStorage.Delete(model);
        }
    }
}
