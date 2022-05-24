using BuisnessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic.BusinessLogic.OfficePackage.Models
{
    public class ExcelInfoRepairWork
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public List<ReportRepairWorkViewModel> RepairWork{ get; set; }
    }
}
