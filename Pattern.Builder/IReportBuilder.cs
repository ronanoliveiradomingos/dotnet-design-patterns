namespace Pattern.Builder
{
    // Creating the Abstract/Interface Builder 
    public interface IReportBuilder
    {
        void SetReportHeader();
        void SetReportBody();
        void SetReportFooter();
        Report GetReport();
    }
}