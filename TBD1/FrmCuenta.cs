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
    public partial class FrmCuenta : Form
    {
        public FrmCuenta()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmAdmin admin = new FrmAdmin();
            admin.lblUser.Text = lblUser.Text;
            this.Hide();
            admin.Closed += (s, args) => this.Close();
            admin.Show();
        }

        private void FrmCuenta_Load(object sender, EventArgs e)
        {
            cmbTipo.DisplayMember = "Text";
            cmbTipo.ValueMember = "Value";
            cmbTipo.Items.Add(new { Text = "Aportaciones", Value = "Aportaciones" });
            cmbTipo.Items.Add(new { Text = "AhorroRetirable", Value = "AhorroRetirable" });

            cmbTipo2.DisplayMember = "Text";
            cmbTipo2.ValueMember = "Value";
            cmbTipo2.Items.Add(new { Text = "Aportaciones", Value = "Aportaciones" });
            cmbTipo2.Items.Add(new { Text = "AhorroRetirable", Value = "AhorroRetirable" });

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" || txtSaldo.Text != "" || cmbTipo.Text != "")
            {
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "execute SP_Create_Cuenta @cod_empleado =" + txtCodigo.Text + ", @saldo =" + txtSaldo.Text + ", @tipo_cuenta ='" + cmbTipo.SelectedValue + "' , @u_creador ='" + lblUser.Text + "',@u_modificador ='" + lblUser.Text + "'";
                cmd.ExecuteNonQuery();
                TBD1.AseConnection.messageBox("Guardado Exitosamente.");
                txtSaldo.Text = "";
                txtCodigo.Text = "";
            }
            else
            {
                TBD1.AseConnection.messageBox("Debe llenar todos los Campos!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtParam1.Text != "")
            {
                int x;
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "execute SP_READ_CUENTA @id =" + txtParam1.Text;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
                x = Convert.ToInt32(dt.Rows.Count.ToString());
                if (x == 0)
                {
                    TBD1.AseConnection.messageBox("Cuenta No Existe.");
                    txtParam1.Text = "";
                }
                else
                {
                    txtCodigo2.Text = dt.Rows[0]["empleado_codigo_empleado"].ToString();
                    txtSaldo2.Text = dt.Rows[0]["saldo"].ToString();
                    txtParam1.Text = "";
                    cmbTipo2.Enabled = true;
                    txtCodigo2.Enabled = true;
                    txtSaldo2.Enabled = true;                 
                    btnGuardar2.Enabled = true;
                    txtParam1.Enabled = false;
                }
            }
            else
                TBD1.AseConnection.messageBox("Ingrese un Numero de Cuenta!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtCodigo2.Text != "" || txtSaldo2.Text != "" || cmbTipo2.Text != "")
            {
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "execute SP_Update_Cuenta @cod_empleado =" + txtCodigo.Text + "',@saldo =" + txtSaldo.Text + ",@tipo_cuenta =" + cmbTipo.Text + ",@u_modificador ='" + lblUser.Text + "'";
                cmd.ExecuteNonQuery();

                cmbTipo2.Enabled = false;

                txtCodigo2.Enabled = false;
                txtSaldo2.Enabled = false;
                btnGuardar2.Enabled = false;
                txtParam1.Enabled = true;
            }
            else
            {
                TBD1.AseConnection.messageBox("Debe llenar todos los Campos!");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtParam.Text != "")
            {
                int x;
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "execute SP_READ_CUENTA @id =" + txtParam.Text + ", @tipo_cuenta = 'Cuenta Ahorro'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
                x = Convert.ToInt32(dt.Rows.Count.ToString());
                if (x == 0)
                {
                    TBD1.AseConnection.messageBox("Cuenta No Existe.");
                    txtParam1.Text = "";
                }
                else
                {
                    dt.Columns["numero_cuenta"].ColumnName = "Numero Cuenta";
                    dt.Columns["empleado_codigo_empleado"].ColumnName = "Codigo Empleado";
                    dt.Columns["fecha_apertura"].ColumnName = "Fecha Apertura";
                    dt.Columns["antiguedad"].ColumnName = "Antiguedad";
                    dt.Columns["saldo"].ColumnName = "Saldo";
                    dt.Columns["monto_mensual"].ColumnName = "Monto Mensual";
                    dt.Columns["tipo_cuenta"].ColumnName = "Tipo Cuenta";
                    dt.Columns["fecha_creacion"].ColumnName = "Fecha Creacion";
                    dt.Columns["ultima_modificacion"].ColumnName = "Ultima Modificacion";
                    dt.Columns["usuario_modificador"].ColumnName = "Usuario Modificador";
                    dt.Columns["usuario_creador"].ColumnName = "Usuario Creador";
                    dataGridView1.DataSource = dt;
                    txtParam1.Text = "";
                }
            }
            else
            {
                TBD1.AseConnection.messageBox("Debe llenar todos los Campos!");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(txtParamEliminar.Text != "")
            {
                int x;
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "execute SP_READ_CUENTA @id =" + txtParamEliminar.Text;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
                x = Convert.ToInt32(dt.Rows.Count.ToString());
                if (x == 1)
                {
                    TBD1.AseConnection.messageBox("Registro Eliminado Exitosamente!");
                    cmd.CommandText = "execute SP_Delete_Cuenta @id =" + txtParamEliminar.Text;
                    cmd.ExecuteNonQuery();
                    txtParamEliminar.Text = "";
                }
                else
                {
                    TBD1.AseConnection.messageBox("Registro No Existe!");
                    txtParamEliminar.Text = "";
                }
            }
            else
            {
                TBD1.AseConnection.messageBox("Debe llenar todos los Campos!");
            }
        }
    }
}
