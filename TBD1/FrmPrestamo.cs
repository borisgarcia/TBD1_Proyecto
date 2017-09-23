using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBD1
{
    public partial class FrmPrestamo : Form
    {
        public FrmPrestamo()
        {
            InitializeComponent();
        }

        //Nuevo
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtPeriodo.Text != "" || txtMonto.Text != "" || cmbTipo.Text != "" || txtId.Text != "" )
            {
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "execute SP_Create_Prestamos @periodo =" + txtPeriodo.Text + ", @monto =" + txtMonto.Text + ",@tipo_prestamo ='" + cmbTipo.Text + "',@creador ='" + lblUser.Text + "',@empleado =" + txtId.Text + ",@modificador ='" + lblUser.Text + "'";
                cmd.ExecuteNonQuery();

                TBD1.AseConnection.messageBox("Guardado Exitosamente.");
                txtId.Text = "";
                txtMonto.Text = "";
                txtPeriodo.Text = "";
            }
            else
                TBD1.AseConnection.messageBox("Debe llenar todos los campos.");
        }

        //Formulario
         private void FrmPrestamo_Load(object sender, EventArgs e)
        {
            cmbTipo.DisplayMember = "Text";
            cmbTipo.ValueMember = "Value";
            cmbTipo.Items.Add(new { Text = "Automatico", Value = "Automatico" });
            cmbTipo.Items.Add(new { Text = "Fiduciario", Value = "Fiduciario" });
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmAdmin admin = new FrmAdmin();
            admin.lblUser.Text = lblUser.Text;
            this.Hide();
            admin.Closed += (s, args) => this.Close();
            admin.Show();
        }


        //Modificar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtParamMod.Text != "")
            {
                int x;
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "execute SP_READ_PRESTAMOS @id =" + txtParamMod.Text;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
                x = Convert.ToInt32(dt.Rows.Count.ToString());
                if (x == 0)
                {
                    TBD1.AseConnection.messageBox("Prestamo No Existe.");
                    txtParamMod.Text = "";
                }
                else
                {
                    txtPeriodo2.Text = dt.Rows[0]["periodo"].ToString();
                    //cmbTipo2.Text = dt.Rows[0]["tipo_prestamo"].ToString();
                    txtMonto2.Text = dt.Rows[0]["monto"].ToString();
                    txtEmpleado2.Text = dt.Rows[0]["empleado_codigo_empleado"].ToString();
                    txtPeriodo2.Enabled = true;
                    txtMonto2.Enabled = true;
                    cmbTipo2.Enabled = true;
                    txtEmpleado2.Enabled = true;
                    button1.Enabled = true;
                    txtParamMod.Enabled = false;
                }
            }
            else
                TBD1.AseConnection.messageBox("Debe llenar todos los campos.");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPeriodo.Text != "" || txtMonto.Text != "" || cmbTipo.Text != "" || txtId.Text != "")
            {
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "execute SP_Update_Prestamo @numero_prestamo =" + txtParamMod.Text + ",@periodo =" + txtPeriodo.Text + ", @monto =" + txtMonto.Text + ",@tipo_prestamo ='" + cmbTipo.Text + "',@empleado =" + txtId.Text + ",@modificador ='" + lblUser.Text + "'";
                cmd.ExecuteNonQuery();
                TBD1.AseConnection.messageBox("Guardado Exitosamente.");
                txtParamMod.Text = "";

                txtPeriodo2.Enabled = false;
                txtMonto2.Enabled = false;
                cmbTipo2.Enabled = false;
                txtEmpleado2.Enabled = false;
                txtParamMod.Enabled = true;
                button1.Enabled = false;
            }
            else
                TBD1.AseConnection.messageBox("Debe llenar todos los campos.");
        }

        //Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtParam.Text != "")
            {
                int x;
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "execute SP_READ_PRESTAMOS @id =" + txtParam.Text;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
                x = Convert.ToInt32(dt.Rows.Count.ToString());
                if (x == 0)
                {
                    TBD1.AseConnection.messageBox("Prestamo No Existe.");
                    txtParam.Text = "";
                }
                else
                {
                    dt.Columns["numero_prestamo"].ColumnName = "Numero Prestamo";
                    dt.Columns["periodo"].ColumnName = "Periodo";
                    dt.Columns["saldo"].ColumnName = "Saldo";
                    dt.Columns["fecha"].ColumnName = "Fecha";
                    dt.Columns["monto"].ColumnName = "Monto";
                    dt.Columns["tipo_prestamo"].ColumnName = "Tipo Prestamo";
                    dt.Columns["fecha_creacion"].ColumnName = "Fecha Creacion";
                    dt.Columns["ultima_modificacion"].ColumnName = "Ultima Modificacion";
                    dt.Columns["usuario_creador"].ColumnName = "Usuario Creador";
                    dt.Columns["usuario_modificador"].ColumnName = "Usuario Modificador";
                    dt.Columns["empleado_codigo_empleado"].ColumnName = "Codigo Empleado";
                    dt.Columns["cuota"].ColumnName = "Cuota";
                    dataGridView1.DataSource = dt;
                    txtParam.Text = "";
                }
            }
            else
                TBD1.AseConnection.messageBox("Debe llenar todos los campos.");


        }

        //Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtParamEliminar.Text != "")
            {
                int x;
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "execute SP_READ_PRESTAMOS @id =" + txtParamEliminar.Text;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
                x = Convert.ToInt32(dt.Rows.Count.ToString());
                if (x == 1)
                {
                    TBD1.AseConnection.messageBox("Registro Eliminado Exitosamente!");
                    cmd.CommandText = "execute SP_Delete_Prestamos @id =" + txtParamEliminar.Text;
                    cmd.ExecuteNonQuery();
                    txtParamEliminar.Text = "";

                }
                else
                {
                    TBD1.AseConnection.messageBox("Registro no Existe!");
                    txtParamEliminar.Text = "";
                }
            }
            else
                TBD1.AseConnection.messageBox("Debe llenar todos los campos.");
        }

        private void tabBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
