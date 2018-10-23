using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public class DepositoDeCocinas
    {
        #region Atributos
        private int _cantidadMaxima;
        private List<Cocina> _lista;
        #endregion

        #region Metodos
        private int GetIndice(Cocina oven)
        {
            int indice = -1;

            foreach (Cocina item in this._lista)
            {
                if (item == oven)
                {
                    indice = this._lista.IndexOf(item);
                }
            }

            return indice;
        }

        public bool Agregar(Cocina oven)
        {
            return (this + oven);
        }

        public bool Remover(Cocina oven)
        {
            return (this - oven);
        }

        public bool Guardar(string path)
        {
            bool flag = false;

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(this.ToString());
                flag = true;
            }
            
            return flag;
        }

        public bool Recuperar(string path)
        {
            bool flag = false;

            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
                flag = true;
            }

            return flag;
        }
        #endregion

        #region Constructor
        public DepositoDeCocinas(int cantidad)
        {
            this._cantidadMaxima = cantidad;
            _lista = new List<Cocina>();
        }
        #endregion

        #region Operadores
        public static bool operator +(DepositoDeCocinas dep, Cocina oven)
        {
            bool flag = false;
            bool outside = true;

            if (dep._lista.Count < dep._cantidadMaxima)
            {
                foreach (Cocina item in dep._lista)
                {
                    if (item == oven)
                    {
                        Console.WriteLine("La cocina " + oven.ToString() + "ya esta en el deposito.");
                        outside = false;
                        break;
                    }
                }

                if (outside)
                {
                    dep._lista.Add(oven);
                    Console.WriteLine("Se ha agregado la cocina!");
                    flag = true;
                }

                else
                {
                    Console.WriteLine("No hay mas lugar en el deposito.");
                }
                
            }
            return flag;
        }

        public static bool operator -(DepositoDeCocinas dep, Cocina oven)
        {
            bool flag = false;
            int indice;

            indice = dep.GetIndice(oven);
            if (indice != -1)
            {
                dep._lista.RemoveAt(indice);
                flag = true;
                Console.WriteLine("La cocina se ha removido");
            }

            else
            {
                Console.WriteLine("La cocina no existe en el deposito");
            }

            return flag;
        }
        #endregion

        #region Sobrecarga
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Capacidad maxima: {0}\r\n", this._cantidadMaxima);
            sb.AppendLine("Cocinas en el deposito: ");
            foreach (Cocina item in this._lista)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine();

            return sb.ToString();
        }
        #endregion

    }

}

