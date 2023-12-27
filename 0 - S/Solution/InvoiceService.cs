using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static SOLID._0___S.Problem.OrderService;

namespace SOLID._0___S.Solution
{
    interface IInvoiceService
    {
        Invoice CreateInvoice(Order order);    
    }

    class InvoiceService : IInvoiceService
    { 
        public Invoice CreateInvoice(Order order)
        {
            //Code to create Invoice
            return new Invoice();
        }
    }
}
