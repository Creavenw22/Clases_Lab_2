using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeAutos
    {
        #region Atributos
        private int _capacidadMaxima;
        private List<Auto> _lista;
        #endregion

        #region Metodos
        private int GetIndice(Auto car)
        {
            int indice=-1;

            foreach (Auto item in this._lista)
            {
                if (item == car)
                {
                    indice = this._lista.IndexOf(item);
                }
            }

            return indice;
        }

        public bool Agregar(Auto car)
        {
            return (this + car);
        }

        public bool Remover(Auto car)
        {
            return (this - car);
        }

        #endregion

        #region constructor
        public DepositoDeAutos(int capacidad)
        {
            this._lista = new List<Auto>();
            this._capacidadMaxima = capacidad;
        }
        #endregion

        #region Operadores
        public static bool operator +(DepositoDeAutos dep, Auto car)
        {
            bool flag = false;
            bool outside = true;

            if (dep._lista.Count < dep._capacidadMaxima)
            {
                foreach (Auto item in dep._lista)
                {
                    if (item==car)
                    {
                        Console.WriteLine("El auto " + car.ToString() + "ya esta en el deposito.");
                        outside = false;
                        break;
                    }
                }

                if (outside)
                {
                    dep._lista.Add(car);
                    Console.WriteLine("Se ha agregado el auto!");
                    flag = true;
                }
            }

            else
            {
                Console.WriteLine("No hay mas lugar en el deposito.");
            }

            return flag;
        }

        public static bool operator -(DepositoDeAutos dep, Auto car)
        {
            bool flag = false;
            int indice;

            indice=dep.GetIndice(car);
            if (indice != -1)
            {
                dep._lista.RemoveAt(indice);
                flag = true;
                Console.WriteLine("El auto se ha removido");
            }

            else
            {
                Console.WriteLine("El auto no existe en el deposito");
            }

            return flag;
        }

        #endregion

        #region Sobrecargas
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Cantidad maxima: {0}\n", this._capacidadMaxima);
            sb.AppendLine("Autos en el deposito: ");
            foreach (Auto item in this._lista)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine();

            return sb.ToString();
        }
        #endregion
    }
}
