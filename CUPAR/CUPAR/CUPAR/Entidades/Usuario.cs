using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUPAR.Entidades
{
    public class Usuario
    {
        // Atributos
        public string Nombre;
        public string Contraseña;
        public bool Premium;

        // Constructor
        public Usuario(string nombre, string contraseña, bool premium)
        {
            // Inicializa el nombre, la contraseña y el estado premium del usuario con los valores proporcionados
            this.Nombre = nombre;
            this.Contraseña = contraseña;
            this.Premium = premium;
        }

        // Método para establecer el nombre del usuario
        public void setNombre(string nombre)
        {
            this.Nombre = nombre;
        }

        // Método para obtener el nombre del usuario
        public string getNombre()
        {
            return this.Nombre;
        }

        // Método para establecer la contraseña del usuario
        public void setContraseña(string contraseña)
        {
            this.Contraseña = contraseña;
        }

        // Método para obtener la contraseña del usuario
        public string getContraseña()
        {
            return this.Contraseña;
        }

        // Método para establecer si el usuario es premium o no
        public void esPremium(bool esPremium)
        {
            this.Premium = esPremium;
        }
    }
}
