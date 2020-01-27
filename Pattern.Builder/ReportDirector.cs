namespace Pattern.Builder
{
    public class ReportDirector
    {
        public Report MakeReport(IReportBuilder reportBuilder)
        {
            reportBuilder.SetReportHeader();
            reportBuilder.SetReportBody();
            reportBuilder.SetReportFooter();

            return reportBuilder.GetReport();
        }
    }
}