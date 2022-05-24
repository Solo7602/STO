using BuisnessLogic.BusinessLogic.OfficePackage.Enums;
using BuisnessLogic.BusinessLogic.OfficePackage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic.BusinessLogic.OfficePackage
{
    public abstract class ReportToPdf
    {
        public void CreateDoc(PdfInfo info)
        {
            CreatePdf(info);
            CreateParagraph(new PdfParagraph
            {
                Text = info.Title,
                Style = "NormalTitle"
            });
            CreateParagraph(new PdfParagraph
            {
                Text = $"с{ info.DateFrom.ToShortDateString() } по { info.DateTo.ToShortDateString() }",
                Style = "Normal"
            });
            CreateTable(new List<string> { "6cm", "6cm", "6cm"});
            CreateRow(new PdfRowParameters
            {
                Texts = new List<string> { "Дата визита", "Сумма", "Имя клиента",},
                Style = "NormalTitle",
                ParagraphAlignment = PdfParagraphAlignmentType.Center
            });
            foreach (var order in info.Repairs)
            {
                CreateRow(new PdfRowParameters
                {
                    Texts = new List<string> { order.DateCreate.ToShortDateString(),order.Sum.ToString(), order.ClientName
                },
                    Style = "Normal",
                    ParagraphAlignment = PdfParagraphAlignmentType.Left
                });
            }
            SavePdf(info);
        }
        //public void CreateDocService(PdfInfoService info)
        //{
        //    CreatePdf(info);
        //    CreateParagraph(new PdfParagraph
        //    {
        //        Text = info.Title,
        //        Style = "NormalTitle"
        //    });
        //    CreateParagraph(new PdfParagraph
        //    {
        //        Text = $"с{ info.DateFrom.ToShortDateString() } по { info.DateTo.ToShortDateString() }",
        //        Style = "Normal"
        //    });
        //    CreateTable(new List<string> { "8cm", "8cm" });
        //    CreateRow(new PdfRowParameters
        //    {
        //        Texts = new List<string> { "Услуга", "Количество" },
        //        Style = "NormalTitle",
        //        ParagraphAlignment = PdfParagraphAlignmentType.Center
        //    });
        //    foreach (var order in info.Services.Services)
        //    {
        //        CreateRow(new PdfRowParameters
        //        {
        //            Texts = new List<string> { order.Key,order.Value.ToString()
        //        },
        //            Style = "Normal",
        //            ParagraphAlignment = PdfParagraphAlignmentType.Left
        //        });
        //    }
        //    CreateParagraph(new PdfParagraph
        //    {
        //        Text = $"Оплачено за период: {info.Services.Sum}",
        //        Style = "Normal"
        //    });
        //    SavePdf(info);
        //}
        protected abstract void CreatePdf(PdfInfo info);
        protected abstract void CreatePdf(PdfInfoService info);
        protected abstract void CreateParagraph(PdfParagraph paragraph);
        protected abstract void CreateTable(List<string> columns);
        protected abstract void CreateRow(PdfRowParameters rowParameters);
        protected abstract void SavePdf(PdfInfo info);
        protected abstract void SavePdf(PdfInfoService info);
    }
}
