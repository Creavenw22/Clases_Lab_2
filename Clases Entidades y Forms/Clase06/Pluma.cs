using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Pluma
    {
        #region Atributos
        private string _marca;
        private int _cantidad;
        private Tinta _tinta;
        #endregion

        #region Metodos
        public static string Mostrar(Pluma pluma)
        {
            return pluma.Mostrar();
        }

        private string Mostrar()
        {
            return this._marca + "----" + this._cantidad.ToString() + "----" + Tinta.Mostrar(this._tinta);
        }
        #endregion

        #region Constructor
        public Pluma()
        {
            this._marca = "Sin Marca";
            this._cantidad = 0;
            this._tinta = null;
        }

        public Pluma(string marca) : this()
        {
            this._marca = marca;
        }

        public Pluma(string marca, int cantidad) : this(marca)
        {
            this._cantidad = cantidad;
        }
        public Pluma(string marca, int cantidad, Tinta tinta) : this(marca, cantidad)
        {
            this._tinta = tinta;
        }
        #endregion

        #region SobrecargaOP
        public static bool operator == (Pluma pluma, Tinta tinta)
        {
            bool flag=false;

            if (pluma._tinta == tinta)
            {
                flag = true;
            }

            return flag;
        }

        public static bool operator !=(Pluma pluma, Tinta tinta)
        {
            return !(pluma == tinta);
        }

        public static Pluma operator + (Pluma pluma, Tinta tinta)
        {
            if ((pluma._tinta == tinta))
            {
                if ((pluma._cantidad >= 90))
                {
                    pluma._cantidad = 100;
                }
                else
                {
                    pluma._cantidad += 10;
                }
            }


            return pluma;
        }

        public static Pluma operator -(Pluma pluma, Tinta tinta)
        {
            if ((pluma._tinta == tinta))
            {
                if ((pluma._cantidad < 25) && (pluma._cantidad > 0))
                {
                    pluma._cantidad = 0;
                }
                else
                {
                    pluma._cantidad -= 25;
                }
            }

            return pluma;
        }

        public static implicit operator string(Pluma pluma)
        {
            return pluma.Mostrar();
        }

        #endregion
    }
}
