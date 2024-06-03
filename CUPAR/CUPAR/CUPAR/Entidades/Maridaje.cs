using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUPAR.Entidades
{
    public class Maridaje
    {

        // Atributos
        public string Nombre; // Se declara como public para que sea accesible desde fuera de la clase
        private string Descripcion;

        // Constructor
        public Maridaje(string nombre, string descripcion)
        {
            // Inicializa el nombre y la descripción del maridaje con los valores proporcionados
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }

        // Método para obtener el nombre del maridaje
        public string getNombre()
        {
            return Nombre;
        }

        // Método para establecer el nombre del maridaje
        public void setNombre(string nombre)
        {
            this.Nombre = nombre;
        }

        // Método para obtener la descripción del maridaje
        public string getDescripcion()
        {
            return Descripcion;
        }

        // Método para establecer la descripción del maridaje
        public void setDescripcion(string descripcion)
        {
            this.Descripcion = descripcion;
        }

        // Método para verificar si el maridaje coincide con un nombre dado
        public bool sosMaridaje(string maridaje)
        {
            return getNombre() == maridaje;
        }
    }
}
