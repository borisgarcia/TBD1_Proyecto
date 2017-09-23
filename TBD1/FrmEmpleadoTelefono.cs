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
    public partial class FrmEmpleadoTelefono : Form
    {
        public FrmEmpleadoTelefono()
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



        private void btnEliminar1_Click(object sender, EventArgs e)
        {
            if (txtCodEliminar.Text != "")
            {
                int x;
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "execute SP_READ_EMPLEADO_CORREO @CODIGO =" + txtCodEliminar.Text + ", @CORREO = '" + txtCorreo.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
                x = Convert.ToInt32(dt.Rows.Count.ToString());
                if (x == 1)
                {
                    TBD1.AseConnection.messageBox("Registro Eliminado Exitosamente!");
                    cmd.CommandText = "execute SP_Delete_Empleado_Correo @codigo_empleado =" + txtCodEliminar.Text + ", @correo = '" + txtCorreo.Text + "'";
                    cmd.ExecuteNonQuery();
                    txtCodEliminar.Text = "";
                    txtCorreo.Text = "";
                }
                else
                    TBD1.AseConnection.messageBox("Registro no Existe!");
            }
            else
                TBD1.AseConnection.messageBox("Debe ingresar un codigo de Empleado!");
        }

        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            if (maskedTextBox2.Text != "" || maskedTextBox3.Text != "")
            {
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "execute SP_Create_Empleado_Telefono @cod_empleado =" + maskedTextBox3.Text + ", @telefono =" + maskedTextBox2.Text + ",@creador ='" + lblUser.Text + "',@modificador ='" + lblUser.Text + "'";
                cmd.ExecuteNonQuery();

                TBD1.AseConnection.messageBox("Guardado Exitosamente.");
                textBox1.Text = "";
                maskedTextBox1.Text = "";
            }
            else
                TBD1.AseConnection.messageBox("Debe llenar todos los campos.");
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            if (txtCodEmpleadoMod.Text != "")
            {
                int x;
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "execute SP_READ_EMPLEADO_TELEFONO @CODIGO =" + txtCodEmpleadoMod.Text + ", @telefono = " + txtTelMod2.Text;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
                x = Convert.ToInt32(dt.Rows.Count.ToString());
                if (x == 1)
                {
                    TBD1.AseConnection.messageBox("Registro Eliminado Exitosamente!");
                    cmd.CommandText = "execute SP_Delete_Empleado_Telefono @codigo_empleado =" + txtCodEmpleadoMod.Text + ", @telefono = " + txtTelMod2.Text;
                    cmd.ExecuteNonQuery();
                    txtCodEmpleadoMod.Text = "";
                    txtTelMod2.Text = "";
                }
                else
                    TBD1.AseConnection.messageBox("Registro no Existe!");
            }
            else
                TBD1.AseConnection.messageBox("Debe ingresar un codigo de Empleado!");
        }

        private void btnGuardar1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "" || textBox1.Text != "")
            {
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "execute SP_Create_Empleado_Correo @correo ='" + textBox1.Text + "', @cod_empleado =" + maskedTextBox1.Text + ",@creador ='" + lblUser.Text + "',@modificador ='" + lblUser.Text + "'";
                cmd.ExecuteNonQuery();

                TBD1.AseConnection.messageBox("Guardado Exitosamente.");
                textBox1.Text = "";
                maskedTextBox1.Text = "";
            }
            else
                TBD1.AseConnection.messageBox("Debe llenar todos los campos.");
        }

        private void btnMod1_Click(object sender, EventArgs e)
        {
            if (txtCodMod1.Text != "" || txtCorreoMod1.Text != "")
            {
                int x;
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "execute SP_READ_EMPLEADO_CORREO @CODIGO =" + txtCodMod1.Text + ", @CORREO ='" + txtCorreoMod1.Text+"'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
                x = Convert.ToInt32(dt.Rows.Count.ToString());
                if (x == 0)
                    TBD1.AseConnection.messageBox("Registro no Existe.");

                else
                {
                    btnGuardarMod1.Enabled = true;
                    btnMod1.Enabled = false;
                }
            }
            else
                TBD1.AseConnection.messageBox("Debe llenar todos los campos.");
        }

        private void btnMod2_Click(object sender, EventArgs e)
        {
            if (txtCodMod1.Text != "" || txtCorreoMod1.Text != "")
            {
                int x;
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "execute SP_READ_EMPLEADO_TELEFONO @CODIGO =" + txtCodMod2.Text + ", @telefono =" + txtModTelefono.Text;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
                x = Convert.ToInt32(dt.Rows.Count.ToString());
                if (x == 0)
                    TBD1.AseConnection.messageBox("Registro no Existe.");

                else
                {
                    btnGuardarMod2.Enabled = true;
                    btnMod2.Enabled = false;
                }
            }
            else
                TBD1.AseConnection.messageBox("Debe llenar todos los campos.");
        }

        private void btnGuardarMod1_Click(object sender, EventArgs e)
        {
            if (txtCodMod1.Text != "" || txtCorreoMod1.Text != "")
            {
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "execute SP_Update_Empleado_Correo @correo ='" + txtCorreoMod1.Text + "', @cod_empleado =" + txtCodMod1.Text;
                cmd.ExecuteNonQuery();

                TBD1.AseConnection.messageBox("Guardado Exitosamente.");
                txtCodMod1.Text = "";
                txtCorreoMod1.Text = "";
                btnGuardarMod1.Enabled = false;
                btnMod1.Enabled = true;
            }
            else
                TBD1.AseConnection.messageBox("Debe llenar todos los campos.");
        }

        private void btnGuardarMod2_Click(object sender, EventArgs e)
        {
            if (txtModTelefono.Text != "" || txtCodMod2.Text != "")
            {
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "execute SP_Update_Empleado_Telefono @telefono =" + txtModTelefono.Text + ", @cod_empleado =" + txtCodMod2.Text;
                cmd.ExecuteNonQuery();

                TBD1.AseConnection.messageBox("Guardado Exitosamente.");
                txtCodMod2.Text = "";
                txtModTelefono.Text = "";
                btnGuardarMod2.Enabled = false;
                btnMod2.Enabled = true;
            }
            else
                TBD1.AseConnection.messageBox("Debe llenar todos los campos.");
        }
    }
}
