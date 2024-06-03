using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUPAR.Entidades
{
    public class Varietal
    {
        // Atributos
        public string Descripcion;
        private float Porcentaje;
        private TipoUva TipoUva;

        // Constructor
        public Varietal(string descripcion, float porcentaje, TipoUva tipoUva)
        {
            // Inicializa la descripción, el porcentaje y el tipo de uva del varietal con los valores proporcionados
            this.Descripcion = descripcion;
            this.Porcentaje = porcentaje;
            this.TipoUva = tipoUva;
        }

        // Método para establecer la descripción del varietal
        public void setDescripcion(string descripcion)
        {
            this.Descripcion = descripcion;
        }

        // Método para obtener la descripción del varietal
        public string getDescripcion()
        {
            return Descripcion;
        }

        // Método para establecer el porcentaje del varietal
        public void setPorcentaje(float porcentaje)
        {
            this.Porcentaje = porcentaje;
        }

        // Método para obtener el porcentaje del varietal
        public float getPorcentaje()
        {
            return Porcentaje;
        }

        // Método para establecer el tipo de uva del varietal
        public void setTipoUva(TipoUva tipoUva)
        {
            this.TipoUva = tipoUva;
        }



        //public void setPorcentajeComposicion(int porcentaje)
        //{
        //  porcentajeComposicion = porcentaje;
        //}

        // public void setTipoUva(TipoUva tipoUva)
        //{
        //  TipoDeUva = tipoUva;
        //}
    }
}
