using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int ElMayor;
            string dato;
            cello.mensaje = "nuevo mensaje";
            dato=cello.imprimir();
            Console.WriteLine(dato);

            cello.borrar();


            cello.color = ConsoleColor.White; 
            Console.WriteLine(dato);
            Console.WriteLine("hola mundo");
            cello.imprimircolor();
            ElMayor = Comparadora.RetornarMayor(5, 10);

            /***************************************/
            /***************************************/
            /***************************************/


            cello.crea_carteles();
            //Console.WriteLine("escribir algo");
            //cello.mensaje = Console.ReadLine();
            //ElMayor=cello.tamanio(dato);
            //cello.astericos(cello.tamanio(cello.mensaje));
            //Console.WriteLine("*" + cello.mensaje + "*");
            //cello.astericos(cello.tamanio(cello.mensaje));


            Console.ReadKey();
        }
    }
}
