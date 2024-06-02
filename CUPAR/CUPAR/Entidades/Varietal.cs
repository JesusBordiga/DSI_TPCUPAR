using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUPAR.Entidades
{
    public class Varietal
    {
        private string Descripcion;
        private float Porcentaje;
        private TipoUva TipoUva;

      
        public Varietal(string descripcion, float porcentaje, TipoUva tipoUva)
        {
            this.Descripcion = descripcion;
            this.Porcentaje = porcentaje;
            this.TipoUva = tipoUva;

        }

        //Metodos GET Y SET

       
        public void setDescripcion(string descripcion)
        {
            this.Descripcion = descripcion;

        }

        public string getDescripcion() 
        { 
            return Descripcion;
        }

        public void setPorcentaje(float porcentaje)
        {
            this.Porcentaje = porcentaje;
        }
        public float getPorcentaje()
        {
            return Porcentaje;
        }

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
