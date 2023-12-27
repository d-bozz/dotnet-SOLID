using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SOLID._0___S.Problem.OrderService;

namespace SOLID._0___S.Solution
{
    interface ILoggerService
    {
        void Info(string info);
        void Debug (string info);
        void Error(string message, Exception exception);
    }

    public class LoggerService : ILoggerService
    {
        public LoggerService() 
        {
            // Here we need to write the code for initialization
            // That is creating the log file with necessary details
        }

        public void Info(string info)
        { 
            // here we need to write the code for info information into the ErrorLog text file
        }

        public void Debug(string info)
        {
            // here we need to write the code for debug information into the ErrorLog text file
        }

        void ILoggerService.Error(string message, Exception exception)
        {
            //here we need to write the code for error information into the errorlog text file
        }
    }
}
