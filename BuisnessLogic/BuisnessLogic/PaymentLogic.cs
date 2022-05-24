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
    public class PaymentLogic : IPaymentLogic
    {
        private IPaymentStorage paymentStorage;
        public PaymentLogic(IPaymentStorage paymentS)
        {
            paymentStorage = paymentS;
        }
        public void CreateOrUpdate(PaymentBindingModel model)
        {
            var element = paymentStorage.GetElement(new PaymentBindingModel
            {
                Sum = model.Sum,
                Remain = model.Remain
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть пользователь с такой почтой");
            }
            if (model.Id.HasValue)
            {
                paymentStorage.Update(model);
            }
            else
            {
                paymentStorage.Insert(model);
            }
        }

        public void Delete(PaymentBindingModel model)
        {
            var element = paymentStorage.GetElement(new PaymentBindingModel
            {
                Id =
        model.Id
            });
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            paymentStorage.Delete(model);
        }

        public List<PaymentViewModel> Read(PaymentBindingModel model)
        {
            if (model == null)
            {
                return paymentStorage.GetFullList();
            }
            if(model.RepairId > 0)
            {
                return paymentStorage.GetFilteredList(model);
            }
            if (model.Id.HasValue)
            {
                return new List<PaymentViewModel> { paymentStorage.GetElement(model) };
            }
            return paymentStorage.GetFilteredList(model);
        }
        public PaymentViewModel GetLastPay(PaymentBindingModel model)
        {
            return paymentStorage.GetElement(model);
        }
    }
}
