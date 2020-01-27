using System;

namespace Pattern.Builder
{
    // Creating the Product
    public class Report
    {
        public string ReportHeader { get; set; }
        public string ReportBody { get; set; }
        public string ReportFooter { get; set; }
        
        public void DisplayReport ()
        {
            Console.WriteLine($"{ReportHeader}");
            Console.WriteLine($"{ReportBody}");
            Console.WriteLine($"{ReportFooter}");
        }
    }
}