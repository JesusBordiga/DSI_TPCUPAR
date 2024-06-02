using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUPAR.Entidades
{
    public class Siguiendo
    {
        public Bodega Bodega { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public Siguiendo(Bodega bodega, DateTime fechaInicio, DateTime fechaFin)
        {
            Bodega = bodega;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }

    }
}
