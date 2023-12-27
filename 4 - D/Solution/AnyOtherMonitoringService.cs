using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4___D.Solution
{
    internal class AnyOtherMonitoringService : IEventNotificationService
    {
        public void LogEvent(string message)
        {
            // Codigo para loguear el evento de monitoreo de este service app
        }
    }
}
