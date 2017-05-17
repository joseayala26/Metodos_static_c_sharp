using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_interfacegrafico
{
    public class Class4:Class1,Iimprimir,Imostrable
    {

        void Iimprimir.mostrarprog()
        {
            throw new NotImplementedException();
        }



        void Imostrable.mostrarprog()
        {
            throw new NotImplementedException();
        }
    }
}
