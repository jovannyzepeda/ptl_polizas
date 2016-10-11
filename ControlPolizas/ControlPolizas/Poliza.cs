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
    public partial class Poliza : Form
    {
        SQLiteConnection conexion;
        float IMPORTETOTAL = 0;
        int j;

        public Poliza()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void sugerenciaClientes()
        {
            SQLiteCommand command;
            SQLiteDataReader lectorDatos;

            try
            {

                conexion = new SQLiteConnection("Data Source=C:\\Users\\Nacho Martinez\\Desktop\\Zerebro\\Control Polizas\\BaseDatos\\ControlPolizas.db;Version=3");

                conexion.Open();
                command = new SQLiteCommand("Select Nombre From Clientes", conexion);
                lectorDatos = command.ExecuteReader();
                while (lectorDatos.Read())
                {
                    txtCliente.AutoCompleteCustomSource.Add(lectorDatos["Nombre"].ToString());
                }


                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Error al Cargar Clientes");
            }
        }


        public void fillCmboxAgentes()
        {
            cmbAgente.Items.Clear();
            SQLiteCommand command;
            SQLiteDataReader lectorDatos;

            try
            {

                conexion = new SQLiteConnection("Data Source=C:\\Users\\Nacho Martinez\\Desktop\\Zerebro\\Control Polizas\\BaseDatos\\ControlPolizas.db;Version=3");

                conexion.Open();
                command = new SQLiteCommand("Select Nombre From Agentes", conexion);
                lectorDatos = command.ExecuteReader();
                while (lectorDatos.Read())
                {
                    cmbAgente.Items.Add(lectorDatos["Nombre"]);
                }


                conexion.Close();
            }
            catch (Exception ev)
            {
                MessageBox.Show("Error al Cargar Agentes " + ev);
            }
        }

        public void fillCmboxCompania()
        {
            cmbCompania.Items.Clear();
            SQLiteCommand command;
            SQLiteDataReader lectorDatos;

            try
            {

                conexion = new SQLiteConnection("Data Source=C:\\Users\\Nacho Martinez\\Desktop\\Zerebro\\Control Polizas\\BaseDatos\\ControlPolizas.db;Version=3");

                conexion.Open();
                command = new SQLiteCommand("Select NombreCompania From Companias", conexion);
                lectorDatos = command.ExecuteReader();
                while (lectorDatos.Read())
                {
                    cmbCompania.Items.Add(lectorDatos["NombreCompania"]);
                }


                conexion.Close();
            }
            catch (Exception ev)
            {
                MessageBox.Show("Error al Cargar Compañias " + ev);
            }
        }


        public void sugerenciaNumeroPoliza()
        {
            SQLiteCommand command;
            SQLiteDataReader lectorDatos;

            try
            {

                conexion = new SQLiteConnection("Data Source=C:\\Users\\Nacho Martinez\\Desktop\\Zerebro\\Control Polizas\\BaseDatos\\ControlPolizas.db;Version=3");

                conexion.Open();
                command = new SQLiteCommand("Select NumeroPoliza From Polizas", conexion);
                lectorDatos = command.ExecuteReader();
                while (lectorDatos.Read())
                {
                    txtNumeroPoliza.AutoCompleteCustomSource.Add(lectorDatos["NumeroPoliza"].ToString());
                }


                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Error al Cargar Polizas");
            }
        }


        public void buscarPoliza(String numeroPoliza,String fechaInicio, String fechaFin)
        {
            int pk_Poliza = 7;
            SQLiteCommand command;
            SQLiteDataReader lectorDatos;
             try
            {
                String query = "SELECT p.PK_Poliza, p.NumeroPoliza,p.Nueva,c.Nombre,tp.TipoPoliza,co.NombreCompania, p.NumeroRenovacion,p.FrecuenciaDePago,p.InicioVigencia,p.FinVigencia,p.Adjunto,a.Nombre,p.Version,p.PrimaNeta,p.RecargoPagoFraccionado,p.DerechoPoliza,p.IVA,p.ImporteTotal FROM Polizas p, TipoPolizas tp, Clientes c, Agentes a,Companias co  WHERE p.NumeroPoliza='" + numeroPoliza + "' and tp.PK_TipoPoliza=p.FK_TipoPoliza and p.FK_Cliente=c.PK_Cliente and co.PK_Compania=p.FK_Compania and a.PK_Agente=p.FK_Agente AND p.InicioVigencia='" + fechaInicio + "' AND FinVigencia='" + fechaFin + "'";

                //Console.WriteLine(query);
                conexion = new SQLiteConnection("Data Source=C:\\Users\\Nacho Martinez\\Desktop\\Zerebro\\Control Polizas\\BaseDatos\\ControlPolizas.db;Version=3");
                conexion.Open();
                command = new SQLiteCommand(query, conexion);
                lectorDatos = command.ExecuteReader();

                while (lectorDatos.Read())
                {
                    pk_Poliza = lectorDatos.GetInt16(0);
                    txtNumeroPoliza.Text = lectorDatos.GetString(1);
                    String nueva = lectorDatos.GetString(2);
                    if (nueva.Equals("True"))
                    {
                        chkboxNueva.Checked = true;
                    }
                    else
                    {
                        chkboxNueva.Checked = false;
                    }
                    txtCliente.Text = lectorDatos.GetString(3);
                    cmbRamo.SelectedItem = lectorDatos.GetString(4);
                    cmbCompania.SelectedItem = lectorDatos.GetString(5);
                    txtNumeroRenovacion.Text = lectorDatos.GetString(6);
                    int frecPago = lectorDatos.GetInt16(7);

                    switch(frecPago){
                        case 0:
                            cmbFrecuenciaPago.SelectedIndex = 0;//mensual
                            break;
                        case 1:
                            cmbFrecuenciaPago.SelectedIndex = 1;//trimestral
                            break;
                        case 2:
                            cmbFrecuenciaPago.SelectedIndex = 2;//semestral
                            break;
                    }

                    //dtpInicioVigencia.Value = lectorDatos.GetDateTime(8);
                    //dtpFinVigencia.Value = lectorDatos.GetDateTime(9);
                    
                    txtAdjunto.Text = lectorDatos.GetString(10);
                    cmbAgente.SelectedItem = lectorDatos.GetString(11);
                    txtVersion.Text = lectorDatos.GetString(12);
                    txtPrima.Text = lectorDatos.GetDouble(13).ToString();
                    txtFraccionado.Text = lectorDatos.GetDouble(14).ToString();
                    txtDerechoPoliza.Text = lectorDatos.GetDouble(15).ToString();
                    txtIVA.Text = lectorDatos.GetDouble(16).ToString();
                    txtImporte.Text = lectorDatos.GetDouble(17).ToString();

                }


                conexion.Close();

                if (txtCliente.Text.Equals(""))
                {
                    MessageBox.Show("Verifique la informacion");
                    dtpInicioVigencia.Focus();
                }
                else
                {
                    btnEliminar.Enabled = true;
                    btnAgregar.Enabled = false;
                    btnAgregar.Visible = false;
                    btnBusca.Enabled = false;
                }

            }
            catch (Exception ev)
            {
                MessageBox.Show("No se encontro la Póliza " + ev);
            }
        }


        private void Poliza_Load(object sender, EventArgs e)
        {
            //DateTime esteDia = new DateTime();

            sugerenciaNumeroPoliza();
            sugerenciaClientes();
            fillCmboxAgentes();
            fillCmboxCompania();
            dtpFinVigencia.Value= DateTime.Today.AddYears(1);

            limpiarComboBox();
            LimpiarTextBox();
            ValoresBotonesDefault();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Archivos PDF (.pdf)|*.pdf|All Files (*.*)|*.*";
            file.FilterIndex = 1;
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                txtAdjunto.Text = path;
            }

        }

        private void btcBusca_Click(object sender, EventArgs e)
        {
            if (txtNumeroPoliza.Text.Equals(""))
            {
                MessageBox.Show("Agregue un numero de póliza para buscar");
                txtNumeroPoliza.Focus();
            }
            else
            {
                buscarPoliza(txtNumeroPoliza.Text, dtpInicioVigencia.Value.Date.ToString("yyyy-MM-dd"), dtpFinVigencia.Value.Date.ToString("yyyy-MM-dd"));
            }
            
           
        }

        public void ValoresBotonesDefault()
        {
            btnEliminar.Enabled = false;
            btnAdjuntoPoliza.Enabled = true;
            btnAgregar.Enabled = true;
            btnAgregar.Visible = true;
            btnCancelar.Enabled = true;
            btnBusca.Enabled = true;
            
        }
        public void LimpiarTextBox()
        {
            txtNumeroPoliza.Text = "";
            txtCliente.Text = "";
            txtNumeroRenovacion.Text = "";
            txtPrima.Text = "";
            txtFraccionado.Text = "";
            txtDerechoPoliza.Text = "";
            txtIVA.Text = "";
            txtImporte.Text = "";
            txtAdjunto.Text = "";
            txtVersion.Text = "";
            IMPORTETOTAL = 0;
        }

        public void limpiarComboBox()
        {
            cmbRamo.SelectedItem=null;
            cmbCompania.SelectedItem=null;
            cmbAgente.SelectedItem = null;
            cmbFrecuenciaPago.SelectedItem = null;
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarComboBox();
            LimpiarTextBox();
            ValoresBotonesDefault();
        }

        public void eliminarPoliza(String numeroPoliza, String fechaInicio, String fechaFin) 
        {
            SQLiteCommand commandoInsert;
            string query;

            try
            {
                conexion = new SQLiteConnection("Data Source=C:\\Users\\Nacho Martinez\\Desktop\\Zerebro\\Control Polizas\\BaseDatos\\ControlPolizas.db;Version=3");
                conexion.Open();

                query = "delete from Polizas where NumeroPoliza='" + numeroPoliza + "' and InicioVigencia='" + fechaInicio + "'and FinVigencia='" + fechaFin + "'";
                // MessageBox.Show(query);
                commandoInsert = new SQLiteCommand(query, conexion);
                commandoInsert.ExecuteNonQuery();
                MessageBox.Show("Póliza Eliminada");
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Error al tratar de eliminar la póliza");
            }
            }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea eliminar la póliza?", "Salir", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                eliminarPoliza(txtNumeroPoliza.Text,dtpInicioVigencia.Value.ToString("yyyy-MM-dd"),dtpFinVigencia.Value.ToString("yyyy-MM-dd"));
                limpiarComboBox();
                LimpiarTextBox();
                ValoresBotonesDefault();
            }
            else if (result == DialogResult.No)
            {
            }
            
        }

        public int ultimaPoliza()
        {
            int PK_Poliza = 0;
            SQLiteCommand commandMax;
            try
            {
                conexion = new SQLiteConnection("Data Source=C:\\Users\\Nacho Martinez\\Desktop\\Zerebro\\Control Polizas\\BaseDatos\\ControlPolizas.db;Version=3");
                conexion.Open();
                string queryMax = "SELECT max(PK_Poliza) FROM Polizas";
                commandMax = new SQLiteCommand(queryMax, conexion);
                string PK_PolizaString = commandMax.ExecuteScalar().ToString();
                PK_Poliza = Int32.Parse(PK_PolizaString);

                if (PK_Poliza == -1)
                {
                    PK_Poliza = 1;
                }
                else
                {
                    PK_Poliza += 1;
                }
                conexion.Close();
            }
            catch {


            }

            return PK_Poliza;
        }

        public int buscarFK_Cliente(String NombreCliente)
        {
            int PK_Cliente=0;
            SQLiteCommand commandMax;
            try
            {
                conexion = new SQLiteConnection("Data Source=C:\\Users\\Nacho Martinez\\Desktop\\Zerebro\\Control Polizas\\BaseDatos\\ControlPolizas.db;Version=3");
                conexion.Open();

                string queryMax = "SELECT PK_Cliente FROM Clientes WHERE Nombre='"+NombreCliente+"'";
                commandMax = new SQLiteCommand(queryMax, conexion);
                string PK_ClienteString = commandMax.ExecuteScalar().ToString();
                PK_Cliente = Int32.Parse(PK_ClienteString);

                conexion.Close();
            }
            catch(Exception ev)
            {
                MessageBox.Show("No se encontró el cliente solicitado "+ev);
            }

            return PK_Cliente;
        }

        public int buscarFK_TipoPoliza(String TipoPoliza)
        {
            int PK_TipoPoliza = 0;
            SQLiteCommand commandMax;
            try
            {
                conexion = new SQLiteConnection("Data Source=C:\\Users\\Nacho Martinez\\Desktop\\Zerebro\\Control Polizas\\BaseDatos\\ControlPolizas.db;Version=3");
                conexion.Open();

                string queryMax = "SELECT PK_TipoPoliza FROM TipoPolizas WHERE TipoPoliza='" + TipoPoliza + "'";
                commandMax = new SQLiteCommand(queryMax, conexion);
                string PK_TipoPolizaString = commandMax.ExecuteScalar().ToString();
                PK_TipoPoliza = Int32.Parse(PK_TipoPolizaString);

                conexion.Close();
            }
            catch(Exception ev)
            {
                MessageBox.Show("No se encontró el tipo de póliza " + ev);
            }

            return PK_TipoPoliza;
        }



        public int buscarFK_Compania(String NombreCompania)
        {
            int PK_Compania = 0;
            SQLiteCommand commandMax;
            try
            {
                conexion = new SQLiteConnection("Data Source=C:\\Users\\Nacho Martinez\\Desktop\\Zerebro\\Control Polizas\\BaseDatos\\ControlPolizas.db;Version=3");
                conexion.Open();

                string queryMax = "SELECT PK_Compania FROM Companias WHERE NombreCompania='" + NombreCompania + "'";
                commandMax = new SQLiteCommand(queryMax, conexion);
                string PK_CompaniaString = commandMax.ExecuteScalar().ToString();
                PK_Compania = Int32.Parse(PK_CompaniaString);

                conexion.Close();
            }
            catch (Exception ev)
            {
                MessageBox.Show("No se encontró la compañía " + ev);
            }

            return PK_Compania;
        }

        public int frecuenciaDePago(int Frecuencia)
        {
            int frecuenciaDePago = 4;

            switch (Frecuencia)
            {
                case 0:
                    frecuenciaDePago = 0;
                    break;
                case 1:
                    frecuenciaDePago = 1;
                    break;
                case 2:
                    frecuenciaDePago = 2;
                    break;
                default:
                    MessageBox.Show("error al detectar frecuencia de pago");
                    break;
            }

            return frecuenciaDePago;
        }

        public int buscarFK_Agente(String Nombre)
        {
            int PK_Agente = 0;
            SQLiteCommand commandMax;
            try
            {
                conexion = new SQLiteConnection("Data Source=C:\\Users\\Nacho Martinez\\Desktop\\Zerebro\\Control Polizas\\BaseDatos\\ControlPolizas.db;Version=3");
                conexion.Open();

                string queryMax = "SELECT PK_Agente FROM Agentes WHERE Nombre='" + Nombre + "'";
                commandMax = new SQLiteCommand(queryMax, conexion);
                string PK_AgenteString = commandMax.ExecuteScalar().ToString();
                PK_Agente = Int32.Parse(PK_AgenteString);

                conexion.Close();
            }
            catch (Exception ev)
            {
                MessageBox.Show("No se encontró Agente " + ev);
            }

            return PK_Agente;
        }

        public void insertarPoliza(int PK_Poliza,String numeroPoliza,bool nueva,int FK_Cliente,int FK_TipoPoliza,int FK_Compania,String numeroRenovacion,int frecuenciaPago,String fechaInicio, String fechaFin,int FK_Agente,String version,float primaNeta,float recargoPagoFraccionado,float derechoPoliza,float IVA, float importeTotal,String adjunto)
        {
            SQLiteCommand commandoInsert;
            string query;

            try
            {
                conexion = new SQLiteConnection("Data Source=C:\\Users\\Nacho Martinez\\Desktop\\Zerebro\\Control Polizas\\BaseDatos\\ControlPolizas.db;Version=3");
                conexion.Open();
                
                query = "INSERT INTO Polizas VALUES("+PK_Poliza + ",'"+numeroPoliza + "','"+nueva + "',"+FK_Cliente + ","+FK_TipoPoliza + ","+FK_Compania + ",'"+numeroRenovacion + "',"+frecuenciaPago + ",'"+fechaInicio + "','"+fechaFin + "','"+adjunto+ "'," +FK_Agente + ",'"+version + "',"+primaNeta + ","+recargoPagoFraccionado + ","+derechoPoliza + ","+IVA + ","+importeTotal+")";

               // MessageBox.Show(query);
                commandoInsert = new SQLiteCommand(query, conexion);
                commandoInsert.ExecuteNonQuery();
                MessageBox.Show("Póliza Agregada");
                conexion.Close();

                PK_Poliza = 0;
            }
            catch (Exception ev)
            {
                MessageBox.Show("Error al Agregar una Póliza " + ev);
            }
        }


        public void actualizarPolizas(String numeroPoliza, bool nueva, int FK_Cliente, int FK_TipoPoliza, int FK_Compania, String numeroRenovacion, int frecuenciaPago, String fechaInicio, String fechaFin, int FK_Agente, String version, float primaNeta, float recargoPagoFraccionado, float derechoPoliza, float IVA, float importeTotal, String adjunto)
        {
            SQLiteCommand commandoInsert;
            //int PK_Cliente;
            string query;

            try
            {
                conexion = new SQLiteConnection("Data Source=C:\\Users\\Nacho Martinez\\Desktop\\Zerebro\\Control Polizas\\BaseDatos\\ControlPolizas.db;Version=3");
                conexion.Open();

                query ="UPDATE Polizas set NumeroPoliza='" + numeroPoliza + "',Nueva='" + nueva + "',FK_Cliente=" + FK_Cliente + ",FK_TipoPoliza=" + FK_TipoPoliza + ",FK_Compania=" + FK_Compania + ",numeroRenovacion='" + numeroRenovacion + "',FrecuenciaDePago=" + frecuenciaPago + ",InicioVigencia='" + fechaInicio + "',FinVigencia='" + fechaFin + "',Adjunto='" + adjunto + "',FK_Agente=" + FK_Agente + ",Version='" + version + "',PrimaNeta=" + primaNeta + ",RecargoPagoFraccionado=" + recargoPagoFraccionado + ",DerechoPoliza=" + derechoPoliza + ",IVA=" + IVA + ",ImporteTotal=" + importeTotal + " WHERE NumeroPoliza='"+numeroPoliza+"' AND InicioVigencia='"+fechaInicio + "' AND FinVigencia='" + fechaFin + "'";
                MessageBox.Show(query);
                commandoInsert = new SQLiteCommand(query, conexion);
                commandoInsert.ExecuteNonQuery();
                MessageBox.Show("Póliza Actualizada");
                conexion.Close();

                //PK_Poliza = 0;
            }
            catch (Exception ev)
            {
                MessageBox.Show("Error al Actualizar la Póliza " + ev);
            }
        }

        /*public void eliminarPoliza(String numeroPoliza, String fechaInicio, String fechaFinal)
        {
            int pk_Poliza = 7;
            SQLiteCommand command;
            SQLiteDataReader lectorDatos;
            String query = "SELECT p.PK_Poliza, p.NumeroPoliza,p.Nueva,c.Nombre,tp.TipoPoliza,co.NombreCompania, p.NumeroRenovacion,p.FrecuenciaDePago,p.InicioVigencia,p.FinVigencia,p.Adjunto,a.Nombre,p.Version,p.PrimaNeta,p.RecargoPagoFraccionado,p.DerechoPoliza,p.IVA,p.ImporteTotal FROM Polizas p, TipoPolizas tp, Clientes c, Agentes a,Companias co  WHERE p.NumeroPoliza='" + numeroPoliza + "' and tp.PK_TipoPoliza=p.FK_TipoPoliza and p.FK_Cliente=c.PK_Cliente and co.PK_Compania=p.FK_Compania and a.PK_Agente=p.FK_Agente";
            try
            {


                conexion = new SQLiteConnection("Data Source=C:\\Users\\Nacho Martinez\\Desktop\\Zerebro\\Control Polizas\\BaseDatos\\ControlPolizas.db;Version=3");
                conexion.Open();
                command = new SQLiteCommand(query, conexion);
            }
            catch
            {

            }
            */

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                bool nueva;
                int PK_Poliza, FK_Cliente, FK_TipoPoliza, FK_Compania, frecuenciaPago, FK_Agente;
                float primaNeta,recargoPagoFraccionado,derechoPoliza,IVA,importeTotal;
                String numeroPoliza,numeroRenovacion,adjunto="",version,fechaInicio,fechaFin;

                PK_Poliza = ultimaPoliza();
                numeroPoliza = txtNumeroPoliza.Text;
                nueva = chkboxNueva.Checked;
                FK_Cliente = buscarFK_Cliente(txtCliente.Text);
                FK_TipoPoliza = buscarFK_TipoPoliza(cmbRamo.SelectedItem.ToString());
                FK_Compania = buscarFK_Compania(cmbCompania.SelectedItem.ToString());
                numeroRenovacion = txtNumeroRenovacion.Text;
                frecuenciaPago = frecuenciaDePago(cmbFrecuenciaPago.SelectedIndex);
                fechaInicio = dtpInicioVigencia.Value.Date.ToString("yyyy-MM-dd");
                fechaFin = dtpFinVigencia.Value.Date.ToString("yyyy-MM-dd");
                primaNeta = float.Parse(txtPrima.Text);
                recargoPagoFraccionado = float.Parse(txtFraccionado.Text);
                derechoPoliza = float.Parse(txtDerechoPoliza.Text);
                IVA = float.Parse(txtIVA.Text);
                importeTotal = float.Parse(txtImporte.Text);
                FK_Agente = buscarFK_Agente(cmbAgente.SelectedItem.ToString());
                version = txtVersion.Text;
                adjunto = txtAdjunto.Text;

                insertarPoliza(PK_Poliza, numeroPoliza, nueva, FK_Cliente, FK_TipoPoliza, FK_Compania, numeroRenovacion, frecuenciaPago, fechaInicio, fechaFin, FK_Agente, version, primaNeta, recargoPagoFraccionado, derechoPoliza, IVA, importeTotal,adjunto);

                sugerenciaNumeroPoliza();
                sugerenciaClientes();
                fillCmboxAgentes();
                fillCmboxCompania();
                limpiarComboBox();
                LimpiarTextBox();
                ValoresBotonesDefault();

            }catch (Exception ev)
            {
                MessageBox.Show("Verifique la información " + ev);
            }
           
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtIVA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtImporte_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            //float primaNeta,RecargoPagoFraccionado,derechoPoliza,IVA,importeTotal;
            //String PrimaNeta, REcargoPagoFraccionado, DerechoPoliza, iVA, ImporteTotal;

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                        IMPORTETOTAL = IMPORTETOTAL + float.Parse(txtIVA.Text);
                        txtImporte.Text = IMPORTETOTAL.ToString();
                        IMPORTETOTAL = 0;
                        cmbAgente.Focus();
                }
                catch
                {
                    MessageBox.Show("Porfavor ingrese un numero valido");
                    txtIVA.Focus();
                }
               
            }
            
           
        }

        private void txtNumeroPoliza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                chkboxNueva.Focus();
            }

            }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmbRamo.Focus();
            }
        }

        private void chkboxNueva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCliente.Focus();
            }
        }

        private void cmbRamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmbCompania.Focus();
            }
        }

        private void cmbCompania_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNumeroRenovacion.Focus();
            }
        }

        private void cmbFrecuenciaPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dtpInicioVigencia.Focus();
            }
        }

        private void txtNumeroRenovacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmbFrecuenciaPago.Focus();
            }
        }

        private void dtpInicioVigencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dtpFinVigencia.Focus();
            }
        }

        private void dtpFinVigencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPrima.Focus();
            }
        }

        private void txtPrima_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    IMPORTETOTAL = IMPORTETOTAL + float.Parse(txtPrima.Text);
                    txtImporte.Text = IMPORTETOTAL.ToString();
                    txtFraccionado.Focus();
                }
                catch
                {
                    MessageBox.Show("Porfavor ingrese un numero valido");
                    txtPrima.Focus();
                }
                
            }
        }

        private void txtFraccionado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                        IMPORTETOTAL = IMPORTETOTAL + float.Parse(txtFraccionado.Text);
                        txtImporte.Text = IMPORTETOTAL.ToString();
                        txtDerechoPoliza.Focus();
                }
                catch
                {
                    MessageBox.Show("Porfavor ingrese un numero valido");
                    txtFraccionado.Focus();
                }

                
            }
        }

        private void txtDerechoPoliza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    IMPORTETOTAL = IMPORTETOTAL + float.Parse(txtDerechoPoliza.Text);
                    txtImporte.Text = IMPORTETOTAL.ToString();
                    txtIVA.Focus();
                }catch(Exception ev)
                {
                    MessageBox.Show("Porfavor ingrese un numero valido");
                    txtDerechoPoliza.Focus();
                }
                
            }
        }

        private void cmbAgente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtVersion.Focus();
            }
        }

        private void txtVersion_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtVersion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAgregar.Focus();
            }
        }

        private void txtPrima_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFraccionado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool nueva;
                int PK_Poliza, FK_Cliente, FK_TipoPoliza, FK_Compania, frecuenciaPago, FK_Agente;
                float primaNeta, recargoPagoFraccionado, derechoPoliza, IVA, importeTotal;
                String numeroPoliza, numeroRenovacion, adjunto = "", version, fechaInicio, fechaFin;

                //PK_Poliza = ultimaPoliza();
                numeroPoliza = txtNumeroPoliza.Text;
                nueva = chkboxNueva.Checked;
                FK_Cliente = buscarFK_Cliente(txtCliente.Text);
                FK_TipoPoliza = buscarFK_TipoPoliza(cmbRamo.SelectedItem.ToString());
                FK_Compania = buscarFK_Compania(cmbCompania.SelectedItem.ToString());
                numeroRenovacion = txtNumeroRenovacion.Text;
                frecuenciaPago = frecuenciaDePago(cmbFrecuenciaPago.SelectedIndex);
                fechaInicio = dtpInicioVigencia.Value.Date.ToString("yyyy-MM-dd");
                fechaFin = dtpFinVigencia.Value.Date.ToString("yyyy-MM-dd");
                primaNeta = float.Parse(txtPrima.Text);
                recargoPagoFraccionado = float.Parse(txtFraccionado.Text);
                derechoPoliza = float.Parse(txtDerechoPoliza.Text);
                IVA = float.Parse(txtIVA.Text);
                importeTotal = float.Parse(txtImporte.Text);
                FK_Agente = buscarFK_Agente(cmbAgente.SelectedItem.ToString());
                version = txtVersion.Text;
                adjunto = txtAdjunto.Text;

                //insertarPoliza(PK_Poliza, numeroPoliza, nueva, FK_Cliente, FK_TipoPoliza, FK_Compania, numeroRenovacion, frecuenciaPago, fechaInicio, fechaFin, FK_Agente, version, primaNeta, recargoPagoFraccionado, derechoPoliza, IVA, importeTotal, adjunto);
                actualizarPolizas(numeroPoliza, nueva, FK_Cliente, FK_TipoPoliza, FK_Compania, numeroRenovacion, frecuenciaPago, fechaInicio, fechaFin, FK_Agente, version, primaNeta, recargoPagoFraccionado, derechoPoliza, IVA, importeTotal, adjunto);


                sugerenciaNumeroPoliza();
                sugerenciaClientes();
                fillCmboxAgentes();
                fillCmboxCompania();
                limpiarComboBox();
                LimpiarTextBox();
                ValoresBotonesDefault();

            }
            catch (Exception ev)
            {
                MessageBox.Show("Verifique la información " + ev);
            }

        }
    }
}
