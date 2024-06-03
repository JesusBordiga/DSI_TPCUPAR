using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CUPAR.Entidades;
using CUPAR.Repositorio;
using CUPAR.Boundary;
using System.Windows.Forms;

namespace CUPAR.Gestor
{
    public class GestorImportarVinoDeBodega
    {
      
        private List<Bodega> listadoBodega = new List<Bodega>();
        private List<Vino>listadoVino = new List<Vino>();
        private Bodega bodegaSeleccionada;
        private List<Maridaje> maridajes = new List<Maridaje>();
        private List<TipoUva> tipoUvas = new List<TipoUva>();//
        private List<Vino> vinosActualizados = new List<Vino>();
        private DateTime fechaActual = new DateTime();
        private List<List<string>> vinos;
        //

        //private Maridaje maridaje;
        private TipoUva tipoUva;
        private List<string> enofiloNotifiaciones = new List<string>(); //agregar
        private List<Enofilo> enofilos = new List<Enofilo>();// agregar
        private RepositorioEnofilo repositorioEnofilo;
        private Probando probando;
        //private InterfazApiBodega apiBodega;
        private PantallaImportar pantallaImportarVino;
        private PantallaNotificacion notificacion;

        public  GestorImportarVinoDeBodega(List<Bodega> bodegas, List<Vino> listadoVino, List<Maridaje> maridajes , List<TipoUva>tipoUvas)
        { 

            this.listadoBodega = bodegas;
            this.listadoVino = listadoVino;
            this.tipoUvas = tipoUvas;
            this.maridajes = maridajes;
  
        }


        public void setPantalla(PantallaImportar pantalla)
        {
            this.pantallaImportarVino = pantalla;
        }
        //Método para seleccionar Opcion "Actualizar Vino Bodega"
        public void opImportarActualizacionVinoBodega(PantallaImportar pantallaImportarVino)
        {

            setPantalla(pantallaImportarVino);
            
            var bodegasConActualizaciones = buscarBodegasActualizar();
            pantallaImportarVino.mostrarBodegaParaActualizar(bodegasConActualizaciones);

            
        }



        // Este método recorre una lista de objetos Bodega, verifica si cada bodega tiene actualizaciones disponibles y,
        // si es así, agrega el nombre de la bodega a una lista de cadenas de texto (List<string>).
        public List<string> buscarBodegasActualizar()
        {
            List<string> bodegaConActualizaciones = new List<string>();

            List<Siguiendo> siguiendo = new List<Siguiendo>();
            List<Siguiendo> siguiendo1 = new List<Siguiendo>();
            enofilos = new List<Enofilo>();

            siguiendo.Add(new Siguiendo(listadoBodega[1], DateTime.Now.AddDays(-3)));
            siguiendo.Add(new Siguiendo(listadoBodega[0], DateTime.Now.AddDays(-3)));

            siguiendo1.Add(new Siguiendo(listadoBodega[1],DateTime.Now.AddDays(-3)));
            siguiendo1.Add(new Siguiendo(listadoBodega[0], DateTime.Now.AddDays(-3)));

            Usuario usuario = new Usuario("Jesus", "Merequetengue", true);
            Usuario usuario1 = new Usuario("Emi", "contra123", true);

            enofilos.Add(new Enofilo("Bordiga", "Bordiga", usuario,siguiendo ));
            enofilos.Add(new Enofilo("Nico", "Ojea", usuario1, siguiendo));



            foreach (Bodega bodega in listadoBodega)
            {
                if (bodega.tieneActualizacionesDisponibles())
                {
                    bodegaConActualizaciones.Add(bodega.getNombre());
                }
            }

            return bodegaConActualizaciones;
        }
        //
        public void tomarBodegaSeleccionada(string nombreBodega)
        {

            // Itera sobre cada bodega en la lista de bodegas
            foreach (Bodega bodega in listadoBodega)
            {
                // Comprueba si el nombre de la bodega actual coincide con el nombre proporcionado
                if (bodega.getNombre() == nombreBodega)
                {
                    // Si hay coincidencia, establece esta bodega como la bodega seleccionada
                    this.bodegaSeleccionada = bodega;
                }
            }

            // Después de seleccionar la bodega, se obtienen las actualizaciones de los vinos de esa bodega
            ObtenerActualizacionVinosBodega();
            //return listadoBodega.FirstOrDefault(b => b.getNombre() == nombreBodega);


        }
        //

