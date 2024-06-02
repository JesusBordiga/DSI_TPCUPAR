using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CUPAR.Entidades;
using CUPAR.Repositorio;
//using CUPAR.Boundary;

namespace CUPAR.Gestor
{
    public class GestorImportarVinoDeBodega
    {
      
        private List<Bodega> listadoBodega = new List<Bodega>();
        //private Bodega bodegaSeleccionada;
        private List<Vino>listadoVino = new List<Vino>();

        private Bodega bodegaSeleccionada;

        private List<Maridaje> maridajes = new List<Maridaje>();
        private List<TipoUva> tipoUvas = new List<TipoUva>();
        private List<Vino> vinosActualizados = new List<Vino>();
        private DateTime fechaActual = new DateTime();
       

        //
        private List<List<string>> vinos;
        //

        //private Maridaje maridaje;
        private TipoUva tipoUva;
        private Enofilo enofilo;
        private RepositorioEnofilo repositorioEnofilo;
        private Probando probando;

        //private InterfazApiBodega apiBodega;
        private PantallaImportar pantallaImportarVino;
        //private frmInterfazNotificacion notificacion;

        public  GestorImportarVinoDeBodega(List<Bodega> bodegas, List<Vino> listadoVino)
        {

            this.listadoBodega = bodegas;
            this.listadoVino = listadoVino;
            //this.apiBodega = apiBodega;
            //this.pantallaImportarVino = pantallaImportarVino;
            // this.notificacion = notificacion;
            //PantallaImportar pantallaImportarVino = new PantallaImportar();



            //opImportarActualizacionVinoBodega(pantallaImportarVino);
        }
        //Método para seleccionar Opcion "Actualizar Vino Bodega"
        public void opImportarActualizacionVinoBodega(PantallaImportar pantallaImportarVino)
        {
            
            var bodegasConActualizaciones = buscarBodegasActualizar();
            pantallaImportarVino.mostrarBodegaParaActualizar(bodegasConActualizaciones);

            //listadoBodega = new List<Bodega>();


            
        }

        //public void AgregarBodega(Bodega bodega)
        //{
        //  listadoBodega.Add(bodega);
        //}


        // Este método recorre una lista de objetos Bodega, verifica si cada bodega tiene actualizaciones disponibles y,
        // si es así, agrega el nombre de la bodega a una lista de cadenas de texto (List<string>).
        public List<string> buscarBodegasActualizar()
        {
            List<string> bodegaConActualizaciones = new List<string>();

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
            
            foreach (Bodega bodega in listadoBodega)
            {
                if (bodega.getNombre() == nombreBodega)
                {
                    this.bodegaSeleccionada = bodega;
                }
            }

            obtenerActualizacionVinos();
            //return listadoBodega.FirstOrDefault(b => b.getNombre() == nombreBodega);


        }
        //


        //

        //lo nuevo

        //Esto lo haria la API DE VINOS
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
                new List<string> {"2", "Vino Toro de Bodega Cordoba", "nota De cata", "250", "asado queso pimiento", "malbec 50 rosada 50", "2" },
                new List<string> {"2", "Vino Mandamas de Bodega Cordoba", "nota De cata", "550", "asado queso pimiento", "malbec 50 rosada 50", "3" }
        };
            }
            else if (bodegaSeleccionada.getNombre() == "Bodega BSAS")
            {
                // Asignar una lista de listas de cadenas (detalles de vinos) a la propiedad 'vinos' para 'Bodega BSAS'
                this.vinos = new List<List<string>>
        {
                new List<string> {"2", "Vino Santa Julia de Bodega BSAS", "nota De cata", "250", "asado queso pimiento", "malbec 50 rosada 50", "2" },
                new List<string> {"2", "Vino Tu Suegra BSAS", "nota De cata", "550", "asado queso pimiento", "malbec 50 rosada 50", "3" }
        };
            }
            else if (bodegaSeleccionada.getNombre() == "Bodega San Juan")
            {
                // Asignar una lista de listas de cadenas (detalles de vinos) a la propiedad 'vinos' para 'Bodega San Juan'
                this.vinos = new List<List<string>>
        {
                new List<string> {"2", "Vino Pingo de Bodega San Juan", "nota De cata", "250", "asado queso pimiento", "malbec 50 rosada 50", "2" },
                new List<string> {"2", "Vino Bordiga de Bodega San Juan", "nota De cata", "550", "asado queso pimiento", "malbec 50 rosada 50", "3" }
        };
            }
        }



        public void actualizarDatosDeVinoBodega()
        {
            foreach (List<string> vino in vinos)
            {
                vinosActualizados.Add(bodegaSeleccionada.actualizarCaracteristicasExistente(listadoVino, vino));
                actualizarFechaActualizacionDeVinoBodega();

               
            }

            Console.WriteLine(listadoBodega.Count); // VERIRIFICAR ESTO

            for (int i = 0; i < vinosActualizados.Count(); i++)
            {
                if (vinosActualizados[i] == null)
                {
                    // SEGUIR ACAAAAAAAA ///
                }
            }
        }

        public void actualizarFechaActualizacionDeVinoBodega()
        {
            bodegaSeleccionada.setFechaDeActualizacionVinoBodega(this.fechaActual);
        }
        

      


       

            

        //


        public List<Enofilo> BuscarSeguidoresDeBodega(Bodega bodega)
        {
            // Llama al método ObtenerSeguidoresDeBodega del repositorioEnofilo,
            // pasándole como argumento la bodega proporcionada.
            // Este método devuelve una lista de objetos Enofilo que representan
            // a los seguidores de la bodega especificada.
            return repositorioEnofilo.ObtenerSeguidoresDeBodega(bodega);
        }

        public void notificarNovedadVinoParaBodega(Bodega bodega, List<Vino> vinosNuevos)
        {
            // Llama al método BuscarSeguidoresDeBodega para obtener una lista de seguidores de la bodega dada
            List<Enofilo> seguidores = BuscarSeguidoresDeBodega(bodega);

            // Recorre la lista de seguidores
            foreach (var enofilo in seguidores)
            {
                // Aquí iría la lógica para enviar una notificación push.
                // Esto es solo una simulación.
                // Imprime un mensaje simulando el envío de una notificación al enófilo
                Console.WriteLine($"Notificación enviada a {enofilo.Nombre} {enofilo.Apellido} sobre las novedades de {bodega.getNombre()}");
            }
        }
    }
}


