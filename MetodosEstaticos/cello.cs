using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstaticos
{
    class cello
    {
        public static string mensaje;
        public static ConsoleColor color;
        public static string imprimir()
        {
           

            return mensaje;
        }

        public static void borrar()
        {
            cello.mensaje = "";

        }


        /// <summary>
        /// imprime msn con el color de la consola
        /// </summary>
        public static void imprimircolor()
        {
            Console.ForegroundColor = cello.color;
            Console.WriteLine(cello.imprimir());
        }
        private static string armarmensaje()
        {
            string retorno = "";

            return cello.mensaje;
        }
        
    }
}
