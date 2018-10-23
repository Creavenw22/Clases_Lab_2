using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Tinta tinta1 = new Tinta();
            Tinta tinta2 = new Tinta(ConsoleColor.Blue);
            Tinta tinta3 = new Tinta(ConsoleColor.Red, ETipoTinta.Comun);


            Pluma pluma1 = new Pluma();
            Pluma pluma2 = new Pluma("Bic");
            Pluma pluma3 = new Pluma("Pelican", 10,tinta2);
            Pluma pluma4 = new Pluma("Parker",5,tinta3);

            Console.WriteLine(pluma1);
            //Console.WriteLine(pluma2);
            Console.WriteLine(pluma3);
            Console.WriteLine(pluma4);

            pluma4 += tinta3;
            pluma3 += tinta3;


            Console.WriteLine(pluma4);
            Console.WriteLine(pluma3);

            pluma3 += tinta2;

            Console.WriteLine();
            Console.WriteLine(pluma3);

            Console.WriteLine(Tinta.Mostrar(tinta1));
            Console.WriteLine(Tinta.Mostrar(tinta2));
            Console.WriteLine(Tinta.Mostrar(tinta3));

            Console.WriteLine();

            if (tinta1 == tinta2)
            {
                Console.WriteLine("{0} y {1} Son Iguales", Tinta.Mostrar(tinta1), Tinta.Mostrar(tinta2));
            }
            else
            {
                Console.WriteLine("{0} y {1} no son Iguales", Tinta.Mostrar(tinta1), Tinta.Mostrar(tinta2));
            }

            if (tinta1 == tinta3)
            {
                Console.WriteLine("{0} y {1} Son Iguales", Tinta.Mostrar(tinta1), Tinta.Mostrar(tinta3));
            }
            else
            {
                Console.WriteLine("{0} y {1} no son Iguales", Tinta.Mostrar(tinta1), Tinta.Mostrar(tinta3));
            }

            Console.ReadLine();
        }
    }
}
