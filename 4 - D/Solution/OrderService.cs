using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4___D.Solution
{
    public class OrderService
    {
        public readonly IEventNotificationService _eventNotificationService;

        public OrderService(IEventNotificationService eventNotificationService)
        {
            _eventNotificationService = eventNotificationService;
        }

        public void GenerateOrder(Order order)
        {
            // Codigo para crear la orden
            _eventNotificationService.LogEvent("El evento fue creado correctamente");
        }
    }

    public class Order
    { }
}
