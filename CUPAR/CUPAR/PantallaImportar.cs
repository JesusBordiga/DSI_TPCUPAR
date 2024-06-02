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

namespace CUPAR
{
    public partial class PantallaImportar : Form
    {
        public GestorImportarVinoDeBodega gestorImportarVinoDeBodega;

        public PantallaImportar(GestorImportarVinoDeBodega gestorImportarVinoDeBodega)
        {
            InitializeComponent();
            this.gestorImportarVinoDeBodega = gestorImportarVinoDeBodega;
            opActualizarImportacionVino();
        }

        public void opActualizarImportacionVino()
        {
            this.habilitarPantalla();
            this.gestorImportarVinoDeBodega.opImportarActualizacionVinoBodega(this);
        }
        public void mostrarBodegaParaActualizar(List<string> bodegasActualizaciones)
        {
            if  (bodegasActualizaciones.Count == 0)
            {
                MessageBox.Show("No hay actualizaciones disponibles", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (var i = 0; i < bodegasActualizaciones.Count; i++)
                {
                    comboBox1.Items.Add(bodegasActualizaciones[i].ToString());

                }

            }
            
            
            //for (var i = 0; i < bodegasActualizaciones.Count; i++)
            //{
              //  comboBox1.Items.Add(bodegasActualizaciones[i].ToString());
               
            //}
        }

        private void habilitarPantalla()
        {
            //this.btnImportarDatos.Visible = false;
            this.comboBox1.Visible = false;
            this.lblBodega.Visible = false;
            this.dtgBodegaSeleccionada.Visible = false;

           
        }

        private void seleccionarBodega()
        {
            string nombreSeleccionado = comboBox1.SelectedItem?.ToString();

            gestorImportarVinoDeBodega.tomarBodegaSeleccionada(nombreSeleccionado);


            //if (!string.IsNullOrEmpty(nombreSeleccionado))
            //{
            //    Bodega bodegaSeleccionada = gestorImportarVinoDeBodega.tomarBodegaSeleccionada(nombreSeleccionado);
            //    //MessageBox.Show($"Bodega seleccionada: {nombreSeleccionado}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    // Aquí puedes añadir más lógica para procesar la selección de la bodega.
            //    if (bodegaSeleccionada != null)
            //    {
            //        MostrarResumenVinosImportados(bodegaSeleccionada);
            //    }
            //}

        }

        public void MostrarResumenVinosImportados(Bodega bodega)
        {
            dtgBodegaSeleccionada.Rows.Clear();

            List<Vino> vinos = bodega.getVinos();

            foreach(var vino in vinos)
            {
                DataGridViewRow row = new DataGridViewRow();

                //Agregar las celdas con la información del vino a la fila
                row.Cells.Add(new DataGridViewTextBoxCell { Value = vino.Aniade });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = vino.Nombre });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = vino.NotaDeCata });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = vino.PrecioARS });

                //Obtener los maridajes del vino como una cadena separada por comas
                //string maridajes = string.Join(", ", vino.ObtenerMaridajes().Select(m => m.Nombre));
                //row.Cells.Add(new DataGridViewTextBoxCell { Value = maridajes });

                //Obtener los varietales del vino como una cadena separada por comas
                //string varietales = string.Join(", ", vino.ObtenerVarietales().Select(v => v.Nombre));
                //row.Cells.Add(new DataGridViewTextBoxCell { Value = varietales });

                //Agregar la fila al DataGridView
                dtgBodegaSeleccionada.Rows.Add(row);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccionarBodega();

        }


        private void btnImportarDatos_Click(object sender, EventArgs e)
        {
            //this.btnImportarDatos.Visible = false;
            comboBox1.Items.Clear();
            this.opActualizarImportacionVino();
            lblBodega.Visible = true;
            dtgBodegaSeleccionada.Visible = true;
            comboBox1.Visible = true; 

        }
    }
}
