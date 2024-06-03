using CUPAR.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUPAR.Repositorio
{
    public  class RepositorioEnofilo
    {
        private List<Enofilo> enofilos;

        public RepositorioEnofilo()
        {
            enofilos = new List<Enofilo>();
            CargarDatosIniciales();
        }

        private void CargarDatosIniciales()
        {
            // Aquí cargas a los enófilos y sus suscripciones a bodegas de ejemplo
        }

        public List<Enofilo> ObtenerEnofilos()
        {
            return enofilos;
        }

        public List<Enofilo> ObtenerSeguidoresDeBodega(Bodega bodega)
        {
            return enofilos.Where(e => e.SiguiendoBodegas.Any(s => s.Bodega == bodega)).ToList();
        }
    }
}
