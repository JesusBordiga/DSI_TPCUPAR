using CUPAR.Gestor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CUPAR.Gestor;
using CUPAR.Entidades;

namespace CUPAR
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GestorImportarVinoDeBodega gestorImportarVinoDeBodega = new GestorImportarVinoDeBodega(crearListadoDeBodegas(), crearListaVinos(), crearListaMaridaje(), crearListaTipoUva());
            Application.Run(new PantallaImportar(gestorImportarVinoDeBodega));
        }

        public static List<Bodega> crearListadoDeBodegas()
        {
            List<Bodega> bodegas = Probando.CargarDatosIniciales();
            return bodegas;
        }

        public static List<Vino> crearListaVinos()
        {
            List<Vino> vinos = Probando.crearListaVinos();
            return vinos;
        }
        public static List<Maridaje> crearListaMaridaje()
        {
            List<Maridaje> vinos = Probando.crearListaMaridaje();
            return vinos;
        }
        public static List<TipoUva> crearListaTipoUva()
        {
            List<TipoUva> vinos = Probando.crearListaTipoUva();
            return vinos;
        }
    }
}
