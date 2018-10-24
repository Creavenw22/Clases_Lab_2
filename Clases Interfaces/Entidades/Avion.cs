using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avion : Vehiculo
    {
        protected double _velocidadMaxima;

        public Avion(double precio, double velocidad) : base(precio)
        {
            this._velocidadMaxima = velocidad;
        }
    }
}