        public void ObtenerActualizacionVinosBodega()
        {
            obtenerActualizacionVinos();
        }
        //
        public void obtenerActualizacionVinos()
        {
            // Parte 1: Imprimir los vinos de la bodega seleccionada
            foreach (Vino vino in listadoVino)
            {
                // Verificar si el vino pertenece a la bodega seleccionada
                if (vino.getBodega().getNombre() == bodegaSeleccionada.getNombre())
                {
                    // Imprimir los detalles del vino
                    Console.WriteLine(vino.ToString());
                }
            }

            // Parte 2: Simulación de la actualización de vinos para la bodega seleccionada
            if (bodegaSeleccionada.getNombre() == "Bodega Cordoba")
            {
                // Asignar una lista de listas de cadenas (detalles de vinos) a la propiedad 'vinos' para 'Bodega Cordoba'
                this.vinos = new List<List<string>>
                {
                    new List<string> {"2", "Vino 1 Bodega Cordoba", "1", "250", "asado queso pimiento", "malbec 50 rosada 50", "2" },
                    new List<string> {"2", "Vino 2 Bodega Cordoba", "3", "550", "asado queso pimiento", "malbec 50 rosada 50", "3" }
                };
            }
            else if (bodegaSeleccionada.getNombre() == "Bodega BSAS")
            {
                    // Asignar una lista de listas de cadenas (detalles de vinos) a la propiedad 'vinos' para 'Bodega BSAS'
                    this.vinos = new List<List<string>>
                {

                    new List<string> {"2", "Vino 1 Bodega BSAS", "4", "250", "asado queso pimiento", "malbec 50 rosada 50", "2" },
                    new List<string> {"2", "Vino 2 Bodega BSAS", "3", "550", "asado queso pimiento", "malbec 50 rosada 50", "3" }
                };
            }
            else if (bodegaSeleccionada.getNombre() == "Bodega SanJuan")
            {
                // Asignar una lista de listas de cadenas (detalles de vinos) a la propiedad 'vinos' para 'Bodega San Juan'
                this.vinos = new List<List<string>>
                {
                    new List<string> {"2", "Vino 1 Bodega SanJuan", "2", "250", "asado queso pimiento", "malbec 50 rosada 50", "2" },
                    new List<string> {"2", "Vino 2 Bodega SanJuan", "5", "550", "asado queso pimiento", "malbec 50 rosada 50", "3" }
                };
            }

            getFechaActual();
            }


        public void getFechaActual()
        {
            // Establece la fecha y hora actuales
            this.fechaActual = DateTime.Now;
            // Actualiza los datos de los vinos de la bodega seleccionada
            actualizarDatosDeVinoBodega();
        }

        public void actualizarDatosDeVinoBodega()
        {

            // Itera sobre cada vino en la lista de vinos
            foreach (List<string> vino in vinos)
            {
                // Actualiza las características del vino existente en la bodega seleccionada
                vinosActualizados.Add(bodegaSeleccionada.actualizarCaracteristicasExistente(listadoVino, vino));
                // Actualiza la fecha de actualización del vino en la bodega
                actualizarFechaActualizacionDeVinoBodega();
                
            }
            vinos = new List<List<string>>();

            // Verifica la cantidad de vinos actualizados (para depuración)
            Console.WriteLine(listadoVino.Count);

            // Verifica si algún vino no fue actualizado correctamente
            for (int i = 0; i < vinosActualizados.Count(); i++)
            {
                if (vinosActualizados[i] == null)
                {
                    // Si no se actualizó correctamente, busca el maridaje del vino
                    buscarMaridaje(i);
                }
            }

            // Muestra un resumen de los vinos importados en la pantalla de importación

            pantallaImportarVino.MostrarResumenVinosImportados(vinosActualizados, bodegaSeleccionada);
            vinosActualizados = new List<Vino>();

        }
        public void buscarMaridaje(int posicion)

