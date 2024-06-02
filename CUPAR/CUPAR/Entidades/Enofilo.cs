using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUPAR.Entidades
{
     public class Enofilo
    {


        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public Usuario Usuario { get; set; }
        public List<Siguiendo> SiguiendoBodegas { get; set; }

        public Enofilo(string apellido, string nombre, Usuario usuario)
        {
            Apellido = apellido;
            Nombre = nombre;
            Usuario = usuario;
            SiguiendoBodegas = new List<Siguiendo>();
        }

        public void SeguirBodega(Bodega bodega, DateTime fechaInicio, DateTime fechaFin)
        {
            SiguiendoBodegas.Add(new Siguiendo(bodega, fechaInicio, fechaFin));
        }
    }



}
