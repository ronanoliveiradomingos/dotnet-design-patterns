using System;

namespace Pattern.Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            var content = new ContentReport
            { 
                Header = "Lorem Ipsum", 
                Body = "O Lorem Ipsum é um texto modelo da indústria tipográfica.", 
                Footer = "Tradução de 1914 por H. Rackham" 
            };

            var contentExcel = new ContentReport
            { 
                Header = "De onde é que ele vem?", 
                Body = "Ao contrário da crença popular, o Lorem Ipsum não é simplesmente texto aleatório."
            };

            // Client code
            Report report;
            ReportDirector reportDirector = new ReportDirector();

            PdfReport pdfReport = new PdfReport(content);
            report = reportDirector.MakeReport(pdfReport);
            report.DisplayReport();

            Console.WriteLine("-------------------");

            ExcelReport excelReport = new ExcelReport(contentExcel);
            report = reportDirector.MakeReport(excelReport);
            report.DisplayReport();

            Console.ReadKey();

        }
    }
}
