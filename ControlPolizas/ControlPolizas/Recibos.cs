using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlPolizas
{
    
    public partial class Recibos : Form
    {
        SQLiteConnection conexion;
        public Poliza poliza;
        public int Pk_poliza=8888;
        public DateTime inicioVigenciaPoliza;
        public Recibos()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            //poliza.recibos.Hide(); 
            

        }

        public void setPK_Poliza(int pk_poliza)
        {
            Pk_poliza = pk_poliza;
        }

        public void setInicioVigenciaPoliza(DateTime inicioVigencia)
        {
            inicioVigenciaPoliza = inicioVigencia;
        }


        private void Recibos_Load(object sender, EventArgs e)
        {

            //int PK_Poliza = poliza.PK_Poliza;
            //DateTime inicioVigencia=poliza.inicioVigenciaExportar;
            String query = "SELECT rp.PK_RecibosPoliza + 1 AS 'No.Recibo',p.NumeroPoliza,rp.InicioVigencia,rp.FinVigencia,rp.Estado,rp.Monto FROM RecibosPoliza rp, Polizas p WHERE rp.FK_Poliza = p.PK_poliza and rp.FK_Poliza ="+ Pk_poliza + " AND rp.InicioVigencia BETWEEN '"+ inicioVigenciaPoliza.ToString("yyyy-MM-dd") + "' AND '" + inicioVigenciaPoliza.AddYears(1).ToString("yyyy-MM-dd") + "'";
            Console.WriteLine(query);
            // String query = "SELECT PK_RecibosPoliza AS No.Recibo, FROM RecibosPoliza WHERE FK_Poliza=" + PK_Poliza + " AND InicioVigencia BETWEEN '" + inicioVigencia.ToString("yyyy-MM-dd") + "' AND '" + inicioVigencia.AddYears(1).ToString("yyyy-MM-dd") + "'";

            //String query = "SELECT c.Nombre AS 'Nombre', p.NumeroPoliza as 'Numero de poliza', tp.TipoPoliza as 'Ramo', p.FinVigencia as 'Vigencia', p.ImporteTotal as 'Importe total' from Clientes c,Polizas p, TipoPolizas tp where c.PK_Cliente=p.FK_Cliente and tp.PK_TipoPoliza=p.FK_TipoPoliza AND p.FinVigencia BETWEEN '" + fecha1 + "' AND '" + fecha2 + "'";
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
                dgvRecibos.DataSource = ds.Tables[0].DefaultView;

                conexion.Close();
                //inicioVigenciaPoliza = null;
                Pk_poliza = 888;
            }
            catch
            {
                MessageBox.Show("Error al cargar los Recibos");
            }
            }
    }
}
