using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CUPAR.Entidades
{
    public class Bodega
    {
        //Atributos de la Clase Bodega
        private static List<Bodega> bodega = new List<Bodega>(); // Almacenamiento de las bodegas creadas
        private string Nombre;
        private string Historia;
        private string Descripcion;
        private List<float> CoordenadasUbicacion;
        private int PeriodoActualizacion;
        private DateTime UltimaActualizacion;
        private List<Vino> Vinos;




        public Bodega(string nombre, int periodoActualizacion, string descripcion, string historia, List<float> coordenadas, DateTime ultimaActualizacion)
        {
            // Inicializa la lista de vinos
            this.Vinos = new List<Vino>();

            // Asigna los valores pasados como argumentos a las propiedades de la instancia de Bodega
            this.Nombre = nombre;
            this.Historia = historia;
            this.Descripcion = descripcion;
            this.UltimaActualizacion = ultimaActualizacion;
            this.PeriodoActualizacion = periodoActualizacion;

            // Agrega esta instancia de Bodega a la lista 'bodega'
            bodega.Add(this);
        }

        // Metodos de GET Y SET para cada atributo

        //Inicio Seteo
        public void setNombre(string nombre)
        {
            // Asigna el nuevo valor 'nombre' al atributo 'Nombre' de la instancia actual
            this.Nombre = nombre;
        }

        public string getNombre()
        {
            // Devuelve el valor del atributo 'Nombre' de la instancia actual
            return Nombre;
        }

        public void setDescripcion(string descripcion)
        {
            // Asigna el nuevo valor 'descripcion' al atributo 'Descripcion' de la instancia actual
            this.Descripcion = descripcion;
        }

        public string getDescripcion()
        {
            // Devuelve el valor del atributo 'Descripcion' de la instancia actual
            return Descripcion;
        }

        public void setHistoria(string historia)
        {
            // Asigna el nuevo valor 'historia' al atributo 'Historia' de la instancia actual
            this.Historia = historia;
        }

        public string getHistoria()
        {
            // Devuelve el valor del atributo 'Historia' de la instancia actual
            return Historia;
        }

        public void setPeriodoActualizacion(int periodoActualizacion)
        {
            // Asigna el nuevo valor 'periodoActualizacion' al atributo 'PeriodoActualizacion' de la instancia actual
            this.PeriodoActualizacion = periodoActualizacion;
        }

        public int getPeriodoActualizacion()
        {
            // Devuelve el valor del atributo 'PeriodoActualizacion' de la instancia actual
            return PeriodoActualizacion;
        }

        public void setUltimaActualizacion(DateTime ultimaActualizacion)
        {
            // Asigna el nuevo valor 'ultimaActualizacion' al atributo 'UltimaActualizacion' de la instancia actual
            this.UltimaActualizacion = ultimaActualizacion;
        }

        public DateTime getUltimaActualizacion()
        {
            // Devuelve el valor del atributo 'UltimaActualizacion' de la instancia actual
            return UltimaActualizacion;
        }

        public void setCoordenadas(List<float> coordenadas)
        {
            // Asigna la lista de coordenadas proporcionada al atributo 'CoordenadasUbicacion' de la instancia actual
            this.CoordenadasUbicacion = coordenadas;
        }

        public List<float> getCoordenadas()
        {
            // Devuelve la lista de coordenadas del atributo 'CoordenadasUbicacion' de la instancia actual
            return CoordenadasUbicacion;
        }

        public void setVinos(List<Vino> vinos)
        {
            // Asigna la lista de vinos proporcionada al atributo 'Vinos' de la instancia actual
            this.Vinos = vinos;
        }

        public List<Vino> getVinos()
        {
            // Devuelve la lista de vinos del atributo 'Vinos' de la instancia actual
            return Vinos;
        }

        /////////////



        //Tiene Actualizaciones Disponible

        public bool tieneActualizacionesDisponibles()
        {
            // Calcula la cantidad de días transcurridos desde la última actualización de la bodega
            int cantidadDias = (DateTime.Now - this.UltimaActualizacion).Days;

            // Comprueba si han pasado más días que el periodo de actualización especificado
            return (cantidadDias >= (this.PeriodoActualizacion * 30));
        }

        public Vino actualizarCaracteristicasExistente(List<Vino> vinosExistente, List<string> vinoAct)
        {
            List<string> vinoLista = new List<string>();
            // Recorre la lista de vinos existentes
            foreach (Vino vino in vinosExistente)
            {
                // Verifica si el vino actual necesita ser actualizado
                if (vino.esVinoParaActualizar(vinoAct[1]))
                {
                    // Actualiza las características del vino con los nuevos valores proporcionados
                    vino.setImagenEtiqueta(int.Parse(vinoAct[6])); // Actualiza la imagen de la etiqueta
                    vino.setAniade(int.Parse(vinoAct[0])); // Actualiza el año del vino
                    vino.setNotaCata(vinoAct[2]); // Actualiza la nota de cata
                    vino.setPrecioARS(float.Parse(vinoAct[3])); // Actualiza el precio en ARS
                    vinoLista.Add(vino.getNombre());
                    vinoLista.Add(vino.getPrecioARS().ToString());
                    vinoLista.Add(vino.getNotaCata());
                    vinoLista.Add("actualizado");

                    // Retorna el vino actualizado
                    return vino;
                }
            }

            // Si no se encuentra un vino para actualizar, retorna null
            return null;
        }

        public void setFechaDeActualizacionVinoBodega(DateTime fechaDeActualizacion)
        {
            // Asigna el valor proporcionado de fechaDeActualizacion a la propiedad UltimaActualizacion del objeto actual.
            this.UltimaActualizacion = fechaDeActualizacion;
        }


        //De Prueba
        //public void AgregarVino(Vino vino)
        //{
        //    Vinos.Add(vino);
        //}

    }





}
