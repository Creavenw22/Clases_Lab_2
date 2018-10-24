using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito<T>
    {
        #region Atributos
        private int _capacidadMaxima;
        private List<T> _lista;
        #endregion

        #region Metodos
        private int GetIndice(T a)
        {
            int indice = -1;

            foreach (T item in this._lista)
            {
                if (item.Equals(a))
                {
                    indice = this._lista.IndexOf(item);
                }
            }

            return indice;
        }

        public bool Agregar(T a)
        {
            return (this + a);
        }

        public bool Remover(T a)
        {
            return (this - a);
        }
        #endregion

        #region Constructor
        public Deposito(int cantidadMaxima)
        {
            this._capacidadMaxima = cantidadMaxima;
            this._lista = new List<T>();
        } 
        #endregion

        #region Operadores
        public static bool operator +(Deposito<T> dep, T obj)
        {
            bool flag = false;
            bool outside = true;

            if (dep._lista.Count < dep._capacidadMaxima)
            {
                foreach (T item in dep._lista)
                {
                    if (item.Equals(obj))
                    {
                        Console.WriteLine("El objeto " + obj.ToString() + "ya esta en el deposito.");
                        outside = false;
                        break;
                    }
                }

                if (outside)
                {
                    dep._lista.Add(obj);
                    Console.WriteLine("Se ha agregado el objeto!");
                    flag = true;
                }
            }

            else
            {
                Console.WriteLine("No hay mas lugar en el deposito.");
            }

            return flag;
        }

        public static bool operator -(Deposito<T> dep, T obj)
        {
            bool flag = false;
            int indice;

            indice = dep.GetIndice(obj);
            if (indice != -1)
            {
                dep._lista.RemoveAt(indice);
                flag = true;
                Console.WriteLine("El objeto se ha removido");
            }

            else
            {
                Console.WriteLine("El objeto no existe en el deposito");
            }

            return flag;
        }
        #endregion

        #region Sobrecargas
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Capacidad maxima: {0}\r\n", this._capacidadMaxima);
            sb.AppendLine("Objetos en el deposito: ");
            foreach (T item in this._lista)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine();

            return sb.ToString();
        }
        #endregion
    }
}
