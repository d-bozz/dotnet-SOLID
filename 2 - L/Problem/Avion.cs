using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2___L.Problem
{
    internal class Avion : Vehiculo
    {
        public virtual void Despegar()
        {
            //Codigo para despegar
        }

        public virtual void Aterrizar()
        {
            //Codigo para aterrizar
        }

        public virtual void Frenar()
        {
            throw new NotImplementedException();
        }


        public virtual void Acelerar()
        {
            throw new NotImplementedException();
        }

        public virtual void Estacionar()
        {
            throw new NotImplementedException();
        }
    }
}
