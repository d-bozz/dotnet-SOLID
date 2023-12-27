using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SOLID._0___S.Problem.OrderService;

namespace SOLID._0___S.Solution
{
    interface INotificationService
    {
        bool EmailInvoice(Invoice invoice);
    }

    class NotificationService : INotificationService
    {
        public bool EmailInvoice(Invoice invoice)
        {
            //Code to email invoice
            return true;
        }
    }
}
