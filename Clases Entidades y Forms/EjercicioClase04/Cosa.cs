using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase04
{
    class Cosa
    {
        #region Atributos
        public string cadena;
        public double numero;
        public DateTime fecha;
        #endregion

        #region Metodos

        public static string Mostrar(Cosa a)
        {
            return a.Mostrar();
        }

        private string Mostrar()
        {
            return "Cadena: " + this.cadena + "\nNumero: " + this.numero.ToString() + "\nFecha: " + this.fecha.ToLongDateString();
        }
        
        #endregion

        #region Constructor

        public Cosa()
        {
            this.cadena = "Sin Valor";
            this.numero = 0;
            this.fecha = DateTime.Now;
        }

        public Cosa(string cadena) : this()
        {
            this.cadena = cadena;
            //this.numero = 0;
            //this.fecha = DateTime.Now;
        }

        public Cosa(string cadena, int numero) : this(cadena)
        {
            this.numero = numero;
        }

        public Cosa(string cadena, int numero, DateTime fecha) : this (cadena,numero)
        {
            this.fecha = DateTime.Today;
        }

        #endregion
    }
}
