using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUPAR.Entidades
{
     public class Enofilo
    {

        #region Atributos
        public string Apellido;
        public string Nombre;
        public Usuario Usuario;
        public List<Siguiendo> SiguiendoBodegas;
        public List<Vino> Vinos;
        #endregion

        
        #region Constructor
        public Enofilo(string apellido, string nombre, Usuario usuario, List<Siguiendo> siguiendoBodega)
        {
            // Inicializa la propiedad Apellido con el valor proporcionado
            this.Apellido = apellido;

            // Inicializa la propiedad Nombre con el valor proporcionado
            this.Nombre = nombre;

            // Inicializa la propiedad Usuario con el valor proporcionado
            this.Usuario = usuario;

            // Inicializa la propiedad SiguiendoBodegas con la lista proporcionada
            this.SiguiendoBodegas = siguiendoBodega;
        }
        #endregion

        
        #region Metodos get y set
        // Método para obtener el valor de Apellido
        public string getApellido()
        {
            // Retorna el valor de la propiedad Apellido
            return Apellido;
        }

        // Método para establecer el valor de Apellido
        public void setApellido(string apellido)
        {
            // Asigna el valor proporcionado a la propiedad Apellido
            this.Apellido = apellido;
        }

        // Métodos get y set para Nombre
        public string getNombre()
        {
            return Nombre;
        }

        // Método para establecer el valor de Nombre
        public void setNombre(string nombre)
        {
            // Asigna el valor proporcionado a la propiedad Nombre
            this.Nombre = nombre;
        }

        // Métodos get y set para Usuario
        public Usuario getUsuario()
        {
            return Usuario;
        }

        // Método para establecer el valor de Usuario
        public void setUsuario(Usuario value)
        {
            // Asigna el valor proporcionado a la propiedad Usuario
            this.Usuario = value;
        }

        // Métodos get y set para SiguiendoBodegas
        public List<Siguiendo> getSiguiendoBodegas()
        {
            return SiguiendoBodegas;
        }
        #endregion


        #region Metodos de la clase
        
        // Método para establecer la lista de bodegas seguidas
        
        public void setSiguiendoBodegas(List<Siguiendo> siguiendobodega)
        {
            // Asigna la lista proporcionada a la propiedad SiguiendoBodegas
            this.SiguiendoBodegas = siguiendobodega;
        }
        
        
        // Método para agregar una nueva bodega a la lista de bodegas seguidas
        
        public string SeguisABodega(Bodega bodegaSeleccionada)
        {
            // Agrega un nuevo objeto Siguiendo a la lista SiguiendoBodegas
            foreach (Siguiendo seguidores in SiguiendoBodegas)
            {
                if (seguidores.sosDeBodega(bodegaSeleccionada))
                {
                    return getUsuario().getNombre();
                }
            }

            return null;
        }

        #endregion
    }



}
