using CUPAR.Entidades;
using CUPAR.Gestor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CUPAR.Entidades;
using CUPAR.Boundary;

namespace CUPAR
{
    public partial class PantallaImportar : Form
    {
        // Instancia del gestor de importación de vinos de la bodega
        public GestorImportarVinoDeBodega gestorImportarVinoDeBodega;

        // Constructor
        public PantallaImportar(GestorImportarVinoDeBodega gestorImportarVinoDeBodega)
        {
            // Inicializa los componentes de la pantalla
            InitializeComponent();
            // Asigna el gestor de importación de vinos de la bodega
            this.gestorImportarVinoDeBodega = gestorImportarVinoDeBodega;
            // Ejecuta la operación de actualizar importación de vinos
            opActualizarImportacionVino();
        }

        // Método para ejecutar la operación de actualizar importación de vinos
        public void opActualizarImportacionVino()
        {
            // Habilita la pantalla de importación
            this.habilitarPantalla();
            // Llama al método del gestor para importar la actualización de los vinos de la bodega
            this.gestorImportarVinoDeBodega.opImportarActualizacionVinoBodega(this);
        }

        // Método para mostrar las bodegas disponibles para actualizar
        public void mostrarBodegaParaActualizar(List<string> bodegasActualizaciones)
        {
            // Verifica si hay bodegas disponibles para actualizar
            if (bodegasActualizaciones.Count == 0)
            {
                // Muestra un mensaje informativo si no hay actualizaciones disponibles
                MessageBox.Show("No hay actualizaciones disponibles", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Agrega las bodegas disponibles al ComboBox en la pantalla
                for (var i = 0; i < bodegasActualizaciones.Count; i++)
                {
                    comboBox1.Items.Add(bodegasActualizaciones[i].ToString());
                }
            }


            
        }

        private void habilitarPantalla()
        {
            
            this.comboBox1.Visible = false;
            this.lblBodega.Visible = false;
            this.dtgBodegaSeleccionada.Visible = false;
            this.lblBodegaSelec.Visible = false;
            btnNotificar.Visible = false;
            lblEnviarNotif.Visible = false;
            


        }

        private void seleccionarBodega()
        {
            string nombreSeleccionado = comboBox1.SelectedItem?.ToString();
            lblBodegaSelec.Text=nombreSeleccionado;
            gestorImportarVinoDeBodega.tomarBodegaSeleccionada(nombreSeleccionado);


           

        }

        public void MostrarResumenVinosImportados(List<Vino> actualizados, Bodega seleccionada)
        {

            
            dtgBodegaSeleccionada.Rows.Clear();
            List <Vino> vinos = seleccionada.getVinos();

            foreach(Vino vino in actualizados)
            {

                DataGridViewRow row = new DataGridViewRow();

                //Agregar las celdas con la información del vino a la fila
                row.Cells.Add(new DataGridViewTextBoxCell { Value = vino.Aniade });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = vino.Nombre });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = vino.NotaDeCata });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = vino.PrecioARS });
               

                //Obtener los maridajes del vino como una cadena separada por comas
                string maridajes = string.Join(", ", vino.ObtenerMaridajes().Select(m => m.Nombre));
                row.Cells.Add(new DataGridViewTextBoxCell { Value = maridajes });

                //Obtener los varietales del vino como una cadena separada por comas
                string varietales = string.Join(", ", vino.ObtenerVarietales().Select(v => v.Descripcion));
                row.Cells.Add(new DataGridViewTextBoxCell { Value = varietales });

                //Agregar la fila al DataGridView
                dtgBodegaSeleccionada.Rows.Add(row);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccionarBodega();
            btnNotificar.Visible = true;
            lblEnviarNotif.Visible = true;
            lblBodega.Visible = true;
        }


        private void btnImportarDatos_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            this.opActualizarImportacionVino();
            dtgBodegaSeleccionada.Visible = true;
            comboBox1.Visible = true;
            lblBodegaSelec.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gestorImportarVinoDeBodega.enviarNotificaciones();
        }

    }
}
