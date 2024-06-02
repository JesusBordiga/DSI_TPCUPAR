using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CUPAR.Entidades
{
    public class Vino
    {

        //Atributos

        public int Aniade;
        public string Nombre;
        public string NotaDeCata;
        public Bodega Bodega;
        public float PrecioARS;
        public int ImagenEtiqueta;
        public List<Maridaje> Maridajes;
        public List<Varietal> Varietales;
       

        public Vino(Bodega bodega, int aniade, string nombre, string notaDeCata, float precio, List<Maridaje> maridajes, List<Varietal> varietal, int imagen )
        {
            this.Bodega = bodega;
            Aniade = aniade;
            Nombre = nombre;
            NotaDeCata = notaDeCata;
            PrecioARS = precio;
            Maridajes = maridajes;
            Varietales = varietal;
            ImagenEtiqueta = imagen;
        }

        // Inicio GET Y SET

        public void setAniade(int aniade)
        {
             this.Aniade = aniade;
        }

        public int getAniade()
        {
            return Aniade;
        }

        public void setBodega(Bodega bodega) 
        {
            this.Bodega= bodega;
        }

        public Bodega getBodega() 
        {
            return Bodega;
        }

        public void setNombre(string nombre)
        {
            this.Nombre = nombre;

        }
        public string getNombre()
        {
            return Nombre;
        }

        public void setNotaCata(string notaDeCata)
        {
            this.NotaDeCata = notaDeCata;
        }

        public string getNotaCata()
        {
            return NotaDeCata;
        }

        public void setPrecioARS(float precioARS)
        {
            this.PrecioARS = precioARS;
        }

        public float getPrecioARS()
        {
            return PrecioARS;
        }

        

        public void setImagenEtiqueta(int imagenEtiqueta)
        {
            this.ImagenEtiqueta = imagenEtiqueta;
        }
        public int getImagenEtiqueta()
        {
            return ImagenEtiqueta;
        }

        public void setMaridaje(List<Maridaje> maridaje)
        {
            this.Maridajes = maridaje;
        }

        public List<Maridaje> getMaridaje()
        {
            return Maridajes;
        }

        public void setVarietal(List<Varietal> varietal)
        {
            this.Varietales = varietal;
        }

        public List<Varietal> getVarietal()
        {
            return Varietales;
        }


        // Verifica si el vino necesita ser actualizado
        public bool esVinoParaActualizar(string nombreVino)
        {
            return nombreVino == getNombre();
        }
       
        
        //public List<Maridaje> ObtenerMaridajes()
        //{
        //    return Maridajes;
        //}

        //public List<Varietal> ObtenerVarietales()
        //{
        //    return Varietales;
        //}
    }


}