        {
            // Divide la cadena de maridajes del vino en un array de maridajes
            string[] maridajeVino = vinos[posicion][4].Split(' ');
            List<Maridaje> maridajesActualizar = new List<Maridaje>();
            // Itera sobre cada maridaje del vino
            for (int i = 0; i < maridajeVino.Length; i++)
            {
                // Compara cada maridaje del vino con los maridajes disponibles
                foreach (Maridaje maridaje in maridajes)
                {
                    // Si hay coincidencia, agrega el maridaje a la lista de maridajes a actualizar
                    if (maridaje.sosMaridaje(maridajeVino[i]))
                    {
                        maridajesActualizar.Add(maridaje);
                    }
                }
            }

            // Imprime un maridaje para propósitos de depuración
            //Console.WriteLine(maridajesActualizar[0].ToString());
            buscarTipoUva(posicion, maridajesActualizar);
        }
        public void buscarTipoUva(int posicion, List<Maridaje> maridajes)
        {
            // Divide la cadena de tipos de uva del vino en un array de tipos de uva
                    string[] tipoUvaActu = vinos[posicion][5].Split(' ');
                    string[] porcentajeVino = vinos[posicion][6].Split(' ');
                    List<TipoUva> tipoUvaActualizar = new List<TipoUva>();
                    List<string> porcentajeActualizar = new List<string>();

                // Itera sobre cada tipo de uva del vino
                for (int i = 0; i < tipoUvaActu.Length; i++)
                {
                    // Compara cada tipo de uva del vino con los tipos de uva disponibles
                    foreach (TipoUva tipoUva in tipoUvas)
                    {
                        // Si hay coincidencia, agrega el tipo de uva y su porcentaje correspondiente a las listas
                        if (tipoUva.sosTipoUva(tipoUvaActu[i]))
                        {
                            tipoUvaActualizar.Add(tipoUva);
                            porcentajeActualizar.Add(porcentajeVino[i]);
                        }
                    }
                }
        }

        // Método para crear vinos y actualizar la lista de vinos.
        public void crearVinos(List<Maridaje> maridajesActualizar, List<TipoUva> tipoUvaActualizar, int posicion, List<string> porcentajeActualizar)
        {
            // Se crea una nueva lista para almacenar los varietales del vino.
            List<Varietal> varietales = new List<Varietal>();

            // Se obtiene el número actual de vinos en la lista.
            int contador = listadoVino.Count;

            // Se agrega un nuevo vino a la lista de vinos utilizando la información proporcionada.
            listadoVino.Add(new Vino(bodegaSeleccionada, int.Parse(vinos[posicion][0]), vinos[posicion][1], vinos[posicion][2], float.Parse(vinos[posicion][4]), maridajes, varietales, int.Parse(vinos[posicion][6])));

            // Se crea el varietal del vino recién creado utilizando la información de los tipos de uva y sus porcentajes.
            listadoVino[contador].crearVarietal(tipoUvaActualizar, porcentajeActualizar);

            // Se actualiza la lista de vinos actualizados con el vino recién creado.
            vinosActualizados[posicion] = listadoVino[contador];
        }

        public void actualizarFechaActualizacionDeVinoBodega()
        {
            // Llama al método setFechaDeActualizacionVinoBodega de la bodega seleccionada,
            // pasando la fecha actual como parámetro. Este método actualiza la fecha de
            // actualización de los vinos en la bodega seleccionada a la fecha actual.
            bodegaSeleccionada.setFechaDeActualizacionVinoBodega(this.fechaActual);
        }


        public void enviarNotificaciones()
        {
            // Inicializa la lista de notificaciones para los enófilos
            enofiloNotifiaciones = new List<string>();

            // Itera sobre cada enófilo en la lista de enófilos
            foreach (Enofilo enofilo in enofilos)
            {
                // Agrega el resultado de SeguisABodega (un string indicando si sigue a la bodega seleccionada) a la lista de notificaciones
                enofiloNotifiaciones.Add(enofilo.SeguisABodega(bodegaSeleccionada));
            }

            // Itera sobre cada enófilo en la lista de notificaciones
            foreach (string esEnofilo in enofiloNotifiaciones)
            {
                // Crea una nueva instancia de PantallaNotificacion con la lista de notificaciones
                this.notificacion = new PantallaNotificacion(enofiloNotifiaciones);

                // Muestra la pantalla de notificaciones
                this.notificacion.Show();

                // Envía la notificación de novedades de vino al enófilo
                notificacion.enviarNotificacionesNovedadesVino(esEnofilo);
            }
        }

        // Método final para finalizar el caso de uso
        public void FinCu() {

            Application.Exit();
        }
       
    }
}


