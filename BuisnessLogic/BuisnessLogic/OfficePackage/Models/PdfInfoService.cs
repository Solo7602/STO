﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic.BusinessLogic.OfficePackage.Models
{
    public class PdfInfoService
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
       // public ReportServiceViewModel Services {get;set;}
    }
}
