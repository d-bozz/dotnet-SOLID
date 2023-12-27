using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3___I.Problem
{
    internal class BurguerOrderService : IFoodOrderService
    {
        public void OrderBurger(int quantity)
        {
            // Codigo para ordenar una hamburguesa
        }

        public void OrderSalad(int quantity)
        {
            throw new NotImplementedException();
        }

        public void OrderSteak(int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
