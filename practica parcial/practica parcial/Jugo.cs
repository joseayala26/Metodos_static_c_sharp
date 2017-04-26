using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using enumerados;

namespace practica_parcial
{
    class Jugo:Producto
    {
        protected Esabordeljugo _sabor;

        public Jugo(int codigo, float precio, Emarcadelproduto marca, Esabordeljugo sabor):base(codigo,marca,precio)
        {
            this._sabor = sabor;
        }

        public override string ToString()
        {
            StringBuilder Bloque = new StringBuilder();
            Bloque.AppendLine(base.ToString());

            Bloque.AppendLine("" + this._sabor);

            return Bloque.ToString();

        }
    }


}
