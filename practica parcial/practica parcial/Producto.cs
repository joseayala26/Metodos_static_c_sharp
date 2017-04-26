using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using enumerados;

namespace practica_parcial
{
    public class Producto
    {
        protected int _codigodebarra;
        protected Emarcadelproduto _marca;
        protected float _precio;

        public Emarcadelproduto marca
        {
            get { return this._marca; }

        }
        public float precio
        {
            get { return this._precio; }
        }
        public Producto(int codigo,Emarcadelproduto marca,float precio)
        {
            this._codigodebarra = codigo;
            this._marca = marca;
            this._precio = precio;
        }

        public void  mostarProducto(Producto prod)
        {
            StringBuilder bloque = new StringBuilder();
            
            bloque.AppendLine("producto" + this._marca); ;

        }

        public static bool operator ==(Producto produno, Emarcadelproduto marca)
        {
            return produno._marca == marca;
        }
        public static bool operator !=(Producto produno, Emarcadelproduto marca)
        {
            return !(produno==marca);
        }

        public static bool operator ==(Producto produno, Producto proddos)
        {
            return produno._marca == proddos._marca&&produno._codigodebarra==proddos._codigodebarra;
        }
        public static bool operator !=(Producto produno, Producto proddos)
        {
            return !(produno==proddos);
        }
    }
}
