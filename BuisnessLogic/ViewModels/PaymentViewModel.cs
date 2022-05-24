using System;

namespace BuisnessLogic.ViewModels
{
    public class PaymentViewModel
    {
        public int Id { get; set; }
        public decimal Remain { get; set; }
        public int RepairId { get; set; }
        public decimal Sum { get; set; }
        public string RepairName { get; set; }
        public DateTime Date { get; set; }
    }
}
