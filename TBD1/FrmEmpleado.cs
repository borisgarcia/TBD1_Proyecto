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
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        //Buscar
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtParam.Text != "")
            {
                int x;
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "execute SP_READ_EMPLEADO @id =" + txtParam.Text;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
                x = Convert.ToInt32(dt.Rows.Count.ToString());


                if (x == 0)
                {
                    TBD1.AseConnection.messageBox("Empledo No Existe.");
                    txtParam.Text = "";
                }

                else
                {
                    int x2;
                    cmd.CommandText = "execute SP_READ_EMPLEADO_CORREO2 @CODIGO =" + txtParam.Text;
                    cmd.ExecuteNonQuery();
                    DataTable dt2 = new DataTable();
                    OdbcDataAdapter da2 = new OdbcDataAdapter(cmd);
                    da2.Fill(dt2);
                    x2 = Convert.ToInt32(dt2.Rows.Count.ToString());

                    if (x2 != 0)
                    {
                        dt2.Columns["correo_electronico"].ColumnName = "Correo Electronico";
                        dt2.Columns["empleado_codigo_empleado"].ColumnName = "Codigo Empleado";
                        dataGridView2.DataSource = dt2;
                    }

                    int x3;
                    cmd.CommandText = "execute SP_READ_EMPLEADO_TELEFONO2 @CODIGO =" + txtParam.Text;
                    cmd.ExecuteNonQuery();
                    DataTable dt3 = new DataTable();
                    OdbcDataAdapter da3 = new OdbcDataAdapter(cmd);
                    da3.Fill(dt3);
                    x3 = Convert.ToInt32(dt3.Rows.Count.ToString());

                    if (x3 != 0)
                    {
                        dt3.Columns["Telefono"].ColumnName = "Telefono";
                        dt3.Columns["empleado_codigo_empleado"].ColumnName = "Codigo Empleado";
                        dataGridView3.DataSource = dt3;
                    }

                    dt.Columns["codigo_empleado"].ColumnName = "Codigo Empleado";
                    dt.Columns["primer_nombre"].ColumnName = "Primer Nombre";
                    dt.Columns["segundo_nombre"].ColumnName = "Segundo Nombre";
                    dt.Columns["primer_apellido"].ColumnName = "Primer Apellido";
                    dt.Columns["segundo_apellido"].ColumnName = "Segundo Apellido";
                    dt.Columns["ciudad"].ColumnName = "Ciudad";
                    dt.Columns["calle"].ColumnName = "Calle";
                    dt.Columns["avenida"].ColumnName = "Avenida";
                    dt.Columns["numero_casa"].ColumnName = "#Casa";
                    dt.Columns["departamento"].ColumnName = "Departamento";
                    dt.Columns["referencia"].ColumnName = "Referencia";
                    dt.Columns["fecha_inicio"].ColumnName = "Fecha Inicio";
                    dt.Columns["fecha_nacimiento"].ColumnName = "Fecha Nacimiento";
                    dt.Columns["fecha_creacion"].ColumnName = "Fecha Creacion";
                    dt.Columns["ultima_modificacion"].ColumnName = "Ultima Modificacion";
                    dt.Columns["usuario_creador"].ColumnName = "Usuario Creador";
                    dt.Columns["usuario_modificador"].ColumnName = "Usuario Modificador";
                    dt.Columns["usuario_id_usuario"].ColumnName = "Id Usuario";
                    dataGridView1.DataSource = dt;
                    txtParam.Text = "";
                }
            }
            else
                TBD1.AseConnection.messageBox("Debe ingresar un valor de Empleado!");

        }

        //Nuevo
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtPNombre.Text != "" || txtSNombre.Text != "" || txtPApellido.Text != "" || txtSApellido.Text != "" || txtCiudad.Text != "" || txtCalle.Text != "" || txtAvenida.Text != "" || txtCasa.Text != "" || txtDepto.Text != "" || txtRef.Text != "" || txtUsuario.Text != "")
            {
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "execute SP_Create_Empleado @primer_nombre ='" + txtPNombre.Text + "', @segundo_nombre ='" + txtSNombre.Text + "',@pri_apellido ='" + txtPApellido.Text + "',@seg_apellido ='" + txtSApellido.Text + "',@ciudad ='" + txtCiudad.Text + "',@calle =" + txtCalle.Text + ",@avenida =" + txtAvenida.Text + ",@numero_casa =" + txtCasa.Text + ",@departamento ='" + txtDepto.Text + "',@referencia ='" + txtRef.Text + "',@fecha_inicio ='" + dtInicio.Text + "',@fecha_nac ='" + dtNac.Text + "',@u_creador ='" + lblUser.Text + "',@u_modificador ='" + lblUser.Text + "',@id_usuario =" + txtUsuario.Text;
                cmd.ExecuteNonQuery();

                TBD1.AseConnection.messageBox("Guardado Exitosamente.");
                txtParam.Text = "";
                txtPNombre.Text = "";
                txtSNombre.Text = "";
                txtPApellido.Text = "";
                txtSApellido.Text = "";
                txtCiudad.Text = "";
                txtCalle.Text = "";
                txtAvenida.Text = "";
                txtCasa.Text = "";
                txtDepto.Text = "";
                txtRef.Text = "";
                txtUsuario.Text = "";
                btnGuardar.Text = "";

            }

            else
                TBD1.AseConnection.messageBox("Debe llenar todos los campos de Empleado!");


        }

        //Eliminar
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (txtParamEliminar.Text != "")
            {
                int x;
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "execute SP_READ_EMPLEADO @id =" + txtParamEliminar.Text;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
                x = Convert.ToInt32(dt.Rows.Count.ToString());
                if (x == 1)
                {
                    TBD1.AseConnection.messageBox("Registro Eliminado Exitosamente!");
                    cmd.CommandText = "execute SP_Delete_Empleado @numero_empleado =" + txtParamEliminar.Text;
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
                TBD1.AseConnection.messageBox("Debe ingresar un codigo de Empleado!");
        }

        //Modificar
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtParamMod.Text != "")
            {
                int x;
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "execute SP_READ_EMPLEADO @id =" + txtParamMod.Text;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
                x = Convert.ToInt32(dt.Rows.Count.ToString());
                if (x == 0)
                {
                    TBD1.AseConnection.messageBox("Empledo No Existe.");
                    txtParam.Text = "";
                }
                else
                {
                    txtPNombre2.Text = dt.Rows[0]["primer_nombre"].ToString();
                    txtSNombre2.Text = dt.Rows[0]["segundo_nombre"].ToString();
                    txtPApellido2.Text = dt.Rows[0]["primer_apellido"].ToString();
                    txtSApellido2.Text = dt.Rows[0]["segundo_apellido"].ToString();
                    txtCiudad2.Text = dt.Rows[0]["ciudad"].ToString();
                    txtCalle2.Text = dt.Rows[0]["calle"].ToString();
                    txtAvenida2.Text = dt.Rows[0]["avenida"].ToString();
                    txtCasa2.Text = dt.Rows[0]["numero_casa"].ToString();
                    txtDepto2.Text = dt.Rows[0]["departamento"].ToString();
                    txtRef2.Text = dt.Rows[0]["referencia"].ToString();
                    txtUsuario2.Text = dt.Rows[0]["usuario_id_usuario"].ToString();

                    txtPNombre2.Enabled = true;
                    txtSNombre2.Enabled = true;
                    txtPApellido2.Enabled = true;
                    txtSApellido2.Enabled = true;
                    txtCiudad2.Enabled = true;
                    txtCalle2.Enabled = true;
                    txtAvenida2.Enabled = true;
                    txtCasa2.Enabled = true;
                    txtDepto2.Enabled = true;
                    txtRef2.Enabled = true;
                    txtUsuario2.Enabled = true;
                    btnGuardar2.Enabled = true;
                    dtInicio2.Enabled = true;
                    dtNac2.Enabled = true;
                    txtParamMod.Enabled = false;

                }
            }
            else
                TBD1.AseConnection.messageBox("Debe ingresar un codigo de Empleado!");
        }

        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            OdbcConnection con = TBD1.AseConnection.Connect();
            OdbcCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "execute SP_Update_Empleado @cod_empleado =" + txtParamMod.Text + ",@primer_nombre ='" + txtPNombre2.Text + "', @segundo_nombre ='" + txtSNombre2.Text + "',@p_apellido ='" + txtPApellido2.Text + "',@s_apellido ='" + txtSApellido2.Text + "',@ciudad ='" + txtCiudad2.Text + "',@calle =" + txtCalle2.Text + ",@avenida =" + txtAvenida2.Text + ",@numero_casa =" + txtCasa2.Text + ",@departamento ='" + txtDepto2.Text + "',@referencia ='" + txtRef2.Text + "',@fecha_inicio ='" + dtInicio2.Text + "',@fecha_nac ='" + dtNac2.Text + "',@u_modificador ='" + lblUser.Text + "',@id_usuario =" + txtUsuario2.Text;
            cmd.ExecuteNonQuery();

            TBD1.AseConnection.messageBox("Guardado Exitosamente.");
            txtParam.Text = "";
            txtPNombre2.Enabled = false;
            txtSNombre2.Enabled = false;
            txtPApellido2.Enabled = false;
            txtSApellido2.Enabled = false;
            txtCiudad2.Enabled = false;
            txtCalle2.Enabled = false;
            txtAvenida2.Enabled = false;
            txtCasa2.Enabled = false;
            txtDepto2.Enabled = false;
            txtRef2.Enabled = false;
            txtUsuario2.Enabled = false;
            btnGuardar2.Enabled = false;
            dtInicio2.Enabled = false;
            dtNac2.Enabled = false;
            txtParamMod.Enabled = true;
            txtParamMod.Text = "";

        }


        //Formulario
        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmAdmin admin = new FrmAdmin();
            admin.lblUser.Text = lblUser.Text;
            this.Hide();
            admin.Closed += (s, args) => this.Close();
            admin.Show();
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            
        }
    }
}
