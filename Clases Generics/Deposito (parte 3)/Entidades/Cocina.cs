using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cocina
    {
        #region Atributos
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;
        #endregion

        #region Properties
        public int Codigo
        {
            get { return this._codigo; }
        }

        public bool EsIndustrial
        {
            get { return this._esIndustrial; }
        }

        public double Precio
        {
            get { return this._precio; }
        }
        #endregion

        #region Constructor
        public Cocina(int codigo, double precio, bool industrial)
        {
            this._codigo = codigo;
            this._precio = precio;
            this._esIndustrial = industrial;
        }
        #endregion

        #region Operadores
        public static bool operator ==(Cocina c1, Cocina c2)
        {
            bool flag = false;

            if (c1.Codigo == c2.Codigo)
            {
                flag = true;
            }

            return flag;
        }

        public static bool operator !=(Cocina c1, Cocina c2)
        {
            return !(c1 == c2);
        }
        #endregion

        #region Sobrecargas
        public override bool Equals(object obj)
        {
            bool flag=false;

            if (obj is Cocina)
            {
                if (this == (Cocina)obj)
                {
                    flag = true;
                }
            }

            return flag;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("\r\nCodigo: {0} \r\nPrecio: {1:#.00}\r\nEs industrial: {2}\r\n", this.Codigo,this.Precio,this.EsIndustrial);

            return sb.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}
