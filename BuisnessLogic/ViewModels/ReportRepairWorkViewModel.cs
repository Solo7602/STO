﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic.ViewModels
{
    public class ReportRepairWorkViewModel
    {
        public DateTime? Date { get; set; }
        public List<string> Works { get; set; }
        public int TotalCount { get; set; }
    }
}
