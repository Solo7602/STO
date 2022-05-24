using BuisnessLogic.BindingModels;
using BuisnessLogic.ViewModels;
using System.Collections.Generic;

namespace BuisnessLogic.BuisnessLogicInterfaces
{
    public interface IPaymentLogic
    {
        List<PaymentViewModel> Read(PaymentBindingModel model);
        void CreateOrUpdate(PaymentBindingModel model);
        void Delete(PaymentBindingModel model);
        PaymentViewModel GetLastPay(PaymentBindingModel model);
    }
}
