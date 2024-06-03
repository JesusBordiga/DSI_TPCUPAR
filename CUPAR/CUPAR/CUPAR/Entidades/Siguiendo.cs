using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUPAR.Entidades
{
    public class Siguiendo
    {
        #region Atributos
        public Bodega Bodega;
        public DateTime FechaInicio;
        public DateTime FechaFin;
        #endregion
        
        // Constructor
        
        public Siguiendo(Bodega bodega, DateTime fechaInicio)
        {
            // Inicializa la bodega y la fecha de inicio con los valores proporcionados
            this.Bodega = bodega;
            this.FechaInicio = fechaInicio;
            // No se inicializa la fecha fin en el constructor
        }

        // Método para establecer la bodega
        public void setBodega(Bodega bodega)
        {
            this.Bodega = bodega;
        }

        // Método para establecer la fecha de inicio
        public void setFechaInicio(DateTime fechaInicio)
        {
            this.FechaInicio = fechaInicio;
        }

        // Método para establecer la fecha de fin
        public void setFechaFin(DateTime fechaFin)
        {
            this.FechaFin = fechaFin;
        }

        // Método para obtener la bodega
        public Bodega getBodega()
        {
            return Bodega;
        }

        // Método para obtener la fecha de inicio
        public DateTime getFechaInicio()
        {
            return FechaInicio;
        }

        // Método para obtener la fecha de fin
        
        public DateTime getFechaFin()
        {
            return FechaFin;
        }
       
        public bool sosDeBodega(Bodega bodegaSeleccionada)
        {
            return getBodega().getNombre() == bodegaSeleccionada.getNombre();
        }
    }
}
