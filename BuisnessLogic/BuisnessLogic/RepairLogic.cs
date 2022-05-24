using BuisnessLogic.BindingModels;
using BuisnessLogic.BuisnessLogicInterfaces;
using BuisnessLogic.StorageInterfaces;
using BuisnessLogic.ViewModels;
using System;
using System.Collections.Generic;

namespace BuisnessLogic.BuisnessLogic
{
    public class RepairLogic : IRepairLogic
    {
        private IRepairStorage repairStorage;
        public RepairLogic(IRepairStorage repairS)
        {
            repairStorage = repairS;
        }
        public void CreateOrUpdate(RepairBindingModel model)
        {
            var element = repairStorage.GetElement(new RepairBindingModel
            {
                Name = model.Name,
                DateEnd = model.DateEnd,
                DateStart = model.DateStart,
                Status = model.Status,
                EmployeeId = model.EmployeeId,
                ClientId = model.ClientId
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть пользователь с такой почтой");
            }
            if (model.Id.HasValue)
            {
                repairStorage.Update(model);
            }
            else
            {
                repairStorage.Insert(model);
            }
        }

        public void Delete(RepairBindingModel model)
        {
            var element = repairStorage.GetElement(new RepairBindingModel
            {
                Id =
        model.Id
            });
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            repairStorage.Delete(model);
        }

        public List<RepairViewModel> Read(RepairBindingModel model)
        {
            if (model == null)
            {
                return repairStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<RepairViewModel> { repairStorage.GetElement(model)};
            }
            if (model.ClientId != null && model.ClientId > 0)
            {
                return repairStorage.GetFilteredList(model);
            }
            return repairStorage.GetFilteredList(model);
        }
    }
}
