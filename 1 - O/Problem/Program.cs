using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SOLID._1___O.Problem.ReportingService;

namespace SOLID._1___O.Problem
{
    internal class Program
    {
        public static void Main()
        {
            List<Order> orders = new List<Order>(); // Obtener ordenes del data source
            ReportingService service = new ReportingService();
            service.GenerateReport(orders, ReportType.PDF);
        }
    }
}
