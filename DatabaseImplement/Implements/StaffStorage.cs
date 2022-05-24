using BuisnessLogic.BindingModels;
using BuisnessLogic.StorageInterfaces;
using BuisnessLogic.ViewModels;
using DatabaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseImplement.Implements
{
    public class StaffStorage : IStaffStorage
    {
        public List<StaffViewModel> GetFullList()
        {
            using var context = new StoDatabase();
            return context.Staffs
            .Select(CreateModel)
            .ToList();
        }
        public List<StaffViewModel> GetFilteredList(StaffBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new StoDatabase();
            return context.Staffs
            .Where(rec => rec.StaffName.Contains(model.StaffName))
            .Select(CreateModel)
            .ToList();
        }
        public StaffViewModel GetElement(StaffBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new StoDatabase();
            var staff = context.Staffs
            .FirstOrDefault(rec => rec.StaffName == model.StaffName || rec.Id
           == model.Id);
            return staff != null ? CreateModel(staff) : null;
        }
        public void Insert(StaffBindingModel model)
        {
            using var context = new StoDatabase();
            context.Staffs.Add(CreateModel(model, new Staff()));
            context.SaveChanges();
        }
        public void Update(StaffBindingModel model)
        {
            using var context = new StoDatabase();
            var element = context.Staffs.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, element);
            context.SaveChanges();
        }
        public void Delete(StaffBindingModel model)
        {
            using var context = new StoDatabase();
            Staff element = context.Staffs.FirstOrDefault(rec => rec.Id ==
           model.Id);
            if (element != null)
            {
                context.Staffs.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        private static Staff CreateModel(StaffBindingModel model, Staff
       staff)
        {
            staff.StaffName = model.StaffName;
            staff.StaffPrice = model.StaffPrice;
            return staff;
        }
        private static StaffViewModel CreateModel(Staff staff)
        {
            return new StaffViewModel
            {
                Id = staff.Id,
                StaffName = staff.StaffName,
                StaffPrice = staff.StaffPrice
            };
        }
    }
}
