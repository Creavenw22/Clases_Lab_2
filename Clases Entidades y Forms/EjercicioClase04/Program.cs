using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase04
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa Persona0 = new Cosa();
            Console.WriteLine(Cosa.Mostrar(Persona0));

            Cosa Persona1 = new Cosa("Franas");
            Console.WriteLine(Cosa.Mostrar(Persona1));

            Cosa Persona2 = new Cosa("Palu", 21);
            Console.WriteLine(Cosa.Mostrar(Persona2));

            Cosa Persona3 = new Cosa("Agus", 19, DateTime.Now);
            Console.WriteLine(Cosa.Mostrar(Persona3));







            Console.ReadLine();

            
        }

    

}
}
