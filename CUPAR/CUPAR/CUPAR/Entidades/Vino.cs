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


        // Constructor
        public Vino(Bodega bodega, int aniade, string nombre, string notaDeCata, float precio, List<Maridaje> maridajes, List<Varietal> varietal, int imagen)
        {
            // Inicializa los atributos del vino con los valores proporcionados
            this.Bodega = bodega;
            this.Aniade = aniade;
            this.Nombre = nombre;
            this.NotaDeCata = notaDeCata;
            this.PrecioARS = precio;
            this.Maridajes = maridajes;
            this.Varietales = varietal;
            this.ImagenEtiqueta = imagen;
        }

        // Métodos para establecer y obtener el año de añada del vino
        public void setAniade(int aniade)
        {
            this.Aniade = aniade;
        }
        public int getAniade()
        {
            return Aniade;
        }

        // Métodos para establecer y obtener la bodega del vino
        public void setBodega(Bodega bodega)
        {
            this.Bodega = bodega;
        }
        public Bodega getBodega()
        {
            return Bodega;
        }

        // Métodos para establecer y obtener el nombre del vino
        public void setNombre(string nombre)
        {
            this.Nombre = nombre;
        }
        public string getNombre()
        {
            return Nombre;
        }

        // Métodos para establecer y obtener la nota de cata del vino
        public void setNotaCata(string notaDeCata)
        {
            this.NotaDeCata = notaDeCata;
        }
        public string getNotaCata()
        {
            return NotaDeCata;
        }

        // Métodos para establecer y obtener el precio del vino
        public void setPrecioARS(float precioARS)
        {
            this.PrecioARS = precioARS;
        }
        public float getPrecioARS()
        {
            return PrecioARS;
        }

        // Métodos para establecer y obtener la imagen de la etiqueta del vino
        public void setImagenEtiqueta(int imagenEtiqueta)
        {
            this.ImagenEtiqueta = imagenEtiqueta;
        }
        public int getImagenEtiqueta()
        {
            return ImagenEtiqueta;
        }

        // Métodos para establecer y obtener los maridajes del vino
        public void setMaridaje(List<Maridaje> maridaje)
        {
            this.Maridajes = maridaje;
        }
        public List<Maridaje> getMaridaje()
        {
            return Maridajes;
        }

        // Métodos para establecer y obtener los varietales del vino
        public void setVarietal(List<Varietal> varietal)
        {
            this.Varietales = varietal;
        }
        public List<Varietal> getVarietal()
        {
            return Varietales;
        }

        // Método para verificar si el vino necesita ser actualizado
        public bool esVinoParaActualizar(string nombreVino)
        {
            string mondongo = getNombre();
            
            return nombreVino == getNombre();
        }

        // Método para obtener los maridajes del vino (prueba)
        public List<Maridaje> ObtenerMaridajes()
        {
            return Maridajes;
        }

        // Método para obtener los varietales del vino (prueba)
        public List<Varietal> ObtenerVarietales()
        {
            return Varietales;
        }

        // Método para crear los varietales del vino
        public void crearVarietal(List<TipoUva> tipoUvaActualizar, List<string> porcentajeActualizar)
        {
            List<Varietal> aux = new List<Varietal>();
            for (int i = 0; i < porcentajeActualizar.Count(); i++)
            {
                aux.Add(new Varietal("Dulce aroma de campo", float.Parse(porcentajeActualizar[i]), tipoUvaActualizar[i]));
            }
            setVarietal(aux);
        }
    }
}
