using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUPAR.Entidades
{
    public class Maridaje
    {
       
        private string Nombre;
        private string Descripcion;

        public Maridaje(string nombre, string descripcion)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }


        // METODO SET Y GET

        public void setNombre(string nombre)
        {
            this.Nombre = nombre;

        }

        public string getNombre() 
        {
            return Nombre;
        }
        public string getDescripcion()
        {
            return Descripcion;
        }

        

        public void setDescripcion(string descripcion)
        {
            this.Descripcion = descripcion;
        }




    }
}
