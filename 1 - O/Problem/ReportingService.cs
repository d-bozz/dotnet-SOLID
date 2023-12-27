using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___O.Problem
{
    internal class ReportingService
    {
        public void GenerateReport(List<Order> orders, ReportType type)
        {
            // Codigo generico para crear un reporte

            if (type == ReportType.PDF)
            {
                CreatePDFReport(orders);
            }
            else if (type == ReportType.EXCEL)
            {
                CreateExcelReport(orders);
            }
            else if (type == ReportType.JSON)
            {
                CreateJSONReport(orders);
            }
            else if (type == ReportType.XML)
            {
                CreateXMLReport(orders);
            }
        }

        public void CreatePDFReport(List<Order> orders)
        {
            // create PDF reports
        }

        public void CreateExcelReport(List<Order> orders)
        {
            // create Excel reports
        }

        public void CreateJSONReport(List<Order> orders)
        {
            // create PDF reports
        }

        public void CreateXMLReport(List<Order> orders)
        {
            // create Excel reports
        }

        public enum ReportType
        {
            PDF,
            EXCEL,
            JSON,
            XML
        }
        public class Order
        {
        }
    }
}
