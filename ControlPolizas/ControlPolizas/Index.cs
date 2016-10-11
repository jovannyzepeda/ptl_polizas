using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace ControlPolizas
{
    public partial class FrmIndex : Form
    {
        DateTime thisDay = DateTime.Today;
        SQLiteConnection conexion;
        Inicio_Sesion inicioSesion;
        Cliente cliente;
        Agente agente;
        

        public int ventanaClienteCreada = 0;

        public FrmIndex()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String fecha1 = thisDay.AddDays(28).ToString("yyyy-MM-dd");
            String fecha2= thisDay.AddDays(33).ToString("yyyy-MM-dd"); 
            MessageBox.Show(fecha1+" y "+ fecha2);

            String query = "SELECT c.Nombre AS 'Nombre', p.NumeroPoliza as 'Numero de poliza', tp.TipoPoliza as 'Ramo', p.FinVigencia as 'Vigencia', p.ImporteTotal as 'Importe total' from Clientes c,Polizas p, TipoPolizas tp where c.PK_Cliente=p.FK_Cliente and tp.PK_TipoPoliza=p.FK_TipoPoliza AND p.FinVigencia BETWEEN '" + fecha1 + "' AND '" + fecha2 + "'";
            //String pruebaQuery="Select * from Polizas";
            //MessageBox.Show(query);
            DataTable dataTable = new DataTable();
            try
            {

                conexion = new SQLiteConnection("Data Source=C:\\Users\\Nacho Martinez\\Desktop\\Zerebro\\Control Polizas\\BaseDatos\\ControlPolizas.db;Version=3");
                conexion.Open();

                 DataSet ds = new DataSet();
                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, conexion);

                adaptador.Fill(dataTable);
                adaptador.Fill(ds);
                dgvPendientes.DataSource = ds.Tables[0].DefaultView;

                conexion.Close();

                //************************************************************************

                inicioSesion = new Inicio_Sesion();
                inicioSesion.ShowDialog();
            }
            catch
            {
                MessageBox.Show("No se Pudo conectar la base de Datos");
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        public void ConsultarPrimas()
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            MostrarFormularioClientes();
            ventanaClienteCreada = 1;

        }

       

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioClientes();
        }

        private void btnSalirIndex_Click(object sender, EventArgs e)
        {
            this.Dispose();
           
        }

        
        private void btnAgente_Click(object sender, EventArgs e)
        {
            MostrarFormularioAgentes();
        }
        private void agenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioAgentes();
        }

        private void btnPoliza_Click(object sender, EventArgs e)
        {
            MostrarFormularioPolizas();
        }

        public void MostrarFormularioAgentes()
        {
            agente = new Agente();
            agente.Show();
        }
        public void MostrarFormularioClientes()
        {

            cliente = new ControlPolizas.Cliente();
            cliente.Show();

        }
        public void MostrarFormularioPolizas()
        {
            Poliza poliza = new Poliza();
            poliza.Show();
        }
        public void MostrarFormularioCompania()
        {
            Compania compania = new Compania();
            compania.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void polizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioPolizas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarFormularioCompania();
        }

        private void compañíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioCompania();
        }

        private void polizaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

      
    }
}
