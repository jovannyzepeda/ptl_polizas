using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlPolizas
{
    public partial class Direccion : Form
    {
        //Cliente cliente;
        public Direccion()
        {
            InitializeComponent();
        }

        public void limpiarText()
        {
            txtCalleDireccion.Text = "";
            txtNumeroCalle.Text = "";
            txtColoniaDireccion.Text = "";
            txtEstadoDireccion.Text = "";
            txtMuniciopioDireccion.Text = "";
            txtCodigoPotalDireccion.Text = "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        public void getCliente(String nombreCliente)
        {
            lblNombreCliente.Text = "Cliente: "+nombreCliente;
        }

        private void Direccion_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
