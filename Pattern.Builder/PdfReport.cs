namespace Pattern.Builder
{
    public class PdfReport : IReportBuilder
    {
        ContentReport _content;
        Report _report;

        public PdfReport(ContentReport content)
        {
            _content = content;
            _report = new Report();
        }
        public void SetReportHeader()
        {
            _report.ReportHeader = $"Header - PDF - {_content.Header}";
        }
        public void SetReportBody()
        {
            _report.ReportBody = $"Body - PDF - {_content.Body}";
        }
        public void SetReportFooter()
        {
            _report.ReportFooter = $"Footer - PDF - {_content.Footer}";
        }
        public Report GetReport()
        {
            var report = _report;
            Clear();
            return report;
        }

        private void Clear() => new Report();
    }
}