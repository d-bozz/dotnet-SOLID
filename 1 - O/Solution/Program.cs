using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___O.Solution
{
    internal class Program
    {
        public static void Main(string[] args) 
        {
            List<Order> orders = new List<Order>(); // Get orders from data source

            ReportingService service = new ReportingService(new ReportGeneratorPDF()); // Send implementation
            service.GenerateReport(orders);
        }
    }
}
