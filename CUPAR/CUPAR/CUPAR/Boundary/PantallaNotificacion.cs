using CUPAR.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CUPAR.Boundary
{
    public partial class PantallaNotificacion : Form
    {
        List<string> enofilos = new List<string>();
        public PantallaNotificacion(List<string> enofilos)
        {
            this.enofilos = enofilos;
            InitializeComponent();
        }

        public void enviarNotificacionesNovedadesVino(string enofiloNoti)
        {
            Show();
            label1.Text = enofiloNoti;
        }
        }

}
