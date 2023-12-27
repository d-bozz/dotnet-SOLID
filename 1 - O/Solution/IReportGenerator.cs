using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___O.Solution
{
    internal interface IReportGenerator
    {
        void CreateReport(List<Order> orders);
    }
}
