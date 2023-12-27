using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4___D.Problem
{
    public class DatadogService
    {
        public void LogEvent(string message)
        {
            // Code to event on DataDog
        }

        public class Orderservice
        {
            public readonly DatadogService _datadogService;

            public Orderservice(DatadogService datadogService)
            {
                _datadogService = datadogService;
            }

            public void GenerateOrder(Order order)
            {
                // Codigo para crear la orden

                _datadogService.LogEvent("La orden fue creada correctamente");
            }
        }
        public class Order
        {
        }
    }
}
