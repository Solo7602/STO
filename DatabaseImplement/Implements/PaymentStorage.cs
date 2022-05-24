using BuisnessLogic.BindingModels;
using BuisnessLogic.StorageInterfaces;
using BuisnessLogic.ViewModels;
using DatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseImplement.Implements
{
    public class PaymentStorage: IPaymentStorage
    {
        public List<PaymentViewModel> GetFullList()
        {
            using var context = new StoDatabase();
            return context.Payments
            .Select(CreateModel)
            .ToList();
        }
        public List<PaymentViewModel> GetFilteredList(PaymentBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new StoDatabase();
            return context.Payments
            .Where(rec => rec.RepairId == model.RepairId)
            .Select(CreateModel)
            .ToList();
        }
        public PaymentViewModel GetElement(PaymentBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new StoDatabase();
            var payment = context.Payments
             .Include(x=>x.Repair)
             .OrderByDescending(x => x.Id)
            .LastOrDefault(rec => rec.RepairId == model.RepairId);
            return payment != null ? CreateModel(payment) : null;
        }
        public void Insert(PaymentBindingModel model)
        {
            using var context = new StoDatabase();
            context.Payments.Add(CreateModel(model, new Payment()));
            context.SaveChanges();
        }
        public void Update(PaymentBindingModel model)
        {
            using var context = new StoDatabase();
            var element = context.Payments.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, element);
            context.SaveChanges();
        }
        public void Delete(PaymentBindingModel model)
        {
            using var context = new StoDatabase();
            Payment element = context.Payments.FirstOrDefault(rec => rec.Id ==
           model.Id);
            if (element != null)
            {
                context.Payments.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        private static Payment CreateModel(PaymentBindingModel model, Payment
       payment)
        {
            payment.Sum = model.Sum;
            payment.RepairId = model.RepairId;
            payment.Remains = model.Remain;
            return payment;
        }
        private static PaymentViewModel CreateModel(Payment payment)
        {
            return new PaymentViewModel
            {
                Id = payment.Id,
                Remain = payment.Remains,
                //RepairName = payment.Repair.Name,
                RepairId = payment.RepairId,
                Sum = payment.Sum
            };
        }
    }
}
