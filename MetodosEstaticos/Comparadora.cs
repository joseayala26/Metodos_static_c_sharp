using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstaticos
{
    class Comparadora
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int RetornarMayor(int num1,int num2)
        {
            int retorno=0;

            if (num1 > num2)
                retorno = num1;
            else
                retorno = num2;
                return retorno;
        }

        /// <summary>
        /// retorna el valor del medio
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        /// <returns></returns>
        public static int RetornarMayor(int num1, int num2,int num3)
        {
            int retorno = 0;
            //int numero_prueba=num1;

            if (num1 > num2)
                retorno = num1;
            else
            {
                if(num1>num3)
                retorno = num2;
            }
                
            return retorno;
        }
    }
}
