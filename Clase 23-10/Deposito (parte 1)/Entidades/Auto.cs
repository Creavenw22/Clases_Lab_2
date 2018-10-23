using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto
    {
        #region Atributos
        private string _color;
        private string _marca;
        #endregion

        #region Properties
        public string Color
        {
            get { return this._color; }
        }

        public string Marca
        {
            get { return this._marca; }
        }
        #endregion

        #region Constructor
        public Auto(string color, string marca)
        {
            this._marca = marca;
            this._color = color;
        }
        #endregion

        #region Operadores
        public static bool operator ==(Auto a1, Auto a2)
        {
            bool flag = false;

            if (a1.Marca == a2.Marca && a1.Color == a2.Color)
            {
                flag = true;
            }

            return flag;
        }

        public static bool operator !=(Auto a1, Auto a2)
        {
            return !(a1 == a2);
        }
        #endregion

        #region Sobrecargas
        public override bool Equals(object obj)
        {
            return (this==(Auto)obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Marca: {0} \nColor: {1}\n",this.Marca,this.Color);

            return sb.ToString();
        }
        #endregion
        
    }
}
