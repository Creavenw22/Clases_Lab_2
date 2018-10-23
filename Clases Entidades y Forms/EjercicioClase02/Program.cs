using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace EjercicioClase02
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "Franas";

            Console.WriteLine(Sello.Imprimir());
            
            
            Console.WriteLine("---------");
            Sello.ImprimirEnColor();
            Console.WriteLine("---------");
            Console.WriteLine(Sello.Imprimir());
            Console.WriteLine("---------");
            Sello.Borrar();
            Console.WriteLine(Sello.Imprimir());

            Console.ReadLine();

        }
    }
}
