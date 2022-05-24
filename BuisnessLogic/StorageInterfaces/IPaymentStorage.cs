using BuisnessLogic.BindingModels;
using BuisnessLogic.ViewModels;
using System.Collections.Generic;

namespace BuisnessLogic.StorageInterfaces
{
    public interface IPaymentStorage
    {
        List<PaymentViewModel> GetFullList();
        List<PaymentViewModel> GetFilteredList(PaymentBindingModel model);
        PaymentViewModel GetElement(PaymentBindingModel model);
        void Insert(PaymentBindingModel model);
        void Update(PaymentBindingModel model);
        void Delete(PaymentBindingModel model);
    }
}
