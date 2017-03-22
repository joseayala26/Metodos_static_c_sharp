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
            cello.color = ConsoleColor.Blue; 
            Console.WriteLine(dato);
            Console.WriteLine("hola mundo");
            cello.imprimircolor();
            ElMayor = Comparadora.RetornarMayor(5, 10);

            Console.ReadKey();
        }
    }
}
