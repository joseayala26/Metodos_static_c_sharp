using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conHerencia
{
    public class Aula
    {


        private int _numero;
        private string _nombre;
        private List<Persona> _listadoDePersonas;
        private int capacidad;


        public Aula(int numero, string nombre,int capacidad)
        {
            this._nombre = nombre;
            this._numero = numero;
            this._listadoDePersonas = new List<Persona>();
        }
        public int cantidadDePersonas
        {
            get
            {
                return 1;
            }
        }
        public int cantidadDeProfesores
        {
            get
            {
                int contador = 0;
                foreach (Persona item in this._listadoDePersonas)
                {
                    //.getType
                    //typeof

                    if (item is Profesor  )
                    {
                        contador++;
                    
                    }
                }
                return contador;
            }
        }

        public int cantidadDeAlumnosEgresados
        {
            get
            {
                return 1;
            }
        }


        public bool agregarPersona(Persona unaPersona)
        {

            //verificar capacidad
            //si hay capacidad
            this._listadoDePersonas.Add(unaPersona);
            return true;
        }

        public bool borrarPersona(Persona unaPersona)
        {
            int contador = 0;
            foreach (Persona item in _listadoDePersonas)
            {
                if(unaPersona is AlumnoEgresado)
                {
                    if(((AlumnoEgresado)unaPersona).Equals(item)&&(AlumnoEgresado)unaPersona==(AlumnoEgresado)item)
                        return true;
                }
                else
                {
                    if(unaPersona is Alumno)
                    {
                        if(((Alumno)unaPersona).Equals(item)&&(Alumno)unaPersona==(Alumno)item)
                            return true;
                    }
                    else
                    {
                         if(unaPersona is Profesor)
                         {
                             if(((Profesor)unaPersona).Equals(item)&&(Profesor)unaPersona==(Profesor)item)
                                return true;
                         }
                         else
                         {
                             if(((Persona)unaPersona).Equals(item)&&(Persona)unaPersona==(Persona)item)
                                return true;
                         }

                    }
                }
                /*if (item.Equals(unaPersona) &&  item == unaPersona)
                {
                    Console.WriteLine("si" + contador);
                }*/
            }

            return true;
        }

       
    }
}
