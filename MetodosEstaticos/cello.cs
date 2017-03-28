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
            return cello.mensaje;
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
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static string armarmensaje()
        {
            string retorno = "";

            return cello.mensaje;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="palabra"></param>
        /// <returns></returns>
        public static int tamanio(string palabra)
        {
            int retorno = 0;
            //int cant_caracteres=0;
            retorno = palabra.Length;
   
            return retorno;
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cant_asteristico"></param>
        public static void astericos(int cant_asteristico)
        {
            Console.Write("*");
            for (int i = 0; i < cant_asteristico; i++)
            {
                Console.Write("*");
            }
            Console.Write("*");


            Console.WriteLine();
        }
        /// <summary>
        /// 
        /// </summary>
        public static void crea_carteles()
        {
            Console.WriteLine("escribir algo");
            cello.mensaje = Console.ReadLine();
            //ElMayor=cello.tamanio(dato);
            cello.astericos(cello.tamanio(cello.mensaje));
            Console.WriteLine("*" + cello.mensaje + "*");
            cello.astericos(cello.tamanio(cello.mensaje));
            
        }
    }
}
