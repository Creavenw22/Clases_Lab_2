using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color = ConsoleColor.Cyan;

        public static string Imprimir()
        {
            string cadena = "";
            string retorno = "";

            if (Sello.TryParse(Sello.mensaje, out cadena))
            {
                retorno = Sello.ArmarFormatoMensaje();
                
            }

            return retorno;
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir()); //Encapsulamiento
        }


        private static string ArmarFormatoMensaje()
        {
            string mensaje = Sello.mensaje;
            string cadenaReturn = "";
            string asteriscos = "";
            string middleLine = "";
            int largo = mensaje.Length;
            int i;
            for (i = 0; i < largo + 2; i++)
            {
                asteriscos += "*";
            }
            middleLine += "\n*";
            middleLine += mensaje;
            middleLine += "*\n";
            cadenaReturn += asteriscos;
            cadenaReturn += middleLine;
            cadenaReturn += asteriscos;
            return cadenaReturn;
        }

        private static bool TryParse(string s1, out string s2)
        {
            int lnght;
            bool flag=false;
            s2 = "";
            lnght = s1.Length;

            if (lnght > 0)
            {
                s2 = s1;
                flag= true;
            }
            return flag;
        }

    }
}
