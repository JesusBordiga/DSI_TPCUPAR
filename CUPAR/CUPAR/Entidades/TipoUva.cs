using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUPAR.Entidades
{
    public class TipoUva
    {
        public string descripcion { get; set; }
        public string nombre { get; set; }

        public TipoUva(string nombre, string descripcion)
        {
            this.descripcion = descripcion;
            this.nombre = nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public string getDescripcion()
        {
            return descripcion;
        }

       

     
      
    }


    
}
