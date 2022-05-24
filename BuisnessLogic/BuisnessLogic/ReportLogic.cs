using BuisnessLogic.BindingModels;
using BuisnessLogic.BusinessLogic.OfficePackage;
using BuisnessLogic.BusinessLogic.OfficePackage.Models;
using BuisnessLogic.StorageInterfaces;
using BuisnessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic.BuisnessLogic
{
    public class ReportLogic
    {
        private readonly IWorkStorage _workStorage;
        private readonly IRepairStorage _RepairStorage;
        private readonly ReportToExcel _saveToExcel;
        private readonly ReportToPdf _saveToPdf;
        private readonly IPaymentStorage paymentStorage;
        public ReportLogic(IRepairStorage RepairStorage, IPaymentStorage paymentStorage,
        ReportToExcel saveToExcel, ReportToPdf saveToPdf)
        {
            this.paymentStorage = paymentStorage;
            _RepairStorage = RepairStorage;
            _saveToExcel = saveToExcel;
            _saveToPdf = saveToPdf;
        }
        public List<ReportRepairWorkViewModel> GetRepairWork(int UserId)
        {
            var Repairs = _RepairStorage.GetFilteredList(new RepairBindingModel()
            {
                ClientId = UserId
            });
            var list = new List<ReportRepairWorkViewModel>();
            foreach (var Repair in Repairs)
            {
                var record = new ReportRepairWorkViewModel
                {
                    Name = Repair.Name,
                    Works = new List<string>(),
                    TotalCount = 0
                };
                record.Works.Add(Repair.WorkName);
                record.TotalCount++;
                list.Add(record);
            }
            return list;
        }
        public void SaveRepairWorkToExcelFile(ReportBindingModel model)
        {
            _saveToExcel.CreateReportRepairWork(new ExcelInfoRepairWork
            {
                FileName = model.FileName,
                Title = "Список визитов",
                RepairWork = GetRepairWork(model.UserId)
            });
        }
        public List<ReportRepairViewModel> GetOrders(ReportBindingModel model)
        {
            return _RepairStorage.GetFilteredListDate(new RepairBindingModel
            {
                DateFrom =
           model.DateFrom,
                DateTo = model.DateTo
            })
            .Select(x => new ReportRepairViewModel
            {
                DateCreate = x.DateStart,
                Name = x.Name,
                Sum = x.Sum
            })
           .ToList();
        }
        public void SaveOrdersToPdfFileRepair(ReportBindingModel model)
        {
            _saveToPdf.CreateDoc(new PdfInfo
            {
                FileName = model.FileName,
                Title = "Список ремонтов",
                DateFrom = model.DateFrom,
                DateTo = model.DateTo,
                Repairs = GetOrders(model)
            });
        }
    }
}
