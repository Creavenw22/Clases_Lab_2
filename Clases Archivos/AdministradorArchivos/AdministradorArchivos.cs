using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class AdministradorArchivos
    {
        
        #region Metodos
        public static bool Escribir(string path, string texto)
        {
            bool flag=false;

            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(texto.ToString());
                    flag = true;
                }
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return flag;
        }

        public static bool Leer(string path, out string texto)
        {
            bool flag=false;
            texto = "";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    texto = sr.ReadToEnd();
                    flag = true;
                }
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return flag;
        }
        #endregion

    }
    
}
