using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3___I.Problem
{
    internal class Program
    {
        public static void Main(string[] args) 
        {
            BurguerOrderService service = new BurguerOrderService();
            service.OrderBurger(2);
        }
    }
}
