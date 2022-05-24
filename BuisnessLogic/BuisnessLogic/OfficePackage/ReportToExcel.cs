using BuisnessLogic.BusinessLogic.OfficePackage.Enums;
using BuisnessLogic.BusinessLogic.OfficePackage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic.BusinessLogic.OfficePackage
{
    public abstract class ReportToExcel
    {
        /// <summary>
        /// Создание отчета
        /// </summary>
        /// <param name="info"></param>
        public void CreateReportRepairWork(ExcelInfoRepairWork info)
        {
            CreateExcel(info);
            InsertCellInWorksheet(new ExcelCellParameters
            {
                ColumnName = "A",
                RowIndex = 1,
                Text = info.Title,
                StyleInfo = ExcelStyleInfoType.Title
            });
            MergeCells(new ExcelMergeParameters
            {
                CellFromName = "A1",
                CellToName = "C1"
            });
            uint rowIndex = 2;
            foreach (var pc in info.RepairWork)
            {
                InsertCellInWorksheet(new ExcelCellParameters
                {
                    ColumnName = "A",
                    RowIndex = rowIndex,
                    Text = pc.Date.ToString(),
                    StyleInfo = ExcelStyleInfoType.Text
                });
                rowIndex++;
                foreach (var Component in pc.Works)
                {
                    InsertCellInWorksheet(new ExcelCellParameters
                    {
                        ColumnName = "B",
                        RowIndex = rowIndex,
                        Text = Component,
                        StyleInfo = ExcelStyleInfoType.TextWithBroder
                    });
                    rowIndex++;
                }
                InsertCellInWorksheet(new ExcelCellParameters
                {
                    ColumnName = "C",
                    RowIndex = rowIndex,
                    Text = pc.TotalCount.ToString(),
                    StyleInfo = ExcelStyleInfoType.Text
                });
                rowIndex++;
            }
            SaveExcel(info);
        }
        //public void CreateReportServiceVisit(ExcelInfoServiceVisit info)
        //{
        //    CreateExcel(info);
        //    InsertCellInWorksheet(new ExcelCellParameters
        //    {
        //        ColumnName = "A",
        //        RowIndex = 1,
        //        Text = info.Title,
        //        StyleInfo = ExcelStyleInfoType.Title
        //    });
        //    MergeCells(new ExcelMergeParameters
        //    {
        //        CellFromName = "A1",
        //        CellToName = "C1"
        //    });
        //    uint rowIndex = 2;
        //    foreach (var pc in info.VisitServices)
        //    {
        //        InsertCellInWorksheet(new ExcelCellParameters
        //        {
        //            ColumnName = "A",
        //            RowIndex = rowIndex,
        //            Text = pc.Name.ToString(),
        //            StyleInfo = ExcelStyleInfoType.Text
        //        });
        //        rowIndex++;
        //        foreach (var Component in pc.Visits)
        //        {
        //            InsertCellInWorksheet(new ExcelCellParameters
        //            {
        //                ColumnName = "B",
        //                RowIndex = rowIndex,
        //                Text = Component.ToString(),
        //                StyleInfo = ExcelStyleInfoType.TextWithBroder
        //            });
        //            rowIndex++;
        //        }
        //        InsertCellInWorksheet(new ExcelCellParameters
        //        {
        //            ColumnName = "C",
        //            RowIndex = rowIndex,
        //            Text = pc.TotalCount.ToString(),
        //            StyleInfo = ExcelStyleInfoType.Text
        //        });
        //        rowIndex++;
        //    }
        //    SaveExcel(info);
        //}
        /// <summary>
        /// Создание excel-файла
        /// </summary>
        /// <param name="info"></param>
        protected abstract void CreateExcel(ExcelInfoRepairWork info);
        /// <summary>
        /// Добавляем новую ячейку в лист
        /// </summary>
        /// <param name="cellParameters"></param>
        protected abstract void InsertCellInWorksheet(ExcelCellParameters
        excelParams);
        /// <summary>
        /// Объединение ячеек
        /// </summary>
        /// <param name="mergeParameters"></param>
        protected abstract void MergeCells(ExcelMergeParameters excelParams);
        /// <summary>
        /// Сохранение файла
        /// </summary>
        /// <param name="info"></param>
        protected abstract void SaveExcel(ExcelInfoRepairWork info);
        protected abstract void SaveExcel(ExcelInfoServiceVisit info);
        protected abstract void CreateExcel(ExcelInfoServiceVisit info);
    }
}
