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
                    Date = Repair.DateStart,
                    Works = new List<string>(),
                    TotalCount = 0
                };
                //foreach (var work in Repair.RepairWorks)
                //{
                //    record.Works.Add(work.Value);
                //    record.TotalCount += 1;
                //}
                list.Add(record);
            }
            return list;
        }
        //public List<ReportWorkRepairViewModel> GetWorkRepair(int UserId)
        //{
        //    var works = _workStorage.GetFullList();
        //    var list = new List<ReportWorkRepairViewModel>();
        //    foreach (var work in works)
        //    {
        //        var record = new ReportWorkRepairViewModel
        //        {
        //            Name = work.Name,
        //            Repairs = new List<DateTime>(),
        //            TotalCount = 0
        //        };
        //        foreach (var repair in work.RepairWorks)
        //        {
        //            record.Repairs.Add(repair.Value);
        //            record.TotalCount += 1;
        //        }
        //        list.Add(record);
        //    }
        //    return list;
        //}
        public void SaveRepairWorkToExcelFile(ReportBindingModel model)
        {
            _saveToExcel.CreateReportRepairWork(new ExcelInfoRepairWork
            {
                FileName = model.FileName,
                Title = "Список визитов",
                RepairWork = GetRepairWork(model.UserId)
            });
        }
        //public void SaveWorkRepairToExcelFile(ReportBindingModel model)
        //{
        //    _saveToExcel.CreateReportWorkRepair(new ExcelInfoWorkRepair
        //    {
        //        FileName = model.FileName,
        //        Title = "Список услуг",
        //        RepairWorks = GetWorkRepair(model.UserId)
        //    });
        //}




        //public void SaveRepairWorkToWordFile(ReportBindingModel model)
        //{
        //    _saveToWord.CreateDocRepairWork(new WordInfoRepairWork
        //    {
        //        FileName = model.FileName,
        //        Title = "Визиты по услугам",
        //        RepairWorks = GetRepairWork(model.UserId)
        //    });
        //}
        //public void SaveWorkRepairToWordFile(ReportBindingModel model)
        //{
        //    _saveToWord.CreateDocWorkRepair(new WordInfoWorkRepair
        //    {
        //        FileName = model.FileName,
        //        Title = "Услуги по визитам",
        //        RepairWorks = GetWorkRepair(model.UserId)
        //    });
        //}
        //public List<ReportRepairViewModel> GetOrders(ReportBindingModel model)
        //{
        //    return _RepairStorage.GetFilteredListDate(new RepairBindingModel
        //    {
        //        DateFrom =
        //   model.DateFrom,
        //        DateTo = model.DateTo
        //    })
        //    .Select(x => new ReportRepairViewModel
        //    {
        //        DateCreate = x.RepairsDate,
        //        ClientName = x.ClientName,
        //        Sum = x.Sum
        //    })
        //   .ToList();
        //}
        //public ReportWorkViewModel GetWorks(ReportBindingModel model)
        //{
        //    var list = _RepairStorage.GetFilteredListDate(new RepairBindingModel
        //    {
        //        DateFrom =
        //   model.DateFrom,
        //        DateTo = model.DateTo
        //    });
        //    Dictionary<string, int> dic = new Dictionary<string, int>();
        //    foreach (var item in list)
        //    {
        //        foreach (var item2 in item.RepairWorks)
        //        {
        //            if (dic.ContainsKey(item2.Value))
        //            {
        //                dic[item2.Value]++;
        //            }
        //            else
        //            {
        //                dic[item2.Value] = 1;
        //            }
        //        }

        //    }
        //    return new ReportWorkViewModel()
        //    {
        //        Sum = paymentStorage.GetElementFirstLast(new PaymentDateBindingModel()).Remains,
        //        Works = dic
        //    };
        //}
        //public void SaveOrdersToPdfFileRepair(ReportBindingModel model)
        //{
        //    _saveToPdf.CreateDoc(new PdfInfo
        //    {
        //        FileName = model.FileName,
        //        Title = "Список визитов",
        //        DateFrom = model.DateFrom.Value,
        //        DateTo = model.DateTo.Value,
        //        Repairs = GetOrders(model)
        //    });
        //}
        //public void SaveOrdersToPdfFileWork(ReportBindingModel model)
        //{
        //    _saveToPdf.CreateDocWork(new PdfInfoWork
        //    {
        //        FileName = model.FileName,
        //        Title = "Список визитов",
        //        DateFrom = model.DateFrom.Value,
        //        DateTo = model.DateTo.Value,
        //        Works = GetWorks(model)
        //    });
        //}
    }
}
