namespace Pattern.Builder
{
    public class ExcelReport : IReportBuilder
    {
        private ContentReport _content;
        private Report _report;

        public ExcelReport(ContentReport content)
        {
            _content = content;
            _report = new Report();
        }
        public void SetReportHeader()
        {
            _report.ReportHeader = $"Header - Excel - {_content.Header}";
        }
        public void SetReportBody()
        {
            _report.ReportBody = $"Body - Excel - {_content.Body} ";
        }
        public void SetReportFooter()
        {
            _report.ReportFooter = "";
        }
        public Report GetReport()
        {
            var report = _report;
            Clear();
            return report;            
        }
        private void Clear() => _report = new Report();
    }
}