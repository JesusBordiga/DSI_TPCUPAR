using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CUPAR.Entidades;

namespace CUPAR.Entidades
{
    internal class Probando
    {
        

        public Probando()
        {
            CargarDatosIniciales();

        }

        public static List<Bodega> CargarDatosIniciales()
        {

            List <Bodega> bodegas = new List<Bodega>();

            bodegas.Add(new Bodega("Bodega Cordoba", 1, "Descripcion Bodega Cordoba", "Historia Fernando", new List<float> { 40.7128f, -74.0060f }, DateTime.Now.AddMonths(-1)));
            bodegas.Add(new Bodega("Bodega BSAS", 2, "Descripcion Bodega BSAS", "Historia Fernando", new List<float> { 40.7128f, -74.0060f }, DateTime.Now.AddMonths(-2)));
            bodegas.Add(new Bodega("Bodega Mendoza", 4, "Descripcion Bodega Mendoza", "Historia Fernando", new List<float> { 40.7128f, -74.0060f }, DateTime.Now.AddMonths(-3)));
            bodegas.Add(new Bodega("Bodega SanJuan", 1, "Descripcion Bodega SanJuan", "Historia Fernando", new List<float> { 40.7128f, -74.0060f }, DateTime.Now.AddMonths(-2)));

            return bodegas;
            
            //Para comprobar si no hay actualizaciones:
            /*
            bodegas.Add(new Bodega("Bodega Cordoba", 4, "Descripcion Bodega Cordoba", "Historia Fernando", new List<float> { 40.7128f, -74.0060f }, DateTime.Now.AddMonths(-3)));
            bodegas.Add(new Bodega("Bodega BSAS", 4, "Descripcion Bodega BSAS", "Historia Fernando", new List<float> { 40.7128f, -74.0060f }, DateTime.Now.AddMonths(-3)));
            bodegas.Add(new Bodega("Bodega Mendoza", 4, "Descripcion Bodega Mendoza", "Historia Fernando", new List<float> { 40.7128f, -74.0060f }, DateTime.Now.AddMonths(-3)));
            bodegas.Add(new Bodega("Bodega SanJuan", 4, "Descripcion Bodega SanJuan", "Historia Fernando", new List<float> { 40.7128f, -74.0060f }, DateTime.Now.AddMonths(-3)));
            */
        }

        // Método para crear una lista de vinos
        public static List<Vino> crearListaVinos()
        {
            List<Vino> vinos = new List<Vino>(); // Inicializa la lista de vinos

            // Inicializa listas de maridajes para los vinos
            List<Maridaje> maridajesVino1 = new List<Maridaje>
            {
                crearListaMaridaje()[0],
                crearListaMaridaje()[3],
                crearListaMaridaje()[2]
            };

            List<Maridaje> maridajesVino3 = new List<Maridaje>
            {
                crearListaMaridaje()[2],
                crearListaMaridaje()[3]
            };

            List<Maridaje> maridajesVino2 = new List<Maridaje>
            {
                crearListaMaridaje()[1],
                crearListaMaridaje()[0],
                crearListaMaridaje()[4]
            };

            // Inicializa listas de varietales para los vinos
            List<Varietal> varietales1 = new List<Varietal>
            {
                crearListaVarietal()[2],
                crearListaVarietal()[7]
            };

            List<Varietal> varietales2 = new List<Varietal>
            {
                crearListaVarietal()[1],
                crearListaVarietal()[6]
            };

            List<Varietal> varietales3 = new List<Varietal>
            {
                crearListaVarietal()[0],
                crearListaVarietal()[5]
            };

            // Añade vinos a la lista, asociándolos a cada bodega
            foreach (var bodega in CargarDatosIniciales())
            {
                vinos.Add(new Vino(bodega, 2018, $"Vino 1 {bodega.getNombre()}", "Nota De Cata", 300, maridajesVino2, varietales1, 700));
                vinos.Add(new Vino(bodega, 2018, $"Vino 2 {bodega.getNombre()}", "Nota De Cata", 300, maridajesVino2, varietales1, 700));
                vinos.Add(new Vino(bodega, 2018, $"Vino 3 {bodega.getNombre()}", "Nota De Cata", 300, maridajesVino3, varietales2, 700));
                vinos.Add(new Vino(bodega, 2018, $"Vino 4 {bodega.getNombre()}", "Nota De Cata", 300, maridajesVino1, varietales3, 700));
            }

            return vinos; // Retorna la lista de vinos
        }

        // Método para crear una lista de tipos de uva
        public static List<TipoUva> crearListaTipoUva()
        {
            List<TipoUva> tiposUva = new List<TipoUva>(); // Inicializa la lista de tipos de uva

            // Añade varios tipos de uva a la lista
            tiposUva.Add(new TipoUva("Cabernet Sauvignon", "Uva con alta concentración de taninos"));
            tiposUva.Add(new TipoUva("Merlot", "Uva con cuerpo medio y sabores afrutados"));
            tiposUva.Add(new TipoUva("Malbec", "Uva con cuerpo completo y sabores especiados"));

            return tiposUva; // Retorna la lista de tipos de uva
        }

        // Método para crear una lista de varietales
        public static List<Varietal> crearListaVarietal()
        {
            List<Varietal> varietales = new List<Varietal>(); // Inicializa la lista de varietales

            // Añade varios varietales a la lista
            varietales.Add(new Varietal("Varietal 1", 50.0f, crearListaTipoUva()[0]));
            varietales.Add(new Varietal("Varietal 2", 30.0f, crearListaTipoUva()[1]));
            varietales.Add(new Varietal("Varietal 3", 20.0f, crearListaTipoUva()[2]));
            varietales.Add(new Varietal("Varietal 4", 70.0f, crearListaTipoUva()[0]));
            varietales.Add(new Varietal("Varietal 5", 60.0f, crearListaTipoUva()[1]));
            varietales.Add(new Varietal("Varietal 1", 50.0f, crearListaTipoUva()[1]));
            varietales.Add(new Varietal("Varietal 2", 70.0f, crearListaTipoUva()[2]));
            varietales.Add(new Varietal("Varietal 3", 80.0f, crearListaTipoUva()[1]));
            varietales.Add(new Varietal("Varietal 4", 30.0f, crearListaTipoUva()[2]));
            varietales.Add(new Varietal("Varietal 5", 30.0f, crearListaTipoUva()[2]));

            return varietales; // Retorna la lista de varietales
        }

        // Método para crear una lista de maridajes
        public static List<Maridaje> crearListaMaridaje()
        {
            List<Maridaje> maridajes = new List<Maridaje>(); // Inicializa la lista de maridajes

            // Añade varios maridajes a la lista
            maridajes.Add(new Maridaje("asado", "asado"));
            maridajes.Add(new Maridaje("queso", "queso"));
            maridajes.Add(new Maridaje("pimiento", "pimiento"));
            maridajes.Add(new Maridaje("ricota", "anana"));
            maridajes.Add(new Maridaje("Maridaje 3", "Pescados grasos y mariscos"));
            maridajes.Add(new Maridaje("Maridaje 4", "Pastas con salsas de tomate"));
            maridajes.Add(new Maridaje("Maridaje 5", "Postres de chocolate y frutos rojos"));

            return maridajes; // Retorna la lista de maridajes
        }

        // Método para inicializar maridajes (comentario placeholder)
        // El método crearListaMaridaje ya inicializa los maridajes
    }
}
