﻿using BuisnessLogic.Enums;
using System;

namespace BuisnessLogic.ViewModels
{
    public class RepairViewModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public decimal Sum { get; set; }
        public int? ClientId { get; set; }
        public int? EmployeeId { get; set; }
        public int? WorkId { get; set; }
        public string WorkName { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime DateFrom { get; set; }
        public RepairStatus Status { get; set; }
    }
}
