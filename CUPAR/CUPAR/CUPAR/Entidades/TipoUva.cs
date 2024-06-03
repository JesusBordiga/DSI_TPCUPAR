using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUPAR.Entidades
{
    public class TipoUva
    {
        // Propiedades auto-implementadas para nombre y descripción
        public string nombre { get; set; }
        public string descripcion { get; set; }

        // Constructor
        public TipoUva(string nombre, string descripcion)
        {
            // Inicializa el nombre y la descripción del tipo de uva con los valores proporcionados
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        // Método para establecer el nombre del tipo de uva
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        // Método para obtener el nombre del tipo de uva
        public string getNombre()
        {
            return nombre;
        }

        // Método para establecer la descripción del tipo de uva
        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }

        // Método para obtener la descripción del tipo de uva
        public string getDescripcion()
        {
            return descripcion;
        }

        // Método para verificar si el tipo de uva coincide con uno dado
        public bool sosTipoUva(string tipoUva)
        {
            return getNombre() == tipoUva;
        }
    }
}
