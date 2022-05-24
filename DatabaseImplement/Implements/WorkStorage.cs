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
    public class WorkStorage : IWorkStorage
    {
        public List<WorkViewModel> GetFullList()
        {
            using var context = new StoDatabase();
            return context.Works
            .Select(CreateModel)
            .ToList();
        }
        public List<WorkViewModel> GetFilteredList(WorkBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new StoDatabase();
            return context.Works
            .Where(rec => rec.WorkName.Contains(model.WorkName))
            .Select(CreateModel)
            .ToList();
        }
        public WorkViewModel GetElement(WorkBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new StoDatabase();
            var work = context.Works
            .FirstOrDefault(rec =>rec.Id == model.Id);
            return work != null ? CreateModel(work) : null;
        }
        public void Insert(WorkBindingModel model)
        {
            using var context = new StoDatabase();
            context.Works.Add(CreateModel(model, new Work()));
            context.SaveChanges();
        }
        public void Update(WorkBindingModel model)
        {
            using var context = new StoDatabase();
            var element = context.Works.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, element);
            context.SaveChanges();
        }
        public void Delete(WorkBindingModel model)
        {
            using var context = new StoDatabase();
            Work element = context.Works.FirstOrDefault(rec => rec.Id ==
           model.Id);
            if (element != null)
            {
                context.Works.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        private static Work CreateModel(WorkBindingModel model, Work
       work)
        {
            work.WorkName = model.WorkName;
            work.WorkPrice = model.WorkPrice;
            return work;
        }
        private static WorkViewModel CreateModel(Work work)
        {
            return new WorkViewModel
            {
                Id = work.Id,
                WorkName = work.WorkName,
                WorkPrice = work.WorkPrice
            };
        }
    }
}
