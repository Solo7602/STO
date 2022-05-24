using System;

namespace BuisnessLogic.BindingModels
{
    public class PaymentBindingModel
    {
        public int? Id { get; set; }
        public decimal Sum { get; set; }
        public decimal Remain { get; set; }
        public int RepairId { get; set; }
        public DateTime Date { get; set; }
    }
}
