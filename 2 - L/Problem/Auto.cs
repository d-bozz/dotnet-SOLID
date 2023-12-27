using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2___L.Problem
{
    internal class Auto : Vehiculo
    {
        public virtual void Acelerar()
        {
            //Codigo para acelerar
        }

        public virtual void Estacionar()
        {
            //Codigo para estacionar
        }

        public virtual void Frenar()
        {
            //Codigo para frenar
        }


        public virtual void Despegar()
        {
            throw new NotImplementedException();
        }

        public virtual void Aterrizar()
        {
            throw new NotImplementedException();
        }
    }
}
