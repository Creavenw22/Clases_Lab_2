using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\##Bustamante\Clases_Lab_2\Clases Archivos\AdministradorArchivos\texto.txt";
            string escritorio = @"C:\Users\alumno\Desktop\TestDesk.txt";
            string misDocumentos = @"C:\Users\alumno\Documents\testDocs.txt";
            string misImagenes = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\testPics.txt";//@"C:\Users\alumno\Pictures\testPics.txt";
            string texto1,texto2,texto3,texto4;


            if (!(AdministradorArchivos.Escribir(path, "EAEAEAEA FUNCIONA PERREKE")))
            {
                Console.WriteLine("No se pudo escribir el archivo");
            }
            if (!(AdministradorArchivos.Escribir(escritorio, "Este es el archivo de escritorio")))
            {
                Console.WriteLine("No se pudo escribir el archivo");
            }
            if (!(AdministradorArchivos.Escribir(misDocumentos, "Este es el archivo de documentos")))
            {
                Console.WriteLine("No se pudo escribir el archivo");
            }
            if (!(AdministradorArchivos.Escribir(misImagenes, "Este es el archivo de imagenes")))
            {
                Console.WriteLine("No se pudo escribir el archivo");
            }

            if (!(AdministradorArchivos.Leer(path, out texto1)))
            {
                Console.WriteLine("No se pudo leer el archivo");
            }
            if (!(AdministradorArchivos.Leer(escritorio, out texto2)))
            {
                Console.WriteLine("No se pudo leer el archivo");
            }
            if (!(AdministradorArchivos.Leer(misDocumentos, out texto3)))
            {
                Console.WriteLine("No se pudo leer el archivo");
            }
            if (!(AdministradorArchivos.Leer(misImagenes, out texto4)))
            {
                Console.WriteLine("No se pudo leer el archivo");
            }


            Console.WriteLine(texto1);
            Console.WriteLine(texto2);
            Console.WriteLine(texto3);
            Console.WriteLine(texto4);

            Console.ReadLine();
        }
    }
}
